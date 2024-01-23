using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using MSTSCLib;

namespace MsRdpEx.Interop
{
    [GeneratedComInterface]
    [Guid("079863B7-6D47-4105-8BFE-0CDCB360E67D")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe partial interface IRemoteDesktopClientEvents : IDispatch
    {
        [PreserveSig, DispId(750)] void OnConnecting();
        [PreserveSig, DispId(751)] void OnConnected();
        [PreserveSig, DispId(752)] void OnLoginCompleted();
        [PreserveSig, DispId(753)] void OnDisconnected(int disconnectReason, int ExtendedDisconnectReason, ReadOnlyBinaryStringRef disconnectErrorMessage);
        [PreserveSig, DispId(754)] void OnStatusChanged(int statusCode, ReadOnlyBinaryStringRef statusMessage);
        [PreserveSig, DispId(755)] void OnAutoReconnecting(int disconnectReason, int ExtendedDisconnectReason, ReadOnlyBinaryStringRef disconnectErrorMessage, [MarshalAs(UnmanagedType.VariantBool)] bool networkAvailable, int attemptCount, int maxAttemptCount);
        [PreserveSig, DispId(756)] void OnAutoReconnected();
        [PreserveSig, DispId(757)] void OnDialogDisplaying();
        [PreserveSig, DispId(758)] void OnDialogDismissed();
        [PreserveSig, DispId(759)] void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt);
        [PreserveSig, DispId(760)] void OnAdminMessageReceived(ReadOnlyBinaryStringRef adminMessage);
        [PreserveSig, DispId(761)] void OnKeyCombinationPressed(int keyCombination);
        [PreserveSig, DispId(762)] void OnRemoteDesktopSizeChanged(int width, int height);
        [PreserveSig, DispId(800)] void OnTouchPointerCursorMoved(int x, int y);
    }

    [GeneratedComInterface]
    [Guid("57D25668-625A-4905-BE4E-304CAA13F89C")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe partial interface IRemoteDesktopClient : IDispatch
    {
        void Connect();
        void Disconnect();
        void Reconnect(uint width, uint height);
        IRemoteDesktopClientSettings GetSettings();
        IRemoteDesktopClientActions GetActions();
        IRemoteDesktopClientTouchPointer GetTouchPointer();
        void DeleteSavedCredentials(ReadOnlyBinaryStringRef serverName);
        void UpdateSessionDisplaySettings(uint width, uint height);
        void attachEvent(ReadOnlyBinaryStringRef eventName, IDispatch callback);
        void detachEvent(ReadOnlyBinaryStringRef eventName, IDispatch callback);
    }

    [GeneratedComInterface]
    [Guid("48A0F2A7-2713-431F-BBAC-6F4558E7D64D")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe partial interface IRemoteDesktopClientSettings : IDispatch
    {
        void ApplySettings(ReadOnlyBinaryStringRef RdpFileContents);
        BinaryString RetrieveSettings();
        [return: MarshalUsing(typeof(Variant.ObjectMarshaller))] object GetRdpProperty(ReadOnlyBinaryStringRef propertyName);
        void SetRdpProperty(ReadOnlyBinaryStringRef propertyName, [MarshalUsing(typeof(Variant.ObjectMarshaller))] object value);
    }

    [GeneratedComInterface]
    [Guid("7D54BC4E-1028-45D4-8B0A-B9B6BFFBA176")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe partial interface IRemoteDesktopClientActions : IDispatch
    {
        void SuspendScreenUpdates();
        void ResumeScreenUpdates();
        void ExecuteRemoteAction(RemoteActionType remoteAction);
        BinaryString GetSnapshot(SnapshotEncodingType snapshotEncoding, SnapshotFormatType snapshotFormat, uint snapshotWidth, uint snapshotHeight);
    }

    //public enum RemoteActionType
    //{
    //    RemoteActionCharms,
    //    RemoteActionAppbar,
    //    RemoteActionSnap,
    //    RemoteActionStartScreen,
    //    RemoteActionAppSwitch,
    //}

    //public enum SnapshotEncodingType
    //{
    //    SnapshotEncodingDataUri,
    //}

    //public enum SnapshotFormatType
    //{
    //    SnapshotFormatPng,
    //    SnapshotFormatJpeg,
    //    SnapshotFormatBmp,
    //}

    [GeneratedComInterface]
    [Guid("260EC22D-8CBC-44B5-9E88-2A37F6C93AE9")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe partial interface IRemoteDesktopClientTouchPointer : IDispatch
    {
        void SetEnabled([MarshalAs(UnmanagedType.VariantBool)] bool Enabled);
        [return: MarshalAs(UnmanagedType.VariantBool)] bool GetEnabled();
        void SetEventsEnabled([MarshalAs(UnmanagedType.VariantBool)] bool EventsEnabled);
        [return: MarshalAs(UnmanagedType.VariantBool)] bool GetEventsEnabled();
        void SetPointerSpeed(uint PointerSpeed);
        uint GetPointerSpeed();
    }
}
