using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_context" /> struct.</summary>
public static unsafe partial class libusb_contextTests
{
    /// <summary>Validates that the <see cref="libusb_context" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_context), Marshal.SizeOf<libusb_context>());
    }

    /// <summary>Validates that the <see cref="libusb_context" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_context).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_context" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(libusb_context));
    }
}
