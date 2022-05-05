#pragma warning disable IDE0017

namespace HyperJet;

using System;

public static partial class MathD
{
    public static D1Scalar Add(double a, D1Scalar b)
    {
        var result = new D1Scalar(a + b.Constant);
        result.D0 = b.D0;

        return result;
    }

    public static D1Scalar Add(D1Scalar a, double b)
    {
        var result = new D1Scalar(a.Constant + b);
        result.D0 = a.D0;
        return result;
    }

    public static D1Scalar Add(D1Scalar a, D1Scalar b)
    {
        var result = new D1Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        return result;
    }

    public static D2Scalar Add(double a, D2Scalar b)
    {
        var result = new D2Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;

        return result;
    }

    public static D2Scalar Add(D2Scalar a, double b)
    {
        var result = new D2Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        return result;
    }

    public static D2Scalar Add(D2Scalar a, D2Scalar b)
    {
        var result = new D2Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        return result;
    }

    public static D3Scalar Add(double a, D3Scalar b)
    {
        var result = new D3Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;

        return result;
    }

    public static D3Scalar Add(D3Scalar a, double b)
    {
        var result = new D3Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        return result;
    }

    public static D3Scalar Add(D3Scalar a, D3Scalar b)
    {
        var result = new D3Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        return result;
    }

    public static D4Scalar Add(double a, D4Scalar b)
    {
        var result = new D4Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;

        return result;
    }

    public static D4Scalar Add(D4Scalar a, double b)
    {
        var result = new D4Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        return result;
    }

    public static D4Scalar Add(D4Scalar a, D4Scalar b)
    {
        var result = new D4Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        return result;
    }

    public static D5Scalar Add(double a, D5Scalar b)
    {
        var result = new D5Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;

        return result;
    }

    public static D5Scalar Add(D5Scalar a, double b)
    {
        var result = new D5Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        return result;
    }

    public static D5Scalar Add(D5Scalar a, D5Scalar b)
    {
        var result = new D5Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        return result;
    }

    public static D6Scalar Add(double a, D6Scalar b)
    {
        var result = new D6Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;

        return result;
    }

    public static D6Scalar Add(D6Scalar a, double b)
    {
        var result = new D6Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        return result;
    }

    public static D6Scalar Add(D6Scalar a, D6Scalar b)
    {
        var result = new D6Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        return result;
    }

    public static D7Scalar Add(double a, D7Scalar b)
    {
        var result = new D7Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;

        return result;
    }

    public static D7Scalar Add(D7Scalar a, double b)
    {
        var result = new D7Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        return result;
    }

    public static D7Scalar Add(D7Scalar a, D7Scalar b)
    {
        var result = new D7Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        return result;
    }

    public static D8Scalar Add(double a, D8Scalar b)
    {
        var result = new D8Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;

        return result;
    }

    public static D8Scalar Add(D8Scalar a, double b)
    {
        var result = new D8Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        return result;
    }

    public static D8Scalar Add(D8Scalar a, D8Scalar b)
    {
        var result = new D8Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        return result;
    }

    public static D9Scalar Add(double a, D9Scalar b)
    {
        var result = new D9Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;
        result.D8 = b.D8;

        return result;
    }

    public static D9Scalar Add(D9Scalar a, double b)
    {
        var result = new D9Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        result.D8 = a.D8;
        return result;
    }

    public static D9Scalar Add(D9Scalar a, D9Scalar b)
    {
        var result = new D9Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        result.D8 = a.D8 + b.D8;
        return result;
    }

    public static D10Scalar Add(double a, D10Scalar b)
    {
        var result = new D10Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;
        result.D8 = b.D8;
        result.D9 = b.D9;

        return result;
    }

    public static D10Scalar Add(D10Scalar a, double b)
    {
        var result = new D10Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        result.D8 = a.D8;
        result.D9 = a.D9;
        return result;
    }

    public static D10Scalar Add(D10Scalar a, D10Scalar b)
    {
        var result = new D10Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        result.D8 = a.D8 + b.D8;
        result.D9 = a.D9 + b.D9;
        return result;
    }

    public static D11Scalar Add(double a, D11Scalar b)
    {
        var result = new D11Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;
        result.D8 = b.D8;
        result.D9 = b.D9;
        result.D10 = b.D10;

        return result;
    }

    public static D11Scalar Add(D11Scalar a, double b)
    {
        var result = new D11Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        result.D8 = a.D8;
        result.D9 = a.D9;
        result.D10 = a.D10;
        return result;
    }

    public static D11Scalar Add(D11Scalar a, D11Scalar b)
    {
        var result = new D11Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        result.D8 = a.D8 + b.D8;
        result.D9 = a.D9 + b.D9;
        result.D10 = a.D10 + b.D10;
        return result;
    }

    public static D12Scalar Add(double a, D12Scalar b)
    {
        var result = new D12Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;
        result.D8 = b.D8;
        result.D9 = b.D9;
        result.D10 = b.D10;
        result.D11 = b.D11;

        return result;
    }

    public static D12Scalar Add(D12Scalar a, double b)
    {
        var result = new D12Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        result.D8 = a.D8;
        result.D9 = a.D9;
        result.D10 = a.D10;
        result.D11 = a.D11;
        return result;
    }

    public static D12Scalar Add(D12Scalar a, D12Scalar b)
    {
        var result = new D12Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        result.D8 = a.D8 + b.D8;
        result.D9 = a.D9 + b.D9;
        result.D10 = a.D10 + b.D10;
        result.D11 = a.D11 + b.D11;
        return result;
    }

    public static DD1Scalar Add(double a, DD1Scalar b)
    {
        var result = new DD1Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D0D0 = b.D0D0;
        return result;
    }

