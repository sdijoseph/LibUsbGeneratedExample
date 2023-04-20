namespace LibUsbDotNet;

public unsafe partial struct libusb_interface_association_descriptor_array
{
    [NativeTypeName("const struct libusb_interface_association_descriptor *")]
    public libusb_interface_association_descriptor* iad;

    public int length;
}
