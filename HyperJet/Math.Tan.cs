namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Tan(D1Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D1Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Tan(D2Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D2Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Tan(D3Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D3Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Tan(D4Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D4Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Tan(D5Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D5Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Tan(D6Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D6Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Tan(D7Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D7Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Tan(D8Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D8Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Tan(D9Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D9Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Tan(D10Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D10Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Tan(D11Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D11Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Tan(D12Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;

        return D12Scalar.Forward(constant, da, a);
    }

    public static DD1Scalar Tan(DD1Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Tan(DD2Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Tan(DD3Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Tan(DD4Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Tan(DD5Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Tan(DD6Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Tan(DD7Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Tan(DD8Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Tan(DD9Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Tan(DD10Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Tan(DD11Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Tan(DD12Scalar a)
    {
        var constant = Math.Tan(a.Constant);
        var da = constant * constant + 1;
        var dada = 2 * constant * da;

        return DD12Scalar.Forward(constant, da, dada, a);
    }
}
