namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_endpoint_transfer_type : uint
{
    LIBUSB_ENDPOINT_TRANSFER_TYPE_CONTROL = 0x0,
    LIBUSB_ENDPOINT_TRANSFER_TYPE_ISOCHRONOUS = 0x1,
    LIBUSB_ENDPOINT_TRANSFER_TYPE_BULK = 0x2,
    LIBUSB_ENDPOINT_TRANSFER_TYPE_INTERRUPT = 0x3,
}
