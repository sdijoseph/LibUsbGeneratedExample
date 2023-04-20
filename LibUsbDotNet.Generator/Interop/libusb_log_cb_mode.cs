namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_log_cb_mode : uint
{
    LIBUSB_LOG_CB_GLOBAL = (1 << 0),
    LIBUSB_LOG_CB_CONTEXT = (1 << 1),
}