    public static DD1Scalar Add(DD1Scalar a, double b)
    {
        var result = new DD1Scalar(a.Constant + b);
        result.D0 = a.D0;
        return result;
    }

    public static DD1Scalar Add(DD1Scalar a, DD1Scalar b)
    {
        var result = new DD1Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D0D0 = a.D0D0 + b.D0D0;
        return result;
    }

    public static DD2Scalar Add(double a, DD2Scalar b)
    {
        var result = new DD2Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D1D1 = b.D1D1;
        return result;
    }

    public static DD2Scalar Add(DD2Scalar a, double b)
    {
        var result = new DD2Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        return result;
    }

    public static DD2Scalar Add(DD2Scalar a, DD2Scalar b)
    {
        var result = new DD2Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D1D1 = a.D1D1 + b.D1D1;
        return result;
    }

    public static DD3Scalar Add(double a, DD3Scalar b)
    {
        var result = new DD3Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D2D2 = b.D2D2;
        return result;
    }

    public static DD3Scalar Add(DD3Scalar a, double b)
    {
        var result = new DD3Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        return result;
    }

    public static DD3Scalar Add(DD3Scalar a, DD3Scalar b)
    {
        var result = new DD3Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D2D2 = a.D2D2 + b.D2D2;
        return result;
    }

    public static DD4Scalar Add(double a, DD4Scalar b)
    {
        var result = new DD4Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D0D3 = b.D0D3;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D1D3 = b.D1D3;
        result.D2D2 = b.D2D2;
        result.D2D3 = b.D2D3;
        result.D3D3 = b.D3D3;
        return result;
    }

    public static DD4Scalar Add(DD4Scalar a, double b)
    {
        var result = new DD4Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        return result;
    }

    public static DD4Scalar Add(DD4Scalar a, DD4Scalar b)
    {
        var result = new DD4Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D0D3 = a.D0D3 + b.D0D3;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D1D3 = a.D1D3 + b.D1D3;
        result.D2D2 = a.D2D2 + b.D2D2;
        result.D2D3 = a.D2D3 + b.D2D3;
        result.D3D3 = a.D3D3 + b.D3D3;
        return result;
    }

    public static DD5Scalar Add(double a, DD5Scalar b)
    {
        var result = new DD5Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D0D3 = b.D0D3;
        result.D0D4 = b.D0D4;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D1D3 = b.D1D3;
        result.D1D4 = b.D1D4;
        result.D2D2 = b.D2D2;
        result.D2D3 = b.D2D3;
        result.D2D4 = b.D2D4;
        result.D3D3 = b.D3D3;
        result.D3D4 = b.D3D4;
        result.D4D4 = b.D4D4;
        return result;
    }

    public static DD5Scalar Add(DD5Scalar a, double b)
    {
        var result = new DD5Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        return result;
    }

    public static DD5Scalar Add(DD5Scalar a, DD5Scalar b)
    {
        var result = new DD5Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D0D3 = a.D0D3 + b.D0D3;
        result.D0D4 = a.D0D4 + b.D0D4;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D1D3 = a.D1D3 + b.D1D3;
        result.D1D4 = a.D1D4 + b.D1D4;
        result.D2D2 = a.D2D2 + b.D2D2;
        result.D2D3 = a.D2D3 + b.D2D3;
        result.D2D4 = a.D2D4 + b.D2D4;
        result.D3D3 = a.D3D3 + b.D3D3;
        result.D3D4 = a.D3D4 + b.D3D4;
        result.D4D4 = a.D4D4 + b.D4D4;
        return result;
    }

    public static DD6Scalar Add(double a, DD6Scalar b)
    {
        var result = new DD6Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D0D3 = b.D0D3;
        result.D0D4 = b.D0D4;
        result.D0D5 = b.D0D5;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D1D3 = b.D1D3;
        result.D1D4 = b.D1D4;
        result.D1D5 = b.D1D5;
        result.D2D2 = b.D2D2;
        result.D2D3 = b.D2D3;
        result.D2D4 = b.D2D4;
        result.D2D5 = b.D2D5;
        result.D3D3 = b.D3D3;
        result.D3D4 = b.D3D4;
        result.D3D5 = b.D3D5;
        result.D4D4 = b.D4D4;
        result.D4D5 = b.D4D5;
        result.D5D5 = b.D5D5;
        return result;
    }

    public static DD6Scalar Add(DD6Scalar a, double b)
    {
        var result = new DD6Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        return result;
    }

    public static DD6Scalar Add(DD6Scalar a, DD6Scalar b)
    {
        var result = new DD6Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D0D3 = a.D0D3 + b.D0D3;
        result.D0D4 = a.D0D4 + b.D0D4;
        result.D0D5 = a.D0D5 + b.D0D5;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D1D3 = a.D1D3 + b.D1D3;
        result.D1D4 = a.D1D4 + b.D1D4;
        result.D1D5 = a.D1D5 + b.D1D5;
        result.D2D2 = a.D2D2 + b.D2D2;
        result.D2D3 = a.D2D3 + b.D2D3;
        result.D2D4 = a.D2D4 + b.D2D4;
        result.D2D5 = a.D2D5 + b.D2D5;
        result.D3D3 = a.D3D3 + b.D3D3;
        result.D3D4 = a.D3D4 + b.D3D4;
        result.D3D5 = a.D3D5 + b.D3D5;
        result.D4D4 = a.D4D4 + b.D4D4;
        result.D4D5 = a.D4D5 + b.D4D5;
        result.D5D5 = a.D5D5 + b.D5D5;
        return result;
    }

