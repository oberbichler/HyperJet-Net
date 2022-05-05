#pragma warning disable IDE0017

namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Multiply(double a, D1Scalar b)
    {
        var db = a;
        var result = new D1Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        return result;
    }

    public static D1Scalar Multiply(D1Scalar a, double b)
    {
        var da = b;
        var result = new D1Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        return result;
    }

    public static D1Scalar Multiply(D1Scalar a, D1Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D1Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        return result;
    }

    public static D2Scalar Multiply(double a, D2Scalar b)
    {
        var db = a;
        var result = new D2Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        return result;
    }

    public static D2Scalar Multiply(D2Scalar a, double b)
    {
        var da = b;
        var result = new D2Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        return result;
    }

    public static D2Scalar Multiply(D2Scalar a, D2Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D2Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        return result;
    }

    public static D3Scalar Multiply(double a, D3Scalar b)
    {
        var db = a;
        var result = new D3Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        return result;
    }

    public static D3Scalar Multiply(D3Scalar a, double b)
    {
        var da = b;
        var result = new D3Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        return result;
    }

    public static D3Scalar Multiply(D3Scalar a, D3Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D3Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        return result;
    }

    public static D4Scalar Multiply(double a, D4Scalar b)
    {
        var db = a;
        var result = new D4Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        return result;
    }

    public static D4Scalar Multiply(D4Scalar a, double b)
    {
        var da = b;
        var result = new D4Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        return result;
    }

    public static D4Scalar Multiply(D4Scalar a, D4Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D4Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        return result;
    }

    public static D5Scalar Multiply(double a, D5Scalar b)
    {
        var db = a;
        var result = new D5Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        return result;
    }

    public static D5Scalar Multiply(D5Scalar a, double b)
    {
        var da = b;
        var result = new D5Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        return result;
    }

    public static D5Scalar Multiply(D5Scalar a, D5Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D5Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        return result;
    }

    public static D6Scalar Multiply(double a, D6Scalar b)
    {
        var db = a;
        var result = new D6Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        return result;
    }

    public static D6Scalar Multiply(D6Scalar a, double b)
    {
        var da = b;
        var result = new D6Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        return result;
    }

    public static D6Scalar Multiply(D6Scalar a, D6Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D6Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        return result;
    }

    public static D7Scalar Multiply(double a, D7Scalar b)
    {
        var db = a;
        var result = new D7Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        return result;
    }

    public static D7Scalar Multiply(D7Scalar a, double b)
    {
        var da = b;
        var result = new D7Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        return result;
    }

    public static D7Scalar Multiply(D7Scalar a, D7Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D7Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        return result;
    }

    public static D8Scalar Multiply(double a, D8Scalar b)
    {
        var db = a;
        var result = new D8Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;
        return result;
    }

    public static D8Scalar Multiply(D8Scalar a, double b)
    {
        var da = b;
        var result = new D8Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        return result;
    }

    public static D8Scalar Multiply(D8Scalar a, D8Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D8Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        return result;
    }

    public static D9Scalar Multiply(double a, D9Scalar b)
    {
        var db = a;
        var result = new D9Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;
        result.D8 = db * b.D8;
        return result;
    }

    public static D9Scalar Multiply(D9Scalar a, double b)
    {
        var da = b;
        var result = new D9Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        return result;
    }

    public static D9Scalar Multiply(D9Scalar a, D9Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D9Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        return result;
    }

    public static D10Scalar Multiply(double a, D10Scalar b)
    {
        var db = a;
        var result = new D10Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;
        result.D8 = db * b.D8;
        result.D9 = db * b.D9;
        return result;
    }

    public static D10Scalar Multiply(D10Scalar a, double b)
    {
        var da = b;
        var result = new D10Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        result.D9 = da * a.D9;
        return result;
    }

    public static D10Scalar Multiply(D10Scalar a, D10Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D10Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        result.D9 = da * a.D9 + db * b.D9;
        return result;
    }

    public static D11Scalar Multiply(double a, D11Scalar b)
    {
        var db = a;
        var result = new D11Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;
        result.D8 = db * b.D8;
        result.D9 = db * b.D9;
        result.D10 = db * b.D10;
        return result;
    }

    public static D11Scalar Multiply(D11Scalar a, double b)
    {
        var da = b;
        var result = new D11Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        result.D9 = da * a.D9;
        result.D10 = da * a.D10;
        return result;
    }

    public static D11Scalar Multiply(D11Scalar a, D11Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D11Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        result.D9 = da * a.D9 + db * b.D9;
        result.D10 = da * a.D10 + db * b.D10;
        return result;
    }

    public static D12Scalar Multiply(double a, D12Scalar b)
    {
        var db = a;
        var result = new D12Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;
        result.D8 = db * b.D8;
        result.D9 = db * b.D9;
        result.D10 = db * b.D10;
        result.D11 = db * b.D11;
        return result;
    }

    public static D12Scalar Multiply(D12Scalar a, double b)
    {
        var da = b;
        var result = new D12Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        result.D9 = da * a.D9;
        result.D10 = da * a.D10;
        result.D11 = da * a.D11;
        return result;
    }

    public static D12Scalar Multiply(D12Scalar a, D12Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new D12Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        result.D9 = da * a.D9 + db * b.D9;
        result.D10 = da * a.D10 + db * b.D10;
        result.D11 = da * a.D11 + db * b.D11;
        return result;
    }

    public static DD1Scalar Multiply(double a, DD1Scalar b)
    {
        var db = a;
        var result = new DD1Scalar(a * b.Constant);
        result.D0 = db * b.D0;

        result.D0D0 = db * b.D0D0;
        return result;
    }

    public static DD1Scalar Multiply(DD1Scalar a, double b)
    {
        var da = b;
        var result = new DD1Scalar(a.Constant * b);
        result.D0 = da * a.D0;

        result.D0D0 = da * a.D0D0;
        return result;
    }

    public static DD1Scalar Multiply(DD1Scalar a, DD1Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD1Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;

        var ca0 = b.D0;
        var cb0 = a.D0;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        return result;
    }

    public static DD2Scalar Multiply(double a, DD2Scalar b)
    {
        var db = a;
        var result = new DD2Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D1D1 = db * b.D1D1;
        return result;
    }

    public static DD2Scalar Multiply(DD2Scalar a, double b)
    {
        var da = b;
        var result = new DD2Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D1D1 = da * a.D1D1;
        return result;
    }

    public static DD2Scalar Multiply(DD2Scalar a, DD2Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD2Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        return result;
    }

    public static DD3Scalar Multiply(double a, DD3Scalar b)
    {
        var db = a;
        var result = new DD3Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D2D2 = db * b.D2D2;
        return result;
    }

    public static DD3Scalar Multiply(DD3Scalar a, double b)
    {
        var da = b;
        var result = new DD3Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D2D2 = da * a.D2D2;
        return result;
    }

    public static DD3Scalar Multiply(DD3Scalar a, DD3Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD3Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        return result;
    }

    public static DD4Scalar Multiply(double a, DD4Scalar b)
    {
        var db = a;
        var result = new DD4Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D0D3 = db * b.D0D3;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D1D3 = db * b.D1D3;
        result.D2D2 = db * b.D2D2;
        result.D2D3 = db * b.D2D3;
        result.D3D3 = db * b.D3D3;
        return result;
    }

    public static DD4Scalar Multiply(DD4Scalar a, double b)
    {
        var da = b;
        var result = new DD4Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D0D3 = da * a.D0D3;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D1D3 = da * a.D1D3;
        result.D2D2 = da * a.D2D2;
        result.D2D3 = da * a.D2D3;
        result.D3D3 = da * a.D3D3;
        return result;
    }

    public static DD4Scalar Multiply(DD4Scalar a, DD4Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD4Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;
        var ca3 = b.D3;
        var cb3 = a.D3;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        return result;
    }

    public static DD5Scalar Multiply(double a, DD5Scalar b)
    {
        var db = a;
        var result = new DD5Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D0D3 = db * b.D0D3;
        result.D0D4 = db * b.D0D4;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D1D3 = db * b.D1D3;
        result.D1D4 = db * b.D1D4;
        result.D2D2 = db * b.D2D2;
        result.D2D3 = db * b.D2D3;
        result.D2D4 = db * b.D2D4;
        result.D3D3 = db * b.D3D3;
        result.D3D4 = db * b.D3D4;
        result.D4D4 = db * b.D4D4;
        return result;
    }

    public static DD5Scalar Multiply(DD5Scalar a, double b)
    {
        var da = b;
        var result = new DD5Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D0D3 = da * a.D0D3;
        result.D0D4 = da * a.D0D4;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D1D3 = da * a.D1D3;
        result.D1D4 = da * a.D1D4;
        result.D2D2 = da * a.D2D2;
        result.D2D3 = da * a.D2D3;
        result.D2D4 = da * a.D2D4;
        result.D3D3 = da * a.D3D3;
        result.D3D4 = da * a.D3D4;
        result.D4D4 = da * a.D4D4;
        return result;
    }

    public static DD5Scalar Multiply(DD5Scalar a, DD5Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD5Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;
        var ca3 = b.D3;
        var cb3 = a.D3;
        var ca4 = b.D4;
        var cb4 = a.D4;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        return result;
    }

    public static DD6Scalar Multiply(double a, DD6Scalar b)
    {
        var db = a;
        var result = new DD6Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D0D3 = db * b.D0D3;
        result.D0D4 = db * b.D0D4;
        result.D0D5 = db * b.D0D5;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D1D3 = db * b.D1D3;
        result.D1D4 = db * b.D1D4;
        result.D1D5 = db * b.D1D5;
        result.D2D2 = db * b.D2D2;
        result.D2D3 = db * b.D2D3;
        result.D2D4 = db * b.D2D4;
        result.D2D5 = db * b.D2D5;
        result.D3D3 = db * b.D3D3;
        result.D3D4 = db * b.D3D4;
        result.D3D5 = db * b.D3D5;
        result.D4D4 = db * b.D4D4;
        result.D4D5 = db * b.D4D5;
        result.D5D5 = db * b.D5D5;
        return result;
    }

    public static DD6Scalar Multiply(DD6Scalar a, double b)
    {
        var da = b;
        var result = new DD6Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D0D3 = da * a.D0D3;
        result.D0D4 = da * a.D0D4;
        result.D0D5 = da * a.D0D5;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D1D3 = da * a.D1D3;
        result.D1D4 = da * a.D1D4;
        result.D1D5 = da * a.D1D5;
        result.D2D2 = da * a.D2D2;
        result.D2D3 = da * a.D2D3;
        result.D2D4 = da * a.D2D4;
        result.D2D5 = da * a.D2D5;
        result.D3D3 = da * a.D3D3;
        result.D3D4 = da * a.D3D4;
        result.D3D5 = da * a.D3D5;
        result.D4D4 = da * a.D4D4;
        result.D4D5 = da * a.D4D5;
        result.D5D5 = da * a.D5D5;
        return result;
    }

    public static DD6Scalar Multiply(DD6Scalar a, DD6Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD6Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;
        var ca3 = b.D3;
        var cb3 = a.D3;
        var ca4 = b.D4;
        var cb4 = a.D4;
        var ca5 = b.D5;
        var cb5 = a.D5;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        return result;
    }

    public static DD7Scalar Multiply(double a, DD7Scalar b)
    {
        var db = a;
        var result = new DD7Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D0D3 = db * b.D0D3;
        result.D0D4 = db * b.D0D4;
        result.D0D5 = db * b.D0D5;
        result.D0D6 = db * b.D0D6;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D1D3 = db * b.D1D3;
        result.D1D4 = db * b.D1D4;
        result.D1D5 = db * b.D1D5;
        result.D1D6 = db * b.D1D6;
        result.D2D2 = db * b.D2D2;
        result.D2D3 = db * b.D2D3;
        result.D2D4 = db * b.D2D4;
        result.D2D5 = db * b.D2D5;
        result.D2D6 = db * b.D2D6;
        result.D3D3 = db * b.D3D3;
        result.D3D4 = db * b.D3D4;
        result.D3D5 = db * b.D3D5;
        result.D3D6 = db * b.D3D6;
        result.D4D4 = db * b.D4D4;
        result.D4D5 = db * b.D4D5;
        result.D4D6 = db * b.D4D6;
        result.D5D5 = db * b.D5D5;
        result.D5D6 = db * b.D5D6;
        result.D6D6 = db * b.D6D6;
        return result;
    }

    public static DD7Scalar Multiply(DD7Scalar a, double b)
    {
        var da = b;
        var result = new DD7Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D0D3 = da * a.D0D3;
        result.D0D4 = da * a.D0D4;
        result.D0D5 = da * a.D0D5;
        result.D0D6 = da * a.D0D6;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D1D3 = da * a.D1D3;
        result.D1D4 = da * a.D1D4;
        result.D1D5 = da * a.D1D5;
        result.D1D6 = da * a.D1D6;
        result.D2D2 = da * a.D2D2;
        result.D2D3 = da * a.D2D3;
        result.D2D4 = da * a.D2D4;
        result.D2D5 = da * a.D2D5;
        result.D2D6 = da * a.D2D6;
        result.D3D3 = da * a.D3D3;
        result.D3D4 = da * a.D3D4;
        result.D3D5 = da * a.D3D5;
        result.D3D6 = da * a.D3D6;
        result.D4D4 = da * a.D4D4;
        result.D4D5 = da * a.D4D5;
        result.D4D6 = da * a.D4D6;
        result.D5D5 = da * a.D5D5;
        result.D5D6 = da * a.D5D6;
        result.D6D6 = da * a.D6D6;
        return result;
    }

    public static DD7Scalar Multiply(DD7Scalar a, DD7Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD7Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;
        var ca3 = b.D3;
        var cb3 = a.D3;
        var ca4 = b.D4;
        var cb4 = a.D4;
        var ca5 = b.D5;
        var cb5 = a.D5;
        var ca6 = b.D6;
        var cb6 = a.D6;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        return result;
    }

    public static DD8Scalar Multiply(double a, DD8Scalar b)
    {
        var db = a;
        var result = new DD8Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D0D3 = db * b.D0D3;
        result.D0D4 = db * b.D0D4;
        result.D0D5 = db * b.D0D5;
        result.D0D6 = db * b.D0D6;
        result.D0D7 = db * b.D0D7;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D1D3 = db * b.D1D3;
        result.D1D4 = db * b.D1D4;
        result.D1D5 = db * b.D1D5;
        result.D1D6 = db * b.D1D6;
        result.D1D7 = db * b.D1D7;
        result.D2D2 = db * b.D2D2;
        result.D2D3 = db * b.D2D3;
        result.D2D4 = db * b.D2D4;
        result.D2D5 = db * b.D2D5;
        result.D2D6 = db * b.D2D6;
        result.D2D7 = db * b.D2D7;
        result.D3D3 = db * b.D3D3;
        result.D3D4 = db * b.D3D4;
        result.D3D5 = db * b.D3D5;
        result.D3D6 = db * b.D3D6;
        result.D3D7 = db * b.D3D7;
        result.D4D4 = db * b.D4D4;
        result.D4D5 = db * b.D4D5;
        result.D4D6 = db * b.D4D6;
        result.D4D7 = db * b.D4D7;
        result.D5D5 = db * b.D5D5;
        result.D5D6 = db * b.D5D6;
        result.D5D7 = db * b.D5D7;
        result.D6D6 = db * b.D6D6;
        result.D6D7 = db * b.D6D7;
        result.D7D7 = db * b.D7D7;
        return result;
    }

    public static DD8Scalar Multiply(DD8Scalar a, double b)
    {
        var da = b;
        var result = new DD8Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D0D3 = da * a.D0D3;
        result.D0D4 = da * a.D0D4;
        result.D0D5 = da * a.D0D5;
        result.D0D6 = da * a.D0D6;
        result.D0D7 = da * a.D0D7;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D1D3 = da * a.D1D3;
        result.D1D4 = da * a.D1D4;
        result.D1D5 = da * a.D1D5;
        result.D1D6 = da * a.D1D6;
        result.D1D7 = da * a.D1D7;
        result.D2D2 = da * a.D2D2;
        result.D2D3 = da * a.D2D3;
        result.D2D4 = da * a.D2D4;
        result.D2D5 = da * a.D2D5;
        result.D2D6 = da * a.D2D6;
        result.D2D7 = da * a.D2D7;
        result.D3D3 = da * a.D3D3;
        result.D3D4 = da * a.D3D4;
        result.D3D5 = da * a.D3D5;
        result.D3D6 = da * a.D3D6;
        result.D3D7 = da * a.D3D7;
        result.D4D4 = da * a.D4D4;
        result.D4D5 = da * a.D4D5;
        result.D4D6 = da * a.D4D6;
        result.D4D7 = da * a.D4D7;
        result.D5D5 = da * a.D5D5;
        result.D5D6 = da * a.D5D6;
        result.D5D7 = da * a.D5D7;
        result.D6D6 = da * a.D6D6;
        result.D6D7 = da * a.D6D7;
        result.D7D7 = da * a.D7D7;
        return result;
    }

    public static DD8Scalar Multiply(DD8Scalar a, DD8Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD8Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;
        var ca3 = b.D3;
        var cb3 = a.D3;
        var ca4 = b.D4;
        var cb4 = a.D4;
        var ca5 = b.D5;
        var cb5 = a.D5;
        var ca6 = b.D6;
        var cb6 = a.D6;
        var ca7 = b.D7;
        var cb7 = a.D7;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;
        return result;
    }

    public static DD9Scalar Multiply(double a, DD9Scalar b)
    {
        var db = a;
        var result = new DD9Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;
        result.D8 = db * b.D8;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D0D3 = db * b.D0D3;
        result.D0D4 = db * b.D0D4;
        result.D0D5 = db * b.D0D5;
        result.D0D6 = db * b.D0D6;
        result.D0D7 = db * b.D0D7;
        result.D0D8 = db * b.D0D8;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D1D3 = db * b.D1D3;
        result.D1D4 = db * b.D1D4;
        result.D1D5 = db * b.D1D5;
        result.D1D6 = db * b.D1D6;
        result.D1D7 = db * b.D1D7;
        result.D1D8 = db * b.D1D8;
        result.D2D2 = db * b.D2D2;
        result.D2D3 = db * b.D2D3;
        result.D2D4 = db * b.D2D4;
        result.D2D5 = db * b.D2D5;
        result.D2D6 = db * b.D2D6;
        result.D2D7 = db * b.D2D7;
        result.D2D8 = db * b.D2D8;
        result.D3D3 = db * b.D3D3;
        result.D3D4 = db * b.D3D4;
        result.D3D5 = db * b.D3D5;
        result.D3D6 = db * b.D3D6;
        result.D3D7 = db * b.D3D7;
        result.D3D8 = db * b.D3D8;
        result.D4D4 = db * b.D4D4;
        result.D4D5 = db * b.D4D5;
        result.D4D6 = db * b.D4D6;
        result.D4D7 = db * b.D4D7;
        result.D4D8 = db * b.D4D8;
        result.D5D5 = db * b.D5D5;
        result.D5D6 = db * b.D5D6;
        result.D5D7 = db * b.D5D7;
        result.D5D8 = db * b.D5D8;
        result.D6D6 = db * b.D6D6;
        result.D6D7 = db * b.D6D7;
        result.D6D8 = db * b.D6D8;
        result.D7D7 = db * b.D7D7;
        result.D7D8 = db * b.D7D8;
        result.D8D8 = db * b.D8D8;
        return result;
    }

    public static DD9Scalar Multiply(DD9Scalar a, double b)
    {
        var da = b;
        var result = new DD9Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D0D3 = da * a.D0D3;
        result.D0D4 = da * a.D0D4;
        result.D0D5 = da * a.D0D5;
        result.D0D6 = da * a.D0D6;
        result.D0D7 = da * a.D0D7;
        result.D0D8 = da * a.D0D8;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D1D3 = da * a.D1D3;
        result.D1D4 = da * a.D1D4;
        result.D1D5 = da * a.D1D5;
        result.D1D6 = da * a.D1D6;
        result.D1D7 = da * a.D1D7;
        result.D1D8 = da * a.D1D8;
        result.D2D2 = da * a.D2D2;
        result.D2D3 = da * a.D2D3;
        result.D2D4 = da * a.D2D4;
        result.D2D5 = da * a.D2D5;
        result.D2D6 = da * a.D2D6;
        result.D2D7 = da * a.D2D7;
        result.D2D8 = da * a.D2D8;
        result.D3D3 = da * a.D3D3;
        result.D3D4 = da * a.D3D4;
        result.D3D5 = da * a.D3D5;
        result.D3D6 = da * a.D3D6;
        result.D3D7 = da * a.D3D7;
        result.D3D8 = da * a.D3D8;
        result.D4D4 = da * a.D4D4;
        result.D4D5 = da * a.D4D5;
        result.D4D6 = da * a.D4D6;
        result.D4D7 = da * a.D4D7;
        result.D4D8 = da * a.D4D8;
        result.D5D5 = da * a.D5D5;
        result.D5D6 = da * a.D5D6;
        result.D5D7 = da * a.D5D7;
        result.D5D8 = da * a.D5D8;
        result.D6D6 = da * a.D6D6;
        result.D6D7 = da * a.D6D7;
        result.D6D8 = da * a.D6D8;
        result.D7D7 = da * a.D7D7;
        result.D7D8 = da * a.D7D8;
        result.D8D8 = da * a.D8D8;
        return result;
    }

    public static DD9Scalar Multiply(DD9Scalar a, DD9Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD9Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;
        var ca3 = b.D3;
        var cb3 = a.D3;
        var ca4 = b.D4;
        var cb4 = a.D4;
        var ca5 = b.D5;
        var cb5 = a.D5;
        var ca6 = b.D6;
        var cb6 = a.D6;
        var ca7 = b.D7;
        var cb7 = a.D7;
        var ca8 = b.D8;
        var cb8 = a.D8;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + ca0 * a.D8 + cb0 * b.D8;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + ca1 * a.D8 + cb1 * b.D8;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + ca2 * a.D8 + cb2 * b.D8;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + ca3 * a.D8 + cb3 * b.D8;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + ca4 * a.D8 + cb4 * b.D8;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + ca5 * a.D8 + cb5 * b.D8;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + ca6 * a.D8 + cb6 * b.D8;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + ca7 * a.D8 + cb7 * b.D8;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + ca8 * a.D8 + cb8 * b.D8;
        return result;
    }

    public static DD10Scalar Multiply(double a, DD10Scalar b)
    {
        var db = a;
        var result = new DD10Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;
        result.D8 = db * b.D8;
        result.D9 = db * b.D9;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D0D3 = db * b.D0D3;
        result.D0D4 = db * b.D0D4;
        result.D0D5 = db * b.D0D5;
        result.D0D6 = db * b.D0D6;
        result.D0D7 = db * b.D0D7;
        result.D0D8 = db * b.D0D8;
        result.D0D9 = db * b.D0D9;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D1D3 = db * b.D1D3;
        result.D1D4 = db * b.D1D4;
        result.D1D5 = db * b.D1D5;
        result.D1D6 = db * b.D1D6;
        result.D1D7 = db * b.D1D7;
        result.D1D8 = db * b.D1D8;
        result.D1D9 = db * b.D1D9;
        result.D2D2 = db * b.D2D2;
        result.D2D3 = db * b.D2D3;
        result.D2D4 = db * b.D2D4;
        result.D2D5 = db * b.D2D5;
        result.D2D6 = db * b.D2D6;
        result.D2D7 = db * b.D2D7;
        result.D2D8 = db * b.D2D8;
        result.D2D9 = db * b.D2D9;
        result.D3D3 = db * b.D3D3;
        result.D3D4 = db * b.D3D4;
        result.D3D5 = db * b.D3D5;
        result.D3D6 = db * b.D3D6;
        result.D3D7 = db * b.D3D7;
        result.D3D8 = db * b.D3D8;
        result.D3D9 = db * b.D3D9;
        result.D4D4 = db * b.D4D4;
        result.D4D5 = db * b.D4D5;
        result.D4D6 = db * b.D4D6;
        result.D4D7 = db * b.D4D7;
        result.D4D8 = db * b.D4D8;
        result.D4D9 = db * b.D4D9;
        result.D5D5 = db * b.D5D5;
        result.D5D6 = db * b.D5D6;
        result.D5D7 = db * b.D5D7;
        result.D5D8 = db * b.D5D8;
        result.D5D9 = db * b.D5D9;
        result.D6D6 = db * b.D6D6;
        result.D6D7 = db * b.D6D7;
        result.D6D8 = db * b.D6D8;
        result.D6D9 = db * b.D6D9;
        result.D7D7 = db * b.D7D7;
        result.D7D8 = db * b.D7D8;
        result.D7D9 = db * b.D7D9;
        result.D8D8 = db * b.D8D8;
        result.D8D9 = db * b.D8D9;
        result.D9D9 = db * b.D9D9;
        return result;
    }

    public static DD10Scalar Multiply(DD10Scalar a, double b)
    {
        var da = b;
        var result = new DD10Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        result.D9 = da * a.D9;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D0D3 = da * a.D0D3;
        result.D0D4 = da * a.D0D4;
        result.D0D5 = da * a.D0D5;
        result.D0D6 = da * a.D0D6;
        result.D0D7 = da * a.D0D7;
        result.D0D8 = da * a.D0D8;
        result.D0D9 = da * a.D0D9;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D1D3 = da * a.D1D3;
        result.D1D4 = da * a.D1D4;
        result.D1D5 = da * a.D1D5;
        result.D1D6 = da * a.D1D6;
        result.D1D7 = da * a.D1D7;
        result.D1D8 = da * a.D1D8;
        result.D1D9 = da * a.D1D9;
        result.D2D2 = da * a.D2D2;
        result.D2D3 = da * a.D2D3;
        result.D2D4 = da * a.D2D4;
        result.D2D5 = da * a.D2D5;
        result.D2D6 = da * a.D2D6;
        result.D2D7 = da * a.D2D7;
        result.D2D8 = da * a.D2D8;
        result.D2D9 = da * a.D2D9;
        result.D3D3 = da * a.D3D3;
        result.D3D4 = da * a.D3D4;
        result.D3D5 = da * a.D3D5;
        result.D3D6 = da * a.D3D6;
        result.D3D7 = da * a.D3D7;
        result.D3D8 = da * a.D3D8;
        result.D3D9 = da * a.D3D9;
        result.D4D4 = da * a.D4D4;
        result.D4D5 = da * a.D4D5;
        result.D4D6 = da * a.D4D6;
        result.D4D7 = da * a.D4D7;
        result.D4D8 = da * a.D4D8;
        result.D4D9 = da * a.D4D9;
        result.D5D5 = da * a.D5D5;
        result.D5D6 = da * a.D5D6;
        result.D5D7 = da * a.D5D7;
        result.D5D8 = da * a.D5D8;
        result.D5D9 = da * a.D5D9;
        result.D6D6 = da * a.D6D6;
        result.D6D7 = da * a.D6D7;
        result.D6D8 = da * a.D6D8;
        result.D6D9 = da * a.D6D9;
        result.D7D7 = da * a.D7D7;
        result.D7D8 = da * a.D7D8;
        result.D7D9 = da * a.D7D9;
        result.D8D8 = da * a.D8D8;
        result.D8D9 = da * a.D8D9;
        result.D9D9 = da * a.D9D9;
        return result;
    }

    public static DD10Scalar Multiply(DD10Scalar a, DD10Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD10Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        result.D9 = da * a.D9 + db * b.D9;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;
        var ca3 = b.D3;
        var cb3 = a.D3;
        var ca4 = b.D4;
        var cb4 = a.D4;
        var ca5 = b.D5;
        var cb5 = a.D5;
        var ca6 = b.D6;
        var cb6 = a.D6;
        var ca7 = b.D7;
        var cb7 = a.D7;
        var ca8 = b.D8;
        var cb8 = a.D8;
        var ca9 = b.D9;
        var cb9 = a.D9;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + ca0 * a.D8 + cb0 * b.D8;
        result.D0D9 = da * a.D0D9 + db * b.D0D9 + ca0 * a.D9 + cb0 * b.D9;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + ca1 * a.D8 + cb1 * b.D8;
        result.D1D9 = da * a.D1D9 + db * b.D1D9 + ca1 * a.D9 + cb1 * b.D9;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + ca2 * a.D8 + cb2 * b.D8;
        result.D2D9 = da * a.D2D9 + db * b.D2D9 + ca2 * a.D9 + cb2 * b.D9;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + ca3 * a.D8 + cb3 * b.D8;
        result.D3D9 = da * a.D3D9 + db * b.D3D9 + ca3 * a.D9 + cb3 * b.D9;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + ca4 * a.D8 + cb4 * b.D8;
        result.D4D9 = da * a.D4D9 + db * b.D4D9 + ca4 * a.D9 + cb4 * b.D9;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + ca5 * a.D8 + cb5 * b.D8;
        result.D5D9 = da * a.D5D9 + db * b.D5D9 + ca5 * a.D9 + cb5 * b.D9;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + ca6 * a.D8 + cb6 * b.D8;
        result.D6D9 = da * a.D6D9 + db * b.D6D9 + ca6 * a.D9 + cb6 * b.D9;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + ca7 * a.D8 + cb7 * b.D8;
        result.D7D9 = da * a.D7D9 + db * b.D7D9 + ca7 * a.D9 + cb7 * b.D9;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + ca8 * a.D8 + cb8 * b.D8;
        result.D8D9 = da * a.D8D9 + db * b.D8D9 + ca8 * a.D9 + cb8 * b.D9;
        result.D9D9 = da * a.D9D9 + db * b.D9D9 + ca9 * a.D9 + cb9 * b.D9;
        return result;
    }

    public static DD11Scalar Multiply(double a, DD11Scalar b)
    {
        var db = a;
        var result = new DD11Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;
        result.D8 = db * b.D8;
        result.D9 = db * b.D9;
        result.D10 = db * b.D10;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D0D3 = db * b.D0D3;
        result.D0D4 = db * b.D0D4;
        result.D0D5 = db * b.D0D5;
        result.D0D6 = db * b.D0D6;
        result.D0D7 = db * b.D0D7;
        result.D0D8 = db * b.D0D8;
        result.D0D9 = db * b.D0D9;
        result.D0D10 = db * b.D0D10;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D1D3 = db * b.D1D3;
        result.D1D4 = db * b.D1D4;
        result.D1D5 = db * b.D1D5;
        result.D1D6 = db * b.D1D6;
        result.D1D7 = db * b.D1D7;
        result.D1D8 = db * b.D1D8;
        result.D1D9 = db * b.D1D9;
        result.D1D10 = db * b.D1D10;
        result.D2D2 = db * b.D2D2;
        result.D2D3 = db * b.D2D3;
        result.D2D4 = db * b.D2D4;
        result.D2D5 = db * b.D2D5;
        result.D2D6 = db * b.D2D6;
        result.D2D7 = db * b.D2D7;
        result.D2D8 = db * b.D2D8;
        result.D2D9 = db * b.D2D9;
        result.D2D10 = db * b.D2D10;
        result.D3D3 = db * b.D3D3;
        result.D3D4 = db * b.D3D4;
        result.D3D5 = db * b.D3D5;
        result.D3D6 = db * b.D3D6;
        result.D3D7 = db * b.D3D7;
        result.D3D8 = db * b.D3D8;
        result.D3D9 = db * b.D3D9;
        result.D3D10 = db * b.D3D10;
        result.D4D4 = db * b.D4D4;
        result.D4D5 = db * b.D4D5;
        result.D4D6 = db * b.D4D6;
        result.D4D7 = db * b.D4D7;
        result.D4D8 = db * b.D4D8;
        result.D4D9 = db * b.D4D9;
        result.D4D10 = db * b.D4D10;
        result.D5D5 = db * b.D5D5;
        result.D5D6 = db * b.D5D6;
        result.D5D7 = db * b.D5D7;
        result.D5D8 = db * b.D5D8;
        result.D5D9 = db * b.D5D9;
        result.D5D10 = db * b.D5D10;
        result.D6D6 = db * b.D6D6;
        result.D6D7 = db * b.D6D7;
        result.D6D8 = db * b.D6D8;
        result.D6D9 = db * b.D6D9;
        result.D6D10 = db * b.D6D10;
        result.D7D7 = db * b.D7D7;
        result.D7D8 = db * b.D7D8;
        result.D7D9 = db * b.D7D9;
        result.D7D10 = db * b.D7D10;
        result.D8D8 = db * b.D8D8;
        result.D8D9 = db * b.D8D9;
        result.D8D10 = db * b.D8D10;
        result.D9D9 = db * b.D9D9;
        result.D9D10 = db * b.D9D10;
        result.D10D10 = db * b.D10D10;
        return result;
    }

    public static DD11Scalar Multiply(DD11Scalar a, double b)
    {
        var da = b;
        var result = new DD11Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        result.D9 = da * a.D9;
        result.D10 = da * a.D10;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D0D3 = da * a.D0D3;
        result.D0D4 = da * a.D0D4;
        result.D0D5 = da * a.D0D5;
        result.D0D6 = da * a.D0D6;
        result.D0D7 = da * a.D0D7;
        result.D0D8 = da * a.D0D8;
        result.D0D9 = da * a.D0D9;
        result.D0D10 = da * a.D0D10;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D1D3 = da * a.D1D3;
        result.D1D4 = da * a.D1D4;
        result.D1D5 = da * a.D1D5;
        result.D1D6 = da * a.D1D6;
        result.D1D7 = da * a.D1D7;
        result.D1D8 = da * a.D1D8;
        result.D1D9 = da * a.D1D9;
        result.D1D10 = da * a.D1D10;
        result.D2D2 = da * a.D2D2;
        result.D2D3 = da * a.D2D3;
        result.D2D4 = da * a.D2D4;
        result.D2D5 = da * a.D2D5;
        result.D2D6 = da * a.D2D6;
        result.D2D7 = da * a.D2D7;
        result.D2D8 = da * a.D2D8;
        result.D2D9 = da * a.D2D9;
        result.D2D10 = da * a.D2D10;
        result.D3D3 = da * a.D3D3;
        result.D3D4 = da * a.D3D4;
        result.D3D5 = da * a.D3D5;
        result.D3D6 = da * a.D3D6;
        result.D3D7 = da * a.D3D7;
        result.D3D8 = da * a.D3D8;
        result.D3D9 = da * a.D3D9;
        result.D3D10 = da * a.D3D10;
        result.D4D4 = da * a.D4D4;
        result.D4D5 = da * a.D4D5;
        result.D4D6 = da * a.D4D6;
        result.D4D7 = da * a.D4D7;
        result.D4D8 = da * a.D4D8;
        result.D4D9 = da * a.D4D9;
        result.D4D10 = da * a.D4D10;
        result.D5D5 = da * a.D5D5;
        result.D5D6 = da * a.D5D6;
        result.D5D7 = da * a.D5D7;
        result.D5D8 = da * a.D5D8;
        result.D5D9 = da * a.D5D9;
        result.D5D10 = da * a.D5D10;
        result.D6D6 = da * a.D6D6;
        result.D6D7 = da * a.D6D7;
        result.D6D8 = da * a.D6D8;
        result.D6D9 = da * a.D6D9;
        result.D6D10 = da * a.D6D10;
        result.D7D7 = da * a.D7D7;
        result.D7D8 = da * a.D7D8;
        result.D7D9 = da * a.D7D9;
        result.D7D10 = da * a.D7D10;
        result.D8D8 = da * a.D8D8;
        result.D8D9 = da * a.D8D9;
        result.D8D10 = da * a.D8D10;
        result.D9D9 = da * a.D9D9;
        result.D9D10 = da * a.D9D10;
        result.D10D10 = da * a.D10D10;
        return result;
    }

    public static DD11Scalar Multiply(DD11Scalar a, DD11Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD11Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        result.D9 = da * a.D9 + db * b.D9;
        result.D10 = da * a.D10 + db * b.D10;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;
        var ca3 = b.D3;
        var cb3 = a.D3;
        var ca4 = b.D4;
        var cb4 = a.D4;
        var ca5 = b.D5;
        var cb5 = a.D5;
        var ca6 = b.D6;
        var cb6 = a.D6;
        var ca7 = b.D7;
        var cb7 = a.D7;
        var ca8 = b.D8;
        var cb8 = a.D8;
        var ca9 = b.D9;
        var cb9 = a.D9;
        var ca10 = b.D10;
        var cb10 = a.D10;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + ca0 * a.D8 + cb0 * b.D8;
        result.D0D9 = da * a.D0D9 + db * b.D0D9 + ca0 * a.D9 + cb0 * b.D9;
        result.D0D10 = da * a.D0D10 + db * b.D0D10 + ca0 * a.D10 + cb0 * b.D10;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + ca1 * a.D8 + cb1 * b.D8;
        result.D1D9 = da * a.D1D9 + db * b.D1D9 + ca1 * a.D9 + cb1 * b.D9;
        result.D1D10 = da * a.D1D10 + db * b.D1D10 + ca1 * a.D10 + cb1 * b.D10;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + ca2 * a.D8 + cb2 * b.D8;
        result.D2D9 = da * a.D2D9 + db * b.D2D9 + ca2 * a.D9 + cb2 * b.D9;
        result.D2D10 = da * a.D2D10 + db * b.D2D10 + ca2 * a.D10 + cb2 * b.D10;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + ca3 * a.D8 + cb3 * b.D8;
        result.D3D9 = da * a.D3D9 + db * b.D3D9 + ca3 * a.D9 + cb3 * b.D9;
        result.D3D10 = da * a.D3D10 + db * b.D3D10 + ca3 * a.D10 + cb3 * b.D10;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + ca4 * a.D8 + cb4 * b.D8;
        result.D4D9 = da * a.D4D9 + db * b.D4D9 + ca4 * a.D9 + cb4 * b.D9;
        result.D4D10 = da * a.D4D10 + db * b.D4D10 + ca4 * a.D10 + cb4 * b.D10;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + ca5 * a.D8 + cb5 * b.D8;
        result.D5D9 = da * a.D5D9 + db * b.D5D9 + ca5 * a.D9 + cb5 * b.D9;
        result.D5D10 = da * a.D5D10 + db * b.D5D10 + ca5 * a.D10 + cb5 * b.D10;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + ca6 * a.D8 + cb6 * b.D8;
        result.D6D9 = da * a.D6D9 + db * b.D6D9 + ca6 * a.D9 + cb6 * b.D9;
        result.D6D10 = da * a.D6D10 + db * b.D6D10 + ca6 * a.D10 + cb6 * b.D10;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + ca7 * a.D8 + cb7 * b.D8;
        result.D7D9 = da * a.D7D9 + db * b.D7D9 + ca7 * a.D9 + cb7 * b.D9;
        result.D7D10 = da * a.D7D10 + db * b.D7D10 + ca7 * a.D10 + cb7 * b.D10;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + ca8 * a.D8 + cb8 * b.D8;
        result.D8D9 = da * a.D8D9 + db * b.D8D9 + ca8 * a.D9 + cb8 * b.D9;
        result.D8D10 = da * a.D8D10 + db * b.D8D10 + ca8 * a.D10 + cb8 * b.D10;
        result.D9D9 = da * a.D9D9 + db * b.D9D9 + ca9 * a.D9 + cb9 * b.D9;
        result.D9D10 = da * a.D9D10 + db * b.D9D10 + ca9 * a.D10 + cb9 * b.D10;
        result.D10D10 = da * a.D10D10 + db * b.D10D10 + ca10 * a.D10 + cb10 * b.D10;
        return result;
    }

    public static DD12Scalar Multiply(double a, DD12Scalar b)
    {
        var db = a;
        var result = new DD12Scalar(a * b.Constant);
        result.D0 = db * b.D0;
        result.D1 = db * b.D1;
        result.D2 = db * b.D2;
        result.D3 = db * b.D3;
        result.D4 = db * b.D4;
        result.D5 = db * b.D5;
        result.D6 = db * b.D6;
        result.D7 = db * b.D7;
        result.D8 = db * b.D8;
        result.D9 = db * b.D9;
        result.D10 = db * b.D10;
        result.D11 = db * b.D11;

        result.D0D0 = db * b.D0D0;
        result.D0D1 = db * b.D0D1;
        result.D0D2 = db * b.D0D2;
        result.D0D3 = db * b.D0D3;
        result.D0D4 = db * b.D0D4;
        result.D0D5 = db * b.D0D5;
        result.D0D6 = db * b.D0D6;
        result.D0D7 = db * b.D0D7;
        result.D0D8 = db * b.D0D8;
        result.D0D9 = db * b.D0D9;
        result.D0D10 = db * b.D0D10;
        result.D0D11 = db * b.D0D11;
        result.D1D1 = db * b.D1D1;
        result.D1D2 = db * b.D1D2;
        result.D1D3 = db * b.D1D3;
        result.D1D4 = db * b.D1D4;
        result.D1D5 = db * b.D1D5;
        result.D1D6 = db * b.D1D6;
        result.D1D7 = db * b.D1D7;
        result.D1D8 = db * b.D1D8;
        result.D1D9 = db * b.D1D9;
        result.D1D10 = db * b.D1D10;
        result.D1D11 = db * b.D1D11;
        result.D2D2 = db * b.D2D2;
        result.D2D3 = db * b.D2D3;
        result.D2D4 = db * b.D2D4;
        result.D2D5 = db * b.D2D5;
        result.D2D6 = db * b.D2D6;
        result.D2D7 = db * b.D2D7;
        result.D2D8 = db * b.D2D8;
        result.D2D9 = db * b.D2D9;
        result.D2D10 = db * b.D2D10;
        result.D2D11 = db * b.D2D11;
        result.D3D3 = db * b.D3D3;
        result.D3D4 = db * b.D3D4;
        result.D3D5 = db * b.D3D5;
        result.D3D6 = db * b.D3D6;
        result.D3D7 = db * b.D3D7;
        result.D3D8 = db * b.D3D8;
        result.D3D9 = db * b.D3D9;
        result.D3D10 = db * b.D3D10;
        result.D3D11 = db * b.D3D11;
        result.D4D4 = db * b.D4D4;
        result.D4D5 = db * b.D4D5;
        result.D4D6 = db * b.D4D6;
        result.D4D7 = db * b.D4D7;
        result.D4D8 = db * b.D4D8;
        result.D4D9 = db * b.D4D9;
        result.D4D10 = db * b.D4D10;
        result.D4D11 = db * b.D4D11;
        result.D5D5 = db * b.D5D5;
        result.D5D6 = db * b.D5D6;
        result.D5D7 = db * b.D5D7;
        result.D5D8 = db * b.D5D8;
        result.D5D9 = db * b.D5D9;
        result.D5D10 = db * b.D5D10;
        result.D5D11 = db * b.D5D11;
        result.D6D6 = db * b.D6D6;
        result.D6D7 = db * b.D6D7;
        result.D6D8 = db * b.D6D8;
        result.D6D9 = db * b.D6D9;
        result.D6D10 = db * b.D6D10;
        result.D6D11 = db * b.D6D11;
        result.D7D7 = db * b.D7D7;
        result.D7D8 = db * b.D7D8;
        result.D7D9 = db * b.D7D9;
        result.D7D10 = db * b.D7D10;
        result.D7D11 = db * b.D7D11;
        result.D8D8 = db * b.D8D8;
        result.D8D9 = db * b.D8D9;
        result.D8D10 = db * b.D8D10;
        result.D8D11 = db * b.D8D11;
        result.D9D9 = db * b.D9D9;
        result.D9D10 = db * b.D9D10;
        result.D9D11 = db * b.D9D11;
        result.D10D10 = db * b.D10D10;
        result.D10D11 = db * b.D10D11;
        result.D11D11 = db * b.D11D11;
        return result;
    }

    public static DD12Scalar Multiply(DD12Scalar a, double b)
    {
        var da = b;
        var result = new DD12Scalar(a.Constant * b);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        result.D9 = da * a.D9;
        result.D10 = da * a.D10;
        result.D11 = da * a.D11;

        result.D0D0 = da * a.D0D0;
        result.D0D1 = da * a.D0D1;
        result.D0D2 = da * a.D0D2;
        result.D0D3 = da * a.D0D3;
        result.D0D4 = da * a.D0D4;
        result.D0D5 = da * a.D0D5;
        result.D0D6 = da * a.D0D6;
        result.D0D7 = da * a.D0D7;
        result.D0D8 = da * a.D0D8;
        result.D0D9 = da * a.D0D9;
        result.D0D10 = da * a.D0D10;
        result.D0D11 = da * a.D0D11;
        result.D1D1 = da * a.D1D1;
        result.D1D2 = da * a.D1D2;
        result.D1D3 = da * a.D1D3;
        result.D1D4 = da * a.D1D4;
        result.D1D5 = da * a.D1D5;
        result.D1D6 = da * a.D1D6;
        result.D1D7 = da * a.D1D7;
        result.D1D8 = da * a.D1D8;
        result.D1D9 = da * a.D1D9;
        result.D1D10 = da * a.D1D10;
        result.D1D11 = da * a.D1D11;
        result.D2D2 = da * a.D2D2;
        result.D2D3 = da * a.D2D3;
        result.D2D4 = da * a.D2D4;
        result.D2D5 = da * a.D2D5;
        result.D2D6 = da * a.D2D6;
        result.D2D7 = da * a.D2D7;
        result.D2D8 = da * a.D2D8;
        result.D2D9 = da * a.D2D9;
        result.D2D10 = da * a.D2D10;
        result.D2D11 = da * a.D2D11;
        result.D3D3 = da * a.D3D3;
        result.D3D4 = da * a.D3D4;
        result.D3D5 = da * a.D3D5;
        result.D3D6 = da * a.D3D6;
        result.D3D7 = da * a.D3D7;
        result.D3D8 = da * a.D3D8;
        result.D3D9 = da * a.D3D9;
        result.D3D10 = da * a.D3D10;
        result.D3D11 = da * a.D3D11;
        result.D4D4 = da * a.D4D4;
        result.D4D5 = da * a.D4D5;
        result.D4D6 = da * a.D4D6;
        result.D4D7 = da * a.D4D7;
        result.D4D8 = da * a.D4D8;
        result.D4D9 = da * a.D4D9;
        result.D4D10 = da * a.D4D10;
        result.D4D11 = da * a.D4D11;
        result.D5D5 = da * a.D5D5;
        result.D5D6 = da * a.D5D6;
        result.D5D7 = da * a.D5D7;
        result.D5D8 = da * a.D5D8;
        result.D5D9 = da * a.D5D9;
        result.D5D10 = da * a.D5D10;
        result.D5D11 = da * a.D5D11;
        result.D6D6 = da * a.D6D6;
        result.D6D7 = da * a.D6D7;
        result.D6D8 = da * a.D6D8;
        result.D6D9 = da * a.D6D9;
        result.D6D10 = da * a.D6D10;
        result.D6D11 = da * a.D6D11;
        result.D7D7 = da * a.D7D7;
        result.D7D8 = da * a.D7D8;
        result.D7D9 = da * a.D7D9;
        result.D7D10 = da * a.D7D10;
        result.D7D11 = da * a.D7D11;
        result.D8D8 = da * a.D8D8;
        result.D8D9 = da * a.D8D9;
        result.D8D10 = da * a.D8D10;
        result.D8D11 = da * a.D8D11;
        result.D9D9 = da * a.D9D9;
        result.D9D10 = da * a.D9D10;
        result.D9D11 = da * a.D9D11;
        result.D10D10 = da * a.D10D10;
        result.D10D11 = da * a.D10D11;
        result.D11D11 = da * a.D11D11;
        return result;
    }

    public static DD12Scalar Multiply(DD12Scalar a, DD12Scalar b)
    {
        var da = b.Constant;
        var db = a.Constant;
        var result = new DD12Scalar(a.Constant * b.Constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        result.D9 = da * a.D9 + db * b.D9;
        result.D10 = da * a.D10 + db * b.D10;
        result.D11 = da * a.D11 + db * b.D11;

        var ca0 = b.D0;
        var cb0 = a.D0;
        var ca1 = b.D1;
        var cb1 = a.D1;
        var ca2 = b.D2;
        var cb2 = a.D2;
        var ca3 = b.D3;
        var cb3 = a.D3;
        var ca4 = b.D4;
        var cb4 = a.D4;
        var ca5 = b.D5;
        var cb5 = a.D5;
        var ca6 = b.D6;
        var cb6 = a.D6;
        var ca7 = b.D7;
        var cb7 = a.D7;
        var ca8 = b.D8;
        var cb8 = a.D8;
        var ca9 = b.D9;
        var cb9 = a.D9;
        var ca10 = b.D10;
        var cb10 = a.D10;
        var ca11 = b.D11;
        var cb11 = a.D11;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + ca0 * a.D8 + cb0 * b.D8;
        result.D0D9 = da * a.D0D9 + db * b.D0D9 + ca0 * a.D9 + cb0 * b.D9;
        result.D0D10 = da * a.D0D10 + db * b.D0D10 + ca0 * a.D10 + cb0 * b.D10;
        result.D0D11 = da * a.D0D11 + db * b.D0D11 + ca0 * a.D11 + cb0 * b.D11;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + ca1 * a.D8 + cb1 * b.D8;
        result.D1D9 = da * a.D1D9 + db * b.D1D9 + ca1 * a.D9 + cb1 * b.D9;
        result.D1D10 = da * a.D1D10 + db * b.D1D10 + ca1 * a.D10 + cb1 * b.D10;
        result.D1D11 = da * a.D1D11 + db * b.D1D11 + ca1 * a.D11 + cb1 * b.D11;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + ca2 * a.D8 + cb2 * b.D8;
        result.D2D9 = da * a.D2D9 + db * b.D2D9 + ca2 * a.D9 + cb2 * b.D9;
        result.D2D10 = da * a.D2D10 + db * b.D2D10 + ca2 * a.D10 + cb2 * b.D10;
        result.D2D11 = da * a.D2D11 + db * b.D2D11 + ca2 * a.D11 + cb2 * b.D11;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + ca3 * a.D8 + cb3 * b.D8;
        result.D3D9 = da * a.D3D9 + db * b.D3D9 + ca3 * a.D9 + cb3 * b.D9;
        result.D3D10 = da * a.D3D10 + db * b.D3D10 + ca3 * a.D10 + cb3 * b.D10;
        result.D3D11 = da * a.D3D11 + db * b.D3D11 + ca3 * a.D11 + cb3 * b.D11;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + ca4 * a.D8 + cb4 * b.D8;
        result.D4D9 = da * a.D4D9 + db * b.D4D9 + ca4 * a.D9 + cb4 * b.D9;
        result.D4D10 = da * a.D4D10 + db * b.D4D10 + ca4 * a.D10 + cb4 * b.D10;
        result.D4D11 = da * a.D4D11 + db * b.D4D11 + ca4 * a.D11 + cb4 * b.D11;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + ca5 * a.D8 + cb5 * b.D8;
        result.D5D9 = da * a.D5D9 + db * b.D5D9 + ca5 * a.D9 + cb5 * b.D9;
        result.D5D10 = da * a.D5D10 + db * b.D5D10 + ca5 * a.D10 + cb5 * b.D10;
        result.D5D11 = da * a.D5D11 + db * b.D5D11 + ca5 * a.D11 + cb5 * b.D11;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + ca6 * a.D8 + cb6 * b.D8;
        result.D6D9 = da * a.D6D9 + db * b.D6D9 + ca6 * a.D9 + cb6 * b.D9;
        result.D6D10 = da * a.D6D10 + db * b.D6D10 + ca6 * a.D10 + cb6 * b.D10;
        result.D6D11 = da * a.D6D11 + db * b.D6D11 + ca6 * a.D11 + cb6 * b.D11;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + ca7 * a.D8 + cb7 * b.D8;
        result.D7D9 = da * a.D7D9 + db * b.D7D9 + ca7 * a.D9 + cb7 * b.D9;
        result.D7D10 = da * a.D7D10 + db * b.D7D10 + ca7 * a.D10 + cb7 * b.D10;
        result.D7D11 = da * a.D7D11 + db * b.D7D11 + ca7 * a.D11 + cb7 * b.D11;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + ca8 * a.D8 + cb8 * b.D8;
        result.D8D9 = da * a.D8D9 + db * b.D8D9 + ca8 * a.D9 + cb8 * b.D9;
        result.D8D10 = da * a.D8D10 + db * b.D8D10 + ca8 * a.D10 + cb8 * b.D10;
        result.D8D11 = da * a.D8D11 + db * b.D8D11 + ca8 * a.D11 + cb8 * b.D11;
        result.D9D9 = da * a.D9D9 + db * b.D9D9 + ca9 * a.D9 + cb9 * b.D9;
        result.D9D10 = da * a.D9D10 + db * b.D9D10 + ca9 * a.D10 + cb9 * b.D10;
        result.D9D11 = da * a.D9D11 + db * b.D9D11 + ca9 * a.D11 + cb9 * b.D11;
        result.D10D10 = da * a.D10D10 + db * b.D10D10 + ca10 * a.D10 + cb10 * b.D10;
        result.D10D11 = da * a.D10D11 + db * b.D10D11 + ca10 * a.D11 + cb10 * b.D11;
        result.D11D11 = da * a.D11D11 + db * b.D11D11 + ca11 * a.D11 + cb11 * b.D11;
        return result;
    }
}
