namespace HyperJet.Tests;

using System;
using System.Diagnostics;
using Xunit.Sdk;

public static class Assertions
{
    /// <summary>
    /// Returns a boolean where two numbers are equal within a tolerance.
    /// </summary>
    /// <param name="a">The actual value.</param>
    /// <param name="b">The expected value.</param>
    /// <param name="rtol">The relative tolerance parameter.</param>
    /// <param name="atol">The absolute tolerance parameter.</param>
    /// <returns>true if <c>a</c> and <c>b</c> are equal within the given tolerance; otherwise, false.</returns>
    [DebuggerHidden]
    public static bool IsClose(double a, double b, double rtol = 1e-5, double atol = 1e-8)
    {
        // Reference: numpy
        // https://github.com/numpy/numpy/blob/05d908a31c0be9db3177a5e2f5a543cbeca7e4f9/numpy/core/numeric.py#L2268-L2389

        return Math.Abs(a - b) <= (atol + rtol * Math.Abs(b));
    }

    [DebuggerHidden]
    public static void AssertAllClose(double[] expected, IScalar actual)
    {
        var data = actual.Data().ToArray();

        if (data.Length != expected.Length)
            throw new AssertActualExpectedException(expected.Length, data.Length, "Data length not matching");

        for (int i = 0; i < data.Length; i++)
        {
            if (IsClose(data[i], expected[i]))
                continue;

            throw new AssertActualExpectedException(expected[i], data[i], $"Values at index {i} not matching");
        }
    }
}
