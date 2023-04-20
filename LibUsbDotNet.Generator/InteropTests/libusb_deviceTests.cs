using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_device" /> struct.</summary>
public static unsafe partial class libusb_deviceTests
{
    /// <summary>Validates that the <see cref="libusb_device" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_device), Marshal.SizeOf<libusb_device>());
    }

    /// <summary>Validates that the <see cref="libusb_device" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_device).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_device" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(libusb_device));
    }
}
