using System.Runtime.InteropServices;

namespace LibUsbDotNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int libusb_hotplug_callback_fn(libusb_context* ctx, libusb_device* device, libusb_hotplug_event @event, void* user_data);
