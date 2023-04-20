namespace LibUsbDotNet;

public partial struct libusb_device_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint16_t")]
    public ushort bcdUSB;

    [NativeTypeName("uint8_t")]
    public byte bDeviceClass;

    [NativeTypeName("uint8_t")]
    public byte bDeviceSubClass;

    [NativeTypeName("uint8_t")]
    public byte bDeviceProtocol;

    [NativeTypeName("uint8_t")]
    public byte bMaxPacketSize0;

    [NativeTypeName("uint16_t")]
    public ushort idVendor;

    [NativeTypeName("uint16_t")]
    public ushort idProduct;

    [NativeTypeName("uint16_t")]
    public ushort bcdDevice;

    [NativeTypeName("uint8_t")]
    public byte iManufacturer;

    [NativeTypeName("uint8_t")]
    public byte iProduct;

    [NativeTypeName("uint8_t")]
    public byte iSerialNumber;

    [NativeTypeName("uint8_t")]
    public byte bNumConfigurations;
}
