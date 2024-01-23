using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using MSTSCLib;

#nullable enable

namespace MsRdpEx.Interop
{
    [Flags]
    public enum VariantType : ushort // typedef unsigned short VARTYPE
    {
        Empty = 0, // VT_EMPTY = 0,
        DBNull = 1, // VT_NULL = 1,
        Int16 = 2, // VT_I2 = 2,
        Int32 = 3, // VT_I4 = 3,
        Float32 = 4, // VT_R4 = 4,
        Float64 = 5, // VT_R8 = 5,
        Currency = 6, // VT_CY = 6,
        DateTime = 7, // VT_DATE = 7,
        BinaryString = 8, // VT_BSTR = 8,
        IDispatch = 9, // VT_DISPATCH = 9,
        Error = 10, // VT_ERROR = 10,
        Boolean = 11, // VT_BOOL = 11,
        Variant = 12, // VT_VARIANT = 12,
        IUnknown = 13, // VT_UNKNOWN = 13,
        Decimal = 14, // VT_DECIMAL = 14,
        Int8 = 16, // VT_I1 = 16,
        UInt8 = 17, // VT_UI1 = 17,
        UInt16 = 18, // VT_UI2 = 18,
        UInt32 = 19, // VT_UI4 = 19,
        Int64 = 20, // VT_I8 = 20,
        UInt64 = 21, // VT_UI8 = 21,
        OtherInt32 = 22, // VT_INT = 22,
        OtherUInt32 = 23, // VT_UINT = 23,
        // VT_VOID = 24,
        // VT_HRESULT = 25,
        // VT_PTR = 26,
        // VT_SAFEARRAY = 27,
        // VT_CARRAY = 28,
        // VT_USERDEFINED = 29,
        // VT_LPSTR = 30,
        // VT_LPWSTR = 31,
        // VT_RECORD = 36,
        IntPtr = 37, // VT_IntPtr = 37,
        UIntPtr = 38, // VT_UIntPtr = 38,
        // VT_FILETIME = 64,
        // VT_BLOB = 65,
        // VT_STREAM = 66,
        // VT_STORAGE = 67,
        // VT_STREAMED_OBJECT = 68,
        // VT_STORED_OBJECT = 69,
        // VT_BLOB_OBJECT = 70,
        // VT_CF = 71,
        // VT_CLSID = 72,
        // VT_VERSIONED_STREAM = 73,
        // VT_BSTR_BLOB = 0xfff,

        // VT_VECTOR = 0x1000,
        ArrayModifier = 0x2000, // VT_ARRAY = 0x2000,
        ByRefModifier = 0x4000, // VT_BYREF = 0x4000,
        // VT_RESERVED = 0x8000,

        // VT_ILLEGAL = 0xffff,
        // VT_ILLEGALMASKED = 0xfff,
        // VT_TYPEMASK = 0xfff,
    }

    public struct NativeVariant
    {
        public VariantType Type;
        public ushort Header1;
        public ushort Header2;
        public ushort Header3;
        public nint Content1;
        public nint Content2;

        public NativeVariant(VariantType Type)
        {
            this.Type = Type;
        }
    }

