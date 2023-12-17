using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsRdpEx.Interop;

#nullable enable

namespace System.Runtime.InteropServices.Marshalling
{
    public unsafe sealed class BinaryStringMarshaler : ICustomMarshaler
    {
        public static ICustomMarshaler GetInstance(string cookie) => new BinaryStringMarshaler();

        public object? MarshalNativeToManaged(IntPtr pointer)
        {
            if (pointer == IntPtr.Zero)
                return null;

            // make sure we don't construct a BinaryString larger than .NET can manage
            // (it's safe to throw here, the marshaller retains ownership and frees it)
            if (((int*)pointer)[-1] < 0)
                throw new OverflowException();

            // transfer ownership to managed code
            return new BinaryString(pointer);
        }

        public void CleanUpManagedData(object ManagedObj)
        {
        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            var value = (BinaryString)ManagedObj;
            if (value is null)
                return IntPtr.Zero;

            var pointer = value.pointer;
            value.pointer = 0;

            // we are using zero pointers in non-null BinaryString as a cheap representation of an empty BinaryString
            // however if we need to pass ownership of an empty string to native code we actually have to allocate one
            if (pointer == 0 && (pointer = BinaryStringInterop.AllocateByteBuffer(null, 0)) == 0)
                throw new OutOfMemoryException();

            return pointer;
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            Marshal.FreeBSTR(pNativeData);
        }

        public int GetNativeDataSize()
        {
            throw new NotImplementedException();
        }
    }
}