    public static DD7Scalar Add(double a, DD7Scalar b)
    {
        var result = new DD7Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D0D3 = b.D0D3;
        result.D0D4 = b.D0D4;
        result.D0D5 = b.D0D5;
        result.D0D6 = b.D0D6;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D1D3 = b.D1D3;
        result.D1D4 = b.D1D4;
        result.D1D5 = b.D1D5;
        result.D1D6 = b.D1D6;
        result.D2D2 = b.D2D2;
        result.D2D3 = b.D2D3;
        result.D2D4 = b.D2D4;
        result.D2D5 = b.D2D5;
        result.D2D6 = b.D2D6;
        result.D3D3 = b.D3D3;
        result.D3D4 = b.D3D4;
        result.D3D5 = b.D3D5;
        result.D3D6 = b.D3D6;
        result.D4D4 = b.D4D4;
        result.D4D5 = b.D4D5;
        result.D4D6 = b.D4D6;
        result.D5D5 = b.D5D5;
        result.D5D6 = b.D5D6;
        result.D6D6 = b.D6D6;
        return result;
    }

    public static DD7Scalar Add(DD7Scalar a, double b)
    {
        var result = new DD7Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        return result;
    }

    public static DD7Scalar Add(DD7Scalar a, DD7Scalar b)
    {
        var result = new DD7Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D0D3 = a.D0D3 + b.D0D3;
        result.D0D4 = a.D0D4 + b.D0D4;
        result.D0D5 = a.D0D5 + b.D0D5;
        result.D0D6 = a.D0D6 + b.D0D6;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D1D3 = a.D1D3 + b.D1D3;
        result.D1D4 = a.D1D4 + b.D1D4;
        result.D1D5 = a.D1D5 + b.D1D5;
        result.D1D6 = a.D1D6 + b.D1D6;
        result.D2D2 = a.D2D2 + b.D2D2;
        result.D2D3 = a.D2D3 + b.D2D3;
        result.D2D4 = a.D2D4 + b.D2D4;
        result.D2D5 = a.D2D5 + b.D2D5;
        result.D2D6 = a.D2D6 + b.D2D6;
        result.D3D3 = a.D3D3 + b.D3D3;
        result.D3D4 = a.D3D4 + b.D3D4;
        result.D3D5 = a.D3D5 + b.D3D5;
        result.D3D6 = a.D3D6 + b.D3D6;
        result.D4D4 = a.D4D4 + b.D4D4;
        result.D4D5 = a.D4D5 + b.D4D5;
        result.D4D6 = a.D4D6 + b.D4D6;
        result.D5D5 = a.D5D5 + b.D5D5;
        result.D5D6 = a.D5D6 + b.D5D6;
        result.D6D6 = a.D6D6 + b.D6D6;
        return result;
    }

    public static DD8Scalar Add(double a, DD8Scalar b)
    {
        var result = new DD8Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D0D3 = b.D0D3;
        result.D0D4 = b.D0D4;
        result.D0D5 = b.D0D5;
        result.D0D6 = b.D0D6;
        result.D0D7 = b.D0D7;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D1D3 = b.D1D3;
        result.D1D4 = b.D1D4;
        result.D1D5 = b.D1D5;
        result.D1D6 = b.D1D6;
        result.D1D7 = b.D1D7;
        result.D2D2 = b.D2D2;
        result.D2D3 = b.D2D3;
        result.D2D4 = b.D2D4;
        result.D2D5 = b.D2D5;
        result.D2D6 = b.D2D6;
        result.D2D7 = b.D2D7;
        result.D3D3 = b.D3D3;
        result.D3D4 = b.D3D4;
        result.D3D5 = b.D3D5;
        result.D3D6 = b.D3D6;
        result.D3D7 = b.D3D7;
        result.D4D4 = b.D4D4;
        result.D4D5 = b.D4D5;
        result.D4D6 = b.D4D6;
        result.D4D7 = b.D4D7;
        result.D5D5 = b.D5D5;
        result.D5D6 = b.D5D6;
        result.D5D7 = b.D5D7;
        result.D6D6 = b.D6D6;
        result.D6D7 = b.D6D7;
        result.D7D7 = b.D7D7;
        return result;
    }

    public static DD8Scalar Add(DD8Scalar a, double b)
    {
        var result = new DD8Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        return result;
    }

    public static DD8Scalar Add(DD8Scalar a, DD8Scalar b)
    {
        var result = new DD8Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D0D3 = a.D0D3 + b.D0D3;
        result.D0D4 = a.D0D4 + b.D0D4;
        result.D0D5 = a.D0D5 + b.D0D5;
        result.D0D6 = a.D0D6 + b.D0D6;
        result.D0D7 = a.D0D7 + b.D0D7;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D1D3 = a.D1D3 + b.D1D3;
        result.D1D4 = a.D1D4 + b.D1D4;
        result.D1D5 = a.D1D5 + b.D1D5;
        result.D1D6 = a.D1D6 + b.D1D6;
        result.D1D7 = a.D1D7 + b.D1D7;
        result.D2D2 = a.D2D2 + b.D2D2;
        result.D2D3 = a.D2D3 + b.D2D3;
        result.D2D4 = a.D2D4 + b.D2D4;
        result.D2D5 = a.D2D5 + b.D2D5;
        result.D2D6 = a.D2D6 + b.D2D6;
        result.D2D7 = a.D2D7 + b.D2D7;
        result.D3D3 = a.D3D3 + b.D3D3;
        result.D3D4 = a.D3D4 + b.D3D4;
        result.D3D5 = a.D3D5 + b.D3D5;
        result.D3D6 = a.D3D6 + b.D3D6;
        result.D3D7 = a.D3D7 + b.D3D7;
        result.D4D4 = a.D4D4 + b.D4D4;
        result.D4D5 = a.D4D5 + b.D4D5;
        result.D4D6 = a.D4D6 + b.D4D6;
        result.D4D7 = a.D4D7 + b.D4D7;
        result.D5D5 = a.D5D5 + b.D5D5;
        result.D5D6 = a.D5D6 + b.D5D6;
        result.D5D7 = a.D5D7 + b.D5D7;
        result.D6D6 = a.D6D6 + b.D6D6;
        result.D6D7 = a.D6D7 + b.D6D7;
        result.D7D7 = a.D7D7 + b.D7D7;
        return result;
    }

