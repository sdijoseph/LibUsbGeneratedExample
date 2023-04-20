namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_ss_usb_device_capability_attributes : uint
{
    LIBUSB_BM_LTM_SUPPORT = (1 << 1),
}
