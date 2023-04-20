using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_version" /> struct.</summary>
public static unsafe partial class libusb_versionTests
{
    /// <summary>Validates that the <see cref="libusb_version" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_version), Marshal.SizeOf<libusb_version>());
    }

    /// <summary>Validates that the <see cref="libusb_version" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_version).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_version" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(24, sizeof(libusb_version));
        }
        else
        {
            Assert.Equal(16, sizeof(libusb_version));
        }
    }
}
