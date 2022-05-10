namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Cbrt(D1Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D1Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Cbrt(D2Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D2Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Cbrt(D3Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D3Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Cbrt(D4Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D4Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Cbrt(D5Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D5Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Cbrt(D6Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D6Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Cbrt(D7Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D7Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Cbrt(D8Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D8Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Cbrt(D9Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D9Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Cbrt(D10Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D10Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Cbrt(D11Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D11Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Cbrt(D12Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);

        return D12Scalar.Forward(constant, da, a);
    }

    public static DD1Scalar Cbrt(DD1Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Cbrt(DD2Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Cbrt(DD3Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Cbrt(DD4Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Cbrt(DD5Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Cbrt(DD6Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Cbrt(DD7Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Cbrt(DD8Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Cbrt(DD9Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Cbrt(DD10Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Cbrt(DD11Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Cbrt(DD12Scalar a)
    {
#if NETSTANDARD2_1_OR_GREATER
        var constant = Math.Cbrt(a.Constant);
#else
        var constant = Math.Pow(a.Constant, 1.0 / 3.0);
#endif
        var da = 1 / (3 * constant * constant);
        var dada = -da * 2 / (3 * a.Constant);

        return DD12Scalar.Forward(constant, da, dada, a);
    }
}
