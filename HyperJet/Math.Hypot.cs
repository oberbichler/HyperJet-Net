namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Hypot(double a, D1Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D1Scalar.Forward(constant, db, b);
    }

    public static D1Scalar Hypot(D1Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D1Scalar.Forward(constant, da, a);
    }

    public static D1Scalar Hypot(D1Scalar a, D1Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D1Scalar.Forward(constant, da, db, a, b);
    }

    public static D1Scalar Hypot(double a, D1Scalar b, D1Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D1Scalar.Forward(constant, db, dc, b, c);
    }

    public static D1Scalar Hypot(double a, double b, D1Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D1Scalar.Forward(constant, dc, c);
    }

    public static D1Scalar Hypot(D1Scalar a, D1Scalar b, D1Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D1Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D2Scalar Hypot(double a, D2Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D2Scalar.Forward(constant, db, b);
    }

    public static D2Scalar Hypot(D2Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D2Scalar.Forward(constant, da, a);
    }

    public static D2Scalar Hypot(D2Scalar a, D2Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D2Scalar.Forward(constant, da, db, a, b);
    }

    public static D2Scalar Hypot(double a, D2Scalar b, D2Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D2Scalar.Forward(constant, db, dc, b, c);
    }

    public static D2Scalar Hypot(double a, double b, D2Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D2Scalar.Forward(constant, dc, c);
    }

    public static D2Scalar Hypot(D2Scalar a, D2Scalar b, D2Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D2Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D3Scalar Hypot(double a, D3Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D3Scalar.Forward(constant, db, b);
    }

    public static D3Scalar Hypot(D3Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D3Scalar.Forward(constant, da, a);
    }

    public static D3Scalar Hypot(D3Scalar a, D3Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D3Scalar.Forward(constant, da, db, a, b);
    }

    public static D3Scalar Hypot(double a, D3Scalar b, D3Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D3Scalar.Forward(constant, db, dc, b, c);
    }

    public static D3Scalar Hypot(double a, double b, D3Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D3Scalar.Forward(constant, dc, c);
    }

    public static D3Scalar Hypot(D3Scalar a, D3Scalar b, D3Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D3Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D4Scalar Hypot(double a, D4Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D4Scalar.Forward(constant, db, b);
    }

    public static D4Scalar Hypot(D4Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D4Scalar.Forward(constant, da, a);
    }

    public static D4Scalar Hypot(D4Scalar a, D4Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D4Scalar.Forward(constant, da, db, a, b);
    }

    public static D4Scalar Hypot(double a, D4Scalar b, D4Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D4Scalar.Forward(constant, db, dc, b, c);
    }

    public static D4Scalar Hypot(double a, double b, D4Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D4Scalar.Forward(constant, dc, c);
    }

    public static D4Scalar Hypot(D4Scalar a, D4Scalar b, D4Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D4Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D5Scalar Hypot(double a, D5Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D5Scalar.Forward(constant, db, b);
    }

    public static D5Scalar Hypot(D5Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D5Scalar.Forward(constant, da, a);
    }

    public static D5Scalar Hypot(D5Scalar a, D5Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D5Scalar.Forward(constant, da, db, a, b);
    }

    public static D5Scalar Hypot(double a, D5Scalar b, D5Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D5Scalar.Forward(constant, db, dc, b, c);
    }

    public static D5Scalar Hypot(double a, double b, D5Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D5Scalar.Forward(constant, dc, c);
    }

    public static D5Scalar Hypot(D5Scalar a, D5Scalar b, D5Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D5Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D6Scalar Hypot(double a, D6Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D6Scalar.Forward(constant, db, b);
    }

    public static D6Scalar Hypot(D6Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D6Scalar.Forward(constant, da, a);
    }

    public static D6Scalar Hypot(D6Scalar a, D6Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D6Scalar.Forward(constant, da, db, a, b);
    }

    public static D6Scalar Hypot(double a, D6Scalar b, D6Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D6Scalar.Forward(constant, db, dc, b, c);
    }

    public static D6Scalar Hypot(double a, double b, D6Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D6Scalar.Forward(constant, dc, c);
    }

    public static D6Scalar Hypot(D6Scalar a, D6Scalar b, D6Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D6Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D7Scalar Hypot(double a, D7Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D7Scalar.Forward(constant, db, b);
    }

    public static D7Scalar Hypot(D7Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D7Scalar.Forward(constant, da, a);
    }

    public static D7Scalar Hypot(D7Scalar a, D7Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D7Scalar.Forward(constant, da, db, a, b);
    }

    public static D7Scalar Hypot(double a, D7Scalar b, D7Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D7Scalar.Forward(constant, db, dc, b, c);
    }

    public static D7Scalar Hypot(double a, double b, D7Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D7Scalar.Forward(constant, dc, c);
    }

    public static D7Scalar Hypot(D7Scalar a, D7Scalar b, D7Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D7Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D8Scalar Hypot(double a, D8Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D8Scalar.Forward(constant, db, b);
    }

    public static D8Scalar Hypot(D8Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D8Scalar.Forward(constant, da, a);
    }

    public static D8Scalar Hypot(D8Scalar a, D8Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D8Scalar.Forward(constant, da, db, a, b);
    }

    public static D8Scalar Hypot(double a, D8Scalar b, D8Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D8Scalar.Forward(constant, db, dc, b, c);
    }

    public static D8Scalar Hypot(double a, double b, D8Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D8Scalar.Forward(constant, dc, c);
    }

    public static D8Scalar Hypot(D8Scalar a, D8Scalar b, D8Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D8Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D9Scalar Hypot(double a, D9Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D9Scalar.Forward(constant, db, b);
    }

    public static D9Scalar Hypot(D9Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D9Scalar.Forward(constant, da, a);
    }

    public static D9Scalar Hypot(D9Scalar a, D9Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D9Scalar.Forward(constant, da, db, a, b);
    }

    public static D9Scalar Hypot(double a, D9Scalar b, D9Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D9Scalar.Forward(constant, db, dc, b, c);
    }

    public static D9Scalar Hypot(double a, double b, D9Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D9Scalar.Forward(constant, dc, c);
    }

    public static D9Scalar Hypot(D9Scalar a, D9Scalar b, D9Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D9Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D10Scalar Hypot(double a, D10Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D10Scalar.Forward(constant, db, b);
    }

    public static D10Scalar Hypot(D10Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D10Scalar.Forward(constant, da, a);
    }

    public static D10Scalar Hypot(D10Scalar a, D10Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D10Scalar.Forward(constant, da, db, a, b);
    }

    public static D10Scalar Hypot(double a, D10Scalar b, D10Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D10Scalar.Forward(constant, db, dc, b, c);
    }

    public static D10Scalar Hypot(double a, double b, D10Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D10Scalar.Forward(constant, dc, c);
    }

    public static D10Scalar Hypot(D10Scalar a, D10Scalar b, D10Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D10Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D11Scalar Hypot(double a, D11Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D11Scalar.Forward(constant, db, b);
    }

    public static D11Scalar Hypot(D11Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D11Scalar.Forward(constant, da, a);
    }

    public static D11Scalar Hypot(D11Scalar a, D11Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D11Scalar.Forward(constant, da, db, a, b);
    }

    public static D11Scalar Hypot(double a, D11Scalar b, D11Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D11Scalar.Forward(constant, db, dc, b, c);
    }

    public static D11Scalar Hypot(double a, double b, D11Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D11Scalar.Forward(constant, dc, c);
    }

    public static D11Scalar Hypot(D11Scalar a, D11Scalar b, D11Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D11Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static D12Scalar Hypot(double a, D12Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var db = b.Constant / constant;

        return D12Scalar.Forward(constant, db, b);
    }

    public static D12Scalar Hypot(D12Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var da = a.Constant / constant;

        return D12Scalar.Forward(constant, da, a);
    }

    public static D12Scalar Hypot(D12Scalar a, D12Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;

        return D12Scalar.Forward(constant, da, db, a, b);
    }

    public static D12Scalar Hypot(double a, D12Scalar b, D12Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D12Scalar.Forward(constant, db, dc, b, c);
    }

    public static D12Scalar Hypot(double a, double b, D12Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var dc = c.Constant / constant;

        return D12Scalar.Forward(constant, dc, c);
    }

    public static D12Scalar Hypot(D12Scalar a, D12Scalar b, D12Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;

        return D12Scalar.Forward(constant, da, db, dc, a, b, c);
    }

    public static DD1Scalar Hypot(double a, DD1Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD1Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD1Scalar Hypot(DD1Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD1Scalar.Forward(constant, da, dada, a);
    }

    public static DD1Scalar Hypot(DD1Scalar a, DD1Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD1Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD1Scalar Hypot(double a, DD1Scalar b, DD1Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD1Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD1Scalar Hypot(double a, double b, DD1Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD1Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD1Scalar Hypot(DD1Scalar a, DD1Scalar b, DD1Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD1Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD2Scalar Hypot(double a, DD2Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD2Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD2Scalar Hypot(DD2Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD2Scalar.Forward(constant, da, dada, a);
    }

    public static DD2Scalar Hypot(DD2Scalar a, DD2Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD2Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD2Scalar Hypot(double a, DD2Scalar b, DD2Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD2Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD2Scalar Hypot(double a, double b, DD2Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD2Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD2Scalar Hypot(DD2Scalar a, DD2Scalar b, DD2Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD2Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD3Scalar Hypot(double a, DD3Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD3Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD3Scalar Hypot(DD3Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD3Scalar.Forward(constant, da, dada, a);
    }

    public static DD3Scalar Hypot(DD3Scalar a, DD3Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD3Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD3Scalar Hypot(double a, DD3Scalar b, DD3Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD3Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD3Scalar Hypot(double a, double b, DD3Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD3Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD3Scalar Hypot(DD3Scalar a, DD3Scalar b, DD3Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD3Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD4Scalar Hypot(double a, DD4Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD4Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD4Scalar Hypot(DD4Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD4Scalar.Forward(constant, da, dada, a);
    }

    public static DD4Scalar Hypot(DD4Scalar a, DD4Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD4Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD4Scalar Hypot(double a, DD4Scalar b, DD4Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD4Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD4Scalar Hypot(double a, double b, DD4Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD4Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD4Scalar Hypot(DD4Scalar a, DD4Scalar b, DD4Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD4Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD5Scalar Hypot(double a, DD5Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD5Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD5Scalar Hypot(DD5Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD5Scalar.Forward(constant, da, dada, a);
    }

    public static DD5Scalar Hypot(DD5Scalar a, DD5Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD5Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD5Scalar Hypot(double a, DD5Scalar b, DD5Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD5Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD5Scalar Hypot(double a, double b, DD5Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD5Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD5Scalar Hypot(DD5Scalar a, DD5Scalar b, DD5Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD5Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD6Scalar Hypot(double a, DD6Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD6Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD6Scalar Hypot(DD6Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD6Scalar.Forward(constant, da, dada, a);
    }

    public static DD6Scalar Hypot(DD6Scalar a, DD6Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD6Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD6Scalar Hypot(double a, DD6Scalar b, DD6Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD6Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD6Scalar Hypot(double a, double b, DD6Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD6Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD6Scalar Hypot(DD6Scalar a, DD6Scalar b, DD6Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD6Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD7Scalar Hypot(double a, DD7Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD7Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD7Scalar Hypot(DD7Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD7Scalar.Forward(constant, da, dada, a);
    }

    public static DD7Scalar Hypot(DD7Scalar a, DD7Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD7Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD7Scalar Hypot(double a, DD7Scalar b, DD7Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD7Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD7Scalar Hypot(double a, double b, DD7Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD7Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD7Scalar Hypot(DD7Scalar a, DD7Scalar b, DD7Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD7Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD8Scalar Hypot(double a, DD8Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD8Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD8Scalar Hypot(DD8Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD8Scalar.Forward(constant, da, dada, a);
    }

    public static DD8Scalar Hypot(DD8Scalar a, DD8Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD8Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD8Scalar Hypot(double a, DD8Scalar b, DD8Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD8Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD8Scalar Hypot(double a, double b, DD8Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD8Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD8Scalar Hypot(DD8Scalar a, DD8Scalar b, DD8Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD8Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD9Scalar Hypot(double a, DD9Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD9Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD9Scalar Hypot(DD9Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD9Scalar.Forward(constant, da, dada, a);
    }

    public static DD9Scalar Hypot(DD9Scalar a, DD9Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD9Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD9Scalar Hypot(double a, DD9Scalar b, DD9Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD9Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD9Scalar Hypot(double a, double b, DD9Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD9Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD9Scalar Hypot(DD9Scalar a, DD9Scalar b, DD9Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD9Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD10Scalar Hypot(double a, DD10Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD10Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD10Scalar Hypot(DD10Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD10Scalar.Forward(constant, da, dada, a);
    }

    public static DD10Scalar Hypot(DD10Scalar a, DD10Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD10Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD10Scalar Hypot(double a, DD10Scalar b, DD10Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD10Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD10Scalar Hypot(double a, double b, DD10Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD10Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD10Scalar Hypot(DD10Scalar a, DD10Scalar b, DD10Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD10Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD11Scalar Hypot(double a, DD11Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD11Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD11Scalar Hypot(DD11Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD11Scalar.Forward(constant, da, dada, a);
    }

    public static DD11Scalar Hypot(DD11Scalar a, DD11Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD11Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD11Scalar Hypot(double a, DD11Scalar b, DD11Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD11Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD11Scalar Hypot(double a, double b, DD11Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD11Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD11Scalar Hypot(DD11Scalar a, DD11Scalar b, DD11Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD11Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }

    public static DD12Scalar Hypot(double a, DD12Scalar b)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var db = b.Constant / constant;
        var dbdb = a * a * tmp;

        return DD12Scalar.Forward(constant, db, dbdb, b);
    }

    public static DD12Scalar Hypot(DD12Scalar a, double b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b * b);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var dada = b * b * tmp;

        return DD12Scalar.Forward(constant, da, dada, a);
    }

    public static DD12Scalar Hypot(DD12Scalar a, DD12Scalar b)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant);
        var tmp = 1 / (constant * constant * constant);
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dada = b.Constant * b.Constant * tmp;
        var dadb = -a.Constant * b.Constant * tmp;
        var dbdb = a.Constant * a.Constant * tmp;

        return DD12Scalar.Forward(constant, da, db, dada, dadb, dbdb, a, b);
    }

    public static DD12Scalar Hypot(double a, DD12Scalar b, DD12Scalar c)
    {
        var constant = Math.Sqrt(a * a + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD12Scalar.Forward(constant, db, dc, dbdb, dbdc, dcdc, b, c);
    }

    public static DD12Scalar Hypot(double a, double b, DD12Scalar c)
    {
        var constant = Math.Sqrt(a * a + b * b + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a * a;
        var b2 = b * b;
        var dc = c.Constant / constant;
        var dcdc = (a2 + b2) * tmp;

        return DD12Scalar.Forward(constant, dc, dcdc, c);
    }

    public static DD12Scalar Hypot(DD12Scalar a, DD12Scalar b, DD12Scalar c)
    {
        var constant = Math.Sqrt(a.Constant * a.Constant + b.Constant * b.Constant + c.Constant * c.Constant);
        var tmp = 1 / (constant * constant * constant);
        var a2 = a.Constant * a.Constant;
        var b2 = b.Constant * b.Constant;
        var c2 = c.Constant * c.Constant;
        var da = a.Constant / constant;
        var db = b.Constant / constant;
        var dc = c.Constant / constant;
        var dada = (b2 + c2) * tmp;
        var dadb = -(a.Constant * b.Constant) * tmp;
        var dadc = -(a.Constant * c.Constant) * tmp;
        var dbdb = (a2 + c2) * tmp;
        var dbdc = -(b.Constant * c.Constant) * tmp;
        var dcdc = (a2 + b2) * tmp;

        return DD12Scalar.Forward(constant, da, db, dc, dada, dadb, dadc, dbdb, dbdc, dcdc, a, b, c);
    }
}
