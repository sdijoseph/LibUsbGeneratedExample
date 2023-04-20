namespace LibUsbDotNet;

public unsafe partial struct libusb_transfer
{
    public libusb_device_handle* dev_handle;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("unsigned char")]
    public byte endpoint;

    [NativeTypeName("unsigned char")]
    public byte type;

    [NativeTypeName("unsigned int")]
    public uint timeout;

    [NativeTypeName("enum libusb_transfer_status")]
    public libusb_transfer_status status;

    public int length;

    public int actual_length;

    [NativeTypeName("libusb_transfer_cb_fn")]
    public IntPtr callback;

    public void* user_data;

    [NativeTypeName("unsigned char *")]
    public byte* buffer;

    public int num_iso_packets;

    [NativeTypeName("struct libusb_iso_packet_descriptor[]")]
    public _iso_packet_desc_e__FixedBuffer iso_packet_desc;

    public partial struct _iso_packet_desc_e__FixedBuffer
    {
        public libusb_iso_packet_descriptor e0;

        public unsafe ref libusb_iso_packet_descriptor this[int index]
        {
            get
            {
                fixed (libusb_iso_packet_descriptor* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
