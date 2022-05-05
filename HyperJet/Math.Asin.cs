namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Asin(D1Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D1Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Asin(D2Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D2Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Asin(D3Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D3Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Asin(D4Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D4Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Asin(D5Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D5Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Asin(D6Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D6Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Asin(D7Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D7Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Asin(D8Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D8Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Asin(D9Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D9Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Asin(D10Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D10Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Asin(D11Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D11Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Asin(D12Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);

        return D12Scalar.Forward(constant, da, a);
    }

    public static DD1Scalar Asin(DD1Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Asin(DD2Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Asin(DD3Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Asin(DD4Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Asin(DD5Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Asin(DD6Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Asin(DD7Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Asin(DD8Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Asin(DD9Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Asin(DD10Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Asin(DD11Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Asin(DD12Scalar a)
    {
        var tmp = 1 - a.Constant * a.Constant;

        var constant = Math.Asin(a.Constant);
        var da = 1 / Math.Sqrt(tmp);
        var dada = a.Constant / tmp * da;

        return DD12Scalar.Forward(constant, da, dada, a);
    }
}
