namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Pow(D1Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D1Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Pow(D2Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D2Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Pow(D3Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D3Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Pow(D4Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D4Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Pow(D5Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D5Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Pow(D6Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D6Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Pow(D7Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D7Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Pow(D8Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D8Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Pow(D9Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D9Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Pow(D10Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D10Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Pow(D11Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D11Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Pow(D12Scalar a, double b)
    {
        var tmp = Math.Pow(a.Constant, b - 1);

        var constant = tmp * a.Constant;
        var da = b * tmp;

        return D12Scalar.Forward(constant, da, a);
    }

    public static DD1Scalar Pow(DD1Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Pow(DD2Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Pow(DD3Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Pow(DD4Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Pow(DD5Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Pow(DD6Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Pow(DD7Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Pow(DD8Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Pow(DD9Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Pow(DD10Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Pow(DD11Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Pow(DD12Scalar a, double b)
    {
        // > 2 times faster when precomputing these values
        var tmp1 = Math.Pow(a.Constant, b - 2);
        var tmp2 = tmp1 * a.Constant;

        var constant = tmp2 * a.Constant;
        var da = b * tmp2;
        var dada = b * (b - 1) * tmp1;

        return DD12Scalar.Forward(constant, da, dada, a);
    }
}
