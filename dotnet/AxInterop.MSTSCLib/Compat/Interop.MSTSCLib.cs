using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using MsRdpEx.Interop;


namespace MSTSCLib
{
#if NET8_0_OR_GREATER
    [ComImport]
    [Guid("327BB5CD-834E-4400-AEF2-B30E15E5D682")]
    public interface IMsTscAx_Redist
    {
        #region IMsTscAx_Redist
        #endregion
    }
    [ComImport]
    [Guid("8C11EFAE-92C3-11D1-BC1E-00C04FA31489")]
    public interface IMsTscAx : IMsTscAx_Redist
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        short Connected { get; }
        int DesktopWidth { set; get; }
        int DesktopHeight { set; get; }
        int StartConnected { set; get; }
        int HorizontalScrollBarVisible { get; }
        int VerticalScrollBarVisible { get; }
        string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        int CipherStrength { get; }
        string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        int SecuredSettingsEnabled { get; }
        IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        void Connect();
        void Disconnect();
        void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
    }
    [ComImport]
    [Guid("C9D65442-A0F9-45B2-8F73-D61D2DB8CBB6")]
    public interface IMsTscSecuredSettings
    {
        #region IMsTscSecuredSettings
        string StartProgram { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string WorkDir { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        int FullScreen { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("809945CC-4B3B-4A92-A6B0-DBF9B5F2EF2D")]
    public interface IMsTscAdvancedSettings
    {
        #region IMsTscAdvancedSettings
        int Compress { set; get; }
        int BitmapPeristence { set; get; }
        int allowBackgroundInput { set; get; }
        string KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.BStr)] set; }
        string PluginDlls { [param: MarshalAs(UnmanagedType.BStr)] set; }
        string IconFile { [param: MarshalAs(UnmanagedType.BStr)] set; }
        int IconIndex { set; }
        int ContainerHandledFullScreen { set; get; }
        int DisableRdpdr { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("209D0EB9-6254-47B1-9033-A98DAE55BB27")]
    public interface IMsTscDebug
    {
        #region IMsTscDebug
        int HatchBitmapPDU { set; get; }
        int HatchSSBOrder { set; get; }
        int HatchMembltOrder { set; get; }
        int HatchIndexPDU { set; get; }
        int LabelMemblt { set; get; }
        int BitmapCacheMonitor { set; get; }
        int MallocFailuresPercent { set; get; }
        int MallocHugeFailuresPercent { set; get; }
        int NetThroughput { set; get; }
        string CLXCmdLine { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string CLXDll { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        int RemoteProgramsHatchVisibleRegion { set; get; }
        int RemoteProgramsHatchVisibleNoDataRegion { set; get; }
        int RemoteProgramsHatchNonVisibleRegion { set; get; }
        int RemoteProgramsHatchWindow { set; get; }
        int RemoteProgramsStayConnectOnBadCaps { set; get; }
        uint ControlType { get; }
        bool DecodeGfx { set; }
        #endregion
    }
    //[ComImport]
    //[Guid("336D5562-EFA8-482E-8CB3-C5C0FC7A7DB6")]
    //[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    //public interface IMsTscAxEvents
    //{
    //    #region IMsTscAxEvents
    //    [PreserveSig] void OnConnecting();
    //    [PreserveSig] void OnConnected();
    //    [PreserveSig] void OnLoginComplete();
    //    [PreserveSig] void OnDisconnected(int discReason);
    //    [PreserveSig] void OnEnterFullScreenMode();
    //    [PreserveSig] void OnLeaveFullScreenMode();
    //    [PreserveSig] void OnChannelReceivedData([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string data);
    //    [PreserveSig] void OnRequestGoFullScreen();
    //    [PreserveSig] void OnRequestLeaveFullScreen();
    //    [PreserveSig] void OnFatalError(int errorCode);
    //    [PreserveSig] void OnWarning(int warningCode);
    //    [PreserveSig] void OnRemoteDesktopSizeChange(int width, int height);
    //    [PreserveSig] void OnIdleTimeoutNotification();
    //    [PreserveSig] void OnRequestContainerMinimize();
    //    [PreserveSig] void OnConfirmClose(out bool pfAllowClose);
    //    [PreserveSig] void OnReceivedTSPublicKey([MarshalAs(UnmanagedType.BStr)] string publicKey, out bool pfContinueLogon);
    //    [PreserveSig] void OnAutoReconnecting(int disconnectReason, int attemptCount, out AutoReconnectContinueState pArcContinueStatus);
    //    [PreserveSig] void OnAuthenticationWarningDisplayed();
    //    [PreserveSig] void OnAuthenticationWarningDismissed();
    //    [PreserveSig] void OnRemoteProgramResult([MarshalAs(UnmanagedType.BStr)] string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable);
    //    [PreserveSig] void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation);
    //    [PreserveSig] void OnRemoteWindowDisplayed(bool vbDisplayed, nint hwnd, RemoteWindowDisplayedAttribute windowAttribute);
    //    [PreserveSig] void OnLogonError(int lError);
    //    [PreserveSig] void OnFocusReleased(int iDirection);
    //    [PreserveSig] void OnUserNameAcquired([MarshalAs(UnmanagedType.BStr)] string bstrUserName);
    //    [PreserveSig] void OnMouseInputModeChanged(bool fMouseModeRelative);
    //    [PreserveSig] void OnServiceMessageReceived([MarshalAs(UnmanagedType.BStr)] string serviceMessage);
    //    [PreserveSig] void OnConnectionBarPullDown();
    //    [PreserveSig] void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt);
    //    [PreserveSig] void OnDevicesButtonPressed();
    //    [PreserveSig] void OnAutoReconnected();
    //    [PreserveSig] void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount);
    //    #endregion
    //}
    public enum AutoReconnectContinueState
    {
        #region AutoReconnectContinueState
        autoReconnectContinueAutomatic = 0,
        autoReconnectContinueStop = 1,
        autoReconnectContinueManual = 2,
        #endregion
    }
    public enum RemoteProgramResult
    {
        #region RemoteProgramResult
        remoteAppResultOk = 0,
        remoteAppResultLocked = 1,
        remoteAppResultProtocolError = 2,
        remoteAppResultNotInWhitelist = 3,
        remoteAppResultNetworkPathDenied = 4,
        remoteAppResultFileNotFound = 5,
        remoteAppResultFailure = 6,
        remoteAppResultHookNotLoaded = 7,
        #endregion
    }
    public enum RemoteWindowDisplayedAttribute
    {
        #region RemoteWindowDisplayedAttribute
        remoteAppWindowNone = 0,
        remoteAppWindowDisplayed = 1,
        remoteAppShellIconDisplayed = 2,
        #endregion
    }
    [ComImport]
    [Guid("92B4A539-7115-4B7C-A5A9-E5D9EFC2780A")]
    public interface IMsRdpClient : IMsTscAx
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        int ColorDepth { set; get; }
        IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        bool FullScreen { set; get; }
        void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        ControlCloseStatus RequestClose();
        #endregion
    }
    [ComImport]
    [Guid("3C65B4AB-12B3-465B-ACD4-B8DAD3BFF9E2")]
    public interface IMsRdpClientAdvancedSettings : IMsTscAdvancedSettings
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new string KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PluginDlls { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string IconFile { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        int SmoothScroll { set; get; }
        int AcceleratorPassthrough { set; get; }
        int ShadowBitmap { set; get; }
        int TransportType { set; get; }
        int SasSequence { set; get; }
        int EncryptionEnabled { set; get; }
        int DedicatedTerminal { set; get; }
        int RDPPort { set; get; }
        int EnableMouse { set; get; }
        int DisableCtrlAltDel { set; get; }
        int EnableWindowsKey { set; get; }
        int DoubleClickDetect { set; get; }
        int MaximizeShell { set; get; }
        int HotKeyFullScreen { set; get; }
        int HotKeyCtrlEsc { set; get; }
        int HotKeyAltEsc { set; get; }
        int HotKeyAltTab { set; get; }
        int HotKeyAltShiftTab { set; get; }
        int HotKeyAltSpace { set; get; }
        int HotKeyCtrlAltDel { set; get; }
        int orderDrawThreshold { set; get; }
        int BitmapCacheSize { set; get; }
        int BitmapVirtualCacheSize { set; get; }
        int ScaleBitmapCachesByBPP { set; get; }
        int NumBitmapCaches { set; get; }
        int CachePersistenceActive { set; get; }
        string PersistCacheDirectory { [param: MarshalAs(UnmanagedType.BStr)] set; }
        int brushSupportLevel { set; get; }
        int minInputSendInterval { set; get; }
        int InputEventsAtOnce { set; get; }
        int maxEventCount { set; get; }
        int keepAliveInterval { set; get; }
        int shutdownTimeout { set; get; }
        int overallConnectionTimeout { set; get; }
        int singleConnectionTimeout { set; get; }
        int KeyboardType { set; get; }
        int KeyboardSubType { set; get; }
        int KeyboardFunctionKey { set; get; }
        int WinceFixedPalette { set; get; }
        bool ConnectToServerConsole { set; get; }
        int BitmapPersistence { set; get; }
        int MinutesToIdleTimeout { set; get; }
        bool SmartSizing { set; get; }
        string RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        bool DisplayConnectionBar { set; get; }
        bool PinConnectionBar { set; get; }
        bool GrabFocusOnConnect { set; get; }
        BinaryString LoadBalanceInfo { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        bool RedirectDrives { set; get; }
        bool RedirectPrinters { set; get; }
        bool RedirectPorts { set; get; }
        bool RedirectSmartCards { set; get; }
        int BitmapVirtualCache16BppSize { set; get; }
        int BitmapVirtualCache24BppSize { set; get; }
        int PerformanceFlags { set; get; }
        void set_ConnectWithEndpoint([In][MarshalAs(UnmanagedType.Struct)] ref object A_1);
        bool NotifyTSPublicKey { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("605BEFCF-39C1-45CC-A811-068FB7BE346D")]
    public interface IMsRdpClientSecuredSettings : IMsTscSecuredSettings
    {
        #region IMsTscSecuredSettings
        new string StartProgram { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string WorkDir { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int FullScreen { set; get; }
        #endregion
        #region IMsRdpClientSecuredSettings
        int KeyboardHookMode { set; get; }
        int AudioRedirectionMode { set; get; }
        #endregion
    }
    public enum ExtendedDisconnectReasonCode
    {
        #region ExtendedDisconnectReasonCode
        exDiscReasonNoInfo = 0,
        exDiscReasonAPIInitiatedDisconnect = 1,
        exDiscReasonAPIInitiatedLogoff = 2,
        exDiscReasonServerIdleTimeout = 3,
        exDiscReasonServerLogonTimeout = 4,
        exDiscReasonReplacedByOtherConnection = 5,
        exDiscReasonOutOfMemory = 6,
        exDiscReasonServerDeniedConnection = 7,
        exDiscReasonServerDeniedConnectionFips = 8,
        exDiscReasonServerInsufficientPrivileges = 9,
        exDiscReasonServerFreshCredsRequired = 10,
        exDiscReasonRpcInitiatedDisconnectByUser = 11,
        exDiscReasonLogoffByUser = 12,
        exDiscReasonShutdown = 25,
        exDiscReasonReboot = 26,
        exDiscReasonLicenseInternal = 256,
        exDiscReasonLicenseNoLicenseServer = 257,
        exDiscReasonLicenseNoLicense = 258,
        exDiscReasonLicenseErrClientMsg = 259,
        exDiscReasonLicenseHwidDoesntMatchLicense = 260,
        exDiscReasonLicenseErrClientLicense = 261,
        exDiscReasonLicenseCantFinishProtocol = 262,
        exDiscReasonLicenseClientEndedProtocol = 263,
        exDiscReasonLicenseErrClientEncryption = 264,
        exDiscReasonLicenseCantUpgradeLicense = 265,
        exDiscReasonLicenseNoRemoteConnections = 266,
        exDiscReasonLicenseCreatingLicStoreAccDenied = 267,
        exDiscReasonRdpEncInvalidCredentials = 768,
        exDiscReasonProtocolRangeStart = 4096,
        exDiscReasonProtocolRangeEnd = 32767,
        #endregion
    }
    public enum ControlCloseStatus
    {
        #region ControlCloseStatus
        controlCloseCanProceed = 0,
        controlCloseWaitForEvents = 1,
        #endregion
    }
    [ComImport]
    [Guid("C1E6743A-41C1-4A74-832A-0DD06C1C7A0E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsTscNonScriptable
    {
        #region IMsTscNonScriptable
        string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        string PortablePassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string PortableSalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string BinaryPassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string BinarySalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        void ResetPassword();
        #endregion
    }
    [ComImport]
    [Guid("2F079C4C-87B2-4AFD-97AB-20CDB43038AE")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable : IMsTscNonScriptable
    {
        #region IMsTscNonScriptable
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PortablePassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string PortableSalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinaryPassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinarySalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
    }
    [ComImport]
    [Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
    public interface IMsRdpClient2 : IMsRdpClient
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        string ConnectedStatusText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
    }
    [ComImport]
    [Guid("9AC42117-2B76-4320-AA44-0E616AB8437B")]
    public interface IMsRdpClientAdvancedSettings2 : IMsRdpClientAdvancedSettings
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new string KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PluginDlls { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string IconFile { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new string PersistCacheDirectory { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new string RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new string LoadBalanceInfo { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In][MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        bool CanAutoReconnect { get; }
        bool EnableAutoReconnect { set; get; }
        int MaxReconnectAttempts { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("91B7CBC5-A72E-4FA0-9300-D647D7E897FF")]
    public interface IMsRdpClient3 : IMsRdpClient2
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new string ConnectedStatusText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClient3
        IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("19CD856B-C542-4C53-ACEE-F127E3BE1A59")]
    public interface IMsRdpClientAdvancedSettings3 : IMsRdpClientAdvancedSettings2
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new string KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PluginDlls { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string IconFile { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new string PersistCacheDirectory { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new string RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new string LoadBalanceInfo { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In][MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        bool ConnectionBarShowMinimizeButton { set; get; }
        bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("095E0738-D97D-488B-B9F6-DD0E8D66C0DE")]
    public interface IMsRdpClient4 : IMsRdpClient3
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new string ConnectedStatusText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("FBA7F64E-7345-4405-AE50-FA4A763DC0DE")]
    public interface IMsRdpClientAdvancedSettings4 : IMsRdpClientAdvancedSettings3
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new string KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PluginDlls { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string IconFile { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new string PersistCacheDirectory { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new string RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new string LoadBalanceInfo { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In][MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        uint AuthenticationLevel { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("17A5E535-4072-4FA4-AF32-C8D0D47345E9")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable2 : IMsRdpClientNonScriptable
    {
        #region IMsTscNonScriptable
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PortablePassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string PortableSalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinaryPassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinarySalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        nint UIParentWindowHandle { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("4EB5335B-6429-477D-B922-E06A28ECD8BF")]
    public interface IMsRdpClient5 : IMsRdpClient4
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new string ConnectedStatusText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] string GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("720298C0-A099-46F5-9F82-96921BAE4701")]
    public interface IMsRdpClientTransportSettings
    {
        #region IMsRdpClientTransportSettings
        string GatewayHostname { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        uint GatewayUsageMethod { set; get; }
        uint GatewayProfileUsageMethod { set; get; }
        uint GatewayCredsSource { set; get; }
        uint GatewayUserSelectedCredsSource { set; get; }
        int GatewayIsSupported { get; }
        uint GatewayDefaultUsageMethod { get; }
        #endregion
    }
    [ComImport]
    [Guid("FBA7F64E-6783-4405-DA45-FA4A763DABD0")]
    public interface IMsRdpClientAdvancedSettings5 : IMsRdpClientAdvancedSettings4
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new string KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PluginDlls { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string IconFile { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new string PersistCacheDirectory { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new string RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new string LoadBalanceInfo { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In][MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        new uint AuthenticationLevel { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings5
        bool RedirectClipboard { set; get; }
        uint AudioRedirectionMode { set; get; }
        bool ConnectionBarShowPinButton { set; get; }
        bool PublicMode { set; get; }
        bool RedirectDevices { set; get; }
        bool RedirectPOSDevices { set; get; }
        int BitmapVirtualCache32BppSize { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("FDD029F9-467A-4C49-8529-64B521DBD1B4")]
    public interface ITSRemoteProgram
    {
        #region ITSRemoteProgram
        bool RemoteProgramMode { set; get; }
        void ServerStartProgram([MarshalAs(UnmanagedType.BStr)] string bstrExecutablePath, [MarshalAs(UnmanagedType.BStr)] string bstrFilePath, [MarshalAs(UnmanagedType.BStr)] string bstrWorkingDirectory, bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.BStr)] string bstrArguments, bool vbExpandEnvVarInArgumentsOnServer);
        #endregion
    }
    [ComImport]
    [Guid("D012AE6D-C19A-4BFE-B367-201F8911F134")]
    public interface IMsRdpClientShell
    {
        #region IMsRdpClientShell
        void Launch();
        string RdpFileContents { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        void SetRdpProperty([MarshalAs(UnmanagedType.BStr)] string szProperty, [MarshalAs(UnmanagedType.Struct)] object Value);
        [return: MarshalAs(UnmanagedType.Struct)] object GetRdpProperty([MarshalAs(UnmanagedType.BStr)] string szProperty);
        bool IsRemoteProgramClientInstalled { get; }
        bool PublicMode { set; get; }
        void ShowTrustedSitesManagementDialog();
        #endregion
    }
    [ComImport]
    [Guid("B3378D90-0728-45C7-8ED7-B6159FB92219")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable3 : IMsRdpClientNonScriptable2
    {
        #region IMsTscNonScriptable
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PortablePassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string PortableSalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinaryPassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinarySalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        bool ShowRedirectionWarningDialog { set; get; }
        bool PromptForCredentials { set; get; }
        bool NegotiateSecurityLayer { set; get; }
        bool EnableCredSspSupport { set; get; }
        bool RedirectDynamicDrives { set; get; }
        bool RedirectDynamicDevices { set; get; }
        IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        bool WarnAboutSendingCredentials { set; get; }
        bool WarnAboutClipboardRedirection { set; get; }
        string ConnectionBarText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
    }
    [ComImport]
    [Guid("56540617-D281-488C-8738-6A8FDF64A118")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpDeviceCollection
    {
        #region IMsRdpDeviceCollection
        void RescanDevices(bool vboolDynRedir);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpDevice get_DeviceByIndex(uint index);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpDevice get_DeviceById([MarshalAs(UnmanagedType.BStr)] string devInstanceId);
        uint DeviceCount { get; }
        #endregion
    }
    [ComImport]
    [Guid("7FF17599-DA2C-4677-AD35-F60C04FE1585")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpDriveCollection
    {
        #region IMsRdpDriveCollection
        void RescanDrives(bool vboolDynRedir);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpDrive get_DriveByIndex(uint index);
        uint DriveCount { get; }
        #endregion
    }
    [ComImport]
    [Guid("D43B7D80-8517-4B6D-9EAC-96AD6800D7F2")]
    public interface IMsRdpClient6 : IMsRdpClient5
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new string ConnectedStatusText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] new string GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("222C4B5D-45D9-4DF0-A7C6-60CF9089D285")]
    public interface IMsRdpClientAdvancedSettings6 : IMsRdpClientAdvancedSettings5
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new string KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PluginDlls { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string IconFile { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new string PersistCacheDirectory { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new string RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new string LoadBalanceInfo { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In][MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        new uint AuthenticationLevel { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings5
        new bool RedirectClipboard { set; get; }
        new uint AudioRedirectionMode { set; get; }
        new bool ConnectionBarShowPinButton { set; get; }
        new bool PublicMode { set; get; }
        new bool RedirectDevices { set; get; }
        new bool RedirectPOSDevices { set; get; }
        new int BitmapVirtualCache32BppSize { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings6
        bool RelativeMouseMode { set; get; }
        string AuthenticationServiceClass { [return: MarshalAs(UnmanagedType.BStr)] get; [param: MarshalAs(UnmanagedType.BStr)] set; }
        string PCB { [return: MarshalAs(UnmanagedType.BStr)] get; [param: MarshalAs(UnmanagedType.BStr)] set; }
        int HotKeyFocusReleaseLeft { set; get; }
        int HotKeyFocusReleaseRight { set; get; }
        bool EnableCredSspSupport { set; get; }
        uint AuthenticationType { get; }
        bool ConnectToAdministerServer { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("67341688-D606-4C73-A5D2-2E0489009319")]
    public interface IMsRdpClientTransportSettings2 : IMsRdpClientTransportSettings
    {
        #region IMsRdpClientTransportSettings
        new string GatewayHostname { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new uint GatewayUsageMethod { set; get; }
        new uint GatewayProfileUsageMethod { set; get; }
        new uint GatewayCredsSource { set; get; }
        new uint GatewayUserSelectedCredsSource { set; get; }
        new int GatewayIsSupported { get; }
        new uint GatewayDefaultUsageMethod { get; }
        #endregion
        #region IMsRdpClientTransportSettings2
        uint GatewayCredSharing { set; get; }
        uint GatewayPreAuthRequirement { set; get; }
        string GatewayPreAuthServerAddr { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string GatewaySupportUrl { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string GatewayEncryptedOtpCookie { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        uint GatewayEncryptedOtpCookieSize { set; get; }
        string GatewayUsername { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string GatewayDomain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string GatewayPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        #endregion
    }
    [ComImport]
    [Guid("F50FA8AA-1C7D-4F59-B15C-A90CACAE1FCB")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable4 : IMsRdpClientNonScriptable3
    {
        #region IMsTscNonScriptable
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PortablePassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string PortableSalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinaryPassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinarySalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        new bool ShowRedirectionWarningDialog { set; get; }
        new bool PromptForCredentials { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new bool RedirectDynamicDrives { set; get; }
        new bool RedirectDynamicDevices { set; get; }
        new IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new bool WarnAboutSendingCredentials { set; get; }
        new bool WarnAboutClipboardRedirection { set; get; }
        new string ConnectionBarText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClientNonScriptable4
        RedirectionWarningType RedirectionWarningType { set; get; }
        bool MarkRdpSettingsSecure { set; get; }
        void set_PublisherCertificateChain([In][MarshalAs(UnmanagedType.Struct)] ref object pVarCert);
        object PublisherCertificateChain { [return: MarshalAs(UnmanagedType.Struct)] get; }
        bool WarnAboutPrinterRedirection { set; get; }
        bool AllowCredentialSaving { set; get; }
        bool PromptForCredsOnClient { set; get; }
        bool LaunchedViaClientShellInterface { set; get; }
        bool TrustedZoneSite { set; get; }
        #endregion
    }
    public enum RedirectionWarningType
    {
        #region RedirectionWarningType
        RedirectionWarningTypeDefault = 0,
        RedirectionWarningTypeUnsigned = 1,
        RedirectionWarningTypeUnknown = 2,
        RedirectionWarningTypeUser = 3,
        RedirectionWarningTypeThirdPartySigned = 4,
        RedirectionWarningTypeTrusted = 5,
        RedirectionWarningTypeMax = 5,
        #endregion
    }
    [ComImport]
    [Guid("B2A5B5CE-3461-444A-91D4-ADD26D070638")]
    public interface IMsRdpClient7 : IMsRdpClient6
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new string ConnectedStatusText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] new string GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        new IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient7
        IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientTransportSettings3 TransportSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] string GetStatusText(uint statusCode);
        IMsRdpClientSecuredSettings2 SecuredSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        ITSRemoteProgram2 RemoteProgram2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("26036036-4010-4578-8091-0DB9A1EDF9C3")]
    public interface IMsRdpClientAdvancedSettings7 : IMsRdpClientAdvancedSettings6
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new string KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PluginDlls { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string IconFile { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new string PersistCacheDirectory { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new string RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new string LoadBalanceInfo { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In][MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        new uint AuthenticationLevel { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings5
        new bool RedirectClipboard { set; get; }
        new uint AudioRedirectionMode { set; get; }
        new bool ConnectionBarShowPinButton { set; get; }
        new bool PublicMode { set; get; }
        new bool RedirectDevices { set; get; }
        new bool RedirectPOSDevices { set; get; }
        new int BitmapVirtualCache32BppSize { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings6
        new bool RelativeMouseMode { set; get; }
        new string AuthenticationServiceClass { [return: MarshalAs(UnmanagedType.BStr)] get; [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PCB { [return: MarshalAs(UnmanagedType.BStr)] get; [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int HotKeyFocusReleaseLeft { set; get; }
        new int HotKeyFocusReleaseRight { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new uint AuthenticationType { get; }
        new bool ConnectToAdministerServer { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings7
        bool AudioCaptureRedirectionMode { set; get; }
        uint VideoPlaybackMode { set; get; }
        bool EnableSuperPan { set; get; }
        uint SuperPanAccelerationFactor { set; get; }
        bool NegotiateSecurityLayer { set; get; }
        uint AudioQualityMode { set; get; }
        bool RedirectDirectX { set; get; }
        uint NetworkConnectionType { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("3D5B21AC-748D-41DE-8F30-E15169586BD4")]
    public interface IMsRdpClientTransportSettings3 : IMsRdpClientTransportSettings2
    {
        #region IMsRdpClientTransportSettings
        new string GatewayHostname { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new uint GatewayUsageMethod { set; get; }
        new uint GatewayProfileUsageMethod { set; get; }
        new uint GatewayCredsSource { set; get; }
        new uint GatewayUserSelectedCredsSource { set; get; }
        new int GatewayIsSupported { get; }
        new uint GatewayDefaultUsageMethod { get; }
        #endregion
        #region IMsRdpClientTransportSettings2
        new uint GatewayCredSharing { set; get; }
        new uint GatewayPreAuthRequirement { set; get; }
        new string GatewayPreAuthServerAddr { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string GatewaySupportUrl { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string GatewayEncryptedOtpCookie { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new uint GatewayEncryptedOtpCookieSize { set; get; }
        new string GatewayUsername { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string GatewayDomain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string GatewayPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        #endregion
        #region IMsRdpClientTransportSettings3
        uint GatewayCredSourceCookie { set; get; }
        string GatewayAuthCookieServerAddr { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        string GatewayEncryptedAuthCookie { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        uint GatewayEncryptedAuthCookieSize { set; get; }
        string GatewayAuthLoginPage { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
    }
    [ComImport]
    [Guid("25F2CE20-8B1D-4971-A7CD-549DAE201FC0")]
    public interface IMsRdpClientSecuredSettings2 : IMsRdpClientSecuredSettings
    {
        #region IMsTscSecuredSettings
        new string StartProgram { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string WorkDir { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int FullScreen { set; get; }
        #endregion
        #region IMsRdpClientSecuredSettings
        new int KeyboardHookMode { set; get; }
        new int AudioRedirectionMode { set; get; }
        #endregion
        #region IMsRdpClientSecuredSettings2
        string PCB { [return: MarshalAs(UnmanagedType.BStr)] get; [param: MarshalAs(UnmanagedType.BStr)] set; }
        #endregion
    }
    [ComImport]
    [Guid("92C38A7D-241A-418C-9936-099872C9AF20")]
    public interface ITSRemoteProgram2 : ITSRemoteProgram
    {
        #region ITSRemoteProgram
        new bool RemoteProgramMode { set; get; }
        new void ServerStartProgram([MarshalAs(UnmanagedType.BStr)] string bstrExecutablePath, [MarshalAs(UnmanagedType.BStr)] string bstrFilePath, [MarshalAs(UnmanagedType.BStr)] string bstrWorkingDirectory, bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.BStr)] string bstrArguments, bool vbExpandEnvVarInArgumentsOnServer);
        #endregion
        #region ITSRemoteProgram2
        string RemoteApplicationName { [param: MarshalAs(UnmanagedType.BStr)] set; }
        string RemoteApplicationProgram { [param: MarshalAs(UnmanagedType.BStr)] set; }
        string RemoteApplicationArgs { [param: MarshalAs(UnmanagedType.BStr)] set; }
        #endregion
    }
    [ComImport]
    [Guid("4F6996D5-D7B1-412C-B0FF-063718566907")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable5 : IMsRdpClientNonScriptable4
    {
        #region IMsTscNonScriptable
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PortablePassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string PortableSalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinaryPassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinarySalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        new bool ShowRedirectionWarningDialog { set; get; }
        new bool PromptForCredentials { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new bool RedirectDynamicDrives { set; get; }
        new bool RedirectDynamicDevices { set; get; }
        new IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new bool WarnAboutSendingCredentials { set; get; }
        new bool WarnAboutClipboardRedirection { set; get; }
        new string ConnectionBarText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClientNonScriptable4
        new RedirectionWarningType RedirectionWarningType { set; get; }
        new bool MarkRdpSettingsSecure { set; get; }
        new void set_PublisherCertificateChain([In][MarshalAs(UnmanagedType.Struct)] ref object pVarCert);
        new object PublisherCertificateChain { [return: MarshalAs(UnmanagedType.Struct)] get; }
        new bool WarnAboutPrinterRedirection { set; get; }
        new bool AllowCredentialSaving { set; get; }
        new bool PromptForCredsOnClient { set; get; }
        new bool LaunchedViaClientShellInterface { set; get; }
        new bool TrustedZoneSite { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable5
        bool UseMultimon { set; get; }
        uint RemoteMonitorCount { get; }
        void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);
        bool RemoteMonitorLayoutMatchesLocal { get; }
        bool DisableConnectionBar { set; }
        bool DisableRemoteAppCapsCheck { set; get; }
        bool WarnAboutDirectXRedirection { set; get; }
        bool AllowPromptingForCredentials { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("FDD029F9-9574-4DEF-8529-64B521CCCAA4")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpPreferredRedirectionInfo
    {
        #region IMsRdpPreferredRedirectionInfo
        bool UseRedirectionServerName { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("302D8188-0052-4807-806A-362B628F9AC5")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpExtendedSettings
    {
        #region IMsRdpExtendedSettings
        void set_Property([MarshalAs(UnmanagedType.BStr)] string bstrPropertyName, [In][MarshalAs(UnmanagedType.Struct)] ref object pValue);
        [return: MarshalAs(UnmanagedType.Struct)] object get_Property([MarshalAs(UnmanagedType.BStr)] string bstrPropertyName);
        #endregion
    }
    [ComImport]
    [Guid("4247E044-9271-43A9-BC49-E2AD9E855D62")]
    public interface IMsRdpClient8 : IMsRdpClient7
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new string ConnectedStatusText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] new string GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        new IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient7
        new IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings3 TransportSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] new string GetStatusText(uint statusCode);
        new IMsRdpClientSecuredSettings2 SecuredSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ITSRemoteProgram2 RemoteProgram2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient8
        void SendRemoteAction(RemoteSessionActionType actionType);
        IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight);
        #endregion
    }
    public enum RemoteSessionActionType
    {
        #region RemoteSessionActionType
        RemoteSessionActionCharms = 0,
        RemoteSessionActionAppbar = 1,
        RemoteSessionActionSnap = 2,
        RemoteSessionActionStartScreen = 3,
        RemoteSessionActionAppSwitch = 4,
        RemoteSessionActionActionCenter = 5,
        #endregion
    }
    [ComImport]
    [Guid("89ACB528-2557-4D16-8625-226A30E97E9A")]
    public interface IMsRdpClientAdvancedSettings8 : IMsRdpClientAdvancedSettings7
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new string KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PluginDlls { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string IconFile { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new string PersistCacheDirectory { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new string RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new string LoadBalanceInfo { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In][MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        new uint AuthenticationLevel { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings5
        new bool RedirectClipboard { set; get; }
        new uint AudioRedirectionMode { set; get; }
        new bool ConnectionBarShowPinButton { set; get; }
        new bool PublicMode { set; get; }
        new bool RedirectDevices { set; get; }
        new bool RedirectPOSDevices { set; get; }
        new int BitmapVirtualCache32BppSize { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings6
        new bool RelativeMouseMode { set; get; }
        new string AuthenticationServiceClass { [return: MarshalAs(UnmanagedType.BStr)] get; [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PCB { [return: MarshalAs(UnmanagedType.BStr)] get; [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int HotKeyFocusReleaseLeft { set; get; }
        new int HotKeyFocusReleaseRight { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new uint AuthenticationType { get; }
        new bool ConnectToAdministerServer { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings7
        new bool AudioCaptureRedirectionMode { set; get; }
        new uint VideoPlaybackMode { set; get; }
        new bool EnableSuperPan { set; get; }
        new uint SuperPanAccelerationFactor { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new uint AudioQualityMode { set; get; }
        new bool RedirectDirectX { set; get; }
        new uint NetworkConnectionType { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings8
        bool BandwidthDetection { set; get; }
        ClientSpec ClientProtocolSpec { set; get; }
        #endregion
    }
    public enum ControlReconnectStatus
    {
        #region ControlReconnectStatus
        controlReconnectStarted = 0,
        controlReconnectBlocked = 1,
        #endregion
    }
    [ComImport]
    [Guid("28904001-04B6-436C-A55B-0AF1A0883DC9")]
    public interface IMsRdpClient9 : IMsRdpClient8
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new string ConnectedStatusText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] new string GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        new IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient7
        new IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings3 TransportSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] new string GetStatusText(uint statusCode);
        new IMsRdpClientSecuredSettings2 SecuredSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ITSRemoteProgram2 RemoteProgram2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient8
        new void SendRemoteAction(RemoteSessionActionType actionType);
        new IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight);
        #endregion
        #region IMsRdpClient9
        IMsRdpClientTransportSettings4 TransportSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        void SyncSessionDisplaySettings();
        void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor);
        void attachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        void detachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        #endregion
    }
    [ComImport]
    [Guid("011C3236-4D81-4515-9143-067AB630D299")]
    public interface IMsRdpClientTransportSettings4 : IMsRdpClientTransportSettings3
    {
        #region IMsRdpClientTransportSettings
        new string GatewayHostname { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new uint GatewayUsageMethod { set; get; }
        new uint GatewayProfileUsageMethod { set; get; }
        new uint GatewayCredsSource { set; get; }
        new uint GatewayUserSelectedCredsSource { set; get; }
        new int GatewayIsSupported { get; }
        new uint GatewayDefaultUsageMethod { get; }
        #endregion
        #region IMsRdpClientTransportSettings2
        new uint GatewayCredSharing { set; get; }
        new uint GatewayPreAuthRequirement { set; get; }
        new string GatewayPreAuthServerAddr { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string GatewaySupportUrl { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string GatewayEncryptedOtpCookie { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new uint GatewayEncryptedOtpCookieSize { set; get; }
        new string GatewayUsername { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string GatewayDomain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string GatewayPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        #endregion
        #region IMsRdpClientTransportSettings3
        new uint GatewayCredSourceCookie { set; get; }
        new string GatewayAuthCookieServerAddr { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string GatewayEncryptedAuthCookie { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new uint GatewayEncryptedAuthCookieSize { set; get; }
        new string GatewayAuthLoginPage { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClientTransportSettings4
        uint GatewayBrokeringType { set; }
        #endregion
    }
    [ComImport]
    [Guid("7ED92C39-EB38-4927-A70A-708AC5A59321")]
    public interface IMsRdpClient10 : IMsRdpClient9
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new string Server { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string Domain { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string UserName { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string DisconnectedText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string ConnectingText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new string FullScreenTitle { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new int CipherStrength { get; }
        new string Version { [return: MarshalAs(UnmanagedType.BStr)] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.BStr)] string newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.BStr)] string chanName, [MarshalAs(UnmanagedType.BStr)] string ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.BStr)] string chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new string ConnectedStatusText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] new string GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        new IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient7
        new IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings3 TransportSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.BStr)] new string GetStatusText(uint statusCode);
        new IMsRdpClientSecuredSettings2 SecuredSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ITSRemoteProgram2 RemoteProgram2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient8
        new void SendRemoteAction(RemoteSessionActionType actionType);
        new IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight);
        #endregion
        #region IMsRdpClient9
        new IMsRdpClientTransportSettings4 TransportSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void SyncSessionDisplaySettings();
        new void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor);
        new void attachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        new void detachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        #endregion
        #region IMsRdpClient10
        ITSRemoteProgram3 RemoteProgram3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("4B84EA77-ACEA-418C-881A-4A8C28AB1510")]
    public interface ITSRemoteProgram3 : ITSRemoteProgram2
    {
        #region ITSRemoteProgram
        new bool RemoteProgramMode { set; get; }
        new void ServerStartProgram([MarshalAs(UnmanagedType.BStr)] string bstrExecutablePath, [MarshalAs(UnmanagedType.BStr)] string bstrFilePath, [MarshalAs(UnmanagedType.BStr)] string bstrWorkingDirectory, bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.BStr)] string bstrArguments, bool vbExpandEnvVarInArgumentsOnServer);
        #endregion
        #region ITSRemoteProgram2
        new string RemoteApplicationName { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string RemoteApplicationProgram { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string RemoteApplicationArgs { [param: MarshalAs(UnmanagedType.BStr)] set; }
        #endregion
        #region ITSRemoteProgram3
        void ServerStartApp([MarshalAs(UnmanagedType.BStr)] string bstrAppUserModelId, [MarshalAs(UnmanagedType.BStr)] string bstrArguments, bool vbExpandEnvVarInArgumentsOnServer);
        #endregion
    }
    [ComImport]
    [Guid("05293249-B28B-4BD8-BE64-1B2F496B910E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable6 : IMsRdpClientNonScriptable5
    {
        #region IMsTscNonScriptable
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PortablePassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string PortableSalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinaryPassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinarySalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        new bool ShowRedirectionWarningDialog { set; get; }
        new bool PromptForCredentials { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new bool RedirectDynamicDrives { set; get; }
        new bool RedirectDynamicDevices { set; get; }
        new IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new bool WarnAboutSendingCredentials { set; get; }
        new bool WarnAboutClipboardRedirection { set; get; }
        new string ConnectionBarText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClientNonScriptable4
        new RedirectionWarningType RedirectionWarningType { set; get; }
        new bool MarkRdpSettingsSecure { set; get; }
        new void set_PublisherCertificateChain([In][MarshalAs(UnmanagedType.Struct)] ref object pVarCert);
        new object PublisherCertificateChain { [return: MarshalAs(UnmanagedType.Struct)] get; }
        new bool WarnAboutPrinterRedirection { set; get; }
        new bool AllowCredentialSaving { set; get; }
        new bool PromptForCredsOnClient { set; get; }
        new bool LaunchedViaClientShellInterface { set; get; }
        new bool TrustedZoneSite { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable5
        new bool UseMultimon { set; get; }
        new uint RemoteMonitorCount { get; }
        new void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);
        new bool RemoteMonitorLayoutMatchesLocal { get; }
        new bool DisableConnectionBar { set; }
        new bool DisableRemoteAppCapsCheck { set; get; }
        new bool WarnAboutDirectXRedirection { set; get; }
        new bool AllowPromptingForCredentials { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable6
        void SendLocation2D(double latitude, double longitude);
        void SendLocation3D(double latitude, double longitude, int altitude);
        #endregion
    }
    [ComImport]
    [Guid("71B4A60A-FE21-46D8-A39B-8E32BA0C5ECC")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable7 : IMsRdpClientNonScriptable6
    {
        #region IMsTscNonScriptable
        new string ClearTextPassword { [param: MarshalAs(UnmanagedType.BStr)] set; }
        new string PortablePassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string PortableSalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinaryPassword { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new string BinarySalt { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        new bool ShowRedirectionWarningDialog { set; get; }
        new bool PromptForCredentials { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new bool RedirectDynamicDrives { set; get; }
        new bool RedirectDynamicDevices { set; get; }
        new IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new bool WarnAboutSendingCredentials { set; get; }
        new bool WarnAboutClipboardRedirection { set; get; }
        new string ConnectionBarText { [param: MarshalAs(UnmanagedType.BStr)] set; [return: MarshalAs(UnmanagedType.BStr)] get; }
        #endregion
        #region IMsRdpClientNonScriptable4
        new RedirectionWarningType RedirectionWarningType { set; get; }
        new bool MarkRdpSettingsSecure { set; get; }
        new void set_PublisherCertificateChain([In][MarshalAs(UnmanagedType.Struct)] ref object pVarCert);
        new object PublisherCertificateChain { [return: MarshalAs(UnmanagedType.Struct)] get; }
        new bool WarnAboutPrinterRedirection { set; get; }
        new bool AllowCredentialSaving { set; get; }
        new bool PromptForCredsOnClient { set; get; }
        new bool LaunchedViaClientShellInterface { set; get; }
        new bool TrustedZoneSite { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable5
        new bool UseMultimon { set; get; }
        new uint RemoteMonitorCount { get; }
        new void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);
        new bool RemoteMonitorLayoutMatchesLocal { get; }
        new bool DisableConnectionBar { set; }
        new bool DisableRemoteAppCapsCheck { set; get; }
        new bool WarnAboutDirectXRedirection { set; get; }
        new bool AllowPromptingForCredentials { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable6
        new void SendLocation2D(double latitude, double longitude);
        new void SendLocation3D(double latitude, double longitude, int altitude);
        #endregion
        #region IMsRdpClientNonScriptable7
        IMsRdpCameraRedirConfigCollection CameraRedirConfigCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        void DisableDpiCursorScalingForProcess();
        IMsRdpClipboard Clipboard { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("AE45252B-AAAB-4504-B681-649D6073A37A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpCameraRedirConfigCollection
    {
        #region IMsRdpCameraRedirConfigCollection
        void Rescan();
        uint Count { get; }
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpCameraRedirConfig get_ByIndex(uint index);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpCameraRedirConfig get_BySymbolicLink([MarshalAs(UnmanagedType.BStr)] string SymbolicLink);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpCameraRedirConfig get_ByInstanceId([MarshalAs(UnmanagedType.BStr)] string InstanceId);
        void AddConfig([MarshalAs(UnmanagedType.BStr)] string SymbolicLink, bool fRedirected);
        bool RedirectByDefault { set; get; }
        bool EncodeVideo { set; get; }
        CameraRedirEncodingQuality EncodingQuality { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("2E769EE8-00C7-43DC-AFD9-235D75B72A40")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClipboard
    {
        #region IMsRdpClipboard
        bool CanSyncLocalClipboardToRemoteSession();
        void SyncLocalClipboardToRemoteSession();
        bool CanSyncRemoteClipboardToLocalSession();
        void SyncRemoteClipboardToLocalSession();
        #endregion
    }
    [ComImport]
    [Guid("57D25668-625A-4905-BE4E-304CAA13F89C")]
    public interface IRemoteDesktopClient
    {
        #region IRemoteDesktopClient
        void Connect();
        void Disconnect();
        void Reconnect(uint width, uint height);
        IRemoteDesktopClientSettings Settings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IRemoteDesktopClientActions Actions { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IRemoteDesktopClientTouchPointer TouchPointer { [return: MarshalAs(UnmanagedType.Interface)] get; }
        void DeleteSavedCredentials([MarshalAs(UnmanagedType.BStr)] string serverName);
        void UpdateSessionDisplaySettings(uint width, uint height);
        void attachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        void detachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        #endregion
    }
    [ComImport]
    [Guid("48A0F2A7-2713-431F-BBAC-6F4558E7D64D")]
    public interface IRemoteDesktopClientSettings
    {
        #region IRemoteDesktopClientSettings
        void ApplySettings([MarshalAs(UnmanagedType.BStr)] string RdpFileContents);
        [return: MarshalAs(UnmanagedType.BStr)] string RetrieveSettings();
        [return: MarshalAs(UnmanagedType.Struct)] object GetRdpProperty([MarshalAs(UnmanagedType.BStr)] string propertyName);
        void SetRdpProperty([MarshalAs(UnmanagedType.BStr)] string propertyName, [MarshalAs(UnmanagedType.Struct)] object Value);
        #endregion
    }
    [ComImport]
    [Guid("7D54BC4E-1028-45D4-8B0A-B9B6BFFBA176")]
    public interface IRemoteDesktopClientActions
    {
        #region IRemoteDesktopClientActions
        void SuspendScreenUpdates();
        void ResumeScreenUpdates();
        void ExecuteRemoteAction(RemoteActionType remoteAction);
        [return: MarshalAs(UnmanagedType.BStr)] string GetSnapshot(SnapshotEncodingType snapshotEncoding, SnapshotFormatType snapshotFormat, uint snapshotWidth, uint snapshotHeight);
        #endregion
    }
    [ComImport]
    [Guid("260EC22D-8CBC-44B5-9E88-2A37F6C93AE9")]
    public interface IRemoteDesktopClientTouchPointer
    {
        #region IRemoteDesktopClientTouchPointer
        bool Enabled { set; get; }
        bool EventsEnabled { set; get; }
        uint PointerSpeed { set; get; }
        #endregion
    }
    //[ComImport]
    //[Guid("079863B7-6D47-4105-8BFE-0CDCB360E67D")]
    //[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    //public interface IRemoteDesktopClientEvents
    //{
    //    #region IRemoteDesktopClientEvents
    //    [PreserveSig] void OnConnecting();
    //    [PreserveSig] void OnConnected();
    //    [PreserveSig] void OnLoginCompleted();
    //    [PreserveSig] void OnDisconnected(int disconnectReason, int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.BStr)] string disconnectErrorMessage);
    //    [PreserveSig] void OnStatusChanged(int statusCode, [MarshalAs(UnmanagedType.BStr)] string statusMessage);
    //    [PreserveSig] void OnAutoReconnecting(int disconnectReason, int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.BStr)] string disconnectErrorMessage, bool networkAvailable, int attemptCount, int maxAttemptCount);
    //    [PreserveSig] void OnAutoReconnected();
    //    [PreserveSig] void OnDialogDisplaying();
    //    [PreserveSig] void OnDialogDismissed();
    //    [PreserveSig] void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt);
    //    [PreserveSig] void OnAdminMessageReceived([MarshalAs(UnmanagedType.BStr)] string adminMessage);
    //    [PreserveSig] void OnKeyCombinationPressed(int keyCombination);
    //    [PreserveSig] void OnRemoteDesktopSizeChanged(int width, int height);
    //    [PreserveSig] void OnTouchPointerCursorMoved(int x, int y);
    //    #endregion
    //}
    public enum ClientSpec
    {
        #region ClientSpec
        FullMode = 0,
        ThinClientMode = 1,
        SmallCacheMode = 2,
        #endregion
    }
    public enum RemoteActionType
    {
        #region RemoteActionType
        RemoteActionCharms = 0,
        RemoteActionAppbar = 1,
        RemoteActionSnap = 2,
        RemoteActionStartScreen = 3,
        RemoteActionAppSwitch = 4,
        #endregion
    }
    public enum SnapshotEncodingType
    {
        #region SnapshotEncodingType
        SnapshotEncodingDataUri = 0,
        #endregion
    }
    public enum SnapshotFormatType
    {
        #region SnapshotFormatType
        SnapshotFormatPng = 0,
        SnapshotFormatJpeg = 1,
        SnapshotFormatBmp = 2,
        #endregion
    }
    [ComImport]
    [Guid("60C3B9C8-9E92-4F5E-A3E7-604A912093EA")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpDevice
    {
        #region IMsRdpDevice
        string DeviceInstanceId { [return: MarshalAs(UnmanagedType.BStr)] get; }
        string FriendlyName { [return: MarshalAs(UnmanagedType.BStr)] get; }
        string DeviceDescription { [return: MarshalAs(UnmanagedType.BStr)] get; }
        bool RedirectionState { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("D28B5458-F694-47A8-8E61-40356A767E46")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpDrive
    {
        #region IMsRdpDrive
        string Name { [return: MarshalAs(UnmanagedType.BStr)] get; }
        bool RedirectionState { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("09750604-D625-47C1-9FCD-F09F735705D7")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpCameraRedirConfig
    {
        #region IMsRdpCameraRedirConfig
        string FriendlyName { [return: MarshalAs(UnmanagedType.BStr)] get; }
        string SymbolicLink { [return: MarshalAs(UnmanagedType.BStr)] get; }
        string InstanceId { [return: MarshalAs(UnmanagedType.BStr)] get; }
        string ParentInstanceId { [return: MarshalAs(UnmanagedType.BStr)] get; }
        bool Redirected { set; get; }
        bool DeviceExists { get; }
        #endregion
    }
    public enum CameraRedirEncodingQuality
    {
        #region CameraRedirEncodingQuality
        encodingQualityLow = 0,
        encodingQualityMedium = 1,
        encodingQualityHigh = 2,
        #endregion
    }
#else
    [ComImport]
    [Guid("327BB5CD-834E-4400-AEF2-B30E15E5D682")]
    public interface IMsTscAx_Redist
    {
        #region IMsTscAx_Redist
        #endregion
    }
    [ComImport]
    [Guid("8C11EFAE-92C3-11D1-BC1E-00C04FA31489")]
    public interface IMsTscAx : IMsTscAx_Redist
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        short Connected { get; }
        int DesktopWidth { set; get; }
        int DesktopHeight { set; get; }
        int StartConnected { set; get; }
        int HorizontalScrollBarVisible { get; }
        int VerticalScrollBarVisible { get; }
        BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        int CipherStrength { get; }
        BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        int SecuredSettingsEnabled { get; }
        IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        void Connect();
        void Disconnect();
        void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
    }
    [ComImport]
    [Guid("C9D65442-A0F9-45B2-8F73-D61D2DB8CBB6")]
    public interface IMsTscSecuredSettings
    {
        #region IMsTscSecuredSettings
        BinaryString StartProgram { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString WorkDir { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        int FullScreen { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("809945CC-4B3B-4A92-A6B0-DBF9B5F2EF2D")]
    public interface IMsTscAdvancedSettings
    {
        #region IMsTscAdvancedSettings
        int Compress { set; get; }
        int BitmapPeristence { set; get; }
        int allowBackgroundInput { set; get; }
        BinaryString KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        BinaryString PluginDlls { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        BinaryString IconFile { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        int IconIndex { set; }
        int ContainerHandledFullScreen { set; get; }
        int DisableRdpdr { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("209D0EB9-6254-47B1-9033-A98DAE55BB27")]
    public interface IMsTscDebug
    {
        #region IMsTscDebug
        int HatchBitmapPDU { set; get; }
        int HatchSSBOrder { set; get; }
        int HatchMembltOrder { set; get; }
        int HatchIndexPDU { set; get; }
        int LabelMemblt { set; get; }
        int BitmapCacheMonitor { set; get; }
        int MallocFailuresPercent { set; get; }
        int MallocHugeFailuresPercent { set; get; }
        int NetThroughput { set; get; }
        BinaryString CLXCmdLine { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString CLXDll { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        int RemoteProgramsHatchVisibleRegion { set; get; }
        int RemoteProgramsHatchVisibleNoDataRegion { set; get; }
        int RemoteProgramsHatchNonVisibleRegion { set; get; }
        int RemoteProgramsHatchWindow { set; get; }
        int RemoteProgramsStayConnectOnBadCaps { set; get; }
        uint ControlType { get; }
        bool DecodeGfx { set; }
        #endregion
    }
    //[ComImport]
    //[Guid("336D5562-EFA8-482E-8CB3-C5C0FC7A7DB6")]
    //[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    //public interface IMsTscAxEvents
    //{
    //    #region IMsTscAxEvents
    //    [PreserveSig] void OnConnecting();
    //    [PreserveSig] void OnConnected();
    //    [PreserveSig] void OnLoginComplete();
    //    [PreserveSig] void OnDisconnected(int discReason);
    //    [PreserveSig] void OnEnterFullScreenMode();
    //    [PreserveSig] void OnLeaveFullScreenMode();
    //    [PreserveSig] void OnChannelReceivedData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString data);
    //    [PreserveSig] void OnRequestGoFullScreen();
    //    [PreserveSig] void OnRequestLeaveFullScreen();
    //    [PreserveSig] void OnFatalError(int errorCode);
    //    [PreserveSig] void OnWarning(int warningCode);
    //    [PreserveSig] void OnRemoteDesktopSizeChange(int width, int height);
    //    [PreserveSig] void OnIdleTimeoutNotification();
    //    [PreserveSig] void OnRequestContainerMinimize();
    //    [PreserveSig] void OnConfirmClose(out bool pfAllowClose);
    //    [PreserveSig] void OnReceivedTSPublicKey([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString publicKey, out bool pfContinueLogon);
    //    [PreserveSig] void OnAutoReconnecting(int disconnectReason, int attemptCount, out AutoReconnectContinueState pArcContinueStatus);
    //    [PreserveSig] void OnAuthenticationWarningDisplayed();
    //    [PreserveSig] void OnAuthenticationWarningDismissed();
    //    [PreserveSig] void OnRemoteProgramResult([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable);
    //    [PreserveSig] void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation);
    //    [PreserveSig] void OnRemoteWindowDisplayed(bool vbDisplayed, nint hwnd, RemoteWindowDisplayedAttribute windowAttribute);
    //    [PreserveSig] void OnLogonError(int lError);
    //    [PreserveSig] void OnFocusReleased(int iDirection);
    //    [PreserveSig] void OnUserNameAcquired([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrUserName);
    //    [PreserveSig] void OnMouseInputModeChanged(bool fMouseModeRelative);
    //    [PreserveSig] void OnServiceMessageReceived([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString serviceMessage);
    //    [PreserveSig] void OnConnectionBarPullDown();
    //    [PreserveSig] void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt);
    //    [PreserveSig] void OnDevicesButtonPressed();
    //    [PreserveSig] void OnAutoReconnected();
    //    [PreserveSig] void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount);
    //    #endregion
    //}
    public enum AutoReconnectContinueState
    {
        #region AutoReconnectContinueState
        autoReconnectContinueAutomatic = 0,
        autoReconnectContinueStop = 1,
        autoReconnectContinueManual = 2,
        #endregion
    }
    public enum RemoteProgramResult
    {
        #region RemoteProgramResult
        remoteAppResultOk = 0,
        remoteAppResultLocked = 1,
        remoteAppResultProtocolError = 2,
        remoteAppResultNotInWhitelist = 3,
        remoteAppResultNetworkPathDenied = 4,
        remoteAppResultFileNotFound = 5,
        remoteAppResultFailure = 6,
        remoteAppResultHookNotLoaded = 7,
        #endregion
    }
    public enum RemoteWindowDisplayedAttribute
    {
        #region RemoteWindowDisplayedAttribute
        remoteAppWindowNone = 0,
        remoteAppWindowDisplayed = 1,
        remoteAppShellIconDisplayed = 2,
        #endregion
    }
    [ComImport]
    [Guid("92B4A539-7115-4B7C-A5A9-E5D9EFC2780A")]
    public interface IMsRdpClient : IMsTscAx
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        int ColorDepth { set; get; }
        IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        bool FullScreen { set; get; }
        void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        ControlCloseStatus RequestClose();
        #endregion
    }
    [ComImport]
    [Guid("3C65B4AB-12B3-465B-ACD4-B8DAD3BFF9E2")]
    public interface IMsRdpClientAdvancedSettings : IMsTscAdvancedSettings
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new BinaryString KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PluginDlls { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString IconFile { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        int SmoothScroll { set; get; }
        int AcceleratorPassthrough { set; get; }
        int ShadowBitmap { set; get; }
        int TransportType { set; get; }
        int SasSequence { set; get; }
        int EncryptionEnabled { set; get; }
        int DedicatedTerminal { set; get; }
        int RDPPort { set; get; }
        int EnableMouse { set; get; }
        int DisableCtrlAltDel { set; get; }
        int EnableWindowsKey { set; get; }
        int DoubleClickDetect { set; get; }
        int MaximizeShell { set; get; }
        int HotKeyFullScreen { set; get; }
        int HotKeyCtrlEsc { set; get; }
        int HotKeyAltEsc { set; get; }
        int HotKeyAltTab { set; get; }
        int HotKeyAltShiftTab { set; get; }
        int HotKeyAltSpace { set; get; }
        int HotKeyCtrlAltDel { set; get; }
        int orderDrawThreshold { set; get; }
        int BitmapCacheSize { set; get; }
        int BitmapVirtualCacheSize { set; get; }
        int ScaleBitmapCachesByBPP { set; get; }
        int NumBitmapCaches { set; get; }
        int CachePersistenceActive { set; get; }
        BinaryString PersistCacheDirectory { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        int brushSupportLevel { set; get; }
        int minInputSendInterval { set; get; }
        int InputEventsAtOnce { set; get; }
        int maxEventCount { set; get; }
        int keepAliveInterval { set; get; }
        int shutdownTimeout { set; get; }
        int overallConnectionTimeout { set; get; }
        int singleConnectionTimeout { set; get; }
        int KeyboardType { set; get; }
        int KeyboardSubType { set; get; }
        int KeyboardFunctionKey { set; get; }
        int WinceFixedPalette { set; get; }
        bool ConnectToServerConsole { set; get; }
        int BitmapPersistence { set; get; }
        int MinutesToIdleTimeout { set; get; }
        bool SmartSizing { set; get; }
        BinaryString RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        bool DisplayConnectionBar { set; get; }
        bool PinConnectionBar { set; get; }
        bool GrabFocusOnConnect { set; get; }
        BinaryString LoadBalanceInfo { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        bool RedirectDrives { set; get; }
        bool RedirectPrinters { set; get; }
        bool RedirectPorts { set; get; }
        bool RedirectSmartCards { set; get; }
        int BitmapVirtualCache16BppSize { set; get; }
        int BitmapVirtualCache24BppSize { set; get; }
        int PerformanceFlags { set; get; }
        void set_ConnectWithEndpoint([In] [MarshalAs(UnmanagedType.Struct)] ref object A_1);
        bool NotifyTSPublicKey { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("605BEFCF-39C1-45CC-A811-068FB7BE346D")]
    public interface IMsRdpClientSecuredSettings : IMsTscSecuredSettings
    {
        #region IMsTscSecuredSettings
        new BinaryString StartProgram { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString WorkDir { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int FullScreen { set; get; }
        #endregion
        #region IMsRdpClientSecuredSettings
        int KeyboardHookMode { set; get; }
        int AudioRedirectionMode { set; get; }
        #endregion
    }
    public enum ExtendedDisconnectReasonCode
    {
        #region ExtendedDisconnectReasonCode
        exDiscReasonNoInfo = 0,
        exDiscReasonAPIInitiatedDisconnect = 1,
        exDiscReasonAPIInitiatedLogoff = 2,
        exDiscReasonServerIdleTimeout = 3,
        exDiscReasonServerLogonTimeout = 4,
        exDiscReasonReplacedByOtherConnection = 5,
        exDiscReasonOutOfMemory = 6,
        exDiscReasonServerDeniedConnection = 7,
        exDiscReasonServerDeniedConnectionFips = 8,
        exDiscReasonServerInsufficientPrivileges = 9,
        exDiscReasonServerFreshCredsRequired = 10,
        exDiscReasonRpcInitiatedDisconnectByUser = 11,
        exDiscReasonLogoffByUser = 12,
        exDiscReasonShutdown = 25,
        exDiscReasonReboot = 26,
        exDiscReasonLicenseInternal = 256,
        exDiscReasonLicenseNoLicenseServer = 257,
        exDiscReasonLicenseNoLicense = 258,
        exDiscReasonLicenseErrClientMsg = 259,
        exDiscReasonLicenseHwidDoesntMatchLicense = 260,
        exDiscReasonLicenseErrClientLicense = 261,
        exDiscReasonLicenseCantFinishProtocol = 262,
        exDiscReasonLicenseClientEndedProtocol = 263,
        exDiscReasonLicenseErrClientEncryption = 264,
        exDiscReasonLicenseCantUpgradeLicense = 265,
        exDiscReasonLicenseNoRemoteConnections = 266,
        exDiscReasonLicenseCreatingLicStoreAccDenied = 267,
        exDiscReasonRdpEncInvalidCredentials = 768,
        exDiscReasonProtocolRangeStart = 4096,
        exDiscReasonProtocolRangeEnd = 32767,
        #endregion
    }
    public enum ControlCloseStatus
    {
        #region ControlCloseStatus
        controlCloseCanProceed = 0,
        controlCloseWaitForEvents = 1,
        #endregion
    }
    [ComImport]
    [Guid("C1E6743A-41C1-4A74-832A-0DD06C1C7A0E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsTscNonScriptable
    {
        #region IMsTscNonScriptable
        BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        BinaryString PortablePassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString PortableSalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString BinaryPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString BinarySalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        void ResetPassword();
        #endregion
    }
    [ComImport]
    [Guid("2F079C4C-87B2-4AFD-97AB-20CDB43038AE")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable : IMsTscNonScriptable
    {
        #region IMsTscNonScriptable
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PortablePassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString PortableSalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinaryPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinarySalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
    }
    [ComImport]
    [Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
    public interface IMsRdpClient2 : IMsRdpClient
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        BinaryString ConnectedStatusText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
    }
    [ComImport]
    [Guid("9AC42117-2B76-4320-AA44-0E616AB8437B")]
    public interface IMsRdpClientAdvancedSettings2 : IMsRdpClientAdvancedSettings
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new BinaryString KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PluginDlls { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString IconFile { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new BinaryString PersistCacheDirectory { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new BinaryString RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new BinaryString LoadBalanceInfo { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In] [MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        bool CanAutoReconnect { get; }
        bool EnableAutoReconnect { set; get; }
        int MaxReconnectAttempts { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("91B7CBC5-A72E-4FA0-9300-D647D7E897FF")]
    public interface IMsRdpClient3 : IMsRdpClient2
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new BinaryString ConnectedStatusText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClient3
        IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("19CD856B-C542-4C53-ACEE-F127E3BE1A59")]
    public interface IMsRdpClientAdvancedSettings3 : IMsRdpClientAdvancedSettings2
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new BinaryString KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PluginDlls { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString IconFile { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new BinaryString PersistCacheDirectory { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new BinaryString RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new BinaryString LoadBalanceInfo { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In] [MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        bool ConnectionBarShowMinimizeButton { set; get; }
        bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("095E0738-D97D-488B-B9F6-DD0E8D66C0DE")]
    public interface IMsRdpClient4 : IMsRdpClient3
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new BinaryString ConnectedStatusText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("FBA7F64E-7345-4405-AE50-FA4A763DC0DE")]
    public interface IMsRdpClientAdvancedSettings4 : IMsRdpClientAdvancedSettings3
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new BinaryString KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PluginDlls { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString IconFile { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new BinaryString PersistCacheDirectory { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new BinaryString RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new BinaryString LoadBalanceInfo { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In] [MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        uint AuthenticationLevel { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("17A5E535-4072-4FA4-AF32-C8D0D47345E9")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable2 : IMsRdpClientNonScriptable
    {
        #region IMsTscNonScriptable
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PortablePassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString PortableSalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinaryPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinarySalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        nint UIParentWindowHandle { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("4EB5335B-6429-477D-B922-E06A28ECD8BF")]
    public interface IMsRdpClient5 : IMsRdpClient4
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new BinaryString ConnectedStatusText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("720298C0-A099-46F5-9F82-96921BAE4701")]
    public interface IMsRdpClientTransportSettings
    {
        #region IMsRdpClientTransportSettings
        BinaryString GatewayHostname { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        uint GatewayUsageMethod { set; get; }
        uint GatewayProfileUsageMethod { set; get; }
        uint GatewayCredsSource { set; get; }
        uint GatewayUserSelectedCredsSource { set; get; }
        int GatewayIsSupported { get; }
        uint GatewayDefaultUsageMethod { get; }
        #endregion
    }
    [ComImport]
    [Guid("FBA7F64E-6783-4405-DA45-FA4A763DABD0")]
    public interface IMsRdpClientAdvancedSettings5 : IMsRdpClientAdvancedSettings4
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new BinaryString KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PluginDlls { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString IconFile { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new BinaryString PersistCacheDirectory { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new BinaryString RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new BinaryString LoadBalanceInfo { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In] [MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        new uint AuthenticationLevel { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings5
        bool RedirectClipboard { set; get; }
        uint AudioRedirectionMode { set; get; }
        bool ConnectionBarShowPinButton { set; get; }
        bool PublicMode { set; get; }
        bool RedirectDevices { set; get; }
        bool RedirectPOSDevices { set; get; }
        int BitmapVirtualCache32BppSize { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("FDD029F9-467A-4C49-8529-64B521DBD1B4")]
    public interface ITSRemoteProgram
    {
        #region ITSRemoteProgram
        bool RemoteProgramMode { set; get; }
        void ServerStartProgram([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrExecutablePath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrFilePath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrWorkingDirectory, bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrArguments, bool vbExpandEnvVarInArgumentsOnServer);
        #endregion
    }
    [ComImport]
    [Guid("D012AE6D-C19A-4BFE-B367-201F8911F134")]
    public interface IMsRdpClientShell
    {
        #region IMsRdpClientShell
        void Launch();
        BinaryString RdpFileContents { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        void SetRdpProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString szProperty, [MarshalAs(UnmanagedType.Struct)] object Value);
        [return: MarshalAs(UnmanagedType.Struct)] object GetRdpProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString szProperty);
        bool IsRemoteProgramClientInstalled { get; }
        bool PublicMode { set; get; }
        void ShowTrustedSitesManagementDialog();
        #endregion
    }
    [ComImport]
    [Guid("B3378D90-0728-45C7-8ED7-B6159FB92219")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable3 : IMsRdpClientNonScriptable2
    {
        #region IMsTscNonScriptable
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PortablePassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString PortableSalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinaryPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinarySalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        bool ShowRedirectionWarningDialog { set; get; }
        bool PromptForCredentials { set; get; }
        bool NegotiateSecurityLayer { set; get; }
        bool EnableCredSspSupport { set; get; }
        bool RedirectDynamicDrives { set; get; }
        bool RedirectDynamicDevices { set; get; }
        IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        bool WarnAboutSendingCredentials { set; get; }
        bool WarnAboutClipboardRedirection { set; get; }
        BinaryString ConnectionBarText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
    }
    [ComImport]
    [Guid("56540617-D281-488C-8738-6A8FDF64A118")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpDeviceCollection
    {
        #region IMsRdpDeviceCollection
        void RescanDevices(bool vboolDynRedir);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpDevice get_DeviceByIndex(uint index);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpDevice get_DeviceById([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString devInstanceId);
        uint DeviceCount { get; }
        #endregion
    }
    [ComImport]
    [Guid("7FF17599-DA2C-4677-AD35-F60C04FE1585")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpDriveCollection
    {
        #region IMsRdpDriveCollection
        void RescanDrives(bool vboolDynRedir);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpDrive get_DriveByIndex(uint index);
        uint DriveCount { get; }
        #endregion
    }
    [ComImport]
    [Guid("D43B7D80-8517-4B6D-9EAC-96AD6800D7F2")]
    public interface IMsRdpClient6 : IMsRdpClient5
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new BinaryString ConnectedStatusText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] new BinaryString GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("222C4B5D-45D9-4DF0-A7C6-60CF9089D285")]
    public interface IMsRdpClientAdvancedSettings6 : IMsRdpClientAdvancedSettings5
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new BinaryString KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PluginDlls { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString IconFile { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new BinaryString PersistCacheDirectory { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new BinaryString RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new BinaryString LoadBalanceInfo { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In] [MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        new uint AuthenticationLevel { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings5
        new bool RedirectClipboard { set; get; }
        new uint AudioRedirectionMode { set; get; }
        new bool ConnectionBarShowPinButton { set; get; }
        new bool PublicMode { set; get; }
        new bool RedirectDevices { set; get; }
        new bool RedirectPOSDevices { set; get; }
        new int BitmapVirtualCache32BppSize { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings6
        bool RelativeMouseMode { set; get; }
        BinaryString AuthenticationServiceClass { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        BinaryString PCB { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        int HotKeyFocusReleaseLeft { set; get; }
        int HotKeyFocusReleaseRight { set; get; }
        bool EnableCredSspSupport { set; get; }
        uint AuthenticationType { get; }
        bool ConnectToAdministerServer { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("67341688-D606-4C73-A5D2-2E0489009319")]
    public interface IMsRdpClientTransportSettings2 : IMsRdpClientTransportSettings
    {
        #region IMsRdpClientTransportSettings
        new BinaryString GatewayHostname { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new uint GatewayUsageMethod { set; get; }
        new uint GatewayProfileUsageMethod { set; get; }
        new uint GatewayCredsSource { set; get; }
        new uint GatewayUserSelectedCredsSource { set; get; }
        new int GatewayIsSupported { get; }
        new uint GatewayDefaultUsageMethod { get; }
        #endregion
        #region IMsRdpClientTransportSettings2
        uint GatewayCredSharing { set; get; }
        uint GatewayPreAuthRequirement { set; get; }
        BinaryString GatewayPreAuthServerAddr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString GatewaySupportUrl { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString GatewayEncryptedOtpCookie { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        uint GatewayEncryptedOtpCookieSize { set; get; }
        BinaryString GatewayUsername { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString GatewayDomain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString GatewayPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        #endregion
    }
    [ComImport]
    [Guid("F50FA8AA-1C7D-4F59-B15C-A90CACAE1FCB")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable4 : IMsRdpClientNonScriptable3
    {
        #region IMsTscNonScriptable
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PortablePassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString PortableSalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinaryPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinarySalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        new bool ShowRedirectionWarningDialog { set; get; }
        new bool PromptForCredentials { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new bool RedirectDynamicDrives { set; get; }
        new bool RedirectDynamicDevices { set; get; }
        new IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new bool WarnAboutSendingCredentials { set; get; }
        new bool WarnAboutClipboardRedirection { set; get; }
        new BinaryString ConnectionBarText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClientNonScriptable4
        RedirectionWarningType RedirectionWarningType { set; get; }
        bool MarkRdpSettingsSecure { set; get; }
        void set_PublisherCertificateChain([In] [MarshalAs(UnmanagedType.Struct)] ref object pVarCert);
        object PublisherCertificateChain { [return: MarshalAs(UnmanagedType.Struct)] get; }
        bool WarnAboutPrinterRedirection { set; get; }
        bool AllowCredentialSaving { set; get; }
        bool PromptForCredsOnClient { set; get; }
        bool LaunchedViaClientShellInterface { set; get; }
        bool TrustedZoneSite { set; get; }
        #endregion
    }
    public enum RedirectionWarningType
    {
        #region RedirectionWarningType
        RedirectionWarningTypeDefault = 0,
        RedirectionWarningTypeUnsigned = 1,
        RedirectionWarningTypeUnknown = 2,
        RedirectionWarningTypeUser = 3,
        RedirectionWarningTypeThirdPartySigned = 4,
        RedirectionWarningTypeTrusted = 5,
        RedirectionWarningTypeMax = 5,
        #endregion
    }
    [ComImport]
    [Guid("B2A5B5CE-3461-444A-91D4-ADD26D070638")]
    public interface IMsRdpClient7 : IMsRdpClient6
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new BinaryString ConnectedStatusText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] new BinaryString GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        new IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient7
        IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IMsRdpClientTransportSettings3 TransportSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString GetStatusText(uint statusCode);
        IMsRdpClientSecuredSettings2 SecuredSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        ITSRemoteProgram2 RemoteProgram2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("26036036-4010-4578-8091-0DB9A1EDF9C3")]
    public interface IMsRdpClientAdvancedSettings7 : IMsRdpClientAdvancedSettings6
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new BinaryString KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PluginDlls { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString IconFile { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new BinaryString PersistCacheDirectory { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new BinaryString RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new BinaryString LoadBalanceInfo { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In] [MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        new uint AuthenticationLevel { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings5
        new bool RedirectClipboard { set; get; }
        new uint AudioRedirectionMode { set; get; }
        new bool ConnectionBarShowPinButton { set; get; }
        new bool PublicMode { set; get; }
        new bool RedirectDevices { set; get; }
        new bool RedirectPOSDevices { set; get; }
        new int BitmapVirtualCache32BppSize { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings6
        new bool RelativeMouseMode { set; get; }
        new BinaryString AuthenticationServiceClass { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PCB { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int HotKeyFocusReleaseLeft { set; get; }
        new int HotKeyFocusReleaseRight { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new uint AuthenticationType { get; }
        new bool ConnectToAdministerServer { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings7
        bool AudioCaptureRedirectionMode { set; get; }
        uint VideoPlaybackMode { set; get; }
        bool EnableSuperPan { set; get; }
        uint SuperPanAccelerationFactor { set; get; }
        bool NegotiateSecurityLayer { set; get; }
        uint AudioQualityMode { set; get; }
        bool RedirectDirectX { set; get; }
        uint NetworkConnectionType { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("3D5B21AC-748D-41DE-8F30-E15169586BD4")]
    public interface IMsRdpClientTransportSettings3 : IMsRdpClientTransportSettings2
    {
        #region IMsRdpClientTransportSettings
        new BinaryString GatewayHostname { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new uint GatewayUsageMethod { set; get; }
        new uint GatewayProfileUsageMethod { set; get; }
        new uint GatewayCredsSource { set; get; }
        new uint GatewayUserSelectedCredsSource { set; get; }
        new int GatewayIsSupported { get; }
        new uint GatewayDefaultUsageMethod { get; }
        #endregion
        #region IMsRdpClientTransportSettings2
        new uint GatewayCredSharing { set; get; }
        new uint GatewayPreAuthRequirement { set; get; }
        new BinaryString GatewayPreAuthServerAddr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString GatewaySupportUrl { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString GatewayEncryptedOtpCookie { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new uint GatewayEncryptedOtpCookieSize { set; get; }
        new BinaryString GatewayUsername { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString GatewayDomain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString GatewayPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        #endregion
        #region IMsRdpClientTransportSettings3
        uint GatewayCredSourceCookie { set; get; }
        BinaryString GatewayAuthCookieServerAddr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString GatewayEncryptedAuthCookie { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        uint GatewayEncryptedAuthCookieSize { set; get; }
        BinaryString GatewayAuthLoginPage { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
    }
    [ComImport]
    [Guid("25F2CE20-8B1D-4971-A7CD-549DAE201FC0")]
    public interface IMsRdpClientSecuredSettings2 : IMsRdpClientSecuredSettings
    {
        #region IMsTscSecuredSettings
        new BinaryString StartProgram { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString WorkDir { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int FullScreen { set; get; }
        #endregion
        #region IMsRdpClientSecuredSettings
        new int KeyboardHookMode { set; get; }
        new int AudioRedirectionMode { set; get; }
        #endregion
        #region IMsRdpClientSecuredSettings2
        BinaryString PCB { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        #endregion
    }
    [ComImport]
    [Guid("92C38A7D-241A-418C-9936-099872C9AF20")]
    public interface ITSRemoteProgram2 : ITSRemoteProgram
    {
        #region ITSRemoteProgram
        new bool RemoteProgramMode { set; get; }
        new void ServerStartProgram([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrExecutablePath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrFilePath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrWorkingDirectory, bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrArguments, bool vbExpandEnvVarInArgumentsOnServer);
        #endregion
        #region ITSRemoteProgram2
        BinaryString RemoteApplicationName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        BinaryString RemoteApplicationProgram { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        BinaryString RemoteApplicationArgs { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        #endregion
    }
    [ComImport]
    [Guid("4F6996D5-D7B1-412C-B0FF-063718566907")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable5 : IMsRdpClientNonScriptable4
    {
        #region IMsTscNonScriptable
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PortablePassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString PortableSalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinaryPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinarySalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        new bool ShowRedirectionWarningDialog { set; get; }
        new bool PromptForCredentials { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new bool RedirectDynamicDrives { set; get; }
        new bool RedirectDynamicDevices { set; get; }
        new IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new bool WarnAboutSendingCredentials { set; get; }
        new bool WarnAboutClipboardRedirection { set; get; }
        new BinaryString ConnectionBarText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClientNonScriptable4
        new RedirectionWarningType RedirectionWarningType { set; get; }
        new bool MarkRdpSettingsSecure { set; get; }
        new void set_PublisherCertificateChain([In] [MarshalAs(UnmanagedType.Struct)] ref object pVarCert);
        new object PublisherCertificateChain { [return: MarshalAs(UnmanagedType.Struct)] get; }
        new bool WarnAboutPrinterRedirection { set; get; }
        new bool AllowCredentialSaving { set; get; }
        new bool PromptForCredsOnClient { set; get; }
        new bool LaunchedViaClientShellInterface { set; get; }
        new bool TrustedZoneSite { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable5
        bool UseMultimon { set; get; }
        uint RemoteMonitorCount { get; }
        void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);
        bool RemoteMonitorLayoutMatchesLocal { get; }
        bool DisableConnectionBar { set; }
        bool DisableRemoteAppCapsCheck { set; get; }
        bool WarnAboutDirectXRedirection { set; get; }
        bool AllowPromptingForCredentials { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("FDD029F9-9574-4DEF-8529-64B521CCCAA4")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpPreferredRedirectionInfo
    {
        #region IMsRdpPreferredRedirectionInfo
        bool UseRedirectionServerName { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("302D8188-0052-4807-806A-362B628F9AC5")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpExtendedSettings
    {
        #region IMsRdpExtendedSettings
        void set_Property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrPropertyName, [In] [MarshalAs(UnmanagedType.Struct)] ref object pValue);
        [return: MarshalAs(UnmanagedType.Struct)] object get_Property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrPropertyName);
        #endregion
    }
    [ComImport]
    [Guid("4247E044-9271-43A9-BC49-E2AD9E855D62")]
    public interface IMsRdpClient8 : IMsRdpClient7
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new BinaryString ConnectedStatusText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] new BinaryString GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        new IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient7
        new IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings3 TransportSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] new BinaryString GetStatusText(uint statusCode);
        new IMsRdpClientSecuredSettings2 SecuredSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ITSRemoteProgram2 RemoteProgram2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient8
        void SendRemoteAction(RemoteSessionActionType actionType);
        IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight);
        #endregion
    }
    public enum RemoteSessionActionType
    {
        #region RemoteSessionActionType
        RemoteSessionActionCharms = 0,
        RemoteSessionActionAppbar = 1,
        RemoteSessionActionSnap = 2,
        RemoteSessionActionStartScreen = 3,
        RemoteSessionActionAppSwitch = 4,
        RemoteSessionActionActionCenter = 5,
        #endregion
    }
    [ComImport]
    [Guid("89ACB528-2557-4D16-8625-226A30E97E9A")]
    public interface IMsRdpClientAdvancedSettings8 : IMsRdpClientAdvancedSettings7
    {
        #region IMsTscAdvancedSettings
        new int Compress { set; get; }
        new int BitmapPeristence { set; get; }
        new int allowBackgroundInput { set; get; }
        new BinaryString KeyBoardLayoutStr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PluginDlls { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString IconFile { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int IconIndex { set; }
        new int ContainerHandledFullScreen { set; get; }
        new int DisableRdpdr { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings
        new int SmoothScroll { set; get; }
        new int AcceleratorPassthrough { set; get; }
        new int ShadowBitmap { set; get; }
        new int TransportType { set; get; }
        new int SasSequence { set; get; }
        new int EncryptionEnabled { set; get; }
        new int DedicatedTerminal { set; get; }
        new int RDPPort { set; get; }
        new int EnableMouse { set; get; }
        new int DisableCtrlAltDel { set; get; }
        new int EnableWindowsKey { set; get; }
        new int DoubleClickDetect { set; get; }
        new int MaximizeShell { set; get; }
        new int HotKeyFullScreen { set; get; }
        new int HotKeyCtrlEsc { set; get; }
        new int HotKeyAltEsc { set; get; }
        new int HotKeyAltTab { set; get; }
        new int HotKeyAltShiftTab { set; get; }
        new int HotKeyAltSpace { set; get; }
        new int HotKeyCtrlAltDel { set; get; }
        new int orderDrawThreshold { set; get; }
        new int BitmapCacheSize { set; get; }
        new int BitmapVirtualCacheSize { set; get; }
        new int ScaleBitmapCachesByBPP { set; get; }
        new int NumBitmapCaches { set; get; }
        new int CachePersistenceActive { set; get; }
        new BinaryString PersistCacheDirectory { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int brushSupportLevel { set; get; }
        new int minInputSendInterval { set; get; }
        new int InputEventsAtOnce { set; get; }
        new int maxEventCount { set; get; }
        new int keepAliveInterval { set; get; }
        new int shutdownTimeout { set; get; }
        new int overallConnectionTimeout { set; get; }
        new int singleConnectionTimeout { set; get; }
        new int KeyboardType { set; get; }
        new int KeyboardSubType { set; get; }
        new int KeyboardFunctionKey { set; get; }
        new int WinceFixedPalette { set; get; }
        new bool ConnectToServerConsole { set; get; }
        new int BitmapPersistence { set; get; }
        new int MinutesToIdleTimeout { set; get; }
        new bool SmartSizing { set; get; }
        new BinaryString RdpdrLocalPrintingDocName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipCleanTempDirString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString RdpdrClipPasteInfoString { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new bool DisplayConnectionBar { set; get; }
        new bool PinConnectionBar { set; get; }
        new bool GrabFocusOnConnect { set; get; }
        new BinaryString LoadBalanceInfo { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new bool RedirectDrives { set; get; }
        new bool RedirectPrinters { set; get; }
        new bool RedirectPorts { set; get; }
        new bool RedirectSmartCards { set; get; }
        new int BitmapVirtualCache16BppSize { set; get; }
        new int BitmapVirtualCache24BppSize { set; get; }
        new int PerformanceFlags { set; get; }
        new void set_ConnectWithEndpoint([In] [MarshalAs(UnmanagedType.Struct)] ref object A_1);
        new bool NotifyTSPublicKey { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings2
        new bool CanAutoReconnect { get; }
        new bool EnableAutoReconnect { set; get; }
        new int MaxReconnectAttempts { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings3
        new bool ConnectionBarShowMinimizeButton { set; get; }
        new bool ConnectionBarShowRestoreButton { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings4
        new uint AuthenticationLevel { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings5
        new bool RedirectClipboard { set; get; }
        new uint AudioRedirectionMode { set; get; }
        new bool ConnectionBarShowPinButton { set; get; }
        new bool PublicMode { set; get; }
        new bool RedirectDevices { set; get; }
        new bool RedirectPOSDevices { set; get; }
        new int BitmapVirtualCache32BppSize { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings6
        new bool RelativeMouseMode { set; get; }
        new BinaryString AuthenticationServiceClass { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PCB { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int HotKeyFocusReleaseLeft { set; get; }
        new int HotKeyFocusReleaseRight { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new uint AuthenticationType { get; }
        new bool ConnectToAdministerServer { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings7
        new bool AudioCaptureRedirectionMode { set; get; }
        new uint VideoPlaybackMode { set; get; }
        new bool EnableSuperPan { set; get; }
        new uint SuperPanAccelerationFactor { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new uint AudioQualityMode { set; get; }
        new bool RedirectDirectX { set; get; }
        new uint NetworkConnectionType { set; get; }
        #endregion
        #region IMsRdpClientAdvancedSettings8
        bool BandwidthDetection { set; get; }
        ClientSpec ClientProtocolSpec { set; get; }
        #endregion
    }
    public enum ControlReconnectStatus
    {
        #region ControlReconnectStatus
        controlReconnectStarted = 0,
        controlReconnectBlocked = 1,
        #endregion
    }
    [ComImport]
    [Guid("28904001-04B6-436C-A55B-0AF1A0883DC9")]
    public interface IMsRdpClient9 : IMsRdpClient8
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new BinaryString ConnectedStatusText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] new BinaryString GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        new IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient7
        new IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings3 TransportSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] new BinaryString GetStatusText(uint statusCode);
        new IMsRdpClientSecuredSettings2 SecuredSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ITSRemoteProgram2 RemoteProgram2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient8
        new void SendRemoteAction(RemoteSessionActionType actionType);
        new IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight);
        #endregion
        #region IMsRdpClient9
        IMsRdpClientTransportSettings4 TransportSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        void SyncSessionDisplaySettings();
        void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor);
        void attachEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        void detachEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        #endregion
    }
    [ComImport]
    [Guid("011C3236-4D81-4515-9143-067AB630D299")]
    public interface IMsRdpClientTransportSettings4 : IMsRdpClientTransportSettings3
    {
        #region IMsRdpClientTransportSettings
        new BinaryString GatewayHostname { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new uint GatewayUsageMethod { set; get; }
        new uint GatewayProfileUsageMethod { set; get; }
        new uint GatewayCredsSource { set; get; }
        new uint GatewayUserSelectedCredsSource { set; get; }
        new int GatewayIsSupported { get; }
        new uint GatewayDefaultUsageMethod { get; }
        #endregion
        #region IMsRdpClientTransportSettings2
        new uint GatewayCredSharing { set; get; }
        new uint GatewayPreAuthRequirement { set; get; }
        new BinaryString GatewayPreAuthServerAddr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString GatewaySupportUrl { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString GatewayEncryptedOtpCookie { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new uint GatewayEncryptedOtpCookieSize { set; get; }
        new BinaryString GatewayUsername { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString GatewayDomain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString GatewayPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        #endregion
        #region IMsRdpClientTransportSettings3
        new uint GatewayCredSourceCookie { set; get; }
        new BinaryString GatewayAuthCookieServerAddr { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString GatewayEncryptedAuthCookie { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new uint GatewayEncryptedAuthCookieSize { set; get; }
        new BinaryString GatewayAuthLoginPage { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClientTransportSettings4
        uint GatewayBrokeringType { set; }
        #endregion
    }
    [ComImport]
    [Guid("7ED92C39-EB38-4927-A70A-708AC5A59321")]
    public interface IMsRdpClient10 : IMsRdpClient9
    {
        #region IMsTscAx_Redist
        #endregion
        #region IMsTscAx
        new BinaryString Server { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString Domain { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString UserName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString DisconnectedText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString ConnectingText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new short Connected { get; }
        new int DesktopWidth { set; get; }
        new int DesktopHeight { set; get; }
        new int StartConnected { set; get; }
        new int HorizontalScrollBarVisible { get; }
        new int VerticalScrollBarVisible { get; }
        new BinaryString FullScreenTitle { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new int CipherStrength { get; }
        new BinaryString Version { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new int SecuredSettingsEnabled { get; }
        new IMsTscSecuredSettings SecuredSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscAdvancedSettings AdvancedSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsTscDebug Debugger { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void Connect();
        new void Disconnect();
        new void CreateVirtualChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString newVal);
        new void SendOnVirtualChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString ChanData);
        #endregion
        #region IMsRdpClient
        new int ColorDepth { set; get; }
        new IMsRdpClientAdvancedSettings AdvancedSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientSecuredSettings SecuredSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }
        new bool FullScreen { set; get; }
        new void SetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName, int chanOptions);
        new int GetVirtualChannelOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString chanName);
        new ControlCloseStatus RequestClose();
        #endregion
        #region IMsRdpClient2
        new IMsRdpClientAdvancedSettings2 AdvancedSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new BinaryString ConnectedStatusText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClient3
        new IMsRdpClientAdvancedSettings3 AdvancedSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient4
        new IMsRdpClientAdvancedSettings4 AdvancedSettings5 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient5
        new IMsRdpClientTransportSettings TransportSettings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientAdvancedSettings5 AdvancedSettings6 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] new BinaryString GetErrorDescription(uint disconnectReason, uint ExtendedDisconnectReason);
        new ITSRemoteProgram RemoteProgram { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientShell MsRdpClientShell { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient6
        new IMsRdpClientAdvancedSettings6 AdvancedSettings7 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings2 TransportSettings2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient7
        new IMsRdpClientAdvancedSettings7 AdvancedSettings8 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpClientTransportSettings3 TransportSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] new BinaryString GetStatusText(uint statusCode);
        new IMsRdpClientSecuredSettings2 SecuredSettings3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ITSRemoteProgram2 RemoteProgram2 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
        #region IMsRdpClient8
        new void SendRemoteAction(RemoteSessionActionType actionType);
        new IMsRdpClientAdvancedSettings8 AdvancedSettings9 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight);
        #endregion
        #region IMsRdpClient9
        new IMsRdpClientTransportSettings4 TransportSettings4 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new void SyncSessionDisplaySettings();
        new void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor);
        new void attachEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        new void detachEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        #endregion
        #region IMsRdpClient10
        ITSRemoteProgram3 RemoteProgram3 { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("4B84EA77-ACEA-418C-881A-4A8C28AB1510")]
    public interface ITSRemoteProgram3 : ITSRemoteProgram2
    {
        #region ITSRemoteProgram
        new bool RemoteProgramMode { set; get; }
        new void ServerStartProgram([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrExecutablePath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrFilePath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrWorkingDirectory, bool vbExpandEnvVarInWorkingDirectoryOnServer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrArguments, bool vbExpandEnvVarInArgumentsOnServer);
        #endregion
        #region ITSRemoteProgram2
        new BinaryString RemoteApplicationName { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString RemoteApplicationProgram { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString RemoteApplicationArgs { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        #endregion
        #region ITSRemoteProgram3
        void ServerStartApp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrAppUserModelId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString bstrArguments, bool vbExpandEnvVarInArgumentsOnServer);
        #endregion
    }
    [ComImport]
    [Guid("05293249-B28B-4BD8-BE64-1B2F496B910E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable6 : IMsRdpClientNonScriptable5
    {
        #region IMsTscNonScriptable
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PortablePassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString PortableSalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinaryPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinarySalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        new bool ShowRedirectionWarningDialog { set; get; }
        new bool PromptForCredentials { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new bool RedirectDynamicDrives { set; get; }
        new bool RedirectDynamicDevices { set; get; }
        new IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new bool WarnAboutSendingCredentials { set; get; }
        new bool WarnAboutClipboardRedirection { set; get; }
        new BinaryString ConnectionBarText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClientNonScriptable4
        new RedirectionWarningType RedirectionWarningType { set; get; }
        new bool MarkRdpSettingsSecure { set; get; }
        new void set_PublisherCertificateChain([In] [MarshalAs(UnmanagedType.Struct)] ref object pVarCert);
        new object PublisherCertificateChain { [return: MarshalAs(UnmanagedType.Struct)] get; }
        new bool WarnAboutPrinterRedirection { set; get; }
        new bool AllowCredentialSaving { set; get; }
        new bool PromptForCredsOnClient { set; get; }
        new bool LaunchedViaClientShellInterface { set; get; }
        new bool TrustedZoneSite { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable5
        new bool UseMultimon { set; get; }
        new uint RemoteMonitorCount { get; }
        new void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);
        new bool RemoteMonitorLayoutMatchesLocal { get; }
        new bool DisableConnectionBar { set; }
        new bool DisableRemoteAppCapsCheck { set; get; }
        new bool WarnAboutDirectXRedirection { set; get; }
        new bool AllowPromptingForCredentials { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable6
        void SendLocation2D(double latitude, double longitude);
        void SendLocation3D(double latitude, double longitude, int altitude);
        #endregion
    }
    [ComImport]
    [Guid("71B4A60A-FE21-46D8-A39B-8E32BA0C5ECC")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClientNonScriptable7 : IMsRdpClientNonScriptable6
    {
        #region IMsTscNonScriptable
        new BinaryString ClearTextPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; }
        new BinaryString PortablePassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString PortableSalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinaryPassword { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new BinaryString BinarySalt { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        new void ResetPassword();
        #endregion
        #region IMsRdpClientNonScriptable
        new void NotifyRedirectDeviceChange(ulong wParam, long lParam);
        new void SendKeys(int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
        #endregion
        #region IMsRdpClientNonScriptable2
        new nint UIParentWindowHandle { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable3
        new bool ShowRedirectionWarningDialog { set; get; }
        new bool PromptForCredentials { set; get; }
        new bool NegotiateSecurityLayer { set; get; }
        new bool EnableCredSspSupport { set; get; }
        new bool RedirectDynamicDrives { set; get; }
        new bool RedirectDynamicDevices { set; get; }
        new IMsRdpDeviceCollection DeviceCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new IMsRdpDriveCollection DriveCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        new bool WarnAboutSendingCredentials { set; get; }
        new bool WarnAboutClipboardRedirection { set; get; }
        new BinaryString ConnectionBarText { [param: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] set; [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        #endregion
        #region IMsRdpClientNonScriptable4
        new RedirectionWarningType RedirectionWarningType { set; get; }
        new bool MarkRdpSettingsSecure { set; get; }
        new void set_PublisherCertificateChain([In] [MarshalAs(UnmanagedType.Struct)] ref object pVarCert);
        new object PublisherCertificateChain { [return: MarshalAs(UnmanagedType.Struct)] get; }
        new bool WarnAboutPrinterRedirection { set; get; }
        new bool AllowCredentialSaving { set; get; }
        new bool PromptForCredsOnClient { set; get; }
        new bool LaunchedViaClientShellInterface { set; get; }
        new bool TrustedZoneSite { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable5
        new bool UseMultimon { set; get; }
        new uint RemoteMonitorCount { get; }
        new void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);
        new bool RemoteMonitorLayoutMatchesLocal { get; }
        new bool DisableConnectionBar { set; }
        new bool DisableRemoteAppCapsCheck { set; get; }
        new bool WarnAboutDirectXRedirection { set; get; }
        new bool AllowPromptingForCredentials { set; get; }
        #endregion
        #region IMsRdpClientNonScriptable6
        new void SendLocation2D(double latitude, double longitude);
        new void SendLocation3D(double latitude, double longitude, int altitude);
        #endregion
        #region IMsRdpClientNonScriptable7
        IMsRdpCameraRedirConfigCollection CameraRedirConfigCollection { [return: MarshalAs(UnmanagedType.Interface)] get; }
        void DisableDpiCursorScalingForProcess();
        IMsRdpClipboard Clipboard { [return: MarshalAs(UnmanagedType.Interface)] get; }
        #endregion
    }
    [ComImport]
    [Guid("AE45252B-AAAB-4504-B681-649D6073A37A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpCameraRedirConfigCollection
    {
        #region IMsRdpCameraRedirConfigCollection
        void Rescan();
        uint Count { get; }
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpCameraRedirConfig get_ByIndex(uint index);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpCameraRedirConfig get_BySymbolicLink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString SymbolicLink);
        [return: MarshalAs(UnmanagedType.Interface)] IMsRdpCameraRedirConfig get_ByInstanceId([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString InstanceId);
        void AddConfig([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString SymbolicLink, bool fRedirected);
        bool RedirectByDefault { set; get; }
        bool EncodeVideo { set; get; }
        CameraRedirEncodingQuality EncodingQuality { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("2E769EE8-00C7-43DC-AFD9-235D75B72A40")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpClipboard
    {
        #region IMsRdpClipboard
        bool CanSyncLocalClipboardToRemoteSession();
        void SyncLocalClipboardToRemoteSession();
        bool CanSyncRemoteClipboardToLocalSession();
        void SyncRemoteClipboardToLocalSession();
        #endregion
    }
    [ComImport]
    [Guid("57D25668-625A-4905-BE4E-304CAA13F89C")]
    public interface IRemoteDesktopClient
    {
        #region IRemoteDesktopClient
        void Connect();
        void Disconnect();
        void Reconnect(uint width, uint height);
        IRemoteDesktopClientSettings Settings { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IRemoteDesktopClientActions Actions { [return: MarshalAs(UnmanagedType.Interface)] get; }
        IRemoteDesktopClientTouchPointer TouchPointer { [return: MarshalAs(UnmanagedType.Interface)] get; }
        void DeleteSavedCredentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString serverName);
        void UpdateSessionDisplaySettings(uint width, uint height);
        void attachEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        void detachEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString eventName, [MarshalAs(UnmanagedType.IDispatch)] object callback);
        #endregion
    }
    [ComImport]
    [Guid("48A0F2A7-2713-431F-BBAC-6F4558E7D64D")]
    public interface IRemoteDesktopClientSettings
    {
        #region IRemoteDesktopClientSettings
        void ApplySettings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString RdpFileContents);
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString RetrieveSettings();
        [return: MarshalAs(UnmanagedType.Struct)] object GetRdpProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString propertyName);
        void SetRdpProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString propertyName, [MarshalAs(UnmanagedType.Struct)] object Value);
        #endregion
    }
    [ComImport]
    [Guid("7D54BC4E-1028-45D4-8B0A-B9B6BFFBA176")]
    public interface IRemoteDesktopClientActions
    {
        #region IRemoteDesktopClientActions
        void SuspendScreenUpdates();
        void ResumeScreenUpdates();
        void ExecuteRemoteAction(RemoteActionType remoteAction);
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString GetSnapshot(SnapshotEncodingType snapshotEncoding, SnapshotFormatType snapshotFormat, uint snapshotWidth, uint snapshotHeight);
        #endregion
    }
    [ComImport]
    [Guid("260EC22D-8CBC-44B5-9E88-2A37F6C93AE9")]
    public interface IRemoteDesktopClientTouchPointer
    {
        #region IRemoteDesktopClientTouchPointer
        bool Enabled { set; get; }
        bool EventsEnabled { set; get; }
        uint PointerSpeed { set; get; }
        #endregion
    }
    //[ComImport]
    //[Guid("079863B7-6D47-4105-8BFE-0CDCB360E67D")]
    //[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    //public interface IRemoteDesktopClientEvents
    //{
    //    #region IRemoteDesktopClientEvents
    //    [PreserveSig] void OnConnecting();
    //    [PreserveSig] void OnConnected();
    //    [PreserveSig] void OnLoginCompleted();
    //    [PreserveSig] void OnDisconnected(int disconnectReason, int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString disconnectErrorMessage);
    //    [PreserveSig] void OnStatusChanged(int statusCode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString statusMessage);
    //    [PreserveSig] void OnAutoReconnecting(int disconnectReason, int ExtendedDisconnectReason, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString disconnectErrorMessage, bool networkAvailable, int attemptCount, int maxAttemptCount);
    //    [PreserveSig] void OnAutoReconnected();
    //    [PreserveSig] void OnDialogDisplaying();
    //    [PreserveSig] void OnDialogDismissed();
    //    [PreserveSig] void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt);
    //    [PreserveSig] void OnAdminMessageReceived([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] BinaryString adminMessage);
    //    [PreserveSig] void OnKeyCombinationPressed(int keyCombination);
    //    [PreserveSig] void OnRemoteDesktopSizeChanged(int width, int height);
    //    [PreserveSig] void OnTouchPointerCursorMoved(int x, int y);
    //    #endregion
    //}
    public enum ClientSpec
    {
        #region ClientSpec
        FullMode = 0,
        ThinClientMode = 1,
        SmallCacheMode = 2,
        #endregion
    }
    public enum RemoteActionType
    {
        #region RemoteActionType
        RemoteActionCharms = 0,
        RemoteActionAppbar = 1,
        RemoteActionSnap = 2,
        RemoteActionStartScreen = 3,
        RemoteActionAppSwitch = 4,
        #endregion
    }
    public enum SnapshotEncodingType
    {
        #region SnapshotEncodingType
        SnapshotEncodingDataUri = 0,
        #endregion
    }
    public enum SnapshotFormatType
    {
        #region SnapshotFormatType
        SnapshotFormatPng = 0,
        SnapshotFormatJpeg = 1,
        SnapshotFormatBmp = 2,
        #endregion
    }
    [ComImport]
    [Guid("60C3B9C8-9E92-4F5E-A3E7-604A912093EA")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpDevice
    {
        #region IMsRdpDevice
        BinaryString DeviceInstanceId { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString FriendlyName { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString DeviceDescription { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        bool RedirectionState { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("D28B5458-F694-47A8-8E61-40356A767E46")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpDrive
    {
        #region IMsRdpDrive
        BinaryString Name { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        bool RedirectionState { set; get; }
        #endregion
    }
    [ComImport]
    [Guid("09750604-D625-47C1-9FCD-F09F735705D7")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMsRdpCameraRedirConfig
    {
        #region IMsRdpCameraRedirConfig
        BinaryString FriendlyName { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString SymbolicLink { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString InstanceId { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        BinaryString ParentInstanceId { [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BinaryStringMarshaler))] get; }
        bool Redirected { set; get; }
        bool DeviceExists { get; }
        #endregion
    }
    public enum CameraRedirEncodingQuality
    {
        #region CameraRedirEncodingQuality
        encodingQualityLow = 0,
        encodingQualityMedium = 1,
        encodingQualityHigh = 2,
        #endregion
    }
#endif
}
