namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_request_recipient : uint
{
    LIBUSB_RECIPIENT_DEVICE = 0x00,
    LIBUSB_RECIPIENT_INTERFACE = 0x01,
    LIBUSB_RECIPIENT_ENDPOINT = 0x02,
    LIBUSB_RECIPIENT_OTHER = 0x03,
}
