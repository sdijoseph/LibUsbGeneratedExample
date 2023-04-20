namespace LibUsbDotNet;

[NativeTypeName("unsigned int")]
public enum libusb_hotplug_event : uint
{
    LIBUSB_HOTPLUG_EVENT_DEVICE_ARRIVED = (1 << 0),
    LIBUSB_HOTPLUG_EVENT_DEVICE_LEFT = (1 << 1),
}
