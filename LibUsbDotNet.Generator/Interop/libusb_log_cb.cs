using System.Runtime.InteropServices;

namespace LibUsbDotNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void libusb_log_cb(libusb_context* ctx, [NativeTypeName("enum libusb_log_level")] libusb_log_level level, [NativeTypeName("const char *")] sbyte* str);
