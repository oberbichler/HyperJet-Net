namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Sqrt(D1Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D1Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Sqrt(D2Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D2Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Sqrt(D3Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D3Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Sqrt(D4Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D4Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Sqrt(D5Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D5Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Sqrt(D6Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D6Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Sqrt(D7Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D7Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Sqrt(D8Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D8Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Sqrt(D9Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D9Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Sqrt(D10Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D10Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Sqrt(D11Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D11Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Sqrt(D12Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);

        return D12Scalar.Forward(constant, da, a);
    }

    public static DD1Scalar Sqrt(DD1Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Sqrt(DD2Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Sqrt(DD3Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Sqrt(DD4Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Sqrt(DD5Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Sqrt(DD6Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Sqrt(DD7Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Sqrt(DD8Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Sqrt(DD9Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Sqrt(DD10Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Sqrt(DD11Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Sqrt(DD12Scalar a)
    {
        var constant = Math.Sqrt(a.Constant);
        var da = 1 / (2 * constant);
        var dada = -da / (2 * a.Constant);

        return DD12Scalar.Forward(constant, da, dada, a);
    }
}
