namespace HyperJet;
public static partial class MathD
{
    public static D1Scalar Penalty(double w, D1Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D1Scalar.Forward(constant, da, a);
    }


    public static D2Scalar Penalty(double w, D2Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D2Scalar.Forward(constant, da, a);
    }


    public static D3Scalar Penalty(double w, D3Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D3Scalar.Forward(constant, da, a);
    }


    public static D4Scalar Penalty(double w, D4Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D4Scalar.Forward(constant, da, a);
    }


    public static D5Scalar Penalty(double w, D5Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D5Scalar.Forward(constant, da, a);
    }


    public static D6Scalar Penalty(double w, D6Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D6Scalar.Forward(constant, da, a);
    }


    public static D7Scalar Penalty(double w, D7Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D7Scalar.Forward(constant, da, a);
    }


    public static D8Scalar Penalty(double w, D8Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D8Scalar.Forward(constant, da, a);
    }


    public static D9Scalar Penalty(double w, D9Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D9Scalar.Forward(constant, da, a);
    }


    public static D10Scalar Penalty(double w, D10Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D10Scalar.Forward(constant, da, a);
    }


    public static D11Scalar Penalty(double w, D11Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D11Scalar.Forward(constant, da, a);
    }


    public static D12Scalar Penalty(double w, D12Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;

        return D12Scalar.Forward(constant, da, a);
    }


    public static DD1Scalar Penalty(double w, DD1Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Penalty(double w, DD2Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Penalty(double w, DD3Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Penalty(double w, DD4Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Penalty(double w, DD5Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Penalty(double w, DD6Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Penalty(double w, DD7Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Penalty(double w, DD8Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Penalty(double w, DD9Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Penalty(double w, DD10Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Penalty(double w, DD11Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Penalty(double w, DD12Scalar a)
    {
        var da = w * a.Constant;
        var constant = 0.5 * da * a.Constant;
        var dada = w;

        return DD12Scalar.Forward(constant, da, dada, a);
    }
}
