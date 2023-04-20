using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_interface_association_descriptor" /> struct.</summary>
public static unsafe partial class libusb_interface_association_descriptorTests
{
    /// <summary>Validates that the <see cref="libusb_interface_association_descriptor" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_interface_association_descriptor), Marshal.SizeOf<libusb_interface_association_descriptor>());
    }

    /// <summary>Validates that the <see cref="libusb_interface_association_descriptor" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_interface_association_descriptor).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_interface_association_descriptor" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(8, sizeof(libusb_interface_association_descriptor));
    }
}
