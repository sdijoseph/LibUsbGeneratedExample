namespace LibUsbDotNet;

public partial struct libusb_ss_endpoint_companion_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint8_t")]
    public byte bMaxBurst;

    [NativeTypeName("uint8_t")]
    public byte bmAttributes;

    [NativeTypeName("uint16_t")]
    public ushort wBytesPerInterval;
}
