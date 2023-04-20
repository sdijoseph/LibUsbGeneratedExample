namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_transfer_flags : uint
{
    LIBUSB_TRANSFER_SHORT_NOT_OK = (1U << 0),
    LIBUSB_TRANSFER_FREE_BUFFER = (1U << 1),
    LIBUSB_TRANSFER_FREE_TRANSFER = (1U << 2),
    LIBUSB_TRANSFER_ADD_ZERO_PACKET = (1U << 3),
}
