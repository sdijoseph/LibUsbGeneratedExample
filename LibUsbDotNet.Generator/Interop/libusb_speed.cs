namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_speed : uint
{
    LIBUSB_SPEED_UNKNOWN = 0,
    LIBUSB_SPEED_LOW = 1,
    LIBUSB_SPEED_FULL = 2,
    LIBUSB_SPEED_HIGH = 3,
    LIBUSB_SPEED_SUPER = 4,
    LIBUSB_SPEED_SUPER_PLUS = 5,
}
