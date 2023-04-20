using System.Runtime.InteropServices;
using static LibUsbDotNet.libusb_descriptor_type;
using static LibUsbDotNet.libusb_endpoint_direction;
using static LibUsbDotNet.libusb_standard_request;
using static LibUsbDotNet.libusb_transfer_type;

namespace LibUsbDotNet;

public static unsafe partial class NativeMethods
{
    // [return: NativeTypeName("uint16_t")]
    // public static ushort libusb_cpu_to_le16([NativeTypeName("const uint16_t")] ushort x)
    // {
    //
    //     [StructLayout(LayoutKind.Explicit)]
    //     public unsafe partial struct __AnonymousRecord_libusb_L168_C2
    //     {
    //         [FieldOffset(0)]
    //         [NativeTypeName("uint8_t[2]")]
    //         public fixed byte b8[2];
    //
    //         [FieldOffset(0)]
    //         [NativeTypeName("uint16_t")]
    //         public ushort b16;
    //     }
    // , _tmp
    //
    //     _tmp.b8[1] = (byte)(x >> 8);
    //     _tmp.b8[0] = (byte)(x & 0xff);
    //     return _tmp.b16;
    // }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct __AnonymousRecord_libusb_L168_C2
    {
        [FieldOffset(0)]
        [NativeTypeName("uint8_t[2]")]
        public fixed byte b8[2];

        [FieldOffset(0)]
        [NativeTypeName("uint16_t")]
        public ushort b16;
    }

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_init(libusb_context** ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_init_context(libusb_context** ctx, [NativeTypeName("const struct libusb_init_option[]")] libusb_init_option* options, int num_options);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_exit(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_set_debug(libusb_context* ctx, int level);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_set_log_cb(libusb_context* ctx, [NativeTypeName("libusb_log_cb")] IntPtr cb, int mode);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const struct libusb_version *")]
    public static extern libusb_version* libusb_get_version();

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_has_capability([NativeTypeName("uint32_t")] uint capability);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* libusb_error_name(int errcode);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_setlocale([NativeTypeName("const char *")] sbyte* locale);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* libusb_strerror(int errcode);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ssize_t")]
    public static extern IntPtr libusb_get_device_list(libusb_context* ctx, libusb_device*** list);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_device_list(libusb_device** list, int unref_devices);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern libusb_device* libusb_ref_device(libusb_device* dev);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_unref_device(libusb_device* dev);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_configuration(libusb_device_handle* dev, int* config);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_device_descriptor(libusb_device* dev, [NativeTypeName("struct libusb_device_descriptor *")] libusb_device_descriptor* desc);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_active_config_descriptor(libusb_device* dev, [NativeTypeName("struct libusb_config_descriptor **")] libusb_config_descriptor** config);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_config_descriptor(libusb_device* dev, [NativeTypeName("uint8_t")] byte config_index, [NativeTypeName("struct libusb_config_descriptor **")] libusb_config_descriptor** config);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_config_descriptor_by_value(libusb_device* dev, [NativeTypeName("uint8_t")] byte bConfigurationValue, [NativeTypeName("struct libusb_config_descriptor **")] libusb_config_descriptor** config);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_config_descriptor([NativeTypeName("struct libusb_config_descriptor *")] libusb_config_descriptor* config);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_ss_endpoint_companion_descriptor(libusb_context* ctx, [NativeTypeName("const struct libusb_endpoint_descriptor *")] libusb_endpoint_descriptor* endpoint, [NativeTypeName("struct libusb_ss_endpoint_companion_descriptor **")] libusb_ss_endpoint_companion_descriptor** ep_comp);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_ss_endpoint_companion_descriptor([NativeTypeName("struct libusb_ss_endpoint_companion_descriptor *")] libusb_ss_endpoint_companion_descriptor* ep_comp);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_bos_descriptor(libusb_device_handle* dev_handle, [NativeTypeName("struct libusb_bos_descriptor **")] libusb_bos_descriptor** bos);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_bos_descriptor([NativeTypeName("struct libusb_bos_descriptor *")] libusb_bos_descriptor* bos);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_usb_2_0_extension_descriptor(libusb_context* ctx, [NativeTypeName("struct libusb_bos_dev_capability_descriptor *")] libusb_bos_dev_capability_descriptor* dev_cap, [NativeTypeName("struct libusb_usb_2_0_extension_descriptor **")] libusb_usb_2_0_extension_descriptor** usb_2_0_extension);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_usb_2_0_extension_descriptor([NativeTypeName("struct libusb_usb_2_0_extension_descriptor *")] libusb_usb_2_0_extension_descriptor* usb_2_0_extension);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_ss_usb_device_capability_descriptor(libusb_context* ctx, [NativeTypeName("struct libusb_bos_dev_capability_descriptor *")] libusb_bos_dev_capability_descriptor* dev_cap, [NativeTypeName("struct libusb_ss_usb_device_capability_descriptor **")] libusb_ss_usb_device_capability_descriptor** ss_usb_device_cap);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_ss_usb_device_capability_descriptor([NativeTypeName("struct libusb_ss_usb_device_capability_descriptor *")] libusb_ss_usb_device_capability_descriptor* ss_usb_device_cap);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_container_id_descriptor(libusb_context* ctx, [NativeTypeName("struct libusb_bos_dev_capability_descriptor *")] libusb_bos_dev_capability_descriptor* dev_cap, [NativeTypeName("struct libusb_container_id_descriptor **")] libusb_container_id_descriptor** container_id);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_container_id_descriptor([NativeTypeName("struct libusb_container_id_descriptor *")] libusb_container_id_descriptor* container_id);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_platform_descriptor(libusb_context* ctx, [NativeTypeName("struct libusb_bos_dev_capability_descriptor *")] libusb_bos_dev_capability_descriptor* dev_cap, [NativeTypeName("struct libusb_platform_descriptor **")] libusb_platform_descriptor** platform_descriptor);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_platform_descriptor([NativeTypeName("struct libusb_platform_descriptor *")] libusb_platform_descriptor* platform_descriptor);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint8_t")]
    public static extern byte libusb_get_bus_number(libusb_device* dev);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint8_t")]
    public static extern byte libusb_get_port_number(libusb_device* dev);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_port_numbers(libusb_device* dev, [NativeTypeName("uint8_t *")] byte* port_numbers, int port_numbers_len);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern int libusb_get_port_path(libusb_context* ctx, libusb_device* dev, [NativeTypeName("uint8_t *")] byte* path, [NativeTypeName("uint8_t")] byte path_length);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern libusb_device* libusb_get_parent(libusb_device* dev);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint8_t")]
    public static extern byte libusb_get_device_address(libusb_device* dev);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_device_speed(libusb_device* dev);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_max_packet_size(libusb_device* dev, [NativeTypeName("unsigned char")] byte endpoint);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_max_iso_packet_size(libusb_device* dev, [NativeTypeName("unsigned char")] byte endpoint);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_max_alt_packet_size(libusb_device* dev, int interface_number, int alternate_setting, [NativeTypeName("unsigned char")] byte endpoint);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_interface_association_descriptors(libusb_device* dev, [NativeTypeName("uint8_t")] byte config_index, [NativeTypeName("struct libusb_interface_association_descriptor_array **")] libusb_interface_association_descriptor_array** iad_array);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_active_interface_association_descriptors(libusb_device* dev, [NativeTypeName("struct libusb_interface_association_descriptor_array **")] libusb_interface_association_descriptor_array** iad_array);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_interface_association_descriptors([NativeTypeName("struct libusb_interface_association_descriptor_array *")] libusb_interface_association_descriptor_array* iad_array);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_wrap_sys_device(libusb_context* ctx, [NativeTypeName("intptr_t")] IntPtr sys_dev, libusb_device_handle** dev_handle);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_open(libusb_device* dev, libusb_device_handle** dev_handle);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_close(libusb_device_handle* dev_handle);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern libusb_device* libusb_get_device(libusb_device_handle* dev_handle);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_set_configuration(libusb_device_handle* dev_handle, int configuration);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_claim_interface(libusb_device_handle* dev_handle, int interface_number);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_release_interface(libusb_device_handle* dev_handle, int interface_number);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern libusb_device_handle* libusb_open_device_with_vid_pid(libusb_context* ctx, [NativeTypeName("uint16_t")] ushort vendor_id, [NativeTypeName("uint16_t")] ushort product_id);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_set_interface_alt_setting(libusb_device_handle* dev_handle, int interface_number, int alternate_setting);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_clear_halt(libusb_device_handle* dev_handle, [NativeTypeName("unsigned char")] byte endpoint);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_reset_device(libusb_device_handle* dev_handle);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_alloc_streams(libusb_device_handle* dev_handle, [NativeTypeName("uint32_t")] uint num_streams, [NativeTypeName("unsigned char *")] byte* endpoints, int num_endpoints);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_free_streams(libusb_device_handle* dev_handle, [NativeTypeName("unsigned char *")] byte* endpoints, int num_endpoints);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned char *")]
    public static extern byte* libusb_dev_mem_alloc(libusb_device_handle* dev_handle, [NativeTypeName("size_t")] UIntPtr length);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_dev_mem_free(libusb_device_handle* dev_handle, [NativeTypeName("unsigned char *")] byte* buffer, [NativeTypeName("size_t")] UIntPtr length);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_kernel_driver_active(libusb_device_handle* dev_handle, int interface_number);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_detach_kernel_driver(libusb_device_handle* dev_handle, int interface_number);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_attach_kernel_driver(libusb_device_handle* dev_handle, int interface_number);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_set_auto_detach_kernel_driver(libusb_device_handle* dev_handle, int enable);

    [return: NativeTypeName("unsigned char *")]
    public static byte* libusb_control_transfer_get_data([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer)
    {
        return transfer->buffer + (sizeof(libusb_control_setup));
    }

    [return: NativeTypeName("struct libusb_control_setup *")]
    public static libusb_control_setup* libusb_control_transfer_get_setup([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer)
    {
        return (libusb_control_setup*)((void*)(transfer->buffer));
    }

    public static void libusb_fill_control_setup([NativeTypeName("unsigned char *")] byte* buffer, [NativeTypeName("uint8_t")] byte bmRequestType, [NativeTypeName("uint8_t")] byte bRequest, [NativeTypeName("uint16_t")] ushort wValue, [NativeTypeName("uint16_t")] ushort wIndex, [NativeTypeName("uint16_t")] ushort wLength)
    {
        libusb_control_setup* setup = (libusb_control_setup*)((void*)(buffer));

        setup->bmRequestType = bmRequestType;
        setup->bRequest = bRequest;
        setup->wValue = libusb_cpu_to_le16(wValue);
        setup->wIndex = libusb_cpu_to_le16(wIndex);
        setup->wLength = libusb_cpu_to_le16(wLength);
    }

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("struct libusb_transfer *")]
    public static extern libusb_transfer* libusb_alloc_transfer(int iso_packets);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_submit_transfer([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_cancel_transfer([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_transfer([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_transfer_set_stream_id([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer, [NativeTypeName("uint32_t")] uint stream_id);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint libusb_transfer_get_stream_id([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer);

    public static void libusb_fill_control_transfer([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer, libusb_device_handle* dev_handle, [NativeTypeName("unsigned char *")] byte* buffer, [NativeTypeName("libusb_transfer_cb_fn")] IntPtr callback, void* user_data, [NativeTypeName("unsigned int")] uint timeout)
    {
        libusb_control_setup* setup = (libusb_control_setup*)((void*)(buffer));

        transfer->dev_handle = dev_handle;
        transfer->endpoint = 0;
        transfer->type = (byte)(LIBUSB_TRANSFER_TYPE_CONTROL);
        transfer->timeout = timeout;
        transfer->buffer = buffer;
        if (setup)
        {
            transfer->length = (int)(((uint)(sizeof(libusb_control_setup))) + libusb_cpu_to_le16(setup->wLength));
        }

        transfer->user_data = user_data;
        transfer->callback = callback;
    }

    public static void libusb_fill_bulk_transfer([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer, libusb_device_handle* dev_handle, [NativeTypeName("unsigned char")] byte endpoint, [NativeTypeName("unsigned char *")] byte* buffer, int length, [NativeTypeName("libusb_transfer_cb_fn")] IntPtr callback, void* user_data, [NativeTypeName("unsigned int")] uint timeout)
    {
        transfer->dev_handle = dev_handle;
        transfer->endpoint = endpoint;
        transfer->type = (byte)(LIBUSB_TRANSFER_TYPE_BULK);
        transfer->timeout = timeout;
        transfer->buffer = buffer;
        transfer->length = length;
        transfer->user_data = user_data;
        transfer->callback = callback;
    }

    public static void libusb_fill_bulk_stream_transfer([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer, libusb_device_handle* dev_handle, [NativeTypeName("unsigned char")] byte endpoint, [NativeTypeName("uint32_t")] uint stream_id, [NativeTypeName("unsigned char *")] byte* buffer, int length, [NativeTypeName("libusb_transfer_cb_fn")] IntPtr callback, void* user_data, [NativeTypeName("unsigned int")] uint timeout)
    {
        libusb_fill_bulk_transfer(transfer, dev_handle, endpoint, buffer, length, callback, user_data, timeout);
        transfer->type = (byte)(LIBUSB_TRANSFER_TYPE_BULK_STREAM);
        libusb_transfer_set_stream_id(transfer, stream_id);
    }

    public static void libusb_fill_interrupt_transfer([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer, libusb_device_handle* dev_handle, [NativeTypeName("unsigned char")] byte endpoint, [NativeTypeName("unsigned char *")] byte* buffer, int length, [NativeTypeName("libusb_transfer_cb_fn")] IntPtr callback, void* user_data, [NativeTypeName("unsigned int")] uint timeout)
    {
        transfer->dev_handle = dev_handle;
        transfer->endpoint = endpoint;
        transfer->type = (byte)(LIBUSB_TRANSFER_TYPE_INTERRUPT);
        transfer->timeout = timeout;
        transfer->buffer = buffer;
        transfer->length = length;
        transfer->user_data = user_data;
        transfer->callback = callback;
    }

    public static void libusb_fill_iso_transfer([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer, libusb_device_handle* dev_handle, [NativeTypeName("unsigned char")] byte endpoint, [NativeTypeName("unsigned char *")] byte* buffer, int length, int num_iso_packets, [NativeTypeName("libusb_transfer_cb_fn")] IntPtr callback, void* user_data, [NativeTypeName("unsigned int")] uint timeout)
    {
        transfer->dev_handle = dev_handle;
        transfer->endpoint = endpoint;
        transfer->type = (byte)(LIBUSB_TRANSFER_TYPE_ISOCHRONOUS);
        transfer->timeout = timeout;
        transfer->buffer = buffer;
        transfer->length = length;
        transfer->num_iso_packets = num_iso_packets;
        transfer->user_data = user_data;
        transfer->callback = callback;
    }

    public static void libusb_set_iso_packet_lengths([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer, [NativeTypeName("unsigned int")] uint length)
    {
        int i;

        for (i = 0; i < transfer->num_iso_packets; i++)
        {
            transfer->iso_packet_desc[i].length = length;
        }
    }

    [return: NativeTypeName("unsigned char *")]
    public static byte* libusb_get_iso_packet_buffer([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer, [NativeTypeName("unsigned int")] uint packet)
    {
        int i;
        UIntPtr offset = 0;
        int _packet;

        if (packet > 2147483647)
        {
            return null;
        }

        _packet = (int)(packet);
        if (_packet >= transfer->num_iso_packets)
        {
            return null;
        }

        for (i = 0; i < _packet; i++)
        {
            offset += transfer->iso_packet_desc[i].length;
        }

        return transfer->buffer + offset;
    }

    [return: NativeTypeName("unsigned char *")]
    public static byte* libusb_get_iso_packet_buffer_simple([NativeTypeName("struct libusb_transfer *")] libusb_transfer* transfer, [NativeTypeName("unsigned int")] uint packet)
    {
        int _packet;

        if (packet > 2147483647)
        {
            return null;
        }

        _packet = (int)(packet);
        if (_packet >= transfer->num_iso_packets)
        {
            return null;
        }

        return transfer->buffer + unchecked((int)(transfer->iso_packet_desc[0].length) * _packet);
    }

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_control_transfer(libusb_device_handle* dev_handle, [NativeTypeName("uint8_t")] byte request_type, [NativeTypeName("uint8_t")] byte bRequest, [NativeTypeName("uint16_t")] ushort wValue, [NativeTypeName("uint16_t")] ushort wIndex, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("uint16_t")] ushort wLength, [NativeTypeName("unsigned int")] uint timeout);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_bulk_transfer(libusb_device_handle* dev_handle, [NativeTypeName("unsigned char")] byte endpoint, [NativeTypeName("unsigned char *")] byte* data, int length, int* actual_length, [NativeTypeName("unsigned int")] uint timeout);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_interrupt_transfer(libusb_device_handle* dev_handle, [NativeTypeName("unsigned char")] byte endpoint, [NativeTypeName("unsigned char *")] byte* data, int length, int* actual_length, [NativeTypeName("unsigned int")] uint timeout);

    public static int libusb_get_descriptor(libusb_device_handle* dev_handle, [NativeTypeName("uint8_t")] byte desc_type, [NativeTypeName("uint8_t")] byte desc_index, [NativeTypeName("unsigned char *")] byte* data, int length)
    {
        return libusb_control_transfer(dev_handle, (byte)(LIBUSB_ENDPOINT_IN), (byte)(LIBUSB_REQUEST_GET_DESCRIPTOR), unchecked((ushort)((desc_type << 8) | desc_index)), 0, data, unchecked((ushort)(length)), 1000);
    }

    public static int libusb_get_string_descriptor(libusb_device_handle* dev_handle, [NativeTypeName("uint8_t")] byte desc_index, [NativeTypeName("uint16_t")] ushort langid, [NativeTypeName("unsigned char *")] byte* data, int length)
    {
        return libusb_control_transfer(dev_handle, (byte)(LIBUSB_ENDPOINT_IN), (byte)(LIBUSB_REQUEST_GET_DESCRIPTOR), unchecked((ushort)((LIBUSB_DT_STRING << 8) | desc_index)), langid, data, unchecked((ushort)(length)), 1000);
    }

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_string_descriptor_ascii(libusb_device_handle* dev_handle, [NativeTypeName("uint8_t")] byte desc_index, [NativeTypeName("unsigned char *")] byte* data, int length);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_try_lock_events(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_lock_events(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_unlock_events(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_event_handling_ok(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_event_handler_active(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_interrupt_event_handler(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_lock_event_waiters(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_unlock_event_waiters(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_wait_for_event(libusb_context* ctx, [NativeTypeName("struct timeval *")] timeval* tv);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_handle_events_timeout(libusb_context* ctx, [NativeTypeName("struct timeval *")] timeval* tv);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_handle_events_timeout_completed(libusb_context* ctx, [NativeTypeName("struct timeval *")] timeval* tv, int* completed);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_handle_events(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_handle_events_completed(libusb_context* ctx, int* completed);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_handle_events_locked(libusb_context* ctx, [NativeTypeName("struct timeval *")] timeval* tv);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_pollfds_handle_timeouts(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_get_next_timeout(libusb_context* ctx, [NativeTypeName("struct timeval *")] timeval* tv);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const struct libusb_pollfd **")]
    public static extern libusb_pollfd** libusb_get_pollfds(libusb_context* ctx);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_free_pollfds([NativeTypeName("const struct libusb_pollfd **")] libusb_pollfd** pollfds);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_set_pollfd_notifiers(libusb_context* ctx, [NativeTypeName("libusb_pollfd_added_cb")] IntPtr added_cb, [NativeTypeName("libusb_pollfd_removed_cb")] IntPtr removed_cb, void* user_data);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_hotplug_register_callback(libusb_context* ctx, int events, int flags, int vendor_id, int product_id, int dev_class, [NativeTypeName("libusb_hotplug_callback_fn")] IntPtr cb_fn, void* user_data, [NativeTypeName("libusb_hotplug_callback_handle *")] int* callback_handle);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void libusb_hotplug_deregister_callback(libusb_context* ctx, [NativeTypeName("libusb_hotplug_callback_handle")] int callback_handle);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* libusb_hotplug_get_user_data(libusb_context* ctx, [NativeTypeName("libusb_hotplug_callback_handle")] int callback_handle);

    [DllImport("libusb-1.0", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int libusb_set_option(libusb_context* ctx, [NativeTypeName("enum libusb_option")] libusb_option option, __arglist);
}
