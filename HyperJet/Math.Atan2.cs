namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Atan2(double a, D1Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D1Scalar.Forward(constant, db, b);
    }

    public static D1Scalar Atan2(D1Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D1Scalar.Forward(constant, da, a);
    }

    public static D1Scalar Atan2(D1Scalar a, D1Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D1Scalar.Forward(constant, da, db, a, b);
    }

    public static D2Scalar Atan2(double a, D2Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D2Scalar.Forward(constant, db, b);
    }

    public static D2Scalar Atan2(D2Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D2Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Atan2(D2Scalar a, D2Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D2Scalar.Forward(constant, da, db, a, b);
    }

    public static D3Scalar Atan2(double a, D3Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D3Scalar.Forward(constant, db, b);
    }

    public static D3Scalar Atan2(D3Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D3Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Atan2(D3Scalar a, D3Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D3Scalar.Forward(constant, da, db, a, b);
    }

    public static D4Scalar Atan2(double a, D4Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D4Scalar.Forward(constant, db, b);
    }

    public static D4Scalar Atan2(D4Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D4Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Atan2(D4Scalar a, D4Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D4Scalar.Forward(constant, da, db, a, b);
    }

    public static D5Scalar Atan2(double a, D5Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D5Scalar.Forward(constant, db, b);
    }

    public static D5Scalar Atan2(D5Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D5Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Atan2(D5Scalar a, D5Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D5Scalar.Forward(constant, da, db, a, b);
    }

    public static D6Scalar Atan2(double a, D6Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D6Scalar.Forward(constant, db, b);
    }

    public static D6Scalar Atan2(D6Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D6Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Atan2(D6Scalar a, D6Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D6Scalar.Forward(constant, da, db, a, b);
    }

    public static D7Scalar Atan2(double a, D7Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D7Scalar.Forward(constant, db, b);
    }

    public static D7Scalar Atan2(D7Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D7Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Atan2(D7Scalar a, D7Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D7Scalar.Forward(constant, da, db, a, b);
    }

    public static D8Scalar Atan2(double a, D8Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D8Scalar.Forward(constant, db, b);
    }

    public static D8Scalar Atan2(D8Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D8Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Atan2(D8Scalar a, D8Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D8Scalar.Forward(constant, da, db, a, b);
    }

    public static D9Scalar Atan2(double a, D9Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D9Scalar.Forward(constant, db, b);
    }

    public static D9Scalar Atan2(D9Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D9Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Atan2(D9Scalar a, D9Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D9Scalar.Forward(constant, da, db, a, b);
    }

    public static D10Scalar Atan2(double a, D10Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D10Scalar.Forward(constant, db, b);
    }

    public static D10Scalar Atan2(D10Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D10Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Atan2(D10Scalar a, D10Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D10Scalar.Forward(constant, da, db, a, b);
    }

    public static D11Scalar Atan2(double a, D11Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D11Scalar.Forward(constant, db, b);
    }

    public static D11Scalar Atan2(D11Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D11Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Atan2(D11Scalar a, D11Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D11Scalar.Forward(constant, da, db, a, b);
    }

    public static D12Scalar Atan2(double a, D12Scalar b)
    {
        var constant = Math.Atan2(a, b.Constant);
        var db = -a / (a * a + b.Constant * b.Constant);

        return D12Scalar.Forward(constant, db, b);
    }

    public static D12Scalar Atan2(D12Scalar a, double b)
    {
        var constant = Math.Atan2(a.Constant, b);
        var da = b / (a.Constant * a.Constant + b * b);

        return D12Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Atan2(D12Scalar a, D12Scalar b)
    {
        var tmp = a.Constant * a.Constant + b.Constant * b.Constant;

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant / tmp;
        var db = -a.Constant / tmp;

        return D12Scalar.Forward(constant, da, db, a, b);
    }

    public static DD1Scalar Atan2(double a, DD1Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD1Scalar.Forward(constant, db, dbb, b);
    }

    public static DD1Scalar Atan2(DD1Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD1Scalar.Forward(constant, da, daa, a);
    }

    public static DD1Scalar Atan2(DD1Scalar a, DD1Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD1Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD2Scalar Atan2(double a, DD2Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD2Scalar.Forward(constant, db, dbb, b);
    }

    public static DD2Scalar Atan2(DD2Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD2Scalar.Forward(constant, da, daa, a);
    }

    public static DD2Scalar Atan2(DD2Scalar a, DD2Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD2Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD3Scalar Atan2(double a, DD3Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD3Scalar.Forward(constant, db, dbb, b);
    }

    public static DD3Scalar Atan2(DD3Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD3Scalar.Forward(constant, da, daa, a);
    }

    public static DD3Scalar Atan2(DD3Scalar a, DD3Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD3Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD4Scalar Atan2(double a, DD4Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD4Scalar.Forward(constant, db, dbb, b);
    }

    public static DD4Scalar Atan2(DD4Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD4Scalar.Forward(constant, da, daa, a);
    }

    public static DD4Scalar Atan2(DD4Scalar a, DD4Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD4Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD5Scalar Atan2(double a, DD5Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD5Scalar.Forward(constant, db, dbb, b);
    }

    public static DD5Scalar Atan2(DD5Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD5Scalar.Forward(constant, da, daa, a);
    }

    public static DD5Scalar Atan2(DD5Scalar a, DD5Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD5Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD6Scalar Atan2(double a, DD6Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD6Scalar.Forward(constant, db, dbb, b);
    }

    public static DD6Scalar Atan2(DD6Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD6Scalar.Forward(constant, da, daa, a);
    }

    public static DD6Scalar Atan2(DD6Scalar a, DD6Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD6Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD7Scalar Atan2(double a, DD7Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD7Scalar.Forward(constant, db, dbb, b);
    }

    public static DD7Scalar Atan2(DD7Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD7Scalar.Forward(constant, da, daa, a);
    }

    public static DD7Scalar Atan2(DD7Scalar a, DD7Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD7Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD8Scalar Atan2(double a, DD8Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD8Scalar.Forward(constant, db, dbb, b);
    }

    public static DD8Scalar Atan2(DD8Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD8Scalar.Forward(constant, da, daa, a);
    }

    public static DD8Scalar Atan2(DD8Scalar a, DD8Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD8Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD9Scalar Atan2(double a, DD9Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD9Scalar.Forward(constant, db, dbb, b);
    }

    public static DD9Scalar Atan2(DD9Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD9Scalar.Forward(constant, da, daa, a);
    }

    public static DD9Scalar Atan2(DD9Scalar a, DD9Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD9Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD10Scalar Atan2(double a, DD10Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD10Scalar.Forward(constant, db, dbb, b);
    }

    public static DD10Scalar Atan2(DD10Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD10Scalar.Forward(constant, da, daa, a);
    }

    public static DD10Scalar Atan2(DD10Scalar a, DD10Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD10Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD11Scalar Atan2(double a, DD11Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD11Scalar.Forward(constant, db, dbb, b);
    }

    public static DD11Scalar Atan2(DD11Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD11Scalar.Forward(constant, da, daa, a);
    }

    public static DD11Scalar Atan2(DD11Scalar a, DD11Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD11Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }

    public static DD12Scalar Atan2(double a, DD12Scalar b)
    {
        var tmp = 1 / (a * a + b.Constant * b.Constant);

        var constant = Math.Atan2(a, b.Constant);
        var db = -a * tmp;
        var dbb = a * tmp * b.Constant * tmp * 2;

        return DD12Scalar.Forward(constant, db, dbb, b);
    }

    public static DD12Scalar Atan2(DD12Scalar a, double b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b * b);

        var constant = Math.Atan2(a.Constant, b);
        var da = b * tmp;
        var daa = -a.Constant * tmp * da * 2;

        return DD12Scalar.Forward(constant, da, daa, a);
    }

    public static DD12Scalar Atan2(DD12Scalar a, DD12Scalar b)
    {
        var tmp = 1 / (a.Constant * a.Constant + b.Constant * b.Constant);

        var constant = Math.Atan2(a.Constant, b.Constant);
        var da = b.Constant * tmp;
        var db = -a.Constant * tmp;
        var daa = db * da * 2;
        var dab = db * db - da * da;
        var dbb = -daa;

        return DD12Scalar.Forward(constant, da, db, daa, dab, dbb, a, b);
    }
}