    public static DD9Scalar Add(double a, DD9Scalar b)
    {
        var result = new DD9Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;
        result.D8 = b.D8;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D0D3 = b.D0D3;
        result.D0D4 = b.D0D4;
        result.D0D5 = b.D0D5;
        result.D0D6 = b.D0D6;
        result.D0D7 = b.D0D7;
        result.D0D8 = b.D0D8;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D1D3 = b.D1D3;
        result.D1D4 = b.D1D4;
        result.D1D5 = b.D1D5;
        result.D1D6 = b.D1D6;
        result.D1D7 = b.D1D7;
        result.D1D8 = b.D1D8;
        result.D2D2 = b.D2D2;
        result.D2D3 = b.D2D3;
        result.D2D4 = b.D2D4;
        result.D2D5 = b.D2D5;
        result.D2D6 = b.D2D6;
        result.D2D7 = b.D2D7;
        result.D2D8 = b.D2D8;
        result.D3D3 = b.D3D3;
        result.D3D4 = b.D3D4;
        result.D3D5 = b.D3D5;
        result.D3D6 = b.D3D6;
        result.D3D7 = b.D3D7;
        result.D3D8 = b.D3D8;
        result.D4D4 = b.D4D4;
        result.D4D5 = b.D4D5;
        result.D4D6 = b.D4D6;
        result.D4D7 = b.D4D7;
        result.D4D8 = b.D4D8;
        result.D5D5 = b.D5D5;
        result.D5D6 = b.D5D6;
        result.D5D7 = b.D5D7;
        result.D5D8 = b.D5D8;
        result.D6D6 = b.D6D6;
        result.D6D7 = b.D6D7;
        result.D6D8 = b.D6D8;
        result.D7D7 = b.D7D7;
        result.D7D8 = b.D7D8;
        result.D8D8 = b.D8D8;
        return result;
    }

    public static DD9Scalar Add(DD9Scalar a, double b)
    {
        var result = new DD9Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        result.D8 = a.D8;
        return result;
    }

    public static DD9Scalar Add(DD9Scalar a, DD9Scalar b)
    {
        var result = new DD9Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        result.D8 = a.D8 + b.D8;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D0D3 = a.D0D3 + b.D0D3;
        result.D0D4 = a.D0D4 + b.D0D4;
        result.D0D5 = a.D0D5 + b.D0D5;
        result.D0D6 = a.D0D6 + b.D0D6;
        result.D0D7 = a.D0D7 + b.D0D7;
        result.D0D8 = a.D0D8 + b.D0D8;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D1D3 = a.D1D3 + b.D1D3;
        result.D1D4 = a.D1D4 + b.D1D4;
        result.D1D5 = a.D1D5 + b.D1D5;
        result.D1D6 = a.D1D6 + b.D1D6;
        result.D1D7 = a.D1D7 + b.D1D7;
        result.D1D8 = a.D1D8 + b.D1D8;
        result.D2D2 = a.D2D2 + b.D2D2;
        result.D2D3 = a.D2D3 + b.D2D3;
        result.D2D4 = a.D2D4 + b.D2D4;
        result.D2D5 = a.D2D5 + b.D2D5;
        result.D2D6 = a.D2D6 + b.D2D6;
        result.D2D7 = a.D2D7 + b.D2D7;
        result.D2D8 = a.D2D8 + b.D2D8;
        result.D3D3 = a.D3D3 + b.D3D3;
        result.D3D4 = a.D3D4 + b.D3D4;
        result.D3D5 = a.D3D5 + b.D3D5;
        result.D3D6 = a.D3D6 + b.D3D6;
        result.D3D7 = a.D3D7 + b.D3D7;
        result.D3D8 = a.D3D8 + b.D3D8;
        result.D4D4 = a.D4D4 + b.D4D4;
        result.D4D5 = a.D4D5 + b.D4D5;
        result.D4D6 = a.D4D6 + b.D4D6;
        result.D4D7 = a.D4D7 + b.D4D7;
        result.D4D8 = a.D4D8 + b.D4D8;
        result.D5D5 = a.D5D5 + b.D5D5;
        result.D5D6 = a.D5D6 + b.D5D6;
        result.D5D7 = a.D5D7 + b.D5D7;
        result.D5D8 = a.D5D8 + b.D5D8;
        result.D6D6 = a.D6D6 + b.D6D6;
        result.D6D7 = a.D6D7 + b.D6D7;
        result.D6D8 = a.D6D8 + b.D6D8;
        result.D7D7 = a.D7D7 + b.D7D7;
        result.D7D8 = a.D7D8 + b.D7D8;
        result.D8D8 = a.D8D8 + b.D8D8;
        return result;
    }

