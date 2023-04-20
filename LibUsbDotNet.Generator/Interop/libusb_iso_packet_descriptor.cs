namespace LibUsbDotNet;

public partial struct libusb_iso_packet_descriptor
{
    [NativeTypeName("unsigned int")]
    public uint length;

    [NativeTypeName("unsigned int")]
    public uint actual_length;

    [NativeTypeName("enum libusb_transfer_status")]
    public libusb_transfer_status status;
}
