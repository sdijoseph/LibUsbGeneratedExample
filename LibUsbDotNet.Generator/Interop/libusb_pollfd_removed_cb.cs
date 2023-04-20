using System.Runtime.InteropServices;

namespace LibUsbDotNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void libusb_pollfd_removed_cb(int fd, void* user_data);
