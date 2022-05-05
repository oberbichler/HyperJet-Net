namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Atan(D1Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D1Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Atan(D2Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D2Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Atan(D3Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D3Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Atan(D4Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D4Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Atan(D5Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D5Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Atan(D6Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D6Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Atan(D7Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D7Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Atan(D8Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D8Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Atan(D9Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D9Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Atan(D10Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D10Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Atan(D11Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D11Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Atan(D12Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);

        return D12Scalar.Forward(constant, da, a);
    }

    public static DD1Scalar Atan(DD1Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Atan(DD2Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Atan(DD3Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Atan(DD4Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Atan(DD5Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Atan(DD6Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Atan(DD7Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Atan(DD8Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Atan(DD9Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Atan(DD10Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Atan(DD11Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Atan(DD12Scalar a)
    {
        var constant = Math.Atan(a.Constant);
        var da = 1 / (a.Constant * a.Constant + 1);
        var dada = -2 * a.Constant * da * da;

        return DD12Scalar.Forward(constant, da, dada, a);
    }
}
