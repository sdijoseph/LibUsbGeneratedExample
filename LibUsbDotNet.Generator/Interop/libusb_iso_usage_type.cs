namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_iso_usage_type : uint
{
    LIBUSB_ISO_USAGE_TYPE_DATA = 0x0,
    LIBUSB_ISO_USAGE_TYPE_FEEDBACK = 0x1,
    LIBUSB_ISO_USAGE_TYPE_IMPLICIT = 0x2,
}
