namespace LibUsbDotNet;

public partial struct libusb_usb_2_0_extension_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint8_t")]
    public byte bDevCapabilityType;

    [NativeTypeName("uint32_t")]
    public uint bmAttributes;
}
