namespace LibUsbDotNet;

public unsafe partial struct libusb_config_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint16_t")]
    public ushort wTotalLength;

    [NativeTypeName("uint8_t")]
    public byte bNumInterfaces;

    [NativeTypeName("uint8_t")]
    public byte bConfigurationValue;

    [NativeTypeName("uint8_t")]
    public byte iConfiguration;

    [NativeTypeName("uint8_t")]
    public byte bmAttributes;

    [NativeTypeName("uint8_t")]
    public byte MaxPower;

    [NativeTypeName("const struct libusb_interface *")]
    public libusb_interface* @interface;

    [NativeTypeName("const unsigned char *")]
    public byte* extra;

    public int extra_length;
}

public class NativeTypeNameAttribute : Attribute
{
    public NativeTypeNameAttribute(string uint8T)
    {
        throw new NotImplementedException();
    }
}
