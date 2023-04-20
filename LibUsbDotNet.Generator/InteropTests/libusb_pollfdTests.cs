using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_pollfd" /> struct.</summary>
public static unsafe partial class libusb_pollfdTests
{
    /// <summary>Validates that the <see cref="libusb_pollfd" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_pollfd), Marshal.SizeOf<libusb_pollfd>());
    }

    /// <summary>Validates that the <see cref="libusb_pollfd" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_pollfd).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_pollfd" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(8, sizeof(libusb_pollfd));
    }
}
