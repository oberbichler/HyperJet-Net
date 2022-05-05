#pragma warning disable IDE0017

namespace HyperJet;

public static partial class MathD
{
    public static D1Scalar Negative(D1Scalar b)
    {
        var result = new D1Scalar(-b.Constant);
        result.D0 = -b.D0;
        return result;
    }

    public static D2Scalar Negative(D2Scalar b)
    {
        var result = new D2Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        return result;
    }

    public static D3Scalar Negative(D3Scalar b)
    {
        var result = new D3Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        return result;
    }

    public static D4Scalar Negative(D4Scalar b)
    {
        var result = new D4Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        return result;
    }

    public static D5Scalar Negative(D5Scalar b)
    {
        var result = new D5Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        return result;
    }

    public static D6Scalar Negative(D6Scalar b)
    {
        var result = new D6Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        return result;
    }

    public static D7Scalar Negative(D7Scalar b)
    {
        var result = new D7Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        return result;
    }

    public static D8Scalar Negative(D8Scalar b)
    {
        var result = new D8Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        return result;
    }

    public static D9Scalar Negative(D9Scalar b)
    {
        var result = new D9Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        result.D8 = -b.D8;
        return result;
    }

    public static D10Scalar Negative(D10Scalar b)
    {
        var result = new D10Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        result.D8 = -b.D8;
        result.D9 = -b.D9;
        return result;
    }

    public static D11Scalar Negative(D11Scalar b)
    {
        var result = new D11Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        result.D8 = -b.D8;
        result.D9 = -b.D9;
        result.D10 = -b.D10;
        return result;
    }

    public static D12Scalar Negative(D12Scalar b)
    {
        var result = new D12Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        result.D8 = -b.D8;
        result.D9 = -b.D9;
        result.D10 = -b.D10;
        result.D11 = -b.D11;
        return result;
    }

    public static DD1Scalar Negative(DD1Scalar b)
    {
        var result = new DD1Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D0D0 = -b.D0D0;
        return result;
    }

    public static DD2Scalar Negative(DD2Scalar b)
    {
        var result = new DD2Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D1D1 = -b.D1D1;
        return result;
    }

    public static DD3Scalar Negative(DD3Scalar b)
    {
        var result = new DD3Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D2D2 = -b.D2D2;
        return result;
    }

    public static DD4Scalar Negative(DD4Scalar b)
    {
        var result = new DD4Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D0D3 = -b.D0D3;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D1D3 = -b.D1D3;
        result.D2D2 = -b.D2D2;
        result.D2D3 = -b.D2D3;
        result.D3D3 = -b.D3D3;
        return result;
    }

    public static DD5Scalar Negative(DD5Scalar b)
    {
        var result = new DD5Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D0D3 = -b.D0D3;
        result.D0D4 = -b.D0D4;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D1D3 = -b.D1D3;
        result.D1D4 = -b.D1D4;
        result.D2D2 = -b.D2D2;
        result.D2D3 = -b.D2D3;
        result.D2D4 = -b.D2D4;
        result.D3D3 = -b.D3D3;
        result.D3D4 = -b.D3D4;
        result.D4D4 = -b.D4D4;
        return result;
    }

    public static DD6Scalar Negative(DD6Scalar b)
    {
        var result = new DD6Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D0D3 = -b.D0D3;
        result.D0D4 = -b.D0D4;
        result.D0D5 = -b.D0D5;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D1D3 = -b.D1D3;
        result.D1D4 = -b.D1D4;
        result.D1D5 = -b.D1D5;
        result.D2D2 = -b.D2D2;
        result.D2D3 = -b.D2D3;
        result.D2D4 = -b.D2D4;
        result.D2D5 = -b.D2D5;
        result.D3D3 = -b.D3D3;
        result.D3D4 = -b.D3D4;
        result.D3D5 = -b.D3D5;
        result.D4D4 = -b.D4D4;
        result.D4D5 = -b.D4D5;
        result.D5D5 = -b.D5D5;
        return result;
    }

