using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_init_option" /> struct.</summary>
public static unsafe partial class libusb_init_optionTests
{
    /// <summary>Validates that the <see cref="libusb_init_option" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_init_option), Marshal.SizeOf<libusb_init_option>());
    }

    /// <summary>Validates that the <see cref="libusb_init_option" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_init_option).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_init_option" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(libusb_init_option));
        }
        else
        {
            Assert.Equal(8, sizeof(libusb_init_option));
        }
    }
}
