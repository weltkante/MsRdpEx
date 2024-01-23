using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using MsRdpEx.Interop;

namespace MsRdpEx.Tests
{
    public unsafe class VariantTests
    {
        public static IEnumerable<object?[]> GetVariantValueTestData()
        {
            return GetTestData().Select(x => new object?[] { x.Item1, x.Item2, x.Item3 });

            static IEnumerable<(object?, VarEnum, byte[])> GetTestData()
            {
                yield return (null, VarEnum.VT_EMPTY, []);
                yield return (false, VarEnum.VT_BOOL, [0x00, 0x00]);
                yield return (true, VarEnum.VT_BOOL, [0xFF, 0xFF]);
                yield return (DBNull.Value, VarEnum.VT_NULL, []);
                yield return ((sbyte)0x12, VarEnum.VT_I1, [0x12]);
                yield return ((byte)0x87, VarEnum.VT_UI1, [0x87]);
                yield return ((short)0x1234, VarEnum.VT_I2, [0x34, 0x12]);
                yield return ((ushort)0x8765, VarEnum.VT_UI2, [0x65, 0x87]);
                yield return ((int)0x1234_5678, VarEnum.VT_I4, [0x78, 0x56, 0x34, 0x12]);
                yield return ((uint)0x8765_4321, VarEnum.VT_UI4, [0x21, 0x43, 0x65, 0x87]);
                yield return ((long)0x1234_5678_1234_5678, VarEnum.VT_I8, [0x78, 0x56, 0x34, 0x12, 0x78, 0x56, 0x34, 0x12]);
                yield return ((ulong)0x8765_4321_8765_4321, VarEnum.VT_UI8, [0x21, 0x43, 0x65, 0x87, 0x21, 0x43, 0x65, 0x87]);
                yield return ((float)1.2f, VarEnum.VT_R4, BitConverter.GetBytes((float)1.2f));
                yield return ((double)1.2d, VarEnum.VT_R8, BitConverter.GetBytes((double)1.2d));
                yield return ((decimal)1.2m, VarEnum.VT_DECIMAL, [0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00]);
            }
        }

        private static bool IsLargeVariant(VarEnum vt) => vt == VarEnum.VT_DECIMAL;

        private struct ManagedBoxedVariant
        {
            [MarshalAs(UnmanagedType.Struct)]
            public object? Value;
        }

        [Theory]
        [MemberData(nameof(GetVariantValueTestData))]
        public void ClassicMarshalTest(object? value, VarEnum expectedType, byte[] expectedData)
        {
            var managed = new ManagedBoxedVariant { Value = value };
            var native = new NativeVariant();
            Marshal.StructureToPtr(managed, (nint)(&native), false);
            try
            {
                Assert.Equal(expectedType, (VarEnum)native.Type);

                if (IsLargeVariant((VarEnum)native.Type))
                {
                    var contentSpan = MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan(ref native, 1))[sizeof(VarEnum)..];
                    Assert.True(expectedData.Length <= contentSpan.Length);
                    Assert.Equal(expectedData, contentSpan[..expectedData.Length].ToArray());
                }
                else
                {
                    var contentSpan = MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan(ref native.Content1, 2));
                    Assert.True(expectedData.Length <= contentSpan.Length);
                    Assert.Equal(expectedData, contentSpan[..expectedData.Length].ToArray());
                }
            }
            finally
            {
                Marshal.DestroyStructure<ManagedBoxedVariant>((nint)(&native));
            }
        }

#if NET9_0_OR_GREATER
        [Theory]
        [MemberData(nameof(GetVariantValueTestData))]
        public void ModernMarshalTest(object? value, VarEnum expectedType, byte[] expectedData)
        {
            var native = ComVariantMarshaller.ConvertToUnmanaged(value);
            try
            {
                Assert.Equal(expectedType, (VarEnum)native.VarType);

                if (IsLargeVariant((VarEnum)native.VarType))
                {
                    var contentSpan = MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan(ref native, 1))[sizeof(VarEnum)..];
                    Assert.True(expectedData.Length <= contentSpan.Length);
                    Assert.Equal(expectedData, contentSpan[..expectedData.Length].ToArray());
                }
                else
                {
                    var contentSpan = MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan(ref native.GetRawDataRef<nint>(), 2));
                    Assert.True(expectedData.Length <= contentSpan.Length);
                    Assert.Equal(expectedData, contentSpan[..expectedData.Length].ToArray());
                }
            }
            finally
            {
                ComVariantMarshaller.Free(native);
            }
        }
#endif
    }
}
