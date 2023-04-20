namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_capability : uint
{
    LIBUSB_CAP_HAS_CAPABILITY = 0x0000U,
    LIBUSB_CAP_HAS_HOTPLUG = 0x0001U,
    LIBUSB_CAP_HAS_HID_ACCESS = 0x0100U,
    LIBUSB_CAP_SUPPORTS_DETACH_KERNEL_DRIVER = 0x0101U,
}
