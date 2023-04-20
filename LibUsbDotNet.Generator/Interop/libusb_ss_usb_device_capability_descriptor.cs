namespace LibUsbDotNet;

public partial struct libusb_ss_usb_device_capability_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint8_t")]
    public byte bDevCapabilityType;

    [NativeTypeName("uint8_t")]
    public byte bmAttributes;

    [NativeTypeName("uint16_t")]
    public ushort wSpeedSupported;

    [NativeTypeName("uint8_t")]
    public byte bFunctionalitySupport;

    [NativeTypeName("uint8_t")]
    public byte bU1DevExitLat;

    [NativeTypeName("uint16_t")]
    public ushort bU2DevExitLat;
}
