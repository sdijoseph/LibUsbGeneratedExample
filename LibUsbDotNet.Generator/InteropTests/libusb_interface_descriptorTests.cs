using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_interface_descriptor" /> struct.</summary>
public static unsafe partial class libusb_interface_descriptorTests
{
    /// <summary>Validates that the <see cref="libusb_interface_descriptor" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_interface_descriptor), Marshal.SizeOf<libusb_interface_descriptor>());
    }

    /// <summary>Validates that the <see cref="libusb_interface_descriptor" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_interface_descriptor).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_interface_descriptor" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(40, sizeof(libusb_interface_descriptor));
        }
        else
        {
            Assert.Equal(24, sizeof(libusb_interface_descriptor));
        }
    }
}
