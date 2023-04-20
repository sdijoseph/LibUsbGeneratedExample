using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_ss_usb_device_capability_descriptor" /> struct.</summary>
public static unsafe partial class libusb_ss_usb_device_capability_descriptorTests
{
    /// <summary>Validates that the <see cref="libusb_ss_usb_device_capability_descriptor" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_ss_usb_device_capability_descriptor), Marshal.SizeOf<libusb_ss_usb_device_capability_descriptor>());
    }

    /// <summary>Validates that the <see cref="libusb_ss_usb_device_capability_descriptor" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_ss_usb_device_capability_descriptor).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_ss_usb_device_capability_descriptor" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(10, sizeof(libusb_ss_usb_device_capability_descriptor));
    }
}
