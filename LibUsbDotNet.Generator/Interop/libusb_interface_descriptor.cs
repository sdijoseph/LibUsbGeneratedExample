namespace LibUsbDotNet;

public unsafe partial struct libusb_interface_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint8_t")]
    public byte bInterfaceNumber;

    [NativeTypeName("uint8_t")]
    public byte bAlternateSetting;

    [NativeTypeName("uint8_t")]
    public byte bNumEndpoints;

    [NativeTypeName("uint8_t")]
    public byte bInterfaceClass;

    [NativeTypeName("uint8_t")]
    public byte bInterfaceSubClass;

    [NativeTypeName("uint8_t")]
    public byte bInterfaceProtocol;

    [NativeTypeName("uint8_t")]
    public byte iInterface;

    [NativeTypeName("const struct libusb_endpoint_descriptor *")]
    public libusb_endpoint_descriptor* endpoint;

    [NativeTypeName("const unsigned char *")]
    public byte* extra;

    public int extra_length;
}
