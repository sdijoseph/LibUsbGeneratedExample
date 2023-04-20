namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_supported_speed : uint
{
    LIBUSB_LOW_SPEED_OPERATION = (1 << 0),
    LIBUSB_FULL_SPEED_OPERATION = (1 << 1),
    LIBUSB_HIGH_SPEED_OPERATION = (1 << 2),
    LIBUSB_SUPER_SPEED_OPERATION = (1 << 3),
}