    public static DD7Scalar Negative(DD7Scalar b)
    {
        var result = new DD7Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D0D3 = -b.D0D3;
        result.D0D4 = -b.D0D4;
        result.D0D5 = -b.D0D5;
        result.D0D6 = -b.D0D6;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D1D3 = -b.D1D3;
        result.D1D4 = -b.D1D4;
        result.D1D5 = -b.D1D5;
        result.D1D6 = -b.D1D6;
        result.D2D2 = -b.D2D2;
        result.D2D3 = -b.D2D3;
        result.D2D4 = -b.D2D4;
        result.D2D5 = -b.D2D5;
        result.D2D6 = -b.D2D6;
        result.D3D3 = -b.D3D3;
        result.D3D4 = -b.D3D4;
        result.D3D5 = -b.D3D5;
        result.D3D6 = -b.D3D6;
        result.D4D4 = -b.D4D4;
        result.D4D5 = -b.D4D5;
        result.D4D6 = -b.D4D6;
        result.D5D5 = -b.D5D5;
        result.D5D6 = -b.D5D6;
        result.D6D6 = -b.D6D6;
        return result;
    }

    public static DD8Scalar Negative(DD8Scalar b)
    {
        var result = new DD8Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D0D3 = -b.D0D3;
        result.D0D4 = -b.D0D4;
        result.D0D5 = -b.D0D5;
        result.D0D6 = -b.D0D6;
        result.D0D7 = -b.D0D7;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D1D3 = -b.D1D3;
        result.D1D4 = -b.D1D4;
        result.D1D5 = -b.D1D5;
        result.D1D6 = -b.D1D6;
        result.D1D7 = -b.D1D7;
        result.D2D2 = -b.D2D2;
        result.D2D3 = -b.D2D3;
        result.D2D4 = -b.D2D4;
        result.D2D5 = -b.D2D5;
        result.D2D6 = -b.D2D6;
        result.D2D7 = -b.D2D7;
        result.D3D3 = -b.D3D3;
        result.D3D4 = -b.D3D4;
        result.D3D5 = -b.D3D5;
        result.D3D6 = -b.D3D6;
        result.D3D7 = -b.D3D7;
        result.D4D4 = -b.D4D4;
        result.D4D5 = -b.D4D5;
        result.D4D6 = -b.D4D6;
        result.D4D7 = -b.D4D7;
        result.D5D5 = -b.D5D5;
        result.D5D6 = -b.D5D6;
        result.D5D7 = -b.D5D7;
        result.D6D6 = -b.D6D6;
        result.D6D7 = -b.D6D7;
        result.D7D7 = -b.D7D7;
        return result;
    }

    public static DD9Scalar Negative(DD9Scalar b)
    {
        var result = new DD9Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        result.D8 = -b.D8;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D0D3 = -b.D0D3;
        result.D0D4 = -b.D0D4;
        result.D0D5 = -b.D0D5;
        result.D0D6 = -b.D0D6;
        result.D0D7 = -b.D0D7;
        result.D0D8 = -b.D0D8;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D1D3 = -b.D1D3;
        result.D1D4 = -b.D1D4;
        result.D1D5 = -b.D1D5;
        result.D1D6 = -b.D1D6;
        result.D1D7 = -b.D1D7;
        result.D1D8 = -b.D1D8;
        result.D2D2 = -b.D2D2;
        result.D2D3 = -b.D2D3;
        result.D2D4 = -b.D2D4;
        result.D2D5 = -b.D2D5;
        result.D2D6 = -b.D2D6;
        result.D2D7 = -b.D2D7;
        result.D2D8 = -b.D2D8;
        result.D3D3 = -b.D3D3;
        result.D3D4 = -b.D3D4;
        result.D3D5 = -b.D3D5;
        result.D3D6 = -b.D3D6;
        result.D3D7 = -b.D3D7;
        result.D3D8 = -b.D3D8;
        result.D4D4 = -b.D4D4;
        result.D4D5 = -b.D4D5;
        result.D4D6 = -b.D4D6;
        result.D4D7 = -b.D4D7;
        result.D4D8 = -b.D4D8;
        result.D5D5 = -b.D5D5;
        result.D5D6 = -b.D5D6;
        result.D5D7 = -b.D5D7;
        result.D5D8 = -b.D5D8;
        result.D6D6 = -b.D6D6;
        result.D6D7 = -b.D6D7;
        result.D6D8 = -b.D6D8;
        result.D7D7 = -b.D7D7;
        result.D7D8 = -b.D7D8;
        result.D8D8 = -b.D8D8;
        return result;
    }

