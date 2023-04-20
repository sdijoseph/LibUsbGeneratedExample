namespace LibUsbDotNet;

public partial struct libusb_pollfd
{
    public int fd;

    public short events;
}
