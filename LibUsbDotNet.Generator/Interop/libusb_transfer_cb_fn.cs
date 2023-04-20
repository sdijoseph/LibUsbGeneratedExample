using System.Runtime.InteropServices;

namespace LibUsbDotNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void libusb_transfer_cb_fn([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer);
