namespace LibUsbDotNet;

public partial struct libusb_bos_descriptor
{
    [NativeTypeName("uint8_t")]
    public byte bLength;

    [NativeTypeName("uint8_t")]
    public byte bDescriptorType;

    [NativeTypeName("uint16_t")]
    public ushort wTotalLength;

    [NativeTypeName("uint8_t")]
    public byte bNumDeviceCaps;

    [NativeTypeName("struct libusb_bos_dev_capability_descriptor *[]")]
    public _dev_capability_e__FixedBuffer dev_capability;

    public unsafe partial struct _dev_capability_e__FixedBuffer
    {
        public libusb_bos_dev_capability_descriptor* e0;

        public ref libusb_bos_dev_capability_descriptor* this[int index]
        {
            get
            {
                fixed (libusb_bos_dev_capability_descriptor** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
