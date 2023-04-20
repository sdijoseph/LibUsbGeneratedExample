namespace LibUsbDotNet;

public unsafe partial struct libusb_endpoint_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint8_t")]
    public byte bEndpointAddress;

    [NativeTypeName("uint8_t")]
    public byte bmAttributes;

    [NativeTypeName("uint16_t")]
    public ushort wMaxPacketSize;

    [NativeTypeName("uint8_t")]
    public byte bInterval;

    [NativeTypeName("uint8_t")]
    public byte bRefresh;

    [NativeTypeName("uint8_t")]
    public byte bSynchAddress;

    [NativeTypeName("const unsigned char *")]
    public byte* extra;

    public int extra_length;
}
