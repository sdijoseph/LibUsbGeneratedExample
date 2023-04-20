using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_control_setup" /> struct.</summary>
public static unsafe partial class libusb_control_setupTests
{
    /// <summary>Validates that the <see cref="libusb_control_setup" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_control_setup), Marshal.SizeOf<libusb_control_setup>());
    }

    /// <summary>Validates that the <see cref="libusb_control_setup" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_control_setup).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_control_setup" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(8, sizeof(libusb_control_setup));
    }
}