    public static DD10Scalar Add(double a, DD10Scalar b)
    {
        var result = new DD10Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;
        result.D8 = b.D8;
        result.D9 = b.D9;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D0D3 = b.D0D3;
        result.D0D4 = b.D0D4;
        result.D0D5 = b.D0D5;
        result.D0D6 = b.D0D6;
        result.D0D7 = b.D0D7;
        result.D0D8 = b.D0D8;
        result.D0D9 = b.D0D9;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D1D3 = b.D1D3;
        result.D1D4 = b.D1D4;
        result.D1D5 = b.D1D5;
        result.D1D6 = b.D1D6;
        result.D1D7 = b.D1D7;
        result.D1D8 = b.D1D8;
        result.D1D9 = b.D1D9;
        result.D2D2 = b.D2D2;
        result.D2D3 = b.D2D3;
        result.D2D4 = b.D2D4;
        result.D2D5 = b.D2D5;
        result.D2D6 = b.D2D6;
        result.D2D7 = b.D2D7;
        result.D2D8 = b.D2D8;
        result.D2D9 = b.D2D9;
        result.D3D3 = b.D3D3;
        result.D3D4 = b.D3D4;
        result.D3D5 = b.D3D5;
        result.D3D6 = b.D3D6;
        result.D3D7 = b.D3D7;
        result.D3D8 = b.D3D8;
        result.D3D9 = b.D3D9;
        result.D4D4 = b.D4D4;
        result.D4D5 = b.D4D5;
        result.D4D6 = b.D4D6;
        result.D4D7 = b.D4D7;
        result.D4D8 = b.D4D8;
        result.D4D9 = b.D4D9;
        result.D5D5 = b.D5D5;
        result.D5D6 = b.D5D6;
        result.D5D7 = b.D5D7;
        result.D5D8 = b.D5D8;
        result.D5D9 = b.D5D9;
        result.D6D6 = b.D6D6;
        result.D6D7 = b.D6D7;
        result.D6D8 = b.D6D8;
        result.D6D9 = b.D6D9;
        result.D7D7 = b.D7D7;
        result.D7D8 = b.D7D8;
        result.D7D9 = b.D7D9;
        result.D8D8 = b.D8D8;
        result.D8D9 = b.D8D9;
        result.D9D9 = b.D9D9;
        return result;
    }

    public static DD10Scalar Add(DD10Scalar a, double b)
    {
        var result = new DD10Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        result.D8 = a.D8;
        result.D9 = a.D9;
        return result;
    }

    public static DD10Scalar Add(DD10Scalar a, DD10Scalar b)
    {
        var result = new DD10Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        result.D8 = a.D8 + b.D8;
        result.D9 = a.D9 + b.D9;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D0D3 = a.D0D3 + b.D0D3;
        result.D0D4 = a.D0D4 + b.D0D4;
        result.D0D5 = a.D0D5 + b.D0D5;
        result.D0D6 = a.D0D6 + b.D0D6;
        result.D0D7 = a.D0D7 + b.D0D7;
        result.D0D8 = a.D0D8 + b.D0D8;
        result.D0D9 = a.D0D9 + b.D0D9;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D1D3 = a.D1D3 + b.D1D3;
        result.D1D4 = a.D1D4 + b.D1D4;
        result.D1D5 = a.D1D5 + b.D1D5;
        result.D1D6 = a.D1D6 + b.D1D6;
        result.D1D7 = a.D1D7 + b.D1D7;
        result.D1D8 = a.D1D8 + b.D1D8;
        result.D1D9 = a.D1D9 + b.D1D9;
        result.D2D2 = a.D2D2 + b.D2D2;
        result.D2D3 = a.D2D3 + b.D2D3;
        result.D2D4 = a.D2D4 + b.D2D4;
        result.D2D5 = a.D2D5 + b.D2D5;
        result.D2D6 = a.D2D6 + b.D2D6;
        result.D2D7 = a.D2D7 + b.D2D7;
        result.D2D8 = a.D2D8 + b.D2D8;
        result.D2D9 = a.D2D9 + b.D2D9;
        result.D3D3 = a.D3D3 + b.D3D3;
        result.D3D4 = a.D3D4 + b.D3D4;
        result.D3D5 = a.D3D5 + b.D3D5;
        result.D3D6 = a.D3D6 + b.D3D6;
        result.D3D7 = a.D3D7 + b.D3D7;
        result.D3D8 = a.D3D8 + b.D3D8;
        result.D3D9 = a.D3D9 + b.D3D9;
        result.D4D4 = a.D4D4 + b.D4D4;
        result.D4D5 = a.D4D5 + b.D4D5;
        result.D4D6 = a.D4D6 + b.D4D6;
        result.D4D7 = a.D4D7 + b.D4D7;
        result.D4D8 = a.D4D8 + b.D4D8;
        result.D4D9 = a.D4D9 + b.D4D9;
        result.D5D5 = a.D5D5 + b.D5D5;
        result.D5D6 = a.D5D6 + b.D5D6;
        result.D5D7 = a.D5D7 + b.D5D7;
        result.D5D8 = a.D5D8 + b.D5D8;
        result.D5D9 = a.D5D9 + b.D5D9;
        result.D6D6 = a.D6D6 + b.D6D6;
        result.D6D7 = a.D6D7 + b.D6D7;
        result.D6D8 = a.D6D8 + b.D6D8;
        result.D6D9 = a.D6D9 + b.D6D9;
        result.D7D7 = a.D7D7 + b.D7D7;
        result.D7D8 = a.D7D8 + b.D7D8;
        result.D7D9 = a.D7D9 + b.D7D9;
        result.D8D8 = a.D8D8 + b.D8D8;
        result.D8D9 = a.D8D9 + b.D8D9;
        result.D9D9 = a.D9D9 + b.D9D9;
        return result;
    }

