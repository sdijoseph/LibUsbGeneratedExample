namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_endpoint_direction : uint
{
    LIBUSB_ENDPOINT_OUT = 0x00,
    LIBUSB_ENDPOINT_IN = 0x80,
}
