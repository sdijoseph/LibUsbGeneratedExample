using System.Runtime.InteropServices;

namespace LibUsbDotNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void libusb_pollfd_added_cb(int fd, short events, void* user_data);
