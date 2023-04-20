namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_usb_2_0_extension_attributes : uint
{
    LIBUSB_BM_LPM_SUPPORT = (1 << 1),
}
