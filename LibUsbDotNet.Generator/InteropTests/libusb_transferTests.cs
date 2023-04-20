using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_transfer" /> struct.</summary>
public static unsafe partial class libusb_transferTests
{
    /// <summary>Validates that the <see cref="libusb_transfer" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_transfer), Marshal.SizeOf<libusb_transfer>());
    }

    /// <summary>Validates that the <see cref="libusb_transfer" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_transfer).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_transfer" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(72, sizeof(libusb_transfer));
        }
        else
        {
            Assert.Equal(52, sizeof(libusb_transfer));
        }
    }
}
