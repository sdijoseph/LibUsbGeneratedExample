namespace LibUsbDotNet;

public unsafe partial struct libusb_version
{
    [NativeTypeName("const uint16_t")]
    public ushort major;

    [NativeTypeName("const uint16_t")]
    public ushort minor;

    [NativeTypeName("const uint16_t")]
    public ushort micro;

    [NativeTypeName("const uint16_t")]
    public ushort nano;

    [NativeTypeName("const char *")]
    public sbyte* rc;

    [NativeTypeName("const char *")]
    public sbyte* describe;
}
