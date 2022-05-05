namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Acos(D1Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D1Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Acos(D2Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D2Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Acos(D3Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D3Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Acos(D4Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D4Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Acos(D5Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D5Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Acos(D6Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D6Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Acos(D7Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D7Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Acos(D8Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D8Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Acos(D9Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D9Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Acos(D10Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D10Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Acos(D11Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D11Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Acos(D12Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);

       return D12Scalar.Forward(constant, da, a);
    }

    public static DD1Scalar Acos(DD1Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Acos(DD2Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Acos(DD3Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Acos(DD4Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Acos(DD5Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Acos(DD6Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Acos(DD7Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Acos(DD8Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Acos(DD9Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Acos(DD10Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Acos(DD11Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Acos(DD12Scalar a)
    {
       var tmp = 1 - a.Constant * a.Constant;

       var constant = Math.Acos(a.Constant);
       var da = -1 / Math.Sqrt(tmp);
       var dada = a.Constant / tmp * da;

       return DD12Scalar.Forward(constant, da, dada, a);
    }
}