    public static DD10Scalar Negative(DD10Scalar b)
    {
        var result = new DD10Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        result.D8 = -b.D8;
        result.D9 = -b.D9;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D0D3 = -b.D0D3;
        result.D0D4 = -b.D0D4;
        result.D0D5 = -b.D0D5;
        result.D0D6 = -b.D0D6;
        result.D0D7 = -b.D0D7;
        result.D0D8 = -b.D0D8;
        result.D0D9 = -b.D0D9;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D1D3 = -b.D1D3;
        result.D1D4 = -b.D1D4;
        result.D1D5 = -b.D1D5;
        result.D1D6 = -b.D1D6;
        result.D1D7 = -b.D1D7;
        result.D1D8 = -b.D1D8;
        result.D1D9 = -b.D1D9;
        result.D2D2 = -b.D2D2;
        result.D2D3 = -b.D2D3;
        result.D2D4 = -b.D2D4;
        result.D2D5 = -b.D2D5;
        result.D2D6 = -b.D2D6;
        result.D2D7 = -b.D2D7;
        result.D2D8 = -b.D2D8;
        result.D2D9 = -b.D2D9;
        result.D3D3 = -b.D3D3;
        result.D3D4 = -b.D3D4;
        result.D3D5 = -b.D3D5;
        result.D3D6 = -b.D3D6;
        result.D3D7 = -b.D3D7;
        result.D3D8 = -b.D3D8;
        result.D3D9 = -b.D3D9;
        result.D4D4 = -b.D4D4;
        result.D4D5 = -b.D4D5;
        result.D4D6 = -b.D4D6;
        result.D4D7 = -b.D4D7;
        result.D4D8 = -b.D4D8;
        result.D4D9 = -b.D4D9;
        result.D5D5 = -b.D5D5;
        result.D5D6 = -b.D5D6;
        result.D5D7 = -b.D5D7;
        result.D5D8 = -b.D5D8;
        result.D5D9 = -b.D5D9;
        result.D6D6 = -b.D6D6;
        result.D6D7 = -b.D6D7;
        result.D6D8 = -b.D6D8;
        result.D6D9 = -b.D6D9;
        result.D7D7 = -b.D7D7;
        result.D7D8 = -b.D7D8;
        result.D7D9 = -b.D7D9;
        result.D8D8 = -b.D8D8;
        result.D8D9 = -b.D8D9;
        result.D9D9 = -b.D9D9;
        return result;
    }

    public static DD11Scalar Negative(DD11Scalar b)
    {
        var result = new DD11Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        result.D8 = -b.D8;
        result.D9 = -b.D9;
        result.D10 = -b.D10;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D0D3 = -b.D0D3;
        result.D0D4 = -b.D0D4;
        result.D0D5 = -b.D0D5;
        result.D0D6 = -b.D0D6;
        result.D0D7 = -b.D0D7;
        result.D0D8 = -b.D0D8;
        result.D0D9 = -b.D0D9;
        result.D0D10 = -b.D0D10;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D1D3 = -b.D1D3;
        result.D1D4 = -b.D1D4;
        result.D1D5 = -b.D1D5;
        result.D1D6 = -b.D1D6;
        result.D1D7 = -b.D1D7;
        result.D1D8 = -b.D1D8;
        result.D1D9 = -b.D1D9;
        result.D1D10 = -b.D1D10;
        result.D2D2 = -b.D2D2;
        result.D2D3 = -b.D2D3;
        result.D2D4 = -b.D2D4;
        result.D2D5 = -b.D2D5;
        result.D2D6 = -b.D2D6;
        result.D2D7 = -b.D2D7;
        result.D2D8 = -b.D2D8;
        result.D2D9 = -b.D2D9;
        result.D2D10 = -b.D2D10;
        result.D3D3 = -b.D3D3;
        result.D3D4 = -b.D3D4;
        result.D3D5 = -b.D3D5;
        result.D3D6 = -b.D3D6;
        result.D3D7 = -b.D3D7;
        result.D3D8 = -b.D3D8;
        result.D3D9 = -b.D3D9;
        result.D3D10 = -b.D3D10;
        result.D4D4 = -b.D4D4;
        result.D4D5 = -b.D4D5;
        result.D4D6 = -b.D4D6;
        result.D4D7 = -b.D4D7;
        result.D4D8 = -b.D4D8;
        result.D4D9 = -b.D4D9;
        result.D4D10 = -b.D4D10;
        result.D5D5 = -b.D5D5;
        result.D5D6 = -b.D5D6;
        result.D5D7 = -b.D5D7;
        result.D5D8 = -b.D5D8;
        result.D5D9 = -b.D5D9;
        result.D5D10 = -b.D5D10;
        result.D6D6 = -b.D6D6;
        result.D6D7 = -b.D6D7;
        result.D6D8 = -b.D6D8;
        result.D6D9 = -b.D6D9;
        result.D6D10 = -b.D6D10;
        result.D7D7 = -b.D7D7;
        result.D7D8 = -b.D7D8;
        result.D7D9 = -b.D7D9;
        result.D7D10 = -b.D7D10;
        result.D8D8 = -b.D8D8;
        result.D8D9 = -b.D8D9;
        result.D8D10 = -b.D8D10;
        result.D9D9 = -b.D9D9;
        result.D9D10 = -b.D9D10;
        result.D10D10 = -b.D10D10;
        return result;
    }

