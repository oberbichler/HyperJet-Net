namespace HyperJet;
public static partial class MathD
{
    public static D1Scalar Reciprocal(D1Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D1Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Reciprocal(D2Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D2Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Reciprocal(D3Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D3Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Reciprocal(D4Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D4Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Reciprocal(D5Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D5Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Reciprocal(D6Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D6Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Reciprocal(D7Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D7Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Reciprocal(D8Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D8Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Reciprocal(D9Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D9Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Reciprocal(D10Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D10Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Reciprocal(D11Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D11Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Reciprocal(D12Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;

        return D12Scalar.Forward(constant, da, a);
    }

    public static DD1Scalar Reciprocal(DD1Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Reciprocal(DD2Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Reciprocal(DD3Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Reciprocal(DD4Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Reciprocal(DD5Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Reciprocal(DD6Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Reciprocal(DD7Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Reciprocal(DD8Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Reciprocal(DD9Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Reciprocal(DD10Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Reciprocal(DD11Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Reciprocal(DD12Scalar a)
    {
        var constant = 1 / a.Constant;
        var da = -constant * constant;
        var dada = -2 * constant * da;

        return DD12Scalar.Forward(constant, da, dada, a);
    }
}
