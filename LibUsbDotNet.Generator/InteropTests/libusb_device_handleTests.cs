using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_device_handle" /> struct.</summary>
public static unsafe partial class libusb_device_handleTests
{
    /// <summary>Validates that the <see cref="libusb_device_handle" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_device_handle), Marshal.SizeOf<libusb_device_handle>());
    }

    /// <summary>Validates that the <see cref="libusb_device_handle" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_device_handle).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_device_handle" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(libusb_device_handle));
    }
}
