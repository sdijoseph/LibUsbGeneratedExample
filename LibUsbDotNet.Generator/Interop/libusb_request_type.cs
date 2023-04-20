namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_request_type : uint
{
    LIBUSB_REQUEST_TYPE_STANDARD = (0x00 << 5),
    LIBUSB_REQUEST_TYPE_CLASS = (0x01 << 5),
    LIBUSB_REQUEST_TYPE_VENDOR = (0x02 << 5),
    LIBUSB_REQUEST_TYPE_RESERVED = (0x03 << 5),
}
