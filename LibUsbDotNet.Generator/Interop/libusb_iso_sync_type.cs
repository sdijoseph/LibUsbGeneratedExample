namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_iso_sync_type : uint
{
    LIBUSB_ISO_SYNC_TYPE_NONE = 0x0,
    LIBUSB_ISO_SYNC_TYPE_ASYNC = 0x1,
    LIBUSB_ISO_SYNC_TYPE_ADAPTIVE = 0x2,
    LIBUSB_ISO_SYNC_TYPE_SYNC = 0x3,
}
