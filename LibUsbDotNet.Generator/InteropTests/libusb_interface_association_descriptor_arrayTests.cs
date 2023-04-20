using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;

/// <summary>Provides validation of the <see cref="libusb_interface_association_descriptor_array" /> struct.</summary>
public static unsafe partial class libusb_interface_association_descriptor_arrayTests
{
    /// <summary>Validates that the <see cref="libusb_interface_association_descriptor_array" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(libusb_interface_association_descriptor_array), Marshal.SizeOf<libusb_interface_association_descriptor_array>());
    }

    /// <summary>Validates that the <see cref="libusb_interface_association_descriptor_array" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(libusb_interface_association_descriptor_array).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="libusb_interface_association_descriptor_array" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(libusb_interface_association_descriptor_array));
        }
        else
        {
            Assert.Equal(8, sizeof(libusb_interface_association_descriptor_array));
        }
    }
}
