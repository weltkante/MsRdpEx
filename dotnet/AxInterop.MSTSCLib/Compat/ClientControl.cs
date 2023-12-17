using System;
using System.Runtime.InteropServices;
using MsRdpEx.Interop;

namespace MSTSCLib
{
    [ComImport]
    [Guid("336D5562-EFA8-482E-8CB3-C5C0FC7A7DB6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IMsTscAxEvents
    {
        [DispId(1)] [PreserveSig] void OnConnecting();
        [DispId(2)] [PreserveSig] void OnConnected();
        [DispId(3)] [PreserveSig] void OnLoginComplete();
        [DispId(4)] [PreserveSig] void OnDisconnected(int discReason);
        [DispId(5)] [PreserveSig] void OnEnterFullScreenMode();
        [DispId(6)] [PreserveSig] void OnLeaveFullScreenMode();
        [DispId(7)] [PreserveSig] void OnChannelReceivedData([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string data);
        [DispId(8)] [PreserveSig] void OnRequestGoFullScreen();
        [DispId(9)] [PreserveSig] void OnRequestLeaveFullScreen();
        [DispId(10)] [PreserveSig] void OnFatalError(int errorCode);
        [DispId(11)] [PreserveSig] void OnWarning(int warningCode);
        [DispId(12)] [PreserveSig] void OnRemoteDesktopSizeChange(int width, int height);
        [DispId(13)] [PreserveSig] void OnIdleTimeoutNotification();
        [DispId(14)] [PreserveSig] void OnRequestContainerMinimize();
        [DispId(15)] [PreserveSig] void OnConfirmClose(out bool pfAllowClose);
        [DispId(16)] [PreserveSig] void OnReceivedTSPublicKey([MarshalAs(UnmanagedType.BStr)] string publicKey, out bool pfContinueLogon);
        [DispId(17)] [PreserveSig] void OnAutoReconnecting(int disconnectReason, int attemptCount, out AutoReconnectContinueState pArcContinueStatus);
        [DispId(18)] [PreserveSig] void OnAuthenticationWarningDisplayed();
        [DispId(19)] [PreserveSig] void OnAuthenticationWarningDismissed();
        [DispId(20)] [PreserveSig] void OnRemoteProgramResult([MarshalAs(UnmanagedType.BStr)] string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable);
        [DispId(21)] [PreserveSig] void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation);
        [DispId(29)] [PreserveSig] void OnRemoteWindowDisplayed(bool vbDisplayed, nint hwnd, RemoteWindowDisplayedAttribute windowAttribute);
        [DispId(22)] [PreserveSig] void OnLogonError(int lError);
        [DispId(23)] [PreserveSig] void OnFocusReleased(int iDirection);
        [DispId(24)] [PreserveSig] void OnUserNameAcquired([MarshalAs(UnmanagedType.BStr)] string bstrUserName);
        [DispId(26)] [PreserveSig] void OnMouseInputModeChanged(bool fMouseModeRelative);
        [DispId(28)] [PreserveSig] void OnServiceMessageReceived([MarshalAs(UnmanagedType.BStr)] string serviceMessage);
        [DispId(30)] [PreserveSig] void OnConnectionBarPullDown();
        [DispId(32)] [PreserveSig] void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt);
        [DispId(35)] [PreserveSig] void OnDevicesButtonPressed();
        [DispId(33)] [PreserveSig] void OnAutoReconnected();
        [DispId(34)] [PreserveSig] void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount);
    }
}
