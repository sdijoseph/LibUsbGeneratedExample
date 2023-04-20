using System.Runtime.InteropServices;

namespace LibUsbDotNet;

public partial struct libusb_init_option
{
    [NativeTypeName("enum libusb_option")]
    public libusb_option option;

    [NativeTypeName("union (anonymous union at libusb/libusb/libusb.h:1573:3)")]
    public _value_e__Union value;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _value_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("int64_t")]
        public IntPtr ival;

        [FieldOffset(0)]
        [NativeTypeName("libusb_log_cb")]
        public IntPtr log_cbval;
    }
}