    public static DD11Scalar Add(double a, DD11Scalar b)
    {
        var result = new DD11Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;
        result.D8 = b.D8;
        result.D9 = b.D9;
        result.D10 = b.D10;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D0D3 = b.D0D3;
        result.D0D4 = b.D0D4;
        result.D0D5 = b.D0D5;
        result.D0D6 = b.D0D6;
        result.D0D7 = b.D0D7;
        result.D0D8 = b.D0D8;
        result.D0D9 = b.D0D9;
        result.D0D10 = b.D0D10;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D1D3 = b.D1D3;
        result.D1D4 = b.D1D4;
        result.D1D5 = b.D1D5;
        result.D1D6 = b.D1D6;
        result.D1D7 = b.D1D7;
        result.D1D8 = b.D1D8;
        result.D1D9 = b.D1D9;
        result.D1D10 = b.D1D10;
        result.D2D2 = b.D2D2;
        result.D2D3 = b.D2D3;
        result.D2D4 = b.D2D4;
        result.D2D5 = b.D2D5;
        result.D2D6 = b.D2D6;
        result.D2D7 = b.D2D7;
        result.D2D8 = b.D2D8;
        result.D2D9 = b.D2D9;
        result.D2D10 = b.D2D10;
        result.D3D3 = b.D3D3;
        result.D3D4 = b.D3D4;
        result.D3D5 = b.D3D5;
        result.D3D6 = b.D3D6;
        result.D3D7 = b.D3D7;
        result.D3D8 = b.D3D8;
        result.D3D9 = b.D3D9;
        result.D3D10 = b.D3D10;
        result.D4D4 = b.D4D4;
        result.D4D5 = b.D4D5;
        result.D4D6 = b.D4D6;
        result.D4D7 = b.D4D7;
        result.D4D8 = b.D4D8;
        result.D4D9 = b.D4D9;
        result.D4D10 = b.D4D10;
        result.D5D5 = b.D5D5;
        result.D5D6 = b.D5D6;
        result.D5D7 = b.D5D7;
        result.D5D8 = b.D5D8;
        result.D5D9 = b.D5D9;
        result.D5D10 = b.D5D10;
        result.D6D6 = b.D6D6;
        result.D6D7 = b.D6D7;
        result.D6D8 = b.D6D8;
        result.D6D9 = b.D6D9;
        result.D6D10 = b.D6D10;
        result.D7D7 = b.D7D7;
        result.D7D8 = b.D7D8;
        result.D7D9 = b.D7D9;
        result.D7D10 = b.D7D10;
        result.D8D8 = b.D8D8;
        result.D8D9 = b.D8D9;
        result.D8D10 = b.D8D10;
        result.D9D9 = b.D9D9;
        result.D9D10 = b.D9D10;
        result.D10D10 = b.D10D10;
        return result;
    }

    public static DD11Scalar Add(DD11Scalar a, double b)
    {
        var result = new DD11Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        result.D8 = a.D8;
        result.D9 = a.D9;
        result.D10 = a.D10;
        return result;
    }

    public static DD11Scalar Add(DD11Scalar a, DD11Scalar b)
    {
        var result = new DD11Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        result.D8 = a.D8 + b.D8;
        result.D9 = a.D9 + b.D9;
        result.D10 = a.D10 + b.D10;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D0D3 = a.D0D3 + b.D0D3;
        result.D0D4 = a.D0D4 + b.D0D4;
        result.D0D5 = a.D0D5 + b.D0D5;
        result.D0D6 = a.D0D6 + b.D0D6;
        result.D0D7 = a.D0D7 + b.D0D7;
        result.D0D8 = a.D0D8 + b.D0D8;
        result.D0D9 = a.D0D9 + b.D0D9;
        result.D0D10 = a.D0D10 + b.D0D10;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D1D3 = a.D1D3 + b.D1D3;
        result.D1D4 = a.D1D4 + b.D1D4;
        result.D1D5 = a.D1D5 + b.D1D5;
        result.D1D6 = a.D1D6 + b.D1D6;
        result.D1D7 = a.D1D7 + b.D1D7;
        result.D1D8 = a.D1D8 + b.D1D8;
        result.D1D9 = a.D1D9 + b.D1D9;
        result.D1D10 = a.D1D10 + b.D1D10;
        result.D2D2 = a.D2D2 + b.D2D2;
        result.D2D3 = a.D2D3 + b.D2D3;
        result.D2D4 = a.D2D4 + b.D2D4;
        result.D2D5 = a.D2D5 + b.D2D5;
        result.D2D6 = a.D2D6 + b.D2D6;
        result.D2D7 = a.D2D7 + b.D2D7;
        result.D2D8 = a.D2D8 + b.D2D8;
        result.D2D9 = a.D2D9 + b.D2D9;
        result.D2D10 = a.D2D10 + b.D2D10;
        result.D3D3 = a.D3D3 + b.D3D3;
        result.D3D4 = a.D3D4 + b.D3D4;
        result.D3D5 = a.D3D5 + b.D3D5;
        result.D3D6 = a.D3D6 + b.D3D6;
        result.D3D7 = a.D3D7 + b.D3D7;
        result.D3D8 = a.D3D8 + b.D3D8;
        result.D3D9 = a.D3D9 + b.D3D9;
        result.D3D10 = a.D3D10 + b.D3D10;
        result.D4D4 = a.D4D4 + b.D4D4;
        result.D4D5 = a.D4D5 + b.D4D5;
        result.D4D6 = a.D4D6 + b.D4D6;
        result.D4D7 = a.D4D7 + b.D4D7;
        result.D4D8 = a.D4D8 + b.D4D8;
        result.D4D9 = a.D4D9 + b.D4D9;
        result.D4D10 = a.D4D10 + b.D4D10;
        result.D5D5 = a.D5D5 + b.D5D5;
        result.D5D6 = a.D5D6 + b.D5D6;
        result.D5D7 = a.D5D7 + b.D5D7;
        result.D5D8 = a.D5D8 + b.D5D8;
        result.D5D9 = a.D5D9 + b.D5D9;
        result.D5D10 = a.D5D10 + b.D5D10;
        result.D6D6 = a.D6D6 + b.D6D6;
        result.D6D7 = a.D6D7 + b.D6D7;
        result.D6D8 = a.D6D8 + b.D6D8;
        result.D6D9 = a.D6D9 + b.D6D9;
        result.D6D10 = a.D6D10 + b.D6D10;
        result.D7D7 = a.D7D7 + b.D7D7;
        result.D7D8 = a.D7D8 + b.D7D8;
        result.D7D9 = a.D7D9 + b.D7D9;
        result.D7D10 = a.D7D10 + b.D7D10;
        result.D8D8 = a.D8D8 + b.D8D8;
        result.D8D9 = a.D8D9 + b.D8D9;
        result.D8D10 = a.D8D10 + b.D8D10;
        result.D9D9 = a.D9D9 + b.D9D9;
        result.D9D10 = a.D9D10 + b.D9D10;
        result.D10D10 = a.D10D10 + b.D10D10;
        return result;
    }

