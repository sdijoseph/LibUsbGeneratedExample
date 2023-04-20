namespace LibUsbDotNet;

public unsafe partial struct libusb_platform_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint8_t")]
    public byte bDevCapabilityType;

    [NativeTypeName("uint8_t")]
    public byte bReserved;

    [NativeTypeName("uint8_t[16]")]
    public fixed byte PlatformCapabilityUUID[16];

    [NativeTypeName("uint8_t[]")]
    public fixed byte CapabilityData[1];
}
