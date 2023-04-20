namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_hotplug_flag : uint
{
    LIBUSB_HOTPLUG_ENUMERATE = (1 << 0),
}
