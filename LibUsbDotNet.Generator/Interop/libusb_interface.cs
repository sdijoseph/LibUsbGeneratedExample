namespace LibUsbDotNet;

public unsafe partial struct libusb_interface
{
    [NativeTypeName("const struct libusb_interface_descriptor *")]
    public libusb_interface_descriptor* altsetting;

    public int num_altsetting;
}
