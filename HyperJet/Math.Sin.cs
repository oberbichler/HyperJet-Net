namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Sin(D1Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D1Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Sin(D2Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D2Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Sin(D3Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D3Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Sin(D4Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D4Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Sin(D5Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D5Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Sin(D6Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D6Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Sin(D7Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D7Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Sin(D8Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D8Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Sin(D9Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D9Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Sin(D10Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D10Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Sin(D11Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D11Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Sin(D12Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);

        return D12Scalar.Forward(constant, da, a);
    }

    public static DD1Scalar Sin(DD1Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Sin(DD2Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Sin(DD3Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Sin(DD4Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Sin(DD5Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Sin(DD6Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Sin(DD7Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Sin(DD8Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Sin(DD9Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Sin(DD10Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Sin(DD11Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Sin(DD12Scalar a)
    {
        var constant = Math.Sin(a.Constant);
        var da = Math.Cos(a.Constant);
        var dada = -Math.Sin(a.Constant);

        return DD12Scalar.Forward(constant, da, dada, a);
    }
}
