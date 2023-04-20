namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_bos_type : uint
{
    LIBUSB_BT_WIRELESS_USB_DEVICE_CAPABILITY = 0x01,
    LIBUSB_BT_USB_2_0_EXTENSION = 0x02,
    LIBUSB_BT_SS_USB_DEVICE_CAPABILITY = 0x03,
    LIBUSB_BT_CONTAINER_ID = 0x04,
    LIBUSB_BT_PLATFORM_DESCRIPTOR = 0x05,
}