    [NativeMarshalling(typeof(Marshaller))]
    public readonly struct Variant : IEquatable<Variant>
    {
        [CustomMarshaller(typeof(object), MarshalMode.Default, typeof(ObjectMarshaller))]
        [CustomMarshaller(typeof(Variant), MarshalMode.Default, typeof(Marshaller))]
        [CustomMarshaller(typeof(Variant), MarshalMode.UnmanagedToManagedRef, typeof(ByRef))]
        public static unsafe class Marshaller
        {
            public static Variant ConvertToManaged(NativeVariant data)
            {
                switch (data.Type)
                {
                    case VariantType.Empty: return Empty;
                    case VariantType.DBNull: return DBNull;
                    case VariantType.Error: return new(InlineType.Error, Unsafe.As<nint, int>(ref data.Content1));
                    case VariantType.Boolean: return new(InlineType.Boolean, Unsafe.As<nint, short>(ref data.Content1));
                    case VariantType.Int8: return new(InlineType.Int8, Unsafe.As<nint, sbyte>(ref data.Content1));
                    case VariantType.Int16: return new(InlineType.Int16, Unsafe.As<nint, short>(ref data.Content1));
                    case VariantType.Int32: return new(InlineType.Int32, Unsafe.As<nint, int>(ref data.Content1));
                    case VariantType.Int64: return new(InlineType.Int64, Unsafe.As<nint, long>(ref data.Content1));
                    case VariantType.IntPtr: return new(InlineType.IntPtr, Unsafe.As<nint, nint>(ref data.Content1));
                    case VariantType.UInt8: return new(InlineType.UInt8, Unsafe.As<nint, byte>(ref data.Content1));
                    case VariantType.UInt16: return new(InlineType.UInt16, Unsafe.As<nint, ushort>(ref data.Content1));
                    case VariantType.UInt32: return new(InlineType.UInt32, Unsafe.As<nint, uint>(ref data.Content1));
                    case VariantType.UInt64: return new(InlineType.UInt64, Unsafe.As<nint, ulong>(ref data.Content1));
                    case VariantType.UIntPtr: return new(InlineType.UIntPtr, Unsafe.As<nint, nuint>(ref data.Content1));
                    case VariantType.Float32: return new(InlineType.Float32, Unsafe.As<nint, int>(ref data.Content1));
                    case VariantType.Float64: return new(InlineType.Float64, Unsafe.As<nint, long>(ref data.Content1));
                    case VariantType.Currency: return new(InlineType.Currency, Unsafe.As<nint, long>(ref data.Content1));
                    case VariantType.DateTime: return new(InlineType.DateTime, Unsafe.As<nint, long>(ref data.Content1));
                    case VariantType.OtherInt32: goto case VariantType.Int32;
                    case VariantType.OtherUInt32: goto case VariantType.UInt32;

                    case VariantType.Decimal:
                        // .NET decimal has the same layout as VARIANT except that the type field is left empty
                        var variantWithoutType = data;
                        variantWithoutType.Type = VariantType.Empty;
                        return Unsafe.As<NativeVariant, decimal>(ref variantWithoutType);

                    case VariantType.BinaryString:
                        // If we have a NULL pointer .NET would convert this to a NULL string reference
                        if (data.Content1 == 0)
                            return Empty;

                        var length = ((uint*)data.Content1)[-1];
                        if (length == 0)
                            return new Variant(VariantType.BinaryString, string.Empty);

                        if ((length & 1) == 0)
                            return new Variant(VariantType.BinaryString, Marshal.PtrToStringBSTR(data.Content1));

                        return new Variant(VariantType.BinaryString, global::BinaryString.Marshaller.ConvertToManaged(data.Content1));

                    case VariantType.IUnknown:
                    case VariantType.IDispatch:
                        // If we have a NULL pointer .NET would convert this to a NULL object reference
                        if (data.Content1 == 0)
                            return Empty;

                        return new Variant(data.Type, ProxyObject.Pack(ComInterfaceMarshaller<object>.ConvertToManaged((void*)data.Content1)));

                    case VariantType.ByRefModifier | VariantType.Error: return new(InlineType.Error, *(int*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.Boolean: return new(InlineType.Boolean, *(short*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.Int8: return new(InlineType.Int8, *(sbyte*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.Int16: return new(InlineType.Int16, *(short*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.Int32: return new(InlineType.Int32, *(int*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.Int64: return new(InlineType.Int64, *(long*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.IntPtr: return new(InlineType.IntPtr, *(nint*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.UInt8: return new(InlineType.UInt8, *(byte*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.UInt16: return new(InlineType.UInt16, *(ushort*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.UInt32: return new(InlineType.UInt32, *(uint*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.UInt64: return new(InlineType.UInt64, *(ulong*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.UIntPtr: return new(InlineType.UIntPtr, *(nuint*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.Float32: return new(InlineType.Float32, *(float*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.Float64: return new(InlineType.Float64, *(double*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.Currency: return new(InlineType.Currency, *(long*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.DateTime: return new(InlineType.DateTime, *(double*)data.Content1);
                    case VariantType.ByRefModifier | VariantType.OtherInt32: goto case VariantType.ByRefModifier | VariantType.Int32;
                    case VariantType.ByRefModifier | VariantType.OtherUInt32: goto case VariantType.ByRefModifier | VariantType.UInt32;

                    case VariantType.ByRefModifier | VariantType.Variant:
                        {
                            var pVariant = (NativeVariant*)data.Content1;
                            if (pVariant == null)
                                return Empty;

                            if ((pVariant->Type & VariantType.ByRefModifier) != 0)
                                throw new InvalidOperationException("Double indirection is not allowed.");

                            return ConvertToManaged(*pVariant);
                        }

                    default:
                        throw new NotSupportedException($"Variant Type {(ushort)data.Type} is not supported.");
                }
            }

            public static NativeVariant ConvertToUnmanaged(Variant data)
            {
                var result = new NativeVariant(data.Type);
                switch (result.Type)
                {
                    case VariantType.Empty:
                    case VariantType.DBNull:
                    case VariantType.Error:
                    case VariantType.Boolean:
                    case VariantType.Int8:
                    case VariantType.Int16:
                    case VariantType.Int32:
                    case VariantType.Int64:
                    case VariantType.IntPtr:
                    case VariantType.UInt8:
                    case VariantType.UInt16:
                    case VariantType.UInt32:
                    case VariantType.UInt64:
                    case VariantType.UIntPtr:
                    case VariantType.Float32:
                    case VariantType.Float64:
                    case VariantType.Currency:
                    case VariantType.DateTime:
                        // All the inline types use the same format and can be copied directly.
                        Unsafe.As<nint, long>(ref result.Content1) = data.InlineData;
                        break;

                    case VariantType.Decimal:
                        // Decimal overwrites the whole thing, need to restore the type afterwards.
                        Unsafe.As<NativeVariant, decimal>(ref result) = (decimal)data.ReferenceData!;
                        result.Type = VariantType.Decimal;
                        break;

                    case VariantType.BinaryString:
                        // BinaryString needs to be allocated from one of the possible sources.
                        result.Content1 = ReadOnlyBinaryStringRef.Marshaller.ConvertToUnmanaged(
                            (data.ReferenceData as string) ?? (data.ReferenceData as BinaryString));
                        break;

                    default:
                        throw new NotSupportedException($"Variant Type {data.Type} is not supported.");
                }
                return result;
            }

            public static void Free(NativeVariant data)
            {
                if (data.Type != VariantType.Empty)
                    VariantInterop.VariantClear(&data);
            }

            public struct ByRef
            {
                public void FromUnmanaged(NativeVariant value) => throw new NotImplementedException();
                public void FromManaged(Variant value) => throw new NotImplementedException();
                public NativeVariant ToUnmanaged() => throw new NotImplementedException();
                public Variant ToManaged() => throw new NotImplementedException();
                public void Free() => throw new NotImplementedException();
            }
        }

        [CustomMarshaller(typeof(object), MarshalMode.Default, typeof(ObjectMarshaller))]
        public static class ObjectMarshaller
        {
            public static object? ConvertToManaged(NativeVariant data)
            {
                var v = Marshaller.ConvertToManaged(data);
                switch (v.Type)
                {
                    case VariantType.Empty: return null;
                    case VariantType.DBNull: return System.DBNull.Value;
                    case VariantType.Error: return new ErrorWrapper(v.RequireError());
                    case VariantType.Boolean: return v.RequireBoolean();
                    case VariantType.Int8: return v.RequireInt8();
                    case VariantType.Int16: return v.RequireInt16();
                    case VariantType.Int32: return v.RequireInt32();
                    case VariantType.Int64: return v.RequireInt64();
                    case VariantType.IntPtr: return v.RequireIntPtr();
                    case VariantType.UInt8: return v.RequireUInt8();
                    case VariantType.UInt16: return v.RequireUInt16();
                    case VariantType.UInt32: return v.RequireUInt32();
                    case VariantType.UInt64: return v.RequireUInt64();
                    case VariantType.UIntPtr: return v.RequireUIntPtr();
                    case VariantType.Float32: return v.RequireFloat32();
                    case VariantType.Float64: return v.RequireFloat64();
                    case VariantType.Currency: return new CurrencyWrapper(v.RequireCurrency());
                    case VariantType.DateTime: return v.RequireDateTime();
                    case VariantType.Decimal: return v.RequireDecimal();
                    case VariantType.BinaryString: return v.RequireString();

                    case VariantType.IUnknown:
                    case VariantType.IDispatch:
                        return v.ReferenceData;

                    default: throw new NotSupportedException();
                }
            }

            public static NativeVariant ConvertToUnmanaged(object? data)
            {
                return Marshaller.ConvertToUnmanaged(Value(data));
            }

            public static void Free(NativeVariant data)
            {
                Marshaller.Free(data);
            }
        }

        private sealed class InlineType
        {
            public static InlineType Error { get; } = new(VariantType.Error);
            public static InlineType Boolean { get; } = new(VariantType.Boolean);
            public static InlineType Int8 { get; } = new(VariantType.Int8);
            public static InlineType Int16 { get; } = new(VariantType.Int16);
            public static InlineType Int32 { get; } = new(VariantType.Int32);
            public static InlineType Int64 { get; } = new(VariantType.Int64);
            public static InlineType IntPtr { get; } = new(VariantType.IntPtr);
            public static InlineType UInt8 { get; } = new(VariantType.UInt8);
            public static InlineType UInt16 { get; } = new(VariantType.UInt16);
            public static InlineType UInt32 { get; } = new(VariantType.UInt32);
            public static InlineType UInt64 { get; } = new(VariantType.UInt64);
            public static InlineType UIntPtr { get; } = new(VariantType.UIntPtr);
            public static InlineType Float32 { get; } = new(VariantType.Float32);
            public static InlineType Float64 { get; } = new(VariantType.Float64);
            public static InlineType Currency { get; } = new(VariantType.Currency);
            public static InlineType DateTime { get; } = new(VariantType.DateTime);

            public readonly VariantType Type;
            private InlineType(VariantType Type) => this.Type = Type;
        }

        public static Variant Empty => default;
        public static Variant DBNull => new(VariantType.DBNull, null);
        public static Variant Error(int value) => new(InlineType.Error, value);
        public static Variant Boolean(bool value) => new(InlineType.Boolean, value ? VariantBool.TrueValue : VariantBool.FalseValue);
        public static Variant Int8(sbyte value) => new(InlineType.Int8, value);
        public static Variant Int16(short value) => new(InlineType.Int16, value);
        public static Variant Int32(int value) => new(InlineType.Int32, value);
        public static Variant Int64(long value) => new(InlineType.Int64, value);
        public static Variant IntPtr(nint value) => new(InlineType.IntPtr, value);
        public static Variant UInt8(byte value) => new(InlineType.UInt8, value);
        public static Variant UInt16(ushort value) => new(InlineType.UInt16, value);
        public static Variant UInt32(uint value) => new(InlineType.UInt32, value);
        public static Variant UInt64(ulong value) => new(InlineType.UInt64, value);
        public static Variant UIntPtr(nuint value) => new(InlineType.UIntPtr, value);
        public static Variant Float32(float value) => new(InlineType.Float32, value);
        public static Variant Float64(double value) => new(InlineType.Float64, value);
        public static Variant Decimal(decimal value) => new(VariantType.Decimal, value);
        public static Variant Currency(decimal value) => new(InlineType.Currency, decimal.ToOACurrency(value));
        public static Variant DateTime(DateTime value) => new(InlineType.DateTime, value.ToOADate());
        public static Variant BinaryString(string? value) => value is null ? default : new(VariantType.BinaryString, value);
        public static Variant BinaryString(BinaryString? value) => value is null ? default : new(VariantType.BinaryString, value);

        public static implicit operator Variant(DBNull value) => value is null ? default : DBNull;
        public static implicit operator Variant(ErrorWrapper value) => value is null ? default : Error(value.ErrorCode);
        public static implicit operator Variant(bool value) => Boolean(value);
        public static implicit operator Variant(sbyte value) => Int8(value);
        public static implicit operator Variant(short value) => Int16(value);
        public static implicit operator Variant(int value) => Int32(value);
        public static implicit operator Variant(long value) => Int64(value);
        public static implicit operator Variant(nint value) => IntPtr(value);
        public static implicit operator Variant(byte value) => UInt8(value);
        public static implicit operator Variant(ushort value) => UInt16(value);
        public static implicit operator Variant(uint value) => UInt32(value);
        public static implicit operator Variant(ulong value) => UInt64(value);
        public static implicit operator Variant(nuint value) => UIntPtr(value);
        public static implicit operator Variant(float value) => Float32(value);
        public static implicit operator Variant(double value) => Float64(value);
        public static implicit operator Variant(decimal value) => Decimal(value);
        public static implicit operator Variant(CurrencyWrapper value) => value is null ? default : Currency(value.WrappedObject);
        public static implicit operator Variant(string value) => BinaryString(value);
        public static implicit operator Variant(BinaryString value) => BinaryString(value);
        public static implicit operator Variant(BStrWrapper value) => BinaryString(value?.WrappedObject);

        public static Variant Value(object? value)
        {
            switch (value)
            {
                case null: return Empty;
                case DBNull _: return DBNull;
                case ErrorWrapper content: return Error(content.ErrorCode);
                case bool content: return Boolean(content);
                case sbyte content: return Int8(content);
                case short content: return Int16(content);
                case int content: return Int32(content);
                case long content: return Int64(content);
                case nint content: return IntPtr(content);
                case byte content: return UInt8(content);
                case ushort content: return UInt16(content);
                case uint content: return UInt32(content);
                case ulong content: return UInt64(content);
                case nuint content: return UIntPtr(content);
                case float content: return Float32(content);
                case double content: return Float64(content);
                case decimal content: return Decimal(content);
                case CurrencyWrapper content: return value is null ? default : Currency(content.WrappedObject);
                case string content: return BinaryString(content);
                case BinaryString content: return BinaryString(content);
                case BStrWrapper content: return BinaryString(content?.WrappedObject);
                default: throw new NotSupportedException();
            }
        }

        private readonly long InlineData;
        private readonly object? ReferenceData;

        private Variant(VariantType type, object? value)
        {
            ReferenceData = value;
            Unsafe.As<long, VariantType>(ref InlineData) = type;
        }

        private Variant(InlineType type, sbyte value)
        {
            ReferenceData = type;
            Unsafe.As<long, sbyte>(ref InlineData) = value;
        }

        private Variant(InlineType type, byte value)
        {
            ReferenceData = type;
            Unsafe.As<long, byte>(ref InlineData) = value;
        }

        private Variant(InlineType type, short value)
        {
            ReferenceData = type;
            Unsafe.As<long, short>(ref InlineData) = value;
        }

        private Variant(InlineType type, ushort value)
        {
            ReferenceData = type;
            Unsafe.As<long, ushort>(ref InlineData) = value;
        }

        private Variant(InlineType type, int value)
        {
            ReferenceData = type;
            Unsafe.As<long, int>(ref InlineData) = value;
        }

        private Variant(InlineType type, uint value)
        {
            ReferenceData = type;
            Unsafe.As<long, uint>(ref InlineData) = value;
        }

        private Variant(InlineType type, nint value)
        {
            ReferenceData = type;
            Unsafe.As<long, nint>(ref InlineData) = value;
        }

        private Variant(InlineType type, nuint value)
        {
            ReferenceData = type;
            Unsafe.As<long, nuint>(ref InlineData) = value;
        }

        private Variant(InlineType type, long value)
        {
            ReferenceData = type;
            Unsafe.As<long, long>(ref InlineData) = value;
        }

        private Variant(InlineType type, ulong value)
        {
            ReferenceData = type;
            Unsafe.As<long, ulong>(ref InlineData) = value;
        }

        private Variant(InlineType type, float value)
        {
            ReferenceData = type;
            Unsafe.As<long, float>(ref InlineData) = value;
        }

        private Variant(InlineType type, double value)
        {
            ReferenceData = type;
            Unsafe.As<long, double>(ref InlineData) = value;
        }

        public VariantType Type => ReferenceData is InlineType inline ? inline.Type : (VariantType)InlineData;
        public bool IsEmpty => Type == VariantType.Empty;
        public bool IsDBNull => Type == VariantType.DBNull;
        public bool IsError => Type == VariantType.Error;
        public bool IsBoolean => Type == VariantType.Boolean;
        public bool IsInt8 => Type == VariantType.Int8;
        public bool IsInt16 => Type == VariantType.Int16;
        public bool IsInt32 => Type == VariantType.Int32;
        public bool IsInt64 => Type == VariantType.Int64;
        public bool IsIntPtr => Type == VariantType.IntPtr;
        public bool IsUInt8 => Type == VariantType.UInt8;
        public bool IsUInt16 => Type == VariantType.UInt16;
        public bool IsUInt32 => Type == VariantType.UInt32;
        public bool IsUInt64 => Type == VariantType.UInt64;
        public bool IsUIntPtr => Type == VariantType.UIntPtr;
        public bool IsFloat32 => Type == VariantType.Float32;
        public bool IsFloat64 => Type == VariantType.Float64;
        public bool IsDecimal => Type == VariantType.Decimal;
        public bool IsCurrency => Type == VariantType.Currency;
        public bool IsDateTime => Type == VariantType.DateTime;
        public bool IsBinaryString => Type == VariantType.BinaryString;

        public void RequireEmpty() { if (!IsEmpty) throw new InvalidOperationException(); }
        public DBNull RequireDBNull() => IsDBNull ? System.DBNull.Value : throw new InvalidOperationException();
        public int RequireError() => IsError ? (int)InlineData : throw new InvalidOperationException();
        public bool RequireBoolean() => IsBoolean ? (short)InlineData != 0 : throw new InvalidOperationException();
        public sbyte RequireInt8() => IsInt8 ? (sbyte)InlineData : throw new InvalidOperationException();
        public short RequireInt16() => IsInt16 ? (short)InlineData : throw new InvalidOperationException();
        public int RequireInt32() => IsInt32 ? (int)InlineData : throw new InvalidOperationException();
        public long RequireInt64() => IsInt64 ? (long)InlineData : throw new InvalidOperationException();
        public nint RequireIntPtr() => IsIntPtr ? (nint)InlineData : throw new InvalidOperationException();
        public byte RequireUInt8() => IsUInt8 ? (byte)InlineData : throw new InvalidOperationException();
        public ushort RequireUInt16() => IsUInt16 ? (ushort)InlineData : throw new InvalidOperationException();
        public uint RequireUInt32() => IsUInt32 ? (uint)InlineData : throw new InvalidOperationException();
        public ulong RequireUInt64() => IsUInt64 ? (ulong)InlineData : throw new InvalidOperationException();
        public nuint RequireUIntPtr() => IsUIntPtr ? (nuint)InlineData : throw new InvalidOperationException();
        public float RequireFloat32() => IsFloat32 ? BitConverter.Int32BitsToSingle((int)InlineData) : throw new InvalidOperationException();
        public double RequireFloat64() => IsFloat64 ? BitConverter.Int64BitsToDouble(InlineData) : throw new InvalidOperationException();
        public decimal RequireDecimal() => IsDecimal ? (decimal)ReferenceData! : throw new InvalidOperationException();
        public decimal RequireCurrency() => IsCurrency ? decimal.FromOACurrency(InlineData) : throw new InvalidOperationException();
        public DateTime RequireDateTime() => IsDateTime ? System.DateTime.FromOADate(BitConverter.Int64BitsToDouble(InlineData)) : throw new InvalidOperationException();
        public BinaryString RequireBinaryString() => IsBinaryString ? ReferenceData as BinaryString ?? new((string)ReferenceData!) : throw new InvalidOperationException();
        public string RequireString() => IsBinaryString ? ReferenceData as string ?? ((BinaryString)ReferenceData!).ToString() : throw new InvalidOperationException();

        public object? ToComObject()
        {
            switch (Type)
            {
                case VariantType.Empty:
                case VariantType.DBNull:
                    return null;

                case VariantType.IUnknown:
                case VariantType.IDispatch:
                    return ReferenceData;

                default:
                    throw new InvalidOperationException();
            }
        }

        public override string ToString()
        {
            switch (Type)
            {
                case VariantType.Empty: return "Empty";
                case VariantType.DBNull: return "DBNull";
                case VariantType.Error: return $"Error: 0x{(uint)RequireError():x8}";
                case VariantType.Boolean: return $"Boolean: {RequireBoolean()}";
                case VariantType.Int8: return $"Int8: {RequireInt8()}";
                case VariantType.Int16: return $"Int16: {RequireInt16()}";
                case VariantType.Int32: return $"Int32: {RequireInt32()}";
                case VariantType.Int64: return $"Int64: {RequireInt64()}";
                case VariantType.IntPtr: return $"IntPtr: {RequireIntPtr()}";
                case VariantType.UInt8: return $"UInt8: {RequireUInt8()}";
                case VariantType.UInt16: return $"UInt16: {RequireUInt16()}";
                case VariantType.UInt32: return $"UInt32: {RequireUInt32()}";
                case VariantType.UInt64: return $"UInt64: {RequireUInt64()}";
                case VariantType.UIntPtr: return $"UIntPtr: {RequireUIntPtr()}";
                case VariantType.Float32: return $"Float32: {RequireFloat32()}";
                case VariantType.Float64: return $"Float64: {RequireFloat64()}";
                case VariantType.Decimal: return $"Decimal: {RequireDecimal()}";
                case VariantType.Currency: return $"Currency: {RequireCurrency()}";
                case VariantType.DateTime: return $"DateTime: {RequireDateTime():s}";
                case VariantType.BinaryString: return $"BinaryString: {RequireBinaryString()}";
                default: throw new InvalidOperationException();
            }
        }

        public override int GetHashCode() => HashCode.Combine(ReferenceData, InlineData);
        public override bool Equals([NotNullWhen(true)] object? obj) => obj is Variant other && Equals(other);
        public bool Equals(Variant other) => this.InlineData == other.InlineData && Equals(this.ReferenceData, other.ReferenceData);
        public static bool operator ==(Variant lhs, Variant rhs) => lhs.Equals(rhs);
        public static bool operator !=(Variant lhs, Variant rhs) => !lhs.Equals(rhs);
    }

    public struct VariantBool
    {
        public static implicit operator VariantBool(bool value) => new VariantBool(value);
        public static implicit operator bool(VariantBool value) => value.Value != 0;

        public static VariantBool True => new(TrueValue);
        public static VariantBool False => new(FalseValue);

        public const short TrueValue = -1;
        public const short FalseValue = 0;

        public short Value;

        public VariantBool(short value) => Value = value;
        public VariantBool(bool value) => Value = value ? TrueValue : FalseValue;
    }

    internal static unsafe partial class VariantInterop
    {
#if NET8_0_OR_GREATER
        [LibraryImport("oleaut32", EntryPoint = "VariantClear", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial int VariantClear(NativeVariant* value);
#else
        [DllImport("oleaut32", EntryPoint = "VariantClear", SetLastError = false, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int VariantClear(NativeVariant* value);
#endif
    }
}