    public static DD12Scalar Add(double a, DD12Scalar b)
    {
        var result = new DD12Scalar(a + b.Constant);
        result.D0 = b.D0;
        result.D1 = b.D1;
        result.D2 = b.D2;
        result.D3 = b.D3;
        result.D4 = b.D4;
        result.D5 = b.D5;
        result.D6 = b.D6;
        result.D7 = b.D7;
        result.D8 = b.D8;
        result.D9 = b.D9;
        result.D10 = b.D10;
        result.D11 = b.D11;
        result.D0D0 = b.D0D0;
        result.D0D1 = b.D0D1;
        result.D0D2 = b.D0D2;
        result.D0D3 = b.D0D3;
        result.D0D4 = b.D0D4;
        result.D0D5 = b.D0D5;
        result.D0D6 = b.D0D6;
        result.D0D7 = b.D0D7;
        result.D0D8 = b.D0D8;
        result.D0D9 = b.D0D9;
        result.D0D10 = b.D0D10;
        result.D0D11 = b.D0D11;
        result.D1D1 = b.D1D1;
        result.D1D2 = b.D1D2;
        result.D1D3 = b.D1D3;
        result.D1D4 = b.D1D4;
        result.D1D5 = b.D1D5;
        result.D1D6 = b.D1D6;
        result.D1D7 = b.D1D7;
        result.D1D8 = b.D1D8;
        result.D1D9 = b.D1D9;
        result.D1D10 = b.D1D10;
        result.D1D11 = b.D1D11;
        result.D2D2 = b.D2D2;
        result.D2D3 = b.D2D3;
        result.D2D4 = b.D2D4;
        result.D2D5 = b.D2D5;
        result.D2D6 = b.D2D6;
        result.D2D7 = b.D2D7;
        result.D2D8 = b.D2D8;
        result.D2D9 = b.D2D9;
        result.D2D10 = b.D2D10;
        result.D2D11 = b.D2D11;
        result.D3D3 = b.D3D3;
        result.D3D4 = b.D3D4;
        result.D3D5 = b.D3D5;
        result.D3D6 = b.D3D6;
        result.D3D7 = b.D3D7;
        result.D3D8 = b.D3D8;
        result.D3D9 = b.D3D9;
        result.D3D10 = b.D3D10;
        result.D3D11 = b.D3D11;
        result.D4D4 = b.D4D4;
        result.D4D5 = b.D4D5;
        result.D4D6 = b.D4D6;
        result.D4D7 = b.D4D7;
        result.D4D8 = b.D4D8;
        result.D4D9 = b.D4D9;
        result.D4D10 = b.D4D10;
        result.D4D11 = b.D4D11;
        result.D5D5 = b.D5D5;
        result.D5D6 = b.D5D6;
        result.D5D7 = b.D5D7;
        result.D5D8 = b.D5D8;
        result.D5D9 = b.D5D9;
        result.D5D10 = b.D5D10;
        result.D5D11 = b.D5D11;
        result.D6D6 = b.D6D6;
        result.D6D7 = b.D6D7;
        result.D6D8 = b.D6D8;
        result.D6D9 = b.D6D9;
        result.D6D10 = b.D6D10;
        result.D6D11 = b.D6D11;
        result.D7D7 = b.D7D7;
        result.D7D8 = b.D7D8;
        result.D7D9 = b.D7D9;
        result.D7D10 = b.D7D10;
        result.D7D11 = b.D7D11;
        result.D8D8 = b.D8D8;
        result.D8D9 = b.D8D9;
        result.D8D10 = b.D8D10;
        result.D8D11 = b.D8D11;
        result.D9D9 = b.D9D9;
        result.D9D10 = b.D9D10;
        result.D9D11 = b.D9D11;
        result.D10D10 = b.D10D10;
        result.D10D11 = b.D10D11;
        result.D11D11 = b.D11D11;
        return result;
    }

    public static DD12Scalar Add(DD12Scalar a, double b)
    {
        var result = new DD12Scalar(a.Constant + b);
        result.D0 = a.D0;
        result.D1 = a.D1;
        result.D2 = a.D2;
        result.D3 = a.D3;
        result.D4 = a.D4;
        result.D5 = a.D5;
        result.D6 = a.D6;
        result.D7 = a.D7;
        result.D8 = a.D8;
        result.D9 = a.D9;
        result.D10 = a.D10;
        result.D11 = a.D11;
        return result;
    }

