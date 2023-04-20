using System.Runtime.InteropServices;

namespace LibUsbDotNet;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct libusb_control_setup
{
    [NativeTypeName("uint8_t")]
    public byte bmRequestType;

    [NativeTypeName("uint8_t")]
    public byte bRequest;

    [NativeTypeName("uint16_t")]
    public ushort wValue;

    [NativeTypeName("uint16_t")]
    public ushort wIndex;

    [NativeTypeName("uint16_t")]
    public ushort wLength;
}
