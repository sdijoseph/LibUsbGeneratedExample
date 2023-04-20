using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_interface" /> struct.</summary>
public static unsafe partial class libusb_interfaceTests
{
    /// <summary>Validates that the <see cref="libusb_interface" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_interface), Marshal.SizeOf<libusb_interface>());
    }

    /// <summary>Validates that the <see cref="libusb_interface" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_interface).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_interface" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(libusb_interface));
        }
        else
        {
            Assert.Equal(8, sizeof(libusb_interface));
        }
    }
}
