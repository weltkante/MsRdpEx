using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

#nullable enable

namespace MsRdpEx.Interop
{
#if NET8_0_OR_GREATER
    [GeneratedComInterface]
#else
    [ComImport]
#endif
    [Guid("00020400-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe partial interface IDispatch
    {
        void GetTypeInfoCount(nint pctinfo);
        void GetTypeInfo(int iTInfo, int lcid, nint ppTInfo);
        void GetIDsOfNames(nint riid, nint rgszNames, int cNames, int lcid, nint rgDispId);
        void Invoke(int dispIdMember, nint riid, int lcid, short wFlags, nint pDispParams, nint pVarResult, nint pExcepInfo, nint puArgErr);
    }
}
