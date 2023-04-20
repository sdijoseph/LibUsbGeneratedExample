namespace LibUsbDotNet;

public unsafe partial struct libusb_bos_dev_capability_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint8_t")]
    public byte bDevCapabilityType;

    [NativeTypeName("uint8_t[]")]
    public fixed byte dev_capability_data[1];
}