    public static DD12Scalar Negative(DD12Scalar b)
    {
        var result = new DD12Scalar(-b.Constant);
        result.D0 = -b.D0;
        result.D1 = -b.D1;
        result.D2 = -b.D2;
        result.D3 = -b.D3;
        result.D4 = -b.D4;
        result.D5 = -b.D5;
        result.D6 = -b.D6;
        result.D7 = -b.D7;
        result.D8 = -b.D8;
        result.D9 = -b.D9;
        result.D10 = -b.D10;
        result.D11 = -b.D11;
        result.D0D0 = -b.D0D0;
        result.D0D1 = -b.D0D1;
        result.D0D2 = -b.D0D2;
        result.D0D3 = -b.D0D3;
        result.D0D4 = -b.D0D4;
        result.D0D5 = -b.D0D5;
        result.D0D6 = -b.D0D6;
        result.D0D7 = -b.D0D7;
        result.D0D8 = -b.D0D8;
        result.D0D9 = -b.D0D9;
        result.D0D10 = -b.D0D10;
        result.D0D11 = -b.D0D11;
        result.D1D1 = -b.D1D1;
        result.D1D2 = -b.D1D2;
        result.D1D3 = -b.D1D3;
        result.D1D4 = -b.D1D4;
        result.D1D5 = -b.D1D5;
        result.D1D6 = -b.D1D6;
        result.D1D7 = -b.D1D7;
        result.D1D8 = -b.D1D8;
        result.D1D9 = -b.D1D9;
        result.D1D10 = -b.D1D10;
        result.D1D11 = -b.D1D11;
        result.D2D2 = -b.D2D2;
        result.D2D3 = -b.D2D3;
        result.D2D4 = -b.D2D4;
        result.D2D5 = -b.D2D5;
        result.D2D6 = -b.D2D6;
        result.D2D7 = -b.D2D7;
        result.D2D8 = -b.D2D8;
        result.D2D9 = -b.D2D9;
        result.D2D10 = -b.D2D10;
        result.D2D11 = -b.D2D11;
        result.D3D3 = -b.D3D3;
        result.D3D4 = -b.D3D4;
        result.D3D5 = -b.D3D5;
        result.D3D6 = -b.D3D6;
        result.D3D7 = -b.D3D7;
        result.D3D8 = -b.D3D8;
        result.D3D9 = -b.D3D9;
        result.D3D10 = -b.D3D10;
        result.D3D11 = -b.D3D11;
        result.D4D4 = -b.D4D4;
        result.D4D5 = -b.D4D5;
        result.D4D6 = -b.D4D6;
        result.D4D7 = -b.D4D7;
        result.D4D8 = -b.D4D8;
        result.D4D9 = -b.D4D9;
        result.D4D10 = -b.D4D10;
        result.D4D11 = -b.D4D11;
        result.D5D5 = -b.D5D5;
        result.D5D6 = -b.D5D6;
        result.D5D7 = -b.D5D7;
        result.D5D8 = -b.D5D8;
        result.D5D9 = -b.D5D9;
        result.D5D10 = -b.D5D10;
        result.D5D11 = -b.D5D11;
        result.D6D6 = -b.D6D6;
        result.D6D7 = -b.D6D7;
        result.D6D8 = -b.D6D8;
        result.D6D9 = -b.D6D9;
        result.D6D10 = -b.D6D10;
        result.D6D11 = -b.D6D11;
        result.D7D7 = -b.D7D7;
        result.D7D8 = -b.D7D8;
        result.D7D9 = -b.D7D9;
        result.D7D10 = -b.D7D10;
        result.D7D11 = -b.D7D11;
        result.D8D8 = -b.D8D8;
        result.D8D9 = -b.D8D9;
        result.D8D10 = -b.D8D10;
        result.D8D11 = -b.D8D11;
        result.D9D9 = -b.D9D9;
        result.D9D10 = -b.D9D10;
        result.D9D11 = -b.D9D11;
        result.D10D10 = -b.D10D10;
        result.D10D11 = -b.D10D11;
        result.D11D11 = -b.D11D11;
        return result;
    }
}