    public static DD12Scalar Add(DD12Scalar a, DD12Scalar b)
    {
        var result = new DD12Scalar(a.Constant + b.Constant);
        result.D0 = a.D0 + b.D0;
        result.D1 = a.D1 + b.D1;
        result.D2 = a.D2 + b.D2;
        result.D3 = a.D3 + b.D3;
        result.D4 = a.D4 + b.D4;
        result.D5 = a.D5 + b.D5;
        result.D6 = a.D6 + b.D6;
        result.D7 = a.D7 + b.D7;
        result.D8 = a.D8 + b.D8;
        result.D9 = a.D9 + b.D9;
        result.D10 = a.D10 + b.D10;
        result.D11 = a.D11 + b.D11;
        result.D0D0 = a.D0D0 + b.D0D0;
        result.D0D1 = a.D0D1 + b.D0D1;
        result.D0D2 = a.D0D2 + b.D0D2;
        result.D0D3 = a.D0D3 + b.D0D3;
        result.D0D4 = a.D0D4 + b.D0D4;
        result.D0D5 = a.D0D5 + b.D0D5;
        result.D0D6 = a.D0D6 + b.D0D6;
        result.D0D7 = a.D0D7 + b.D0D7;
        result.D0D8 = a.D0D8 + b.D0D8;
        result.D0D9 = a.D0D9 + b.D0D9;
        result.D0D10 = a.D0D10 + b.D0D10;
        result.D0D11 = a.D0D11 + b.D0D11;
        result.D1D1 = a.D1D1 + b.D1D1;
        result.D1D2 = a.D1D2 + b.D1D2;
        result.D1D3 = a.D1D3 + b.D1D3;
        result.D1D4 = a.D1D4 + b.D1D4;
        result.D1D5 = a.D1D5 + b.D1D5;
        result.D1D6 = a.D1D6 + b.D1D6;
        result.D1D7 = a.D1D7 + b.D1D7;
        result.D1D8 = a.D1D8 + b.D1D8;
        result.D1D9 = a.D1D9 + b.D1D9;
        result.D1D10 = a.D1D10 + b.D1D10;
        result.D1D11 = a.D1D11 + b.D1D11;
        result.D2D2 = a.D2D2 + b.D2D2;
        result.D2D3 = a.D2D3 + b.D2D3;
        result.D2D4 = a.D2D4 + b.D2D4;
        result.D2D5 = a.D2D5 + b.D2D5;
        result.D2D6 = a.D2D6 + b.D2D6;
        result.D2D7 = a.D2D7 + b.D2D7;
        result.D2D8 = a.D2D8 + b.D2D8;
        result.D2D9 = a.D2D9 + b.D2D9;
        result.D2D10 = a.D2D10 + b.D2D10;
        result.D2D11 = a.D2D11 + b.D2D11;
        result.D3D3 = a.D3D3 + b.D3D3;
        result.D3D4 = a.D3D4 + b.D3D4;
        result.D3D5 = a.D3D5 + b.D3D5;
        result.D3D6 = a.D3D6 + b.D3D6;
        result.D3D7 = a.D3D7 + b.D3D7;
        result.D3D8 = a.D3D8 + b.D3D8;
        result.D3D9 = a.D3D9 + b.D3D9;
        result.D3D10 = a.D3D10 + b.D3D10;
        result.D3D11 = a.D3D11 + b.D3D11;
        result.D4D4 = a.D4D4 + b.D4D4;
        result.D4D5 = a.D4D5 + b.D4D5;
        result.D4D6 = a.D4D6 + b.D4D6;
        result.D4D7 = a.D4D7 + b.D4D7;
        result.D4D8 = a.D4D8 + b.D4D8;
        result.D4D9 = a.D4D9 + b.D4D9;
        result.D4D10 = a.D4D10 + b.D4D10;
        result.D4D11 = a.D4D11 + b.D4D11;
        result.D5D5 = a.D5D5 + b.D5D5;
        result.D5D6 = a.D5D6 + b.D5D6;
        result.D5D7 = a.D5D7 + b.D5D7;
        result.D5D8 = a.D5D8 + b.D5D8;
        result.D5D9 = a.D5D9 + b.D5D9;
        result.D5D10 = a.D5D10 + b.D5D10;
        result.D5D11 = a.D5D11 + b.D5D11;
        result.D6D6 = a.D6D6 + b.D6D6;
        result.D6D7 = a.D6D7 + b.D6D7;
        result.D6D8 = a.D6D8 + b.D6D8;
        result.D6D9 = a.D6D9 + b.D6D9;
        result.D6D10 = a.D6D10 + b.D6D10;
        result.D6D11 = a.D6D11 + b.D6D11;
        result.D7D7 = a.D7D7 + b.D7D7;
        result.D7D8 = a.D7D8 + b.D7D8;
        result.D7D9 = a.D7D9 + b.D7D9;
        result.D7D10 = a.D7D10 + b.D7D10;
        result.D7D11 = a.D7D11 + b.D7D11;
        result.D8D8 = a.D8D8 + b.D8D8;
        result.D8D9 = a.D8D9 + b.D8D9;
        result.D8D10 = a.D8D10 + b.D8D10;
        result.D8D11 = a.D8D11 + b.D8D11;
        result.D9D9 = a.D9D9 + b.D9D9;
        result.D9D10 = a.D9D10 + b.D9D10;
        result.D9D11 = a.D9D11 + b.D9D11;
        result.D10D10 = a.D10D10 + b.D10D10;
        result.D10D11 = a.D10D11 + b.D10D11;
        result.D11D11 = a.D11D11 + b.D11D11;
        return result;
    }
}
