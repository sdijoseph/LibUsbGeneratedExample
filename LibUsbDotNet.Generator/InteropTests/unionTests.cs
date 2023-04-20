using System.Runtime.InteropServices;
using Xunit;

namespace LibUsbDotNet.UnitTests;


/// <summary>Provides validation of the <see cref="NativeMethods.union" /> struct.</summary>
public static unsafe partial class unionTests
{
    /// <summary>Validates that the <see cref="NativeMethods.union" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(NativeMethods.union), Marshal.SizeOf<NativeMethods.union>());
    }

    /// <summary>Validates that the <see cref="NativeMethods.union" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutExplicitTest()
    {
        Assert.True(typeof(NativeMethods.union).IsExplicitLayout);
    }

    /// <summary>Validates that the <see cref="NativeMethods.union" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(2, sizeof(NativeMethods.union));
    }
}
