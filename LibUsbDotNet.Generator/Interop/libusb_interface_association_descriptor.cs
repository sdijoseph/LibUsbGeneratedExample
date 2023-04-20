namespace LibUsbDotNet;

public partial struct libusb_interface_association_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint8_t")]
    public byte bFirstInterface;

    [NativeTypeName("uint8_t")]
    public byte bInterfaceCount;

    [NativeTypeName("uint8_t")]
    public byte bFunctionClass;

    [NativeTypeName("uint8_t")]
    public byte bFunctionSubClass;

    [NativeTypeName("uint8_t")]
    public byte bFunctionProtocol;

    [NativeTypeName("uint8_t")]
    public byte iFunction;
}
