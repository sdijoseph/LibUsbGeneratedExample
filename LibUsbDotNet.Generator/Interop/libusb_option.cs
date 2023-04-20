namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_option : uint
{
    LIBUSB_OPTION_LOG_LEVEL = 0,
    LIBUSB_OPTION_USE_USBDK = 1,
    LIBUSB_OPTION_NO_DEVICE_DISCOVERY = 2,
    LIBUSB_OPTION_WINUSB_RAW_IO = 3,
    LIBUSB_OPTION_LOG_CB = 4,
    LIBUSB_OPTION_MAX = 5,
}
