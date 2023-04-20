namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_transfer_type : uint
{
    LIBUSB_TRANSFER_TYPE_CONTROL = 0U,
    LIBUSB_TRANSFER_TYPE_ISOCHRONOUS = 1U,
    LIBUSB_TRANSFER_TYPE_BULK = 2U,
    LIBUSB_TRANSFER_TYPE_INTERRUPT = 3U,
    LIBUSB_TRANSFER_TYPE_BULK_STREAM = 4U,
}
