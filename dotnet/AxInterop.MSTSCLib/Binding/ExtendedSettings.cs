using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MsRdpEx.Interop
{
    [GeneratedComInterface]
    [Guid("302D8188-0052-4807-806A-362B628F9AC5")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe partial interface IMsRdpExtendedSettings
    {
        void SetProperty(ReadOnlyBinaryStringRef PropertyName, [MarshalUsing(typeof(Variant.ObjectMarshaller))] in object value);
        [return: MarshalUsing(typeof(Variant.ObjectMarshaller))] object GetProperty(ReadOnlyBinaryStringRef PropertyName);
    }
}
