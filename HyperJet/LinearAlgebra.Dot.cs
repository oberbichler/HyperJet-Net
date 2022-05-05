namespace HyperJet;
public static partial class LinearAlgebraD
{
    public static D1Scalar Dot(D1Vector3 u, D1Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D1Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;

        return result;
    }

    public static D2Scalar Dot(D2Vector3 u, D2Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D2Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;

        return result;
    }

    public static D3Scalar Dot(D3Vector3 u, D3Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D3Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;

        return result;
    }

    public static D4Scalar Dot(D4Vector3 u, D4Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D4Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;

        return result;
    }

    public static D5Scalar Dot(D5Vector3 u, D5Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D5Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;

        return result;
    }

    public static D6Scalar Dot(D6Vector3 u, D6Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D6Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;

        return result;
    }

    public static D7Scalar Dot(D7Vector3 u, D7Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D7Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;

        return result;
    }

    public static D8Scalar Dot(D8Vector3 u, D8Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D8Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;

        return result;
    }

    public static D9Scalar Dot(D9Vector3 u, D9Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D9Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;
        result.D8 = d0 * u.X.D8 + d1 * u.Y.D8 + d2 * u.Z.D8 + d3 * v.X.D8 + d4 * v.Y.D8 + d5 * v.Z.D8;

        return result;
    }

    public static D10Scalar Dot(D10Vector3 u, D10Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D10Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;
        result.D8 = d0 * u.X.D8 + d1 * u.Y.D8 + d2 * u.Z.D8 + d3 * v.X.D8 + d4 * v.Y.D8 + d5 * v.Z.D8;
        result.D9 = d0 * u.X.D9 + d1 * u.Y.D9 + d2 * u.Z.D9 + d3 * v.X.D9 + d4 * v.Y.D9 + d5 * v.Z.D9;

        return result;
    }

    public static D11Scalar Dot(D11Vector3 u, D11Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D11Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;
        result.D8 = d0 * u.X.D8 + d1 * u.Y.D8 + d2 * u.Z.D8 + d3 * v.X.D8 + d4 * v.Y.D8 + d5 * v.Z.D8;
        result.D9 = d0 * u.X.D9 + d1 * u.Y.D9 + d2 * u.Z.D9 + d3 * v.X.D9 + d4 * v.Y.D9 + d5 * v.Z.D9;
        result.D10 = d0 * u.X.D10 + d1 * u.Y.D10 + d2 * u.Z.D10 + d3 * v.X.D10 + d4 * v.Y.D10 + d5 * v.Z.D10;

        return result;
    }

    public static D12Scalar Dot(D12Vector3 u, D12Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new D12Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;
        result.D8 = d0 * u.X.D8 + d1 * u.Y.D8 + d2 * u.Z.D8 + d3 * v.X.D8 + d4 * v.Y.D8 + d5 * v.Z.D8;
        result.D9 = d0 * u.X.D9 + d1 * u.Y.D9 + d2 * u.Z.D9 + d3 * v.X.D9 + d4 * v.Y.D9 + d5 * v.Z.D9;
        result.D10 = d0 * u.X.D10 + d1 * u.Y.D10 + d2 * u.Z.D10 + d3 * v.X.D10 + d4 * v.Y.D10 + d5 * v.Z.D10;
        result.D11 = d0 * u.X.D11 + d1 * u.Y.D11 + d2 * u.Z.D11 + d3 * v.X.D11 + d4 * v.Y.D11 + d5 * v.Z.D11;

        return result;
    }

    public static DD1Scalar Dot(DD1Vector3 u, DD1Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD1Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;

        return result;
    }

    public static DD2Scalar Dot(DD2Vector3 u, DD2Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD2Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;

        return result;
    }

    public static DD3Scalar Dot(DD3Vector3 u, DD3Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD3Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;

        return result;
    }

    public static DD4Scalar Dot(DD4Vector3 u, DD4Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD4Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * u.X.D0D3 + d1 * u.Y.D0D3 + d2 * u.Z.D0D3 + d3 * v.X.D0D3 + d4 * v.Y.D0D3 + d5 * v.Z.D0D3 + v.X.D0 * u.X.D3 + v.Y.D0 * u.Y.D3 + v.Z.D0 * u.Z.D3 + u.X.D0 * v.X.D3 + u.Y.D0 * v.Y.D3 + u.Z.D0 * v.Z.D3;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * u.X.D1D3 + d1 * u.Y.D1D3 + d2 * u.Z.D1D3 + d3 * v.X.D1D3 + d4 * v.Y.D1D3 + d5 * v.Z.D1D3 + v.X.D1 * u.X.D3 + v.Y.D1 * u.Y.D3 + v.Z.D1 * u.Z.D3 + u.X.D1 * v.X.D3 + u.Y.D1 * v.Y.D3 + u.Z.D1 * v.Z.D3;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * u.X.D2D3 + d1 * u.Y.D2D3 + d2 * u.Z.D2D3 + d3 * v.X.D2D3 + d4 * v.Y.D2D3 + d5 * v.Z.D2D3 + v.X.D2 * u.X.D3 + v.Y.D2 * u.Y.D3 + v.Z.D2 * u.Z.D3 + u.X.D2 * v.X.D3 + u.Y.D2 * v.Y.D3 + u.Z.D2 * v.Z.D3;
        result.D3D3 = d0 * u.X.D3D3 + d1 * u.Y.D3D3 + d2 * u.Z.D3D3 + d3 * v.X.D3D3 + d4 * v.Y.D3D3 + d5 * v.Z.D3D3 + v.X.D3 * u.X.D3 + v.Y.D3 * u.Y.D3 + v.Z.D3 * u.Z.D3 + u.X.D3 * v.X.D3 + u.Y.D3 * v.Y.D3 + u.Z.D3 * v.Z.D3;

        return result;
    }

    public static DD5Scalar Dot(DD5Vector3 u, DD5Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD5Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * u.X.D0D3 + d1 * u.Y.D0D3 + d2 * u.Z.D0D3 + d3 * v.X.D0D3 + d4 * v.Y.D0D3 + d5 * v.Z.D0D3 + v.X.D0 * u.X.D3 + v.Y.D0 * u.Y.D3 + v.Z.D0 * u.Z.D3 + u.X.D0 * v.X.D3 + u.Y.D0 * v.Y.D3 + u.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * u.X.D0D4 + d1 * u.Y.D0D4 + d2 * u.Z.D0D4 + d3 * v.X.D0D4 + d4 * v.Y.D0D4 + d5 * v.Z.D0D4 + v.X.D0 * u.X.D4 + v.Y.D0 * u.Y.D4 + v.Z.D0 * u.Z.D4 + u.X.D0 * v.X.D4 + u.Y.D0 * v.Y.D4 + u.Z.D0 * v.Z.D4;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * u.X.D1D3 + d1 * u.Y.D1D3 + d2 * u.Z.D1D3 + d3 * v.X.D1D3 + d4 * v.Y.D1D3 + d5 * v.Z.D1D3 + v.X.D1 * u.X.D3 + v.Y.D1 * u.Y.D3 + v.Z.D1 * u.Z.D3 + u.X.D1 * v.X.D3 + u.Y.D1 * v.Y.D3 + u.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * u.X.D1D4 + d1 * u.Y.D1D4 + d2 * u.Z.D1D4 + d3 * v.X.D1D4 + d4 * v.Y.D1D4 + d5 * v.Z.D1D4 + v.X.D1 * u.X.D4 + v.Y.D1 * u.Y.D4 + v.Z.D1 * u.Z.D4 + u.X.D1 * v.X.D4 + u.Y.D1 * v.Y.D4 + u.Z.D1 * v.Z.D4;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * u.X.D2D3 + d1 * u.Y.D2D3 + d2 * u.Z.D2D3 + d3 * v.X.D2D3 + d4 * v.Y.D2D3 + d5 * v.Z.D2D3 + v.X.D2 * u.X.D3 + v.Y.D2 * u.Y.D3 + v.Z.D2 * u.Z.D3 + u.X.D2 * v.X.D3 + u.Y.D2 * v.Y.D3 + u.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * u.X.D2D4 + d1 * u.Y.D2D4 + d2 * u.Z.D2D4 + d3 * v.X.D2D4 + d4 * v.Y.D2D4 + d5 * v.Z.D2D4 + v.X.D2 * u.X.D4 + v.Y.D2 * u.Y.D4 + v.Z.D2 * u.Z.D4 + u.X.D2 * v.X.D4 + u.Y.D2 * v.Y.D4 + u.Z.D2 * v.Z.D4;
        result.D3D3 = d0 * u.X.D3D3 + d1 * u.Y.D3D3 + d2 * u.Z.D3D3 + d3 * v.X.D3D3 + d4 * v.Y.D3D3 + d5 * v.Z.D3D3 + v.X.D3 * u.X.D3 + v.Y.D3 * u.Y.D3 + v.Z.D3 * u.Z.D3 + u.X.D3 * v.X.D3 + u.Y.D3 * v.Y.D3 + u.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * u.X.D3D4 + d1 * u.Y.D3D4 + d2 * u.Z.D3D4 + d3 * v.X.D3D4 + d4 * v.Y.D3D4 + d5 * v.Z.D3D4 + v.X.D3 * u.X.D4 + v.Y.D3 * u.Y.D4 + v.Z.D3 * u.Z.D4 + u.X.D3 * v.X.D4 + u.Y.D3 * v.Y.D4 + u.Z.D3 * v.Z.D4;
        result.D4D4 = d0 * u.X.D4D4 + d1 * u.Y.D4D4 + d2 * u.Z.D4D4 + d3 * v.X.D4D4 + d4 * v.Y.D4D4 + d5 * v.Z.D4D4 + v.X.D4 * u.X.D4 + v.Y.D4 * u.Y.D4 + v.Z.D4 * u.Z.D4 + u.X.D4 * v.X.D4 + u.Y.D4 * v.Y.D4 + u.Z.D4 * v.Z.D4;

        return result;
    }

    public static DD6Scalar Dot(DD6Vector3 u, DD6Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD6Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * u.X.D0D3 + d1 * u.Y.D0D3 + d2 * u.Z.D0D3 + d3 * v.X.D0D3 + d4 * v.Y.D0D3 + d5 * v.Z.D0D3 + v.X.D0 * u.X.D3 + v.Y.D0 * u.Y.D3 + v.Z.D0 * u.Z.D3 + u.X.D0 * v.X.D3 + u.Y.D0 * v.Y.D3 + u.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * u.X.D0D4 + d1 * u.Y.D0D4 + d2 * u.Z.D0D4 + d3 * v.X.D0D4 + d4 * v.Y.D0D4 + d5 * v.Z.D0D4 + v.X.D0 * u.X.D4 + v.Y.D0 * u.Y.D4 + v.Z.D0 * u.Z.D4 + u.X.D0 * v.X.D4 + u.Y.D0 * v.Y.D4 + u.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * u.X.D0D5 + d1 * u.Y.D0D5 + d2 * u.Z.D0D5 + d3 * v.X.D0D5 + d4 * v.Y.D0D5 + d5 * v.Z.D0D5 + v.X.D0 * u.X.D5 + v.Y.D0 * u.Y.D5 + v.Z.D0 * u.Z.D5 + u.X.D0 * v.X.D5 + u.Y.D0 * v.Y.D5 + u.Z.D0 * v.Z.D5;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * u.X.D1D3 + d1 * u.Y.D1D3 + d2 * u.Z.D1D3 + d3 * v.X.D1D3 + d4 * v.Y.D1D3 + d5 * v.Z.D1D3 + v.X.D1 * u.X.D3 + v.Y.D1 * u.Y.D3 + v.Z.D1 * u.Z.D3 + u.X.D1 * v.X.D3 + u.Y.D1 * v.Y.D3 + u.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * u.X.D1D4 + d1 * u.Y.D1D4 + d2 * u.Z.D1D4 + d3 * v.X.D1D4 + d4 * v.Y.D1D4 + d5 * v.Z.D1D4 + v.X.D1 * u.X.D4 + v.Y.D1 * u.Y.D4 + v.Z.D1 * u.Z.D4 + u.X.D1 * v.X.D4 + u.Y.D1 * v.Y.D4 + u.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * u.X.D1D5 + d1 * u.Y.D1D5 + d2 * u.Z.D1D5 + d3 * v.X.D1D5 + d4 * v.Y.D1D5 + d5 * v.Z.D1D5 + v.X.D1 * u.X.D5 + v.Y.D1 * u.Y.D5 + v.Z.D1 * u.Z.D5 + u.X.D1 * v.X.D5 + u.Y.D1 * v.Y.D5 + u.Z.D1 * v.Z.D5;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * u.X.D2D3 + d1 * u.Y.D2D3 + d2 * u.Z.D2D3 + d3 * v.X.D2D3 + d4 * v.Y.D2D3 + d5 * v.Z.D2D3 + v.X.D2 * u.X.D3 + v.Y.D2 * u.Y.D3 + v.Z.D2 * u.Z.D3 + u.X.D2 * v.X.D3 + u.Y.D2 * v.Y.D3 + u.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * u.X.D2D4 + d1 * u.Y.D2D4 + d2 * u.Z.D2D4 + d3 * v.X.D2D4 + d4 * v.Y.D2D4 + d5 * v.Z.D2D4 + v.X.D2 * u.X.D4 + v.Y.D2 * u.Y.D4 + v.Z.D2 * u.Z.D4 + u.X.D2 * v.X.D4 + u.Y.D2 * v.Y.D4 + u.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * u.X.D2D5 + d1 * u.Y.D2D5 + d2 * u.Z.D2D5 + d3 * v.X.D2D5 + d4 * v.Y.D2D5 + d5 * v.Z.D2D5 + v.X.D2 * u.X.D5 + v.Y.D2 * u.Y.D5 + v.Z.D2 * u.Z.D5 + u.X.D2 * v.X.D5 + u.Y.D2 * v.Y.D5 + u.Z.D2 * v.Z.D5;
        result.D3D3 = d0 * u.X.D3D3 + d1 * u.Y.D3D3 + d2 * u.Z.D3D3 + d3 * v.X.D3D3 + d4 * v.Y.D3D3 + d5 * v.Z.D3D3 + v.X.D3 * u.X.D3 + v.Y.D3 * u.Y.D3 + v.Z.D3 * u.Z.D3 + u.X.D3 * v.X.D3 + u.Y.D3 * v.Y.D3 + u.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * u.X.D3D4 + d1 * u.Y.D3D4 + d2 * u.Z.D3D4 + d3 * v.X.D3D4 + d4 * v.Y.D3D4 + d5 * v.Z.D3D4 + v.X.D3 * u.X.D4 + v.Y.D3 * u.Y.D4 + v.Z.D3 * u.Z.D4 + u.X.D3 * v.X.D4 + u.Y.D3 * v.Y.D4 + u.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * u.X.D3D5 + d1 * u.Y.D3D5 + d2 * u.Z.D3D5 + d3 * v.X.D3D5 + d4 * v.Y.D3D5 + d5 * v.Z.D3D5 + v.X.D3 * u.X.D5 + v.Y.D3 * u.Y.D5 + v.Z.D3 * u.Z.D5 + u.X.D3 * v.X.D5 + u.Y.D3 * v.Y.D5 + u.Z.D3 * v.Z.D5;
        result.D4D4 = d0 * u.X.D4D4 + d1 * u.Y.D4D4 + d2 * u.Z.D4D4 + d3 * v.X.D4D4 + d4 * v.Y.D4D4 + d5 * v.Z.D4D4 + v.X.D4 * u.X.D4 + v.Y.D4 * u.Y.D4 + v.Z.D4 * u.Z.D4 + u.X.D4 * v.X.D4 + u.Y.D4 * v.Y.D4 + u.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * u.X.D4D5 + d1 * u.Y.D4D5 + d2 * u.Z.D4D5 + d3 * v.X.D4D5 + d4 * v.Y.D4D5 + d5 * v.Z.D4D5 + v.X.D4 * u.X.D5 + v.Y.D4 * u.Y.D5 + v.Z.D4 * u.Z.D5 + u.X.D4 * v.X.D5 + u.Y.D4 * v.Y.D5 + u.Z.D4 * v.Z.D5;
        result.D5D5 = d0 * u.X.D5D5 + d1 * u.Y.D5D5 + d2 * u.Z.D5D5 + d3 * v.X.D5D5 + d4 * v.Y.D5D5 + d5 * v.Z.D5D5 + v.X.D5 * u.X.D5 + v.Y.D5 * u.Y.D5 + v.Z.D5 * u.Z.D5 + u.X.D5 * v.X.D5 + u.Y.D5 * v.Y.D5 + u.Z.D5 * v.Z.D5;

        return result;
    }

    public static DD7Scalar Dot(DD7Vector3 u, DD7Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD7Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * u.X.D0D3 + d1 * u.Y.D0D3 + d2 * u.Z.D0D3 + d3 * v.X.D0D3 + d4 * v.Y.D0D3 + d5 * v.Z.D0D3 + v.X.D0 * u.X.D3 + v.Y.D0 * u.Y.D3 + v.Z.D0 * u.Z.D3 + u.X.D0 * v.X.D3 + u.Y.D0 * v.Y.D3 + u.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * u.X.D0D4 + d1 * u.Y.D0D4 + d2 * u.Z.D0D4 + d3 * v.X.D0D4 + d4 * v.Y.D0D4 + d5 * v.Z.D0D4 + v.X.D0 * u.X.D4 + v.Y.D0 * u.Y.D4 + v.Z.D0 * u.Z.D4 + u.X.D0 * v.X.D4 + u.Y.D0 * v.Y.D4 + u.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * u.X.D0D5 + d1 * u.Y.D0D5 + d2 * u.Z.D0D5 + d3 * v.X.D0D5 + d4 * v.Y.D0D5 + d5 * v.Z.D0D5 + v.X.D0 * u.X.D5 + v.Y.D0 * u.Y.D5 + v.Z.D0 * u.Z.D5 + u.X.D0 * v.X.D5 + u.Y.D0 * v.Y.D5 + u.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * u.X.D0D6 + d1 * u.Y.D0D6 + d2 * u.Z.D0D6 + d3 * v.X.D0D6 + d4 * v.Y.D0D6 + d5 * v.Z.D0D6 + v.X.D0 * u.X.D6 + v.Y.D0 * u.Y.D6 + v.Z.D0 * u.Z.D6 + u.X.D0 * v.X.D6 + u.Y.D0 * v.Y.D6 + u.Z.D0 * v.Z.D6;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * u.X.D1D3 + d1 * u.Y.D1D3 + d2 * u.Z.D1D3 + d3 * v.X.D1D3 + d4 * v.Y.D1D3 + d5 * v.Z.D1D3 + v.X.D1 * u.X.D3 + v.Y.D1 * u.Y.D3 + v.Z.D1 * u.Z.D3 + u.X.D1 * v.X.D3 + u.Y.D1 * v.Y.D3 + u.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * u.X.D1D4 + d1 * u.Y.D1D4 + d2 * u.Z.D1D4 + d3 * v.X.D1D4 + d4 * v.Y.D1D4 + d5 * v.Z.D1D4 + v.X.D1 * u.X.D4 + v.Y.D1 * u.Y.D4 + v.Z.D1 * u.Z.D4 + u.X.D1 * v.X.D4 + u.Y.D1 * v.Y.D4 + u.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * u.X.D1D5 + d1 * u.Y.D1D5 + d2 * u.Z.D1D5 + d3 * v.X.D1D5 + d4 * v.Y.D1D5 + d5 * v.Z.D1D5 + v.X.D1 * u.X.D5 + v.Y.D1 * u.Y.D5 + v.Z.D1 * u.Z.D5 + u.X.D1 * v.X.D5 + u.Y.D1 * v.Y.D5 + u.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * u.X.D1D6 + d1 * u.Y.D1D6 + d2 * u.Z.D1D6 + d3 * v.X.D1D6 + d4 * v.Y.D1D6 + d5 * v.Z.D1D6 + v.X.D1 * u.X.D6 + v.Y.D1 * u.Y.D6 + v.Z.D1 * u.Z.D6 + u.X.D1 * v.X.D6 + u.Y.D1 * v.Y.D6 + u.Z.D1 * v.Z.D6;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * u.X.D2D3 + d1 * u.Y.D2D3 + d2 * u.Z.D2D3 + d3 * v.X.D2D3 + d4 * v.Y.D2D3 + d5 * v.Z.D2D3 + v.X.D2 * u.X.D3 + v.Y.D2 * u.Y.D3 + v.Z.D2 * u.Z.D3 + u.X.D2 * v.X.D3 + u.Y.D2 * v.Y.D3 + u.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * u.X.D2D4 + d1 * u.Y.D2D4 + d2 * u.Z.D2D4 + d3 * v.X.D2D4 + d4 * v.Y.D2D4 + d5 * v.Z.D2D4 + v.X.D2 * u.X.D4 + v.Y.D2 * u.Y.D4 + v.Z.D2 * u.Z.D4 + u.X.D2 * v.X.D4 + u.Y.D2 * v.Y.D4 + u.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * u.X.D2D5 + d1 * u.Y.D2D5 + d2 * u.Z.D2D5 + d3 * v.X.D2D5 + d4 * v.Y.D2D5 + d5 * v.Z.D2D5 + v.X.D2 * u.X.D5 + v.Y.D2 * u.Y.D5 + v.Z.D2 * u.Z.D5 + u.X.D2 * v.X.D5 + u.Y.D2 * v.Y.D5 + u.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * u.X.D2D6 + d1 * u.Y.D2D6 + d2 * u.Z.D2D6 + d3 * v.X.D2D6 + d4 * v.Y.D2D6 + d5 * v.Z.D2D6 + v.X.D2 * u.X.D6 + v.Y.D2 * u.Y.D6 + v.Z.D2 * u.Z.D6 + u.X.D2 * v.X.D6 + u.Y.D2 * v.Y.D6 + u.Z.D2 * v.Z.D6;
        result.D3D3 = d0 * u.X.D3D3 + d1 * u.Y.D3D3 + d2 * u.Z.D3D3 + d3 * v.X.D3D3 + d4 * v.Y.D3D3 + d5 * v.Z.D3D3 + v.X.D3 * u.X.D3 + v.Y.D3 * u.Y.D3 + v.Z.D3 * u.Z.D3 + u.X.D3 * v.X.D3 + u.Y.D3 * v.Y.D3 + u.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * u.X.D3D4 + d1 * u.Y.D3D4 + d2 * u.Z.D3D4 + d3 * v.X.D3D4 + d4 * v.Y.D3D4 + d5 * v.Z.D3D4 + v.X.D3 * u.X.D4 + v.Y.D3 * u.Y.D4 + v.Z.D3 * u.Z.D4 + u.X.D3 * v.X.D4 + u.Y.D3 * v.Y.D4 + u.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * u.X.D3D5 + d1 * u.Y.D3D5 + d2 * u.Z.D3D5 + d3 * v.X.D3D5 + d4 * v.Y.D3D5 + d5 * v.Z.D3D5 + v.X.D3 * u.X.D5 + v.Y.D3 * u.Y.D5 + v.Z.D3 * u.Z.D5 + u.X.D3 * v.X.D5 + u.Y.D3 * v.Y.D5 + u.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * u.X.D3D6 + d1 * u.Y.D3D6 + d2 * u.Z.D3D6 + d3 * v.X.D3D6 + d4 * v.Y.D3D6 + d5 * v.Z.D3D6 + v.X.D3 * u.X.D6 + v.Y.D3 * u.Y.D6 + v.Z.D3 * u.Z.D6 + u.X.D3 * v.X.D6 + u.Y.D3 * v.Y.D6 + u.Z.D3 * v.Z.D6;
        result.D4D4 = d0 * u.X.D4D4 + d1 * u.Y.D4D4 + d2 * u.Z.D4D4 + d3 * v.X.D4D4 + d4 * v.Y.D4D4 + d5 * v.Z.D4D4 + v.X.D4 * u.X.D4 + v.Y.D4 * u.Y.D4 + v.Z.D4 * u.Z.D4 + u.X.D4 * v.X.D4 + u.Y.D4 * v.Y.D4 + u.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * u.X.D4D5 + d1 * u.Y.D4D5 + d2 * u.Z.D4D5 + d3 * v.X.D4D5 + d4 * v.Y.D4D5 + d5 * v.Z.D4D5 + v.X.D4 * u.X.D5 + v.Y.D4 * u.Y.D5 + v.Z.D4 * u.Z.D5 + u.X.D4 * v.X.D5 + u.Y.D4 * v.Y.D5 + u.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * u.X.D4D6 + d1 * u.Y.D4D6 + d2 * u.Z.D4D6 + d3 * v.X.D4D6 + d4 * v.Y.D4D6 + d5 * v.Z.D4D6 + v.X.D4 * u.X.D6 + v.Y.D4 * u.Y.D6 + v.Z.D4 * u.Z.D6 + u.X.D4 * v.X.D6 + u.Y.D4 * v.Y.D6 + u.Z.D4 * v.Z.D6;
        result.D5D5 = d0 * u.X.D5D5 + d1 * u.Y.D5D5 + d2 * u.Z.D5D5 + d3 * v.X.D5D5 + d4 * v.Y.D5D5 + d5 * v.Z.D5D5 + v.X.D5 * u.X.D5 + v.Y.D5 * u.Y.D5 + v.Z.D5 * u.Z.D5 + u.X.D5 * v.X.D5 + u.Y.D5 * v.Y.D5 + u.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * u.X.D5D6 + d1 * u.Y.D5D6 + d2 * u.Z.D5D6 + d3 * v.X.D5D6 + d4 * v.Y.D5D6 + d5 * v.Z.D5D6 + v.X.D5 * u.X.D6 + v.Y.D5 * u.Y.D6 + v.Z.D5 * u.Z.D6 + u.X.D5 * v.X.D6 + u.Y.D5 * v.Y.D6 + u.Z.D5 * v.Z.D6;
        result.D6D6 = d0 * u.X.D6D6 + d1 * u.Y.D6D6 + d2 * u.Z.D6D6 + d3 * v.X.D6D6 + d4 * v.Y.D6D6 + d5 * v.Z.D6D6 + v.X.D6 * u.X.D6 + v.Y.D6 * u.Y.D6 + v.Z.D6 * u.Z.D6 + u.X.D6 * v.X.D6 + u.Y.D6 * v.Y.D6 + u.Z.D6 * v.Z.D6;

        return result;
    }

    public static DD8Scalar Dot(DD8Vector3 u, DD8Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD8Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * u.X.D0D3 + d1 * u.Y.D0D3 + d2 * u.Z.D0D3 + d3 * v.X.D0D3 + d4 * v.Y.D0D3 + d5 * v.Z.D0D3 + v.X.D0 * u.X.D3 + v.Y.D0 * u.Y.D3 + v.Z.D0 * u.Z.D3 + u.X.D0 * v.X.D3 + u.Y.D0 * v.Y.D3 + u.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * u.X.D0D4 + d1 * u.Y.D0D4 + d2 * u.Z.D0D4 + d3 * v.X.D0D4 + d4 * v.Y.D0D4 + d5 * v.Z.D0D4 + v.X.D0 * u.X.D4 + v.Y.D0 * u.Y.D4 + v.Z.D0 * u.Z.D4 + u.X.D0 * v.X.D4 + u.Y.D0 * v.Y.D4 + u.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * u.X.D0D5 + d1 * u.Y.D0D5 + d2 * u.Z.D0D5 + d3 * v.X.D0D5 + d4 * v.Y.D0D5 + d5 * v.Z.D0D5 + v.X.D0 * u.X.D5 + v.Y.D0 * u.Y.D5 + v.Z.D0 * u.Z.D5 + u.X.D0 * v.X.D5 + u.Y.D0 * v.Y.D5 + u.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * u.X.D0D6 + d1 * u.Y.D0D6 + d2 * u.Z.D0D6 + d3 * v.X.D0D6 + d4 * v.Y.D0D6 + d5 * v.Z.D0D6 + v.X.D0 * u.X.D6 + v.Y.D0 * u.Y.D6 + v.Z.D0 * u.Z.D6 + u.X.D0 * v.X.D6 + u.Y.D0 * v.Y.D6 + u.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * u.X.D0D7 + d1 * u.Y.D0D7 + d2 * u.Z.D0D7 + d3 * v.X.D0D7 + d4 * v.Y.D0D7 + d5 * v.Z.D0D7 + v.X.D0 * u.X.D7 + v.Y.D0 * u.Y.D7 + v.Z.D0 * u.Z.D7 + u.X.D0 * v.X.D7 + u.Y.D0 * v.Y.D7 + u.Z.D0 * v.Z.D7;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * u.X.D1D3 + d1 * u.Y.D1D3 + d2 * u.Z.D1D3 + d3 * v.X.D1D3 + d4 * v.Y.D1D3 + d5 * v.Z.D1D3 + v.X.D1 * u.X.D3 + v.Y.D1 * u.Y.D3 + v.Z.D1 * u.Z.D3 + u.X.D1 * v.X.D3 + u.Y.D1 * v.Y.D3 + u.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * u.X.D1D4 + d1 * u.Y.D1D4 + d2 * u.Z.D1D4 + d3 * v.X.D1D4 + d4 * v.Y.D1D4 + d5 * v.Z.D1D4 + v.X.D1 * u.X.D4 + v.Y.D1 * u.Y.D4 + v.Z.D1 * u.Z.D4 + u.X.D1 * v.X.D4 + u.Y.D1 * v.Y.D4 + u.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * u.X.D1D5 + d1 * u.Y.D1D5 + d2 * u.Z.D1D5 + d3 * v.X.D1D5 + d4 * v.Y.D1D5 + d5 * v.Z.D1D5 + v.X.D1 * u.X.D5 + v.Y.D1 * u.Y.D5 + v.Z.D1 * u.Z.D5 + u.X.D1 * v.X.D5 + u.Y.D1 * v.Y.D5 + u.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * u.X.D1D6 + d1 * u.Y.D1D6 + d2 * u.Z.D1D6 + d3 * v.X.D1D6 + d4 * v.Y.D1D6 + d5 * v.Z.D1D6 + v.X.D1 * u.X.D6 + v.Y.D1 * u.Y.D6 + v.Z.D1 * u.Z.D6 + u.X.D1 * v.X.D6 + u.Y.D1 * v.Y.D6 + u.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * u.X.D1D7 + d1 * u.Y.D1D7 + d2 * u.Z.D1D7 + d3 * v.X.D1D7 + d4 * v.Y.D1D7 + d5 * v.Z.D1D7 + v.X.D1 * u.X.D7 + v.Y.D1 * u.Y.D7 + v.Z.D1 * u.Z.D7 + u.X.D1 * v.X.D7 + u.Y.D1 * v.Y.D7 + u.Z.D1 * v.Z.D7;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * u.X.D2D3 + d1 * u.Y.D2D3 + d2 * u.Z.D2D3 + d3 * v.X.D2D3 + d4 * v.Y.D2D3 + d5 * v.Z.D2D3 + v.X.D2 * u.X.D3 + v.Y.D2 * u.Y.D3 + v.Z.D2 * u.Z.D3 + u.X.D2 * v.X.D3 + u.Y.D2 * v.Y.D3 + u.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * u.X.D2D4 + d1 * u.Y.D2D4 + d2 * u.Z.D2D4 + d3 * v.X.D2D4 + d4 * v.Y.D2D4 + d5 * v.Z.D2D4 + v.X.D2 * u.X.D4 + v.Y.D2 * u.Y.D4 + v.Z.D2 * u.Z.D4 + u.X.D2 * v.X.D4 + u.Y.D2 * v.Y.D4 + u.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * u.X.D2D5 + d1 * u.Y.D2D5 + d2 * u.Z.D2D5 + d3 * v.X.D2D5 + d4 * v.Y.D2D5 + d5 * v.Z.D2D5 + v.X.D2 * u.X.D5 + v.Y.D2 * u.Y.D5 + v.Z.D2 * u.Z.D5 + u.X.D2 * v.X.D5 + u.Y.D2 * v.Y.D5 + u.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * u.X.D2D6 + d1 * u.Y.D2D6 + d2 * u.Z.D2D6 + d3 * v.X.D2D6 + d4 * v.Y.D2D6 + d5 * v.Z.D2D6 + v.X.D2 * u.X.D6 + v.Y.D2 * u.Y.D6 + v.Z.D2 * u.Z.D6 + u.X.D2 * v.X.D6 + u.Y.D2 * v.Y.D6 + u.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * u.X.D2D7 + d1 * u.Y.D2D7 + d2 * u.Z.D2D7 + d3 * v.X.D2D7 + d4 * v.Y.D2D7 + d5 * v.Z.D2D7 + v.X.D2 * u.X.D7 + v.Y.D2 * u.Y.D7 + v.Z.D2 * u.Z.D7 + u.X.D2 * v.X.D7 + u.Y.D2 * v.Y.D7 + u.Z.D2 * v.Z.D7;
        result.D3D3 = d0 * u.X.D3D3 + d1 * u.Y.D3D3 + d2 * u.Z.D3D3 + d3 * v.X.D3D3 + d4 * v.Y.D3D3 + d5 * v.Z.D3D3 + v.X.D3 * u.X.D3 + v.Y.D3 * u.Y.D3 + v.Z.D3 * u.Z.D3 + u.X.D3 * v.X.D3 + u.Y.D3 * v.Y.D3 + u.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * u.X.D3D4 + d1 * u.Y.D3D4 + d2 * u.Z.D3D4 + d3 * v.X.D3D4 + d4 * v.Y.D3D4 + d5 * v.Z.D3D4 + v.X.D3 * u.X.D4 + v.Y.D3 * u.Y.D4 + v.Z.D3 * u.Z.D4 + u.X.D3 * v.X.D4 + u.Y.D3 * v.Y.D4 + u.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * u.X.D3D5 + d1 * u.Y.D3D5 + d2 * u.Z.D3D5 + d3 * v.X.D3D5 + d4 * v.Y.D3D5 + d5 * v.Z.D3D5 + v.X.D3 * u.X.D5 + v.Y.D3 * u.Y.D5 + v.Z.D3 * u.Z.D5 + u.X.D3 * v.X.D5 + u.Y.D3 * v.Y.D5 + u.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * u.X.D3D6 + d1 * u.Y.D3D6 + d2 * u.Z.D3D6 + d3 * v.X.D3D6 + d4 * v.Y.D3D6 + d5 * v.Z.D3D6 + v.X.D3 * u.X.D6 + v.Y.D3 * u.Y.D6 + v.Z.D3 * u.Z.D6 + u.X.D3 * v.X.D6 + u.Y.D3 * v.Y.D6 + u.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * u.X.D3D7 + d1 * u.Y.D3D7 + d2 * u.Z.D3D7 + d3 * v.X.D3D7 + d4 * v.Y.D3D7 + d5 * v.Z.D3D7 + v.X.D3 * u.X.D7 + v.Y.D3 * u.Y.D7 + v.Z.D3 * u.Z.D7 + u.X.D3 * v.X.D7 + u.Y.D3 * v.Y.D7 + u.Z.D3 * v.Z.D7;
        result.D4D4 = d0 * u.X.D4D4 + d1 * u.Y.D4D4 + d2 * u.Z.D4D4 + d3 * v.X.D4D4 + d4 * v.Y.D4D4 + d5 * v.Z.D4D4 + v.X.D4 * u.X.D4 + v.Y.D4 * u.Y.D4 + v.Z.D4 * u.Z.D4 + u.X.D4 * v.X.D4 + u.Y.D4 * v.Y.D4 + u.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * u.X.D4D5 + d1 * u.Y.D4D5 + d2 * u.Z.D4D5 + d3 * v.X.D4D5 + d4 * v.Y.D4D5 + d5 * v.Z.D4D5 + v.X.D4 * u.X.D5 + v.Y.D4 * u.Y.D5 + v.Z.D4 * u.Z.D5 + u.X.D4 * v.X.D5 + u.Y.D4 * v.Y.D5 + u.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * u.X.D4D6 + d1 * u.Y.D4D6 + d2 * u.Z.D4D6 + d3 * v.X.D4D6 + d4 * v.Y.D4D6 + d5 * v.Z.D4D6 + v.X.D4 * u.X.D6 + v.Y.D4 * u.Y.D6 + v.Z.D4 * u.Z.D6 + u.X.D4 * v.X.D6 + u.Y.D4 * v.Y.D6 + u.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * u.X.D4D7 + d1 * u.Y.D4D7 + d2 * u.Z.D4D7 + d3 * v.X.D4D7 + d4 * v.Y.D4D7 + d5 * v.Z.D4D7 + v.X.D4 * u.X.D7 + v.Y.D4 * u.Y.D7 + v.Z.D4 * u.Z.D7 + u.X.D4 * v.X.D7 + u.Y.D4 * v.Y.D7 + u.Z.D4 * v.Z.D7;
        result.D5D5 = d0 * u.X.D5D5 + d1 * u.Y.D5D5 + d2 * u.Z.D5D5 + d3 * v.X.D5D5 + d4 * v.Y.D5D5 + d5 * v.Z.D5D5 + v.X.D5 * u.X.D5 + v.Y.D5 * u.Y.D5 + v.Z.D5 * u.Z.D5 + u.X.D5 * v.X.D5 + u.Y.D5 * v.Y.D5 + u.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * u.X.D5D6 + d1 * u.Y.D5D6 + d2 * u.Z.D5D6 + d3 * v.X.D5D6 + d4 * v.Y.D5D6 + d5 * v.Z.D5D6 + v.X.D5 * u.X.D6 + v.Y.D5 * u.Y.D6 + v.Z.D5 * u.Z.D6 + u.X.D5 * v.X.D6 + u.Y.D5 * v.Y.D6 + u.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * u.X.D5D7 + d1 * u.Y.D5D7 + d2 * u.Z.D5D7 + d3 * v.X.D5D7 + d4 * v.Y.D5D7 + d5 * v.Z.D5D7 + v.X.D5 * u.X.D7 + v.Y.D5 * u.Y.D7 + v.Z.D5 * u.Z.D7 + u.X.D5 * v.X.D7 + u.Y.D5 * v.Y.D7 + u.Z.D5 * v.Z.D7;
        result.D6D6 = d0 * u.X.D6D6 + d1 * u.Y.D6D6 + d2 * u.Z.D6D6 + d3 * v.X.D6D6 + d4 * v.Y.D6D6 + d5 * v.Z.D6D6 + v.X.D6 * u.X.D6 + v.Y.D6 * u.Y.D6 + v.Z.D6 * u.Z.D6 + u.X.D6 * v.X.D6 + u.Y.D6 * v.Y.D6 + u.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * u.X.D6D7 + d1 * u.Y.D6D7 + d2 * u.Z.D6D7 + d3 * v.X.D6D7 + d4 * v.Y.D6D7 + d5 * v.Z.D6D7 + v.X.D6 * u.X.D7 + v.Y.D6 * u.Y.D7 + v.Z.D6 * u.Z.D7 + u.X.D6 * v.X.D7 + u.Y.D6 * v.Y.D7 + u.Z.D6 * v.Z.D7;
        result.D7D7 = d0 * u.X.D7D7 + d1 * u.Y.D7D7 + d2 * u.Z.D7D7 + d3 * v.X.D7D7 + d4 * v.Y.D7D7 + d5 * v.Z.D7D7 + v.X.D7 * u.X.D7 + v.Y.D7 * u.Y.D7 + v.Z.D7 * u.Z.D7 + u.X.D7 * v.X.D7 + u.Y.D7 * v.Y.D7 + u.Z.D7 * v.Z.D7;

        return result;
    }

    public static DD9Scalar Dot(DD9Vector3 u, DD9Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD9Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;
        result.D8 = d0 * u.X.D8 + d1 * u.Y.D8 + d2 * u.Z.D8 + d3 * v.X.D8 + d4 * v.Y.D8 + d5 * v.Z.D8;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * u.X.D0D3 + d1 * u.Y.D0D3 + d2 * u.Z.D0D3 + d3 * v.X.D0D3 + d4 * v.Y.D0D3 + d5 * v.Z.D0D3 + v.X.D0 * u.X.D3 + v.Y.D0 * u.Y.D3 + v.Z.D0 * u.Z.D3 + u.X.D0 * v.X.D3 + u.Y.D0 * v.Y.D3 + u.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * u.X.D0D4 + d1 * u.Y.D0D4 + d2 * u.Z.D0D4 + d3 * v.X.D0D4 + d4 * v.Y.D0D4 + d5 * v.Z.D0D4 + v.X.D0 * u.X.D4 + v.Y.D0 * u.Y.D4 + v.Z.D0 * u.Z.D4 + u.X.D0 * v.X.D4 + u.Y.D0 * v.Y.D4 + u.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * u.X.D0D5 + d1 * u.Y.D0D5 + d2 * u.Z.D0D5 + d3 * v.X.D0D5 + d4 * v.Y.D0D5 + d5 * v.Z.D0D5 + v.X.D0 * u.X.D5 + v.Y.D0 * u.Y.D5 + v.Z.D0 * u.Z.D5 + u.X.D0 * v.X.D5 + u.Y.D0 * v.Y.D5 + u.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * u.X.D0D6 + d1 * u.Y.D0D6 + d2 * u.Z.D0D6 + d3 * v.X.D0D6 + d4 * v.Y.D0D6 + d5 * v.Z.D0D6 + v.X.D0 * u.X.D6 + v.Y.D0 * u.Y.D6 + v.Z.D0 * u.Z.D6 + u.X.D0 * v.X.D6 + u.Y.D0 * v.Y.D6 + u.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * u.X.D0D7 + d1 * u.Y.D0D7 + d2 * u.Z.D0D7 + d3 * v.X.D0D7 + d4 * v.Y.D0D7 + d5 * v.Z.D0D7 + v.X.D0 * u.X.D7 + v.Y.D0 * u.Y.D7 + v.Z.D0 * u.Z.D7 + u.X.D0 * v.X.D7 + u.Y.D0 * v.Y.D7 + u.Z.D0 * v.Z.D7;
        result.D0D8 = d0 * u.X.D0D8 + d1 * u.Y.D0D8 + d2 * u.Z.D0D8 + d3 * v.X.D0D8 + d4 * v.Y.D0D8 + d5 * v.Z.D0D8 + v.X.D0 * u.X.D8 + v.Y.D0 * u.Y.D8 + v.Z.D0 * u.Z.D8 + u.X.D0 * v.X.D8 + u.Y.D0 * v.Y.D8 + u.Z.D0 * v.Z.D8;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * u.X.D1D3 + d1 * u.Y.D1D3 + d2 * u.Z.D1D3 + d3 * v.X.D1D3 + d4 * v.Y.D1D3 + d5 * v.Z.D1D3 + v.X.D1 * u.X.D3 + v.Y.D1 * u.Y.D3 + v.Z.D1 * u.Z.D3 + u.X.D1 * v.X.D3 + u.Y.D1 * v.Y.D3 + u.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * u.X.D1D4 + d1 * u.Y.D1D4 + d2 * u.Z.D1D4 + d3 * v.X.D1D4 + d4 * v.Y.D1D4 + d5 * v.Z.D1D4 + v.X.D1 * u.X.D4 + v.Y.D1 * u.Y.D4 + v.Z.D1 * u.Z.D4 + u.X.D1 * v.X.D4 + u.Y.D1 * v.Y.D4 + u.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * u.X.D1D5 + d1 * u.Y.D1D5 + d2 * u.Z.D1D5 + d3 * v.X.D1D5 + d4 * v.Y.D1D5 + d5 * v.Z.D1D5 + v.X.D1 * u.X.D5 + v.Y.D1 * u.Y.D5 + v.Z.D1 * u.Z.D5 + u.X.D1 * v.X.D5 + u.Y.D1 * v.Y.D5 + u.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * u.X.D1D6 + d1 * u.Y.D1D6 + d2 * u.Z.D1D6 + d3 * v.X.D1D6 + d4 * v.Y.D1D6 + d5 * v.Z.D1D6 + v.X.D1 * u.X.D6 + v.Y.D1 * u.Y.D6 + v.Z.D1 * u.Z.D6 + u.X.D1 * v.X.D6 + u.Y.D1 * v.Y.D6 + u.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * u.X.D1D7 + d1 * u.Y.D1D7 + d2 * u.Z.D1D7 + d3 * v.X.D1D7 + d4 * v.Y.D1D7 + d5 * v.Z.D1D7 + v.X.D1 * u.X.D7 + v.Y.D1 * u.Y.D7 + v.Z.D1 * u.Z.D7 + u.X.D1 * v.X.D7 + u.Y.D1 * v.Y.D7 + u.Z.D1 * v.Z.D7;
        result.D1D8 = d0 * u.X.D1D8 + d1 * u.Y.D1D8 + d2 * u.Z.D1D8 + d3 * v.X.D1D8 + d4 * v.Y.D1D8 + d5 * v.Z.D1D8 + v.X.D1 * u.X.D8 + v.Y.D1 * u.Y.D8 + v.Z.D1 * u.Z.D8 + u.X.D1 * v.X.D8 + u.Y.D1 * v.Y.D8 + u.Z.D1 * v.Z.D8;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * u.X.D2D3 + d1 * u.Y.D2D3 + d2 * u.Z.D2D3 + d3 * v.X.D2D3 + d4 * v.Y.D2D3 + d5 * v.Z.D2D3 + v.X.D2 * u.X.D3 + v.Y.D2 * u.Y.D3 + v.Z.D2 * u.Z.D3 + u.X.D2 * v.X.D3 + u.Y.D2 * v.Y.D3 + u.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * u.X.D2D4 + d1 * u.Y.D2D4 + d2 * u.Z.D2D4 + d3 * v.X.D2D4 + d4 * v.Y.D2D4 + d5 * v.Z.D2D4 + v.X.D2 * u.X.D4 + v.Y.D2 * u.Y.D4 + v.Z.D2 * u.Z.D4 + u.X.D2 * v.X.D4 + u.Y.D2 * v.Y.D4 + u.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * u.X.D2D5 + d1 * u.Y.D2D5 + d2 * u.Z.D2D5 + d3 * v.X.D2D5 + d4 * v.Y.D2D5 + d5 * v.Z.D2D5 + v.X.D2 * u.X.D5 + v.Y.D2 * u.Y.D5 + v.Z.D2 * u.Z.D5 + u.X.D2 * v.X.D5 + u.Y.D2 * v.Y.D5 + u.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * u.X.D2D6 + d1 * u.Y.D2D6 + d2 * u.Z.D2D6 + d3 * v.X.D2D6 + d4 * v.Y.D2D6 + d5 * v.Z.D2D6 + v.X.D2 * u.X.D6 + v.Y.D2 * u.Y.D6 + v.Z.D2 * u.Z.D6 + u.X.D2 * v.X.D6 + u.Y.D2 * v.Y.D6 + u.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * u.X.D2D7 + d1 * u.Y.D2D7 + d2 * u.Z.D2D7 + d3 * v.X.D2D7 + d4 * v.Y.D2D7 + d5 * v.Z.D2D7 + v.X.D2 * u.X.D7 + v.Y.D2 * u.Y.D7 + v.Z.D2 * u.Z.D7 + u.X.D2 * v.X.D7 + u.Y.D2 * v.Y.D7 + u.Z.D2 * v.Z.D7;
        result.D2D8 = d0 * u.X.D2D8 + d1 * u.Y.D2D8 + d2 * u.Z.D2D8 + d3 * v.X.D2D8 + d4 * v.Y.D2D8 + d5 * v.Z.D2D8 + v.X.D2 * u.X.D8 + v.Y.D2 * u.Y.D8 + v.Z.D2 * u.Z.D8 + u.X.D2 * v.X.D8 + u.Y.D2 * v.Y.D8 + u.Z.D2 * v.Z.D8;
        result.D3D3 = d0 * u.X.D3D3 + d1 * u.Y.D3D3 + d2 * u.Z.D3D3 + d3 * v.X.D3D3 + d4 * v.Y.D3D3 + d5 * v.Z.D3D3 + v.X.D3 * u.X.D3 + v.Y.D3 * u.Y.D3 + v.Z.D3 * u.Z.D3 + u.X.D3 * v.X.D3 + u.Y.D3 * v.Y.D3 + u.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * u.X.D3D4 + d1 * u.Y.D3D4 + d2 * u.Z.D3D4 + d3 * v.X.D3D4 + d4 * v.Y.D3D4 + d5 * v.Z.D3D4 + v.X.D3 * u.X.D4 + v.Y.D3 * u.Y.D4 + v.Z.D3 * u.Z.D4 + u.X.D3 * v.X.D4 + u.Y.D3 * v.Y.D4 + u.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * u.X.D3D5 + d1 * u.Y.D3D5 + d2 * u.Z.D3D5 + d3 * v.X.D3D5 + d4 * v.Y.D3D5 + d5 * v.Z.D3D5 + v.X.D3 * u.X.D5 + v.Y.D3 * u.Y.D5 + v.Z.D3 * u.Z.D5 + u.X.D3 * v.X.D5 + u.Y.D3 * v.Y.D5 + u.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * u.X.D3D6 + d1 * u.Y.D3D6 + d2 * u.Z.D3D6 + d3 * v.X.D3D6 + d4 * v.Y.D3D6 + d5 * v.Z.D3D6 + v.X.D3 * u.X.D6 + v.Y.D3 * u.Y.D6 + v.Z.D3 * u.Z.D6 + u.X.D3 * v.X.D6 + u.Y.D3 * v.Y.D6 + u.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * u.X.D3D7 + d1 * u.Y.D3D7 + d2 * u.Z.D3D7 + d3 * v.X.D3D7 + d4 * v.Y.D3D7 + d5 * v.Z.D3D7 + v.X.D3 * u.X.D7 + v.Y.D3 * u.Y.D7 + v.Z.D3 * u.Z.D7 + u.X.D3 * v.X.D7 + u.Y.D3 * v.Y.D7 + u.Z.D3 * v.Z.D7;
        result.D3D8 = d0 * u.X.D3D8 + d1 * u.Y.D3D8 + d2 * u.Z.D3D8 + d3 * v.X.D3D8 + d4 * v.Y.D3D8 + d5 * v.Z.D3D8 + v.X.D3 * u.X.D8 + v.Y.D3 * u.Y.D8 + v.Z.D3 * u.Z.D8 + u.X.D3 * v.X.D8 + u.Y.D3 * v.Y.D8 + u.Z.D3 * v.Z.D8;
        result.D4D4 = d0 * u.X.D4D4 + d1 * u.Y.D4D4 + d2 * u.Z.D4D4 + d3 * v.X.D4D4 + d4 * v.Y.D4D4 + d5 * v.Z.D4D4 + v.X.D4 * u.X.D4 + v.Y.D4 * u.Y.D4 + v.Z.D4 * u.Z.D4 + u.X.D4 * v.X.D4 + u.Y.D4 * v.Y.D4 + u.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * u.X.D4D5 + d1 * u.Y.D4D5 + d2 * u.Z.D4D5 + d3 * v.X.D4D5 + d4 * v.Y.D4D5 + d5 * v.Z.D4D5 + v.X.D4 * u.X.D5 + v.Y.D4 * u.Y.D5 + v.Z.D4 * u.Z.D5 + u.X.D4 * v.X.D5 + u.Y.D4 * v.Y.D5 + u.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * u.X.D4D6 + d1 * u.Y.D4D6 + d2 * u.Z.D4D6 + d3 * v.X.D4D6 + d4 * v.Y.D4D6 + d5 * v.Z.D4D6 + v.X.D4 * u.X.D6 + v.Y.D4 * u.Y.D6 + v.Z.D4 * u.Z.D6 + u.X.D4 * v.X.D6 + u.Y.D4 * v.Y.D6 + u.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * u.X.D4D7 + d1 * u.Y.D4D7 + d2 * u.Z.D4D7 + d3 * v.X.D4D7 + d4 * v.Y.D4D7 + d5 * v.Z.D4D7 + v.X.D4 * u.X.D7 + v.Y.D4 * u.Y.D7 + v.Z.D4 * u.Z.D7 + u.X.D4 * v.X.D7 + u.Y.D4 * v.Y.D7 + u.Z.D4 * v.Z.D7;
        result.D4D8 = d0 * u.X.D4D8 + d1 * u.Y.D4D8 + d2 * u.Z.D4D8 + d3 * v.X.D4D8 + d4 * v.Y.D4D8 + d5 * v.Z.D4D8 + v.X.D4 * u.X.D8 + v.Y.D4 * u.Y.D8 + v.Z.D4 * u.Z.D8 + u.X.D4 * v.X.D8 + u.Y.D4 * v.Y.D8 + u.Z.D4 * v.Z.D8;
        result.D5D5 = d0 * u.X.D5D5 + d1 * u.Y.D5D5 + d2 * u.Z.D5D5 + d3 * v.X.D5D5 + d4 * v.Y.D5D5 + d5 * v.Z.D5D5 + v.X.D5 * u.X.D5 + v.Y.D5 * u.Y.D5 + v.Z.D5 * u.Z.D5 + u.X.D5 * v.X.D5 + u.Y.D5 * v.Y.D5 + u.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * u.X.D5D6 + d1 * u.Y.D5D6 + d2 * u.Z.D5D6 + d3 * v.X.D5D6 + d4 * v.Y.D5D6 + d5 * v.Z.D5D6 + v.X.D5 * u.X.D6 + v.Y.D5 * u.Y.D6 + v.Z.D5 * u.Z.D6 + u.X.D5 * v.X.D6 + u.Y.D5 * v.Y.D6 + u.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * u.X.D5D7 + d1 * u.Y.D5D7 + d2 * u.Z.D5D7 + d3 * v.X.D5D7 + d4 * v.Y.D5D7 + d5 * v.Z.D5D7 + v.X.D5 * u.X.D7 + v.Y.D5 * u.Y.D7 + v.Z.D5 * u.Z.D7 + u.X.D5 * v.X.D7 + u.Y.D5 * v.Y.D7 + u.Z.D5 * v.Z.D7;
        result.D5D8 = d0 * u.X.D5D8 + d1 * u.Y.D5D8 + d2 * u.Z.D5D8 + d3 * v.X.D5D8 + d4 * v.Y.D5D8 + d5 * v.Z.D5D8 + v.X.D5 * u.X.D8 + v.Y.D5 * u.Y.D8 + v.Z.D5 * u.Z.D8 + u.X.D5 * v.X.D8 + u.Y.D5 * v.Y.D8 + u.Z.D5 * v.Z.D8;
        result.D6D6 = d0 * u.X.D6D6 + d1 * u.Y.D6D6 + d2 * u.Z.D6D6 + d3 * v.X.D6D6 + d4 * v.Y.D6D6 + d5 * v.Z.D6D6 + v.X.D6 * u.X.D6 + v.Y.D6 * u.Y.D6 + v.Z.D6 * u.Z.D6 + u.X.D6 * v.X.D6 + u.Y.D6 * v.Y.D6 + u.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * u.X.D6D7 + d1 * u.Y.D6D7 + d2 * u.Z.D6D7 + d3 * v.X.D6D7 + d4 * v.Y.D6D7 + d5 * v.Z.D6D7 + v.X.D6 * u.X.D7 + v.Y.D6 * u.Y.D7 + v.Z.D6 * u.Z.D7 + u.X.D6 * v.X.D7 + u.Y.D6 * v.Y.D7 + u.Z.D6 * v.Z.D7;
        result.D6D8 = d0 * u.X.D6D8 + d1 * u.Y.D6D8 + d2 * u.Z.D6D8 + d3 * v.X.D6D8 + d4 * v.Y.D6D8 + d5 * v.Z.D6D8 + v.X.D6 * u.X.D8 + v.Y.D6 * u.Y.D8 + v.Z.D6 * u.Z.D8 + u.X.D6 * v.X.D8 + u.Y.D6 * v.Y.D8 + u.Z.D6 * v.Z.D8;
        result.D7D7 = d0 * u.X.D7D7 + d1 * u.Y.D7D7 + d2 * u.Z.D7D7 + d3 * v.X.D7D7 + d4 * v.Y.D7D7 + d5 * v.Z.D7D7 + v.X.D7 * u.X.D7 + v.Y.D7 * u.Y.D7 + v.Z.D7 * u.Z.D7 + u.X.D7 * v.X.D7 + u.Y.D7 * v.Y.D7 + u.Z.D7 * v.Z.D7;
        result.D7D8 = d0 * u.X.D7D8 + d1 * u.Y.D7D8 + d2 * u.Z.D7D8 + d3 * v.X.D7D8 + d4 * v.Y.D7D8 + d5 * v.Z.D7D8 + v.X.D7 * u.X.D8 + v.Y.D7 * u.Y.D8 + v.Z.D7 * u.Z.D8 + u.X.D7 * v.X.D8 + u.Y.D7 * v.Y.D8 + u.Z.D7 * v.Z.D8;
        result.D8D8 = d0 * u.X.D8D8 + d1 * u.Y.D8D8 + d2 * u.Z.D8D8 + d3 * v.X.D8D8 + d4 * v.Y.D8D8 + d5 * v.Z.D8D8 + v.X.D8 * u.X.D8 + v.Y.D8 * u.Y.D8 + v.Z.D8 * u.Z.D8 + u.X.D8 * v.X.D8 + u.Y.D8 * v.Y.D8 + u.Z.D8 * v.Z.D8;

        return result;
    }

    public static DD10Scalar Dot(DD10Vector3 u, DD10Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD10Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;
        result.D8 = d0 * u.X.D8 + d1 * u.Y.D8 + d2 * u.Z.D8 + d3 * v.X.D8 + d4 * v.Y.D8 + d5 * v.Z.D8;
        result.D9 = d0 * u.X.D9 + d1 * u.Y.D9 + d2 * u.Z.D9 + d3 * v.X.D9 + d4 * v.Y.D9 + d5 * v.Z.D9;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * u.X.D0D3 + d1 * u.Y.D0D3 + d2 * u.Z.D0D3 + d3 * v.X.D0D3 + d4 * v.Y.D0D3 + d5 * v.Z.D0D3 + v.X.D0 * u.X.D3 + v.Y.D0 * u.Y.D3 + v.Z.D0 * u.Z.D3 + u.X.D0 * v.X.D3 + u.Y.D0 * v.Y.D3 + u.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * u.X.D0D4 + d1 * u.Y.D0D4 + d2 * u.Z.D0D4 + d3 * v.X.D0D4 + d4 * v.Y.D0D4 + d5 * v.Z.D0D4 + v.X.D0 * u.X.D4 + v.Y.D0 * u.Y.D4 + v.Z.D0 * u.Z.D4 + u.X.D0 * v.X.D4 + u.Y.D0 * v.Y.D4 + u.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * u.X.D0D5 + d1 * u.Y.D0D5 + d2 * u.Z.D0D5 + d3 * v.X.D0D5 + d4 * v.Y.D0D5 + d5 * v.Z.D0D5 + v.X.D0 * u.X.D5 + v.Y.D0 * u.Y.D5 + v.Z.D0 * u.Z.D5 + u.X.D0 * v.X.D5 + u.Y.D0 * v.Y.D5 + u.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * u.X.D0D6 + d1 * u.Y.D0D6 + d2 * u.Z.D0D6 + d3 * v.X.D0D6 + d4 * v.Y.D0D6 + d5 * v.Z.D0D6 + v.X.D0 * u.X.D6 + v.Y.D0 * u.Y.D6 + v.Z.D0 * u.Z.D6 + u.X.D0 * v.X.D6 + u.Y.D0 * v.Y.D6 + u.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * u.X.D0D7 + d1 * u.Y.D0D7 + d2 * u.Z.D0D7 + d3 * v.X.D0D7 + d4 * v.Y.D0D7 + d5 * v.Z.D0D7 + v.X.D0 * u.X.D7 + v.Y.D0 * u.Y.D7 + v.Z.D0 * u.Z.D7 + u.X.D0 * v.X.D7 + u.Y.D0 * v.Y.D7 + u.Z.D0 * v.Z.D7;
        result.D0D8 = d0 * u.X.D0D8 + d1 * u.Y.D0D8 + d2 * u.Z.D0D8 + d3 * v.X.D0D8 + d4 * v.Y.D0D8 + d5 * v.Z.D0D8 + v.X.D0 * u.X.D8 + v.Y.D0 * u.Y.D8 + v.Z.D0 * u.Z.D8 + u.X.D0 * v.X.D8 + u.Y.D0 * v.Y.D8 + u.Z.D0 * v.Z.D8;
        result.D0D9 = d0 * u.X.D0D9 + d1 * u.Y.D0D9 + d2 * u.Z.D0D9 + d3 * v.X.D0D9 + d4 * v.Y.D0D9 + d5 * v.Z.D0D9 + v.X.D0 * u.X.D9 + v.Y.D0 * u.Y.D9 + v.Z.D0 * u.Z.D9 + u.X.D0 * v.X.D9 + u.Y.D0 * v.Y.D9 + u.Z.D0 * v.Z.D9;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * u.X.D1D3 + d1 * u.Y.D1D3 + d2 * u.Z.D1D3 + d3 * v.X.D1D3 + d4 * v.Y.D1D3 + d5 * v.Z.D1D3 + v.X.D1 * u.X.D3 + v.Y.D1 * u.Y.D3 + v.Z.D1 * u.Z.D3 + u.X.D1 * v.X.D3 + u.Y.D1 * v.Y.D3 + u.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * u.X.D1D4 + d1 * u.Y.D1D4 + d2 * u.Z.D1D4 + d3 * v.X.D1D4 + d4 * v.Y.D1D4 + d5 * v.Z.D1D4 + v.X.D1 * u.X.D4 + v.Y.D1 * u.Y.D4 + v.Z.D1 * u.Z.D4 + u.X.D1 * v.X.D4 + u.Y.D1 * v.Y.D4 + u.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * u.X.D1D5 + d1 * u.Y.D1D5 + d2 * u.Z.D1D5 + d3 * v.X.D1D5 + d4 * v.Y.D1D5 + d5 * v.Z.D1D5 + v.X.D1 * u.X.D5 + v.Y.D1 * u.Y.D5 + v.Z.D1 * u.Z.D5 + u.X.D1 * v.X.D5 + u.Y.D1 * v.Y.D5 + u.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * u.X.D1D6 + d1 * u.Y.D1D6 + d2 * u.Z.D1D6 + d3 * v.X.D1D6 + d4 * v.Y.D1D6 + d5 * v.Z.D1D6 + v.X.D1 * u.X.D6 + v.Y.D1 * u.Y.D6 + v.Z.D1 * u.Z.D6 + u.X.D1 * v.X.D6 + u.Y.D1 * v.Y.D6 + u.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * u.X.D1D7 + d1 * u.Y.D1D7 + d2 * u.Z.D1D7 + d3 * v.X.D1D7 + d4 * v.Y.D1D7 + d5 * v.Z.D1D7 + v.X.D1 * u.X.D7 + v.Y.D1 * u.Y.D7 + v.Z.D1 * u.Z.D7 + u.X.D1 * v.X.D7 + u.Y.D1 * v.Y.D7 + u.Z.D1 * v.Z.D7;
        result.D1D8 = d0 * u.X.D1D8 + d1 * u.Y.D1D8 + d2 * u.Z.D1D8 + d3 * v.X.D1D8 + d4 * v.Y.D1D8 + d5 * v.Z.D1D8 + v.X.D1 * u.X.D8 + v.Y.D1 * u.Y.D8 + v.Z.D1 * u.Z.D8 + u.X.D1 * v.X.D8 + u.Y.D1 * v.Y.D8 + u.Z.D1 * v.Z.D8;
        result.D1D9 = d0 * u.X.D1D9 + d1 * u.Y.D1D9 + d2 * u.Z.D1D9 + d3 * v.X.D1D9 + d4 * v.Y.D1D9 + d5 * v.Z.D1D9 + v.X.D1 * u.X.D9 + v.Y.D1 * u.Y.D9 + v.Z.D1 * u.Z.D9 + u.X.D1 * v.X.D9 + u.Y.D1 * v.Y.D9 + u.Z.D1 * v.Z.D9;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * u.X.D2D3 + d1 * u.Y.D2D3 + d2 * u.Z.D2D3 + d3 * v.X.D2D3 + d4 * v.Y.D2D3 + d5 * v.Z.D2D3 + v.X.D2 * u.X.D3 + v.Y.D2 * u.Y.D3 + v.Z.D2 * u.Z.D3 + u.X.D2 * v.X.D3 + u.Y.D2 * v.Y.D3 + u.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * u.X.D2D4 + d1 * u.Y.D2D4 + d2 * u.Z.D2D4 + d3 * v.X.D2D4 + d4 * v.Y.D2D4 + d5 * v.Z.D2D4 + v.X.D2 * u.X.D4 + v.Y.D2 * u.Y.D4 + v.Z.D2 * u.Z.D4 + u.X.D2 * v.X.D4 + u.Y.D2 * v.Y.D4 + u.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * u.X.D2D5 + d1 * u.Y.D2D5 + d2 * u.Z.D2D5 + d3 * v.X.D2D5 + d4 * v.Y.D2D5 + d5 * v.Z.D2D5 + v.X.D2 * u.X.D5 + v.Y.D2 * u.Y.D5 + v.Z.D2 * u.Z.D5 + u.X.D2 * v.X.D5 + u.Y.D2 * v.Y.D5 + u.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * u.X.D2D6 + d1 * u.Y.D2D6 + d2 * u.Z.D2D6 + d3 * v.X.D2D6 + d4 * v.Y.D2D6 + d5 * v.Z.D2D6 + v.X.D2 * u.X.D6 + v.Y.D2 * u.Y.D6 + v.Z.D2 * u.Z.D6 + u.X.D2 * v.X.D6 + u.Y.D2 * v.Y.D6 + u.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * u.X.D2D7 + d1 * u.Y.D2D7 + d2 * u.Z.D2D7 + d3 * v.X.D2D7 + d4 * v.Y.D2D7 + d5 * v.Z.D2D7 + v.X.D2 * u.X.D7 + v.Y.D2 * u.Y.D7 + v.Z.D2 * u.Z.D7 + u.X.D2 * v.X.D7 + u.Y.D2 * v.Y.D7 + u.Z.D2 * v.Z.D7;
        result.D2D8 = d0 * u.X.D2D8 + d1 * u.Y.D2D8 + d2 * u.Z.D2D8 + d3 * v.X.D2D8 + d4 * v.Y.D2D8 + d5 * v.Z.D2D8 + v.X.D2 * u.X.D8 + v.Y.D2 * u.Y.D8 + v.Z.D2 * u.Z.D8 + u.X.D2 * v.X.D8 + u.Y.D2 * v.Y.D8 + u.Z.D2 * v.Z.D8;
        result.D2D9 = d0 * u.X.D2D9 + d1 * u.Y.D2D9 + d2 * u.Z.D2D9 + d3 * v.X.D2D9 + d4 * v.Y.D2D9 + d5 * v.Z.D2D9 + v.X.D2 * u.X.D9 + v.Y.D2 * u.Y.D9 + v.Z.D2 * u.Z.D9 + u.X.D2 * v.X.D9 + u.Y.D2 * v.Y.D9 + u.Z.D2 * v.Z.D9;
        result.D3D3 = d0 * u.X.D3D3 + d1 * u.Y.D3D3 + d2 * u.Z.D3D3 + d3 * v.X.D3D3 + d4 * v.Y.D3D3 + d5 * v.Z.D3D3 + v.X.D3 * u.X.D3 + v.Y.D3 * u.Y.D3 + v.Z.D3 * u.Z.D3 + u.X.D3 * v.X.D3 + u.Y.D3 * v.Y.D3 + u.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * u.X.D3D4 + d1 * u.Y.D3D4 + d2 * u.Z.D3D4 + d3 * v.X.D3D4 + d4 * v.Y.D3D4 + d5 * v.Z.D3D4 + v.X.D3 * u.X.D4 + v.Y.D3 * u.Y.D4 + v.Z.D3 * u.Z.D4 + u.X.D3 * v.X.D4 + u.Y.D3 * v.Y.D4 + u.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * u.X.D3D5 + d1 * u.Y.D3D5 + d2 * u.Z.D3D5 + d3 * v.X.D3D5 + d4 * v.Y.D3D5 + d5 * v.Z.D3D5 + v.X.D3 * u.X.D5 + v.Y.D3 * u.Y.D5 + v.Z.D3 * u.Z.D5 + u.X.D3 * v.X.D5 + u.Y.D3 * v.Y.D5 + u.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * u.X.D3D6 + d1 * u.Y.D3D6 + d2 * u.Z.D3D6 + d3 * v.X.D3D6 + d4 * v.Y.D3D6 + d5 * v.Z.D3D6 + v.X.D3 * u.X.D6 + v.Y.D3 * u.Y.D6 + v.Z.D3 * u.Z.D6 + u.X.D3 * v.X.D6 + u.Y.D3 * v.Y.D6 + u.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * u.X.D3D7 + d1 * u.Y.D3D7 + d2 * u.Z.D3D7 + d3 * v.X.D3D7 + d4 * v.Y.D3D7 + d5 * v.Z.D3D7 + v.X.D3 * u.X.D7 + v.Y.D3 * u.Y.D7 + v.Z.D3 * u.Z.D7 + u.X.D3 * v.X.D7 + u.Y.D3 * v.Y.D7 + u.Z.D3 * v.Z.D7;
        result.D3D8 = d0 * u.X.D3D8 + d1 * u.Y.D3D8 + d2 * u.Z.D3D8 + d3 * v.X.D3D8 + d4 * v.Y.D3D8 + d5 * v.Z.D3D8 + v.X.D3 * u.X.D8 + v.Y.D3 * u.Y.D8 + v.Z.D3 * u.Z.D8 + u.X.D3 * v.X.D8 + u.Y.D3 * v.Y.D8 + u.Z.D3 * v.Z.D8;
        result.D3D9 = d0 * u.X.D3D9 + d1 * u.Y.D3D9 + d2 * u.Z.D3D9 + d3 * v.X.D3D9 + d4 * v.Y.D3D9 + d5 * v.Z.D3D9 + v.X.D3 * u.X.D9 + v.Y.D3 * u.Y.D9 + v.Z.D3 * u.Z.D9 + u.X.D3 * v.X.D9 + u.Y.D3 * v.Y.D9 + u.Z.D3 * v.Z.D9;
        result.D4D4 = d0 * u.X.D4D4 + d1 * u.Y.D4D4 + d2 * u.Z.D4D4 + d3 * v.X.D4D4 + d4 * v.Y.D4D4 + d5 * v.Z.D4D4 + v.X.D4 * u.X.D4 + v.Y.D4 * u.Y.D4 + v.Z.D4 * u.Z.D4 + u.X.D4 * v.X.D4 + u.Y.D4 * v.Y.D4 + u.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * u.X.D4D5 + d1 * u.Y.D4D5 + d2 * u.Z.D4D5 + d3 * v.X.D4D5 + d4 * v.Y.D4D5 + d5 * v.Z.D4D5 + v.X.D4 * u.X.D5 + v.Y.D4 * u.Y.D5 + v.Z.D4 * u.Z.D5 + u.X.D4 * v.X.D5 + u.Y.D4 * v.Y.D5 + u.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * u.X.D4D6 + d1 * u.Y.D4D6 + d2 * u.Z.D4D6 + d3 * v.X.D4D6 + d4 * v.Y.D4D6 + d5 * v.Z.D4D6 + v.X.D4 * u.X.D6 + v.Y.D4 * u.Y.D6 + v.Z.D4 * u.Z.D6 + u.X.D4 * v.X.D6 + u.Y.D4 * v.Y.D6 + u.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * u.X.D4D7 + d1 * u.Y.D4D7 + d2 * u.Z.D4D7 + d3 * v.X.D4D7 + d4 * v.Y.D4D7 + d5 * v.Z.D4D7 + v.X.D4 * u.X.D7 + v.Y.D4 * u.Y.D7 + v.Z.D4 * u.Z.D7 + u.X.D4 * v.X.D7 + u.Y.D4 * v.Y.D7 + u.Z.D4 * v.Z.D7;
        result.D4D8 = d0 * u.X.D4D8 + d1 * u.Y.D4D8 + d2 * u.Z.D4D8 + d3 * v.X.D4D8 + d4 * v.Y.D4D8 + d5 * v.Z.D4D8 + v.X.D4 * u.X.D8 + v.Y.D4 * u.Y.D8 + v.Z.D4 * u.Z.D8 + u.X.D4 * v.X.D8 + u.Y.D4 * v.Y.D8 + u.Z.D4 * v.Z.D8;
        result.D4D9 = d0 * u.X.D4D9 + d1 * u.Y.D4D9 + d2 * u.Z.D4D9 + d3 * v.X.D4D9 + d4 * v.Y.D4D9 + d5 * v.Z.D4D9 + v.X.D4 * u.X.D9 + v.Y.D4 * u.Y.D9 + v.Z.D4 * u.Z.D9 + u.X.D4 * v.X.D9 + u.Y.D4 * v.Y.D9 + u.Z.D4 * v.Z.D9;
        result.D5D5 = d0 * u.X.D5D5 + d1 * u.Y.D5D5 + d2 * u.Z.D5D5 + d3 * v.X.D5D5 + d4 * v.Y.D5D5 + d5 * v.Z.D5D5 + v.X.D5 * u.X.D5 + v.Y.D5 * u.Y.D5 + v.Z.D5 * u.Z.D5 + u.X.D5 * v.X.D5 + u.Y.D5 * v.Y.D5 + u.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * u.X.D5D6 + d1 * u.Y.D5D6 + d2 * u.Z.D5D6 + d3 * v.X.D5D6 + d4 * v.Y.D5D6 + d5 * v.Z.D5D6 + v.X.D5 * u.X.D6 + v.Y.D5 * u.Y.D6 + v.Z.D5 * u.Z.D6 + u.X.D5 * v.X.D6 + u.Y.D5 * v.Y.D6 + u.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * u.X.D5D7 + d1 * u.Y.D5D7 + d2 * u.Z.D5D7 + d3 * v.X.D5D7 + d4 * v.Y.D5D7 + d5 * v.Z.D5D7 + v.X.D5 * u.X.D7 + v.Y.D5 * u.Y.D7 + v.Z.D5 * u.Z.D7 + u.X.D5 * v.X.D7 + u.Y.D5 * v.Y.D7 + u.Z.D5 * v.Z.D7;
        result.D5D8 = d0 * u.X.D5D8 + d1 * u.Y.D5D8 + d2 * u.Z.D5D8 + d3 * v.X.D5D8 + d4 * v.Y.D5D8 + d5 * v.Z.D5D8 + v.X.D5 * u.X.D8 + v.Y.D5 * u.Y.D8 + v.Z.D5 * u.Z.D8 + u.X.D5 * v.X.D8 + u.Y.D5 * v.Y.D8 + u.Z.D5 * v.Z.D8;
        result.D5D9 = d0 * u.X.D5D9 + d1 * u.Y.D5D9 + d2 * u.Z.D5D9 + d3 * v.X.D5D9 + d4 * v.Y.D5D9 + d5 * v.Z.D5D9 + v.X.D5 * u.X.D9 + v.Y.D5 * u.Y.D9 + v.Z.D5 * u.Z.D9 + u.X.D5 * v.X.D9 + u.Y.D5 * v.Y.D9 + u.Z.D5 * v.Z.D9;
        result.D6D6 = d0 * u.X.D6D6 + d1 * u.Y.D6D6 + d2 * u.Z.D6D6 + d3 * v.X.D6D6 + d4 * v.Y.D6D6 + d5 * v.Z.D6D6 + v.X.D6 * u.X.D6 + v.Y.D6 * u.Y.D6 + v.Z.D6 * u.Z.D6 + u.X.D6 * v.X.D6 + u.Y.D6 * v.Y.D6 + u.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * u.X.D6D7 + d1 * u.Y.D6D7 + d2 * u.Z.D6D7 + d3 * v.X.D6D7 + d4 * v.Y.D6D7 + d5 * v.Z.D6D7 + v.X.D6 * u.X.D7 + v.Y.D6 * u.Y.D7 + v.Z.D6 * u.Z.D7 + u.X.D6 * v.X.D7 + u.Y.D6 * v.Y.D7 + u.Z.D6 * v.Z.D7;
        result.D6D8 = d0 * u.X.D6D8 + d1 * u.Y.D6D8 + d2 * u.Z.D6D8 + d3 * v.X.D6D8 + d4 * v.Y.D6D8 + d5 * v.Z.D6D8 + v.X.D6 * u.X.D8 + v.Y.D6 * u.Y.D8 + v.Z.D6 * u.Z.D8 + u.X.D6 * v.X.D8 + u.Y.D6 * v.Y.D8 + u.Z.D6 * v.Z.D8;
        result.D6D9 = d0 * u.X.D6D9 + d1 * u.Y.D6D9 + d2 * u.Z.D6D9 + d3 * v.X.D6D9 + d4 * v.Y.D6D9 + d5 * v.Z.D6D9 + v.X.D6 * u.X.D9 + v.Y.D6 * u.Y.D9 + v.Z.D6 * u.Z.D9 + u.X.D6 * v.X.D9 + u.Y.D6 * v.Y.D9 + u.Z.D6 * v.Z.D9;
        result.D7D7 = d0 * u.X.D7D7 + d1 * u.Y.D7D7 + d2 * u.Z.D7D7 + d3 * v.X.D7D7 + d4 * v.Y.D7D7 + d5 * v.Z.D7D7 + v.X.D7 * u.X.D7 + v.Y.D7 * u.Y.D7 + v.Z.D7 * u.Z.D7 + u.X.D7 * v.X.D7 + u.Y.D7 * v.Y.D7 + u.Z.D7 * v.Z.D7;
        result.D7D8 = d0 * u.X.D7D8 + d1 * u.Y.D7D8 + d2 * u.Z.D7D8 + d3 * v.X.D7D8 + d4 * v.Y.D7D8 + d5 * v.Z.D7D8 + v.X.D7 * u.X.D8 + v.Y.D7 * u.Y.D8 + v.Z.D7 * u.Z.D8 + u.X.D7 * v.X.D8 + u.Y.D7 * v.Y.D8 + u.Z.D7 * v.Z.D8;
        result.D7D9 = d0 * u.X.D7D9 + d1 * u.Y.D7D9 + d2 * u.Z.D7D9 + d3 * v.X.D7D9 + d4 * v.Y.D7D9 + d5 * v.Z.D7D9 + v.X.D7 * u.X.D9 + v.Y.D7 * u.Y.D9 + v.Z.D7 * u.Z.D9 + u.X.D7 * v.X.D9 + u.Y.D7 * v.Y.D9 + u.Z.D7 * v.Z.D9;
        result.D8D8 = d0 * u.X.D8D8 + d1 * u.Y.D8D8 + d2 * u.Z.D8D8 + d3 * v.X.D8D8 + d4 * v.Y.D8D8 + d5 * v.Z.D8D8 + v.X.D8 * u.X.D8 + v.Y.D8 * u.Y.D8 + v.Z.D8 * u.Z.D8 + u.X.D8 * v.X.D8 + u.Y.D8 * v.Y.D8 + u.Z.D8 * v.Z.D8;
        result.D8D9 = d0 * u.X.D8D9 + d1 * u.Y.D8D9 + d2 * u.Z.D8D9 + d3 * v.X.D8D9 + d4 * v.Y.D8D9 + d5 * v.Z.D8D9 + v.X.D8 * u.X.D9 + v.Y.D8 * u.Y.D9 + v.Z.D8 * u.Z.D9 + u.X.D8 * v.X.D9 + u.Y.D8 * v.Y.D9 + u.Z.D8 * v.Z.D9;
        result.D9D9 = d0 * u.X.D9D9 + d1 * u.Y.D9D9 + d2 * u.Z.D9D9 + d3 * v.X.D9D9 + d4 * v.Y.D9D9 + d5 * v.Z.D9D9 + v.X.D9 * u.X.D9 + v.Y.D9 * u.Y.D9 + v.Z.D9 * u.Z.D9 + u.X.D9 * v.X.D9 + u.Y.D9 * v.Y.D9 + u.Z.D9 * v.Z.D9;

        return result;
    }

    public static DD11Scalar Dot(DD11Vector3 u, DD11Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD11Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;
        result.D8 = d0 * u.X.D8 + d1 * u.Y.D8 + d2 * u.Z.D8 + d3 * v.X.D8 + d4 * v.Y.D8 + d5 * v.Z.D8;
        result.D9 = d0 * u.X.D9 + d1 * u.Y.D9 + d2 * u.Z.D9 + d3 * v.X.D9 + d4 * v.Y.D9 + d5 * v.Z.D9;
        result.D10 = d0 * u.X.D10 + d1 * u.Y.D10 + d2 * u.Z.D10 + d3 * v.X.D10 + d4 * v.Y.D10 + d5 * v.Z.D10;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * u.X.D0D3 + d1 * u.Y.D0D3 + d2 * u.Z.D0D3 + d3 * v.X.D0D3 + d4 * v.Y.D0D3 + d5 * v.Z.D0D3 + v.X.D0 * u.X.D3 + v.Y.D0 * u.Y.D3 + v.Z.D0 * u.Z.D3 + u.X.D0 * v.X.D3 + u.Y.D0 * v.Y.D3 + u.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * u.X.D0D4 + d1 * u.Y.D0D4 + d2 * u.Z.D0D4 + d3 * v.X.D0D4 + d4 * v.Y.D0D4 + d5 * v.Z.D0D4 + v.X.D0 * u.X.D4 + v.Y.D0 * u.Y.D4 + v.Z.D0 * u.Z.D4 + u.X.D0 * v.X.D4 + u.Y.D0 * v.Y.D4 + u.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * u.X.D0D5 + d1 * u.Y.D0D5 + d2 * u.Z.D0D5 + d3 * v.X.D0D5 + d4 * v.Y.D0D5 + d5 * v.Z.D0D5 + v.X.D0 * u.X.D5 + v.Y.D0 * u.Y.D5 + v.Z.D0 * u.Z.D5 + u.X.D0 * v.X.D5 + u.Y.D0 * v.Y.D5 + u.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * u.X.D0D6 + d1 * u.Y.D0D6 + d2 * u.Z.D0D6 + d3 * v.X.D0D6 + d4 * v.Y.D0D6 + d5 * v.Z.D0D6 + v.X.D0 * u.X.D6 + v.Y.D0 * u.Y.D6 + v.Z.D0 * u.Z.D6 + u.X.D0 * v.X.D6 + u.Y.D0 * v.Y.D6 + u.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * u.X.D0D7 + d1 * u.Y.D0D7 + d2 * u.Z.D0D7 + d3 * v.X.D0D7 + d4 * v.Y.D0D7 + d5 * v.Z.D0D7 + v.X.D0 * u.X.D7 + v.Y.D0 * u.Y.D7 + v.Z.D0 * u.Z.D7 + u.X.D0 * v.X.D7 + u.Y.D0 * v.Y.D7 + u.Z.D0 * v.Z.D7;
        result.D0D8 = d0 * u.X.D0D8 + d1 * u.Y.D0D8 + d2 * u.Z.D0D8 + d3 * v.X.D0D8 + d4 * v.Y.D0D8 + d5 * v.Z.D0D8 + v.X.D0 * u.X.D8 + v.Y.D0 * u.Y.D8 + v.Z.D0 * u.Z.D8 + u.X.D0 * v.X.D8 + u.Y.D0 * v.Y.D8 + u.Z.D0 * v.Z.D8;
        result.D0D9 = d0 * u.X.D0D9 + d1 * u.Y.D0D9 + d2 * u.Z.D0D9 + d3 * v.X.D0D9 + d4 * v.Y.D0D9 + d5 * v.Z.D0D9 + v.X.D0 * u.X.D9 + v.Y.D0 * u.Y.D9 + v.Z.D0 * u.Z.D9 + u.X.D0 * v.X.D9 + u.Y.D0 * v.Y.D9 + u.Z.D0 * v.Z.D9;
        result.D0D10 = d0 * u.X.D0D10 + d1 * u.Y.D0D10 + d2 * u.Z.D0D10 + d3 * v.X.D0D10 + d4 * v.Y.D0D10 + d5 * v.Z.D0D10 + v.X.D0 * u.X.D10 + v.Y.D0 * u.Y.D10 + v.Z.D0 * u.Z.D10 + u.X.D0 * v.X.D10 + u.Y.D0 * v.Y.D10 + u.Z.D0 * v.Z.D10;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * u.X.D1D3 + d1 * u.Y.D1D3 + d2 * u.Z.D1D3 + d3 * v.X.D1D3 + d4 * v.Y.D1D3 + d5 * v.Z.D1D3 + v.X.D1 * u.X.D3 + v.Y.D1 * u.Y.D3 + v.Z.D1 * u.Z.D3 + u.X.D1 * v.X.D3 + u.Y.D1 * v.Y.D3 + u.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * u.X.D1D4 + d1 * u.Y.D1D4 + d2 * u.Z.D1D4 + d3 * v.X.D1D4 + d4 * v.Y.D1D4 + d5 * v.Z.D1D4 + v.X.D1 * u.X.D4 + v.Y.D1 * u.Y.D4 + v.Z.D1 * u.Z.D4 + u.X.D1 * v.X.D4 + u.Y.D1 * v.Y.D4 + u.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * u.X.D1D5 + d1 * u.Y.D1D5 + d2 * u.Z.D1D5 + d3 * v.X.D1D5 + d4 * v.Y.D1D5 + d5 * v.Z.D1D5 + v.X.D1 * u.X.D5 + v.Y.D1 * u.Y.D5 + v.Z.D1 * u.Z.D5 + u.X.D1 * v.X.D5 + u.Y.D1 * v.Y.D5 + u.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * u.X.D1D6 + d1 * u.Y.D1D6 + d2 * u.Z.D1D6 + d3 * v.X.D1D6 + d4 * v.Y.D1D6 + d5 * v.Z.D1D6 + v.X.D1 * u.X.D6 + v.Y.D1 * u.Y.D6 + v.Z.D1 * u.Z.D6 + u.X.D1 * v.X.D6 + u.Y.D1 * v.Y.D6 + u.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * u.X.D1D7 + d1 * u.Y.D1D7 + d2 * u.Z.D1D7 + d3 * v.X.D1D7 + d4 * v.Y.D1D7 + d5 * v.Z.D1D7 + v.X.D1 * u.X.D7 + v.Y.D1 * u.Y.D7 + v.Z.D1 * u.Z.D7 + u.X.D1 * v.X.D7 + u.Y.D1 * v.Y.D7 + u.Z.D1 * v.Z.D7;
        result.D1D8 = d0 * u.X.D1D8 + d1 * u.Y.D1D8 + d2 * u.Z.D1D8 + d3 * v.X.D1D8 + d4 * v.Y.D1D8 + d5 * v.Z.D1D8 + v.X.D1 * u.X.D8 + v.Y.D1 * u.Y.D8 + v.Z.D1 * u.Z.D8 + u.X.D1 * v.X.D8 + u.Y.D1 * v.Y.D8 + u.Z.D1 * v.Z.D8;
        result.D1D9 = d0 * u.X.D1D9 + d1 * u.Y.D1D9 + d2 * u.Z.D1D9 + d3 * v.X.D1D9 + d4 * v.Y.D1D9 + d5 * v.Z.D1D9 + v.X.D1 * u.X.D9 + v.Y.D1 * u.Y.D9 + v.Z.D1 * u.Z.D9 + u.X.D1 * v.X.D9 + u.Y.D1 * v.Y.D9 + u.Z.D1 * v.Z.D9;
        result.D1D10 = d0 * u.X.D1D10 + d1 * u.Y.D1D10 + d2 * u.Z.D1D10 + d3 * v.X.D1D10 + d4 * v.Y.D1D10 + d5 * v.Z.D1D10 + v.X.D1 * u.X.D10 + v.Y.D1 * u.Y.D10 + v.Z.D1 * u.Z.D10 + u.X.D1 * v.X.D10 + u.Y.D1 * v.Y.D10 + u.Z.D1 * v.Z.D10;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * u.X.D2D3 + d1 * u.Y.D2D3 + d2 * u.Z.D2D3 + d3 * v.X.D2D3 + d4 * v.Y.D2D3 + d5 * v.Z.D2D3 + v.X.D2 * u.X.D3 + v.Y.D2 * u.Y.D3 + v.Z.D2 * u.Z.D3 + u.X.D2 * v.X.D3 + u.Y.D2 * v.Y.D3 + u.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * u.X.D2D4 + d1 * u.Y.D2D4 + d2 * u.Z.D2D4 + d3 * v.X.D2D4 + d4 * v.Y.D2D4 + d5 * v.Z.D2D4 + v.X.D2 * u.X.D4 + v.Y.D2 * u.Y.D4 + v.Z.D2 * u.Z.D4 + u.X.D2 * v.X.D4 + u.Y.D2 * v.Y.D4 + u.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * u.X.D2D5 + d1 * u.Y.D2D5 + d2 * u.Z.D2D5 + d3 * v.X.D2D5 + d4 * v.Y.D2D5 + d5 * v.Z.D2D5 + v.X.D2 * u.X.D5 + v.Y.D2 * u.Y.D5 + v.Z.D2 * u.Z.D5 + u.X.D2 * v.X.D5 + u.Y.D2 * v.Y.D5 + u.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * u.X.D2D6 + d1 * u.Y.D2D6 + d2 * u.Z.D2D6 + d3 * v.X.D2D6 + d4 * v.Y.D2D6 + d5 * v.Z.D2D6 + v.X.D2 * u.X.D6 + v.Y.D2 * u.Y.D6 + v.Z.D2 * u.Z.D6 + u.X.D2 * v.X.D6 + u.Y.D2 * v.Y.D6 + u.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * u.X.D2D7 + d1 * u.Y.D2D7 + d2 * u.Z.D2D7 + d3 * v.X.D2D7 + d4 * v.Y.D2D7 + d5 * v.Z.D2D7 + v.X.D2 * u.X.D7 + v.Y.D2 * u.Y.D7 + v.Z.D2 * u.Z.D7 + u.X.D2 * v.X.D7 + u.Y.D2 * v.Y.D7 + u.Z.D2 * v.Z.D7;
        result.D2D8 = d0 * u.X.D2D8 + d1 * u.Y.D2D8 + d2 * u.Z.D2D8 + d3 * v.X.D2D8 + d4 * v.Y.D2D8 + d5 * v.Z.D2D8 + v.X.D2 * u.X.D8 + v.Y.D2 * u.Y.D8 + v.Z.D2 * u.Z.D8 + u.X.D2 * v.X.D8 + u.Y.D2 * v.Y.D8 + u.Z.D2 * v.Z.D8;
        result.D2D9 = d0 * u.X.D2D9 + d1 * u.Y.D2D9 + d2 * u.Z.D2D9 + d3 * v.X.D2D9 + d4 * v.Y.D2D9 + d5 * v.Z.D2D9 + v.X.D2 * u.X.D9 + v.Y.D2 * u.Y.D9 + v.Z.D2 * u.Z.D9 + u.X.D2 * v.X.D9 + u.Y.D2 * v.Y.D9 + u.Z.D2 * v.Z.D9;
        result.D2D10 = d0 * u.X.D2D10 + d1 * u.Y.D2D10 + d2 * u.Z.D2D10 + d3 * v.X.D2D10 + d4 * v.Y.D2D10 + d5 * v.Z.D2D10 + v.X.D2 * u.X.D10 + v.Y.D2 * u.Y.D10 + v.Z.D2 * u.Z.D10 + u.X.D2 * v.X.D10 + u.Y.D2 * v.Y.D10 + u.Z.D2 * v.Z.D10;
        result.D3D3 = d0 * u.X.D3D3 + d1 * u.Y.D3D3 + d2 * u.Z.D3D3 + d3 * v.X.D3D3 + d4 * v.Y.D3D3 + d5 * v.Z.D3D3 + v.X.D3 * u.X.D3 + v.Y.D3 * u.Y.D3 + v.Z.D3 * u.Z.D3 + u.X.D3 * v.X.D3 + u.Y.D3 * v.Y.D3 + u.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * u.X.D3D4 + d1 * u.Y.D3D4 + d2 * u.Z.D3D4 + d3 * v.X.D3D4 + d4 * v.Y.D3D4 + d5 * v.Z.D3D4 + v.X.D3 * u.X.D4 + v.Y.D3 * u.Y.D4 + v.Z.D3 * u.Z.D4 + u.X.D3 * v.X.D4 + u.Y.D3 * v.Y.D4 + u.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * u.X.D3D5 + d1 * u.Y.D3D5 + d2 * u.Z.D3D5 + d3 * v.X.D3D5 + d4 * v.Y.D3D5 + d5 * v.Z.D3D5 + v.X.D3 * u.X.D5 + v.Y.D3 * u.Y.D5 + v.Z.D3 * u.Z.D5 + u.X.D3 * v.X.D5 + u.Y.D3 * v.Y.D5 + u.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * u.X.D3D6 + d1 * u.Y.D3D6 + d2 * u.Z.D3D6 + d3 * v.X.D3D6 + d4 * v.Y.D3D6 + d5 * v.Z.D3D6 + v.X.D3 * u.X.D6 + v.Y.D3 * u.Y.D6 + v.Z.D3 * u.Z.D6 + u.X.D3 * v.X.D6 + u.Y.D3 * v.Y.D6 + u.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * u.X.D3D7 + d1 * u.Y.D3D7 + d2 * u.Z.D3D7 + d3 * v.X.D3D7 + d4 * v.Y.D3D7 + d5 * v.Z.D3D7 + v.X.D3 * u.X.D7 + v.Y.D3 * u.Y.D7 + v.Z.D3 * u.Z.D7 + u.X.D3 * v.X.D7 + u.Y.D3 * v.Y.D7 + u.Z.D3 * v.Z.D7;
        result.D3D8 = d0 * u.X.D3D8 + d1 * u.Y.D3D8 + d2 * u.Z.D3D8 + d3 * v.X.D3D8 + d4 * v.Y.D3D8 + d5 * v.Z.D3D8 + v.X.D3 * u.X.D8 + v.Y.D3 * u.Y.D8 + v.Z.D3 * u.Z.D8 + u.X.D3 * v.X.D8 + u.Y.D3 * v.Y.D8 + u.Z.D3 * v.Z.D8;
        result.D3D9 = d0 * u.X.D3D9 + d1 * u.Y.D3D9 + d2 * u.Z.D3D9 + d3 * v.X.D3D9 + d4 * v.Y.D3D9 + d5 * v.Z.D3D9 + v.X.D3 * u.X.D9 + v.Y.D3 * u.Y.D9 + v.Z.D3 * u.Z.D9 + u.X.D3 * v.X.D9 + u.Y.D3 * v.Y.D9 + u.Z.D3 * v.Z.D9;
        result.D3D10 = d0 * u.X.D3D10 + d1 * u.Y.D3D10 + d2 * u.Z.D3D10 + d3 * v.X.D3D10 + d4 * v.Y.D3D10 + d5 * v.Z.D3D10 + v.X.D3 * u.X.D10 + v.Y.D3 * u.Y.D10 + v.Z.D3 * u.Z.D10 + u.X.D3 * v.X.D10 + u.Y.D3 * v.Y.D10 + u.Z.D3 * v.Z.D10;
        result.D4D4 = d0 * u.X.D4D4 + d1 * u.Y.D4D4 + d2 * u.Z.D4D4 + d3 * v.X.D4D4 + d4 * v.Y.D4D4 + d5 * v.Z.D4D4 + v.X.D4 * u.X.D4 + v.Y.D4 * u.Y.D4 + v.Z.D4 * u.Z.D4 + u.X.D4 * v.X.D4 + u.Y.D4 * v.Y.D4 + u.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * u.X.D4D5 + d1 * u.Y.D4D5 + d2 * u.Z.D4D5 + d3 * v.X.D4D5 + d4 * v.Y.D4D5 + d5 * v.Z.D4D5 + v.X.D4 * u.X.D5 + v.Y.D4 * u.Y.D5 + v.Z.D4 * u.Z.D5 + u.X.D4 * v.X.D5 + u.Y.D4 * v.Y.D5 + u.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * u.X.D4D6 + d1 * u.Y.D4D6 + d2 * u.Z.D4D6 + d3 * v.X.D4D6 + d4 * v.Y.D4D6 + d5 * v.Z.D4D6 + v.X.D4 * u.X.D6 + v.Y.D4 * u.Y.D6 + v.Z.D4 * u.Z.D6 + u.X.D4 * v.X.D6 + u.Y.D4 * v.Y.D6 + u.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * u.X.D4D7 + d1 * u.Y.D4D7 + d2 * u.Z.D4D7 + d3 * v.X.D4D7 + d4 * v.Y.D4D7 + d5 * v.Z.D4D7 + v.X.D4 * u.X.D7 + v.Y.D4 * u.Y.D7 + v.Z.D4 * u.Z.D7 + u.X.D4 * v.X.D7 + u.Y.D4 * v.Y.D7 + u.Z.D4 * v.Z.D7;
        result.D4D8 = d0 * u.X.D4D8 + d1 * u.Y.D4D8 + d2 * u.Z.D4D8 + d3 * v.X.D4D8 + d4 * v.Y.D4D8 + d5 * v.Z.D4D8 + v.X.D4 * u.X.D8 + v.Y.D4 * u.Y.D8 + v.Z.D4 * u.Z.D8 + u.X.D4 * v.X.D8 + u.Y.D4 * v.Y.D8 + u.Z.D4 * v.Z.D8;
        result.D4D9 = d0 * u.X.D4D9 + d1 * u.Y.D4D9 + d2 * u.Z.D4D9 + d3 * v.X.D4D9 + d4 * v.Y.D4D9 + d5 * v.Z.D4D9 + v.X.D4 * u.X.D9 + v.Y.D4 * u.Y.D9 + v.Z.D4 * u.Z.D9 + u.X.D4 * v.X.D9 + u.Y.D4 * v.Y.D9 + u.Z.D4 * v.Z.D9;
        result.D4D10 = d0 * u.X.D4D10 + d1 * u.Y.D4D10 + d2 * u.Z.D4D10 + d3 * v.X.D4D10 + d4 * v.Y.D4D10 + d5 * v.Z.D4D10 + v.X.D4 * u.X.D10 + v.Y.D4 * u.Y.D10 + v.Z.D4 * u.Z.D10 + u.X.D4 * v.X.D10 + u.Y.D4 * v.Y.D10 + u.Z.D4 * v.Z.D10;
        result.D5D5 = d0 * u.X.D5D5 + d1 * u.Y.D5D5 + d2 * u.Z.D5D5 + d3 * v.X.D5D5 + d4 * v.Y.D5D5 + d5 * v.Z.D5D5 + v.X.D5 * u.X.D5 + v.Y.D5 * u.Y.D5 + v.Z.D5 * u.Z.D5 + u.X.D5 * v.X.D5 + u.Y.D5 * v.Y.D5 + u.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * u.X.D5D6 + d1 * u.Y.D5D6 + d2 * u.Z.D5D6 + d3 * v.X.D5D6 + d4 * v.Y.D5D6 + d5 * v.Z.D5D6 + v.X.D5 * u.X.D6 + v.Y.D5 * u.Y.D6 + v.Z.D5 * u.Z.D6 + u.X.D5 * v.X.D6 + u.Y.D5 * v.Y.D6 + u.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * u.X.D5D7 + d1 * u.Y.D5D7 + d2 * u.Z.D5D7 + d3 * v.X.D5D7 + d4 * v.Y.D5D7 + d5 * v.Z.D5D7 + v.X.D5 * u.X.D7 + v.Y.D5 * u.Y.D7 + v.Z.D5 * u.Z.D7 + u.X.D5 * v.X.D7 + u.Y.D5 * v.Y.D7 + u.Z.D5 * v.Z.D7;
        result.D5D8 = d0 * u.X.D5D8 + d1 * u.Y.D5D8 + d2 * u.Z.D5D8 + d3 * v.X.D5D8 + d4 * v.Y.D5D8 + d5 * v.Z.D5D8 + v.X.D5 * u.X.D8 + v.Y.D5 * u.Y.D8 + v.Z.D5 * u.Z.D8 + u.X.D5 * v.X.D8 + u.Y.D5 * v.Y.D8 + u.Z.D5 * v.Z.D8;
        result.D5D9 = d0 * u.X.D5D9 + d1 * u.Y.D5D9 + d2 * u.Z.D5D9 + d3 * v.X.D5D9 + d4 * v.Y.D5D9 + d5 * v.Z.D5D9 + v.X.D5 * u.X.D9 + v.Y.D5 * u.Y.D9 + v.Z.D5 * u.Z.D9 + u.X.D5 * v.X.D9 + u.Y.D5 * v.Y.D9 + u.Z.D5 * v.Z.D9;
        result.D5D10 = d0 * u.X.D5D10 + d1 * u.Y.D5D10 + d2 * u.Z.D5D10 + d3 * v.X.D5D10 + d4 * v.Y.D5D10 + d5 * v.Z.D5D10 + v.X.D5 * u.X.D10 + v.Y.D5 * u.Y.D10 + v.Z.D5 * u.Z.D10 + u.X.D5 * v.X.D10 + u.Y.D5 * v.Y.D10 + u.Z.D5 * v.Z.D10;
        result.D6D6 = d0 * u.X.D6D6 + d1 * u.Y.D6D6 + d2 * u.Z.D6D6 + d3 * v.X.D6D6 + d4 * v.Y.D6D6 + d5 * v.Z.D6D6 + v.X.D6 * u.X.D6 + v.Y.D6 * u.Y.D6 + v.Z.D6 * u.Z.D6 + u.X.D6 * v.X.D6 + u.Y.D6 * v.Y.D6 + u.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * u.X.D6D7 + d1 * u.Y.D6D7 + d2 * u.Z.D6D7 + d3 * v.X.D6D7 + d4 * v.Y.D6D7 + d5 * v.Z.D6D7 + v.X.D6 * u.X.D7 + v.Y.D6 * u.Y.D7 + v.Z.D6 * u.Z.D7 + u.X.D6 * v.X.D7 + u.Y.D6 * v.Y.D7 + u.Z.D6 * v.Z.D7;
        result.D6D8 = d0 * u.X.D6D8 + d1 * u.Y.D6D8 + d2 * u.Z.D6D8 + d3 * v.X.D6D8 + d4 * v.Y.D6D8 + d5 * v.Z.D6D8 + v.X.D6 * u.X.D8 + v.Y.D6 * u.Y.D8 + v.Z.D6 * u.Z.D8 + u.X.D6 * v.X.D8 + u.Y.D6 * v.Y.D8 + u.Z.D6 * v.Z.D8;
        result.D6D9 = d0 * u.X.D6D9 + d1 * u.Y.D6D9 + d2 * u.Z.D6D9 + d3 * v.X.D6D9 + d4 * v.Y.D6D9 + d5 * v.Z.D6D9 + v.X.D6 * u.X.D9 + v.Y.D6 * u.Y.D9 + v.Z.D6 * u.Z.D9 + u.X.D6 * v.X.D9 + u.Y.D6 * v.Y.D9 + u.Z.D6 * v.Z.D9;
        result.D6D10 = d0 * u.X.D6D10 + d1 * u.Y.D6D10 + d2 * u.Z.D6D10 + d3 * v.X.D6D10 + d4 * v.Y.D6D10 + d5 * v.Z.D6D10 + v.X.D6 * u.X.D10 + v.Y.D6 * u.Y.D10 + v.Z.D6 * u.Z.D10 + u.X.D6 * v.X.D10 + u.Y.D6 * v.Y.D10 + u.Z.D6 * v.Z.D10;
        result.D7D7 = d0 * u.X.D7D7 + d1 * u.Y.D7D7 + d2 * u.Z.D7D7 + d3 * v.X.D7D7 + d4 * v.Y.D7D7 + d5 * v.Z.D7D7 + v.X.D7 * u.X.D7 + v.Y.D7 * u.Y.D7 + v.Z.D7 * u.Z.D7 + u.X.D7 * v.X.D7 + u.Y.D7 * v.Y.D7 + u.Z.D7 * v.Z.D7;
        result.D7D8 = d0 * u.X.D7D8 + d1 * u.Y.D7D8 + d2 * u.Z.D7D8 + d3 * v.X.D7D8 + d4 * v.Y.D7D8 + d5 * v.Z.D7D8 + v.X.D7 * u.X.D8 + v.Y.D7 * u.Y.D8 + v.Z.D7 * u.Z.D8 + u.X.D7 * v.X.D8 + u.Y.D7 * v.Y.D8 + u.Z.D7 * v.Z.D8;
        result.D7D9 = d0 * u.X.D7D9 + d1 * u.Y.D7D9 + d2 * u.Z.D7D9 + d3 * v.X.D7D9 + d4 * v.Y.D7D9 + d5 * v.Z.D7D9 + v.X.D7 * u.X.D9 + v.Y.D7 * u.Y.D9 + v.Z.D7 * u.Z.D9 + u.X.D7 * v.X.D9 + u.Y.D7 * v.Y.D9 + u.Z.D7 * v.Z.D9;
        result.D7D10 = d0 * u.X.D7D10 + d1 * u.Y.D7D10 + d2 * u.Z.D7D10 + d3 * v.X.D7D10 + d4 * v.Y.D7D10 + d5 * v.Z.D7D10 + v.X.D7 * u.X.D10 + v.Y.D7 * u.Y.D10 + v.Z.D7 * u.Z.D10 + u.X.D7 * v.X.D10 + u.Y.D7 * v.Y.D10 + u.Z.D7 * v.Z.D10;
        result.D8D8 = d0 * u.X.D8D8 + d1 * u.Y.D8D8 + d2 * u.Z.D8D8 + d3 * v.X.D8D8 + d4 * v.Y.D8D8 + d5 * v.Z.D8D8 + v.X.D8 * u.X.D8 + v.Y.D8 * u.Y.D8 + v.Z.D8 * u.Z.D8 + u.X.D8 * v.X.D8 + u.Y.D8 * v.Y.D8 + u.Z.D8 * v.Z.D8;
        result.D8D9 = d0 * u.X.D8D9 + d1 * u.Y.D8D9 + d2 * u.Z.D8D9 + d3 * v.X.D8D9 + d4 * v.Y.D8D9 + d5 * v.Z.D8D9 + v.X.D8 * u.X.D9 + v.Y.D8 * u.Y.D9 + v.Z.D8 * u.Z.D9 + u.X.D8 * v.X.D9 + u.Y.D8 * v.Y.D9 + u.Z.D8 * v.Z.D9;
        result.D8D10 = d0 * u.X.D8D10 + d1 * u.Y.D8D10 + d2 * u.Z.D8D10 + d3 * v.X.D8D10 + d4 * v.Y.D8D10 + d5 * v.Z.D8D10 + v.X.D8 * u.X.D10 + v.Y.D8 * u.Y.D10 + v.Z.D8 * u.Z.D10 + u.X.D8 * v.X.D10 + u.Y.D8 * v.Y.D10 + u.Z.D8 * v.Z.D10;
        result.D9D9 = d0 * u.X.D9D9 + d1 * u.Y.D9D9 + d2 * u.Z.D9D9 + d3 * v.X.D9D9 + d4 * v.Y.D9D9 + d5 * v.Z.D9D9 + v.X.D9 * u.X.D9 + v.Y.D9 * u.Y.D9 + v.Z.D9 * u.Z.D9 + u.X.D9 * v.X.D9 + u.Y.D9 * v.Y.D9 + u.Z.D9 * v.Z.D9;
        result.D9D10 = d0 * u.X.D9D10 + d1 * u.Y.D9D10 + d2 * u.Z.D9D10 + d3 * v.X.D9D10 + d4 * v.Y.D9D10 + d5 * v.Z.D9D10 + v.X.D9 * u.X.D10 + v.Y.D9 * u.Y.D10 + v.Z.D9 * u.Z.D10 + u.X.D9 * v.X.D10 + u.Y.D9 * v.Y.D10 + u.Z.D9 * v.Z.D10;
        result.D10D10 = d0 * u.X.D10D10 + d1 * u.Y.D10D10 + d2 * u.Z.D10D10 + d3 * v.X.D10D10 + d4 * v.Y.D10D10 + d5 * v.Z.D10D10 + v.X.D10 * u.X.D10 + v.Y.D10 * u.Y.D10 + v.Z.D10 * u.Z.D10 + u.X.D10 * v.X.D10 + u.Y.D10 * v.Y.D10 + u.Z.D10 * v.Z.D10;

        return result;
    }

    public static DD12Scalar Dot(DD12Vector3 u, DD12Vector3 v)
    {
        var constant = u.X.Constant * v.X.Constant + u.Y.Constant * v.Y.Constant + u.Z.Constant * v.Z.Constant;

        var result = new DD12Scalar(constant);

        var d0 = v.X.Constant;
        var d1 = v.Y.Constant;
        var d2 = v.Z.Constant;
        var d3 = u.X.Constant;
        var d4 = u.Y.Constant;
        var d5 = u.Z.Constant;

        result.D0 = d0 * u.X.D0 + d1 * u.Y.D0 + d2 * u.Z.D0 + d3 * v.X.D0 + d4 * v.Y.D0 + d5 * v.Z.D0;
        result.D1 = d0 * u.X.D1 + d1 * u.Y.D1 + d2 * u.Z.D1 + d3 * v.X.D1 + d4 * v.Y.D1 + d5 * v.Z.D1;
        result.D2 = d0 * u.X.D2 + d1 * u.Y.D2 + d2 * u.Z.D2 + d3 * v.X.D2 + d4 * v.Y.D2 + d5 * v.Z.D2;
        result.D3 = d0 * u.X.D3 + d1 * u.Y.D3 + d2 * u.Z.D3 + d3 * v.X.D3 + d4 * v.Y.D3 + d5 * v.Z.D3;
        result.D4 = d0 * u.X.D4 + d1 * u.Y.D4 + d2 * u.Z.D4 + d3 * v.X.D4 + d4 * v.Y.D4 + d5 * v.Z.D4;
        result.D5 = d0 * u.X.D5 + d1 * u.Y.D5 + d2 * u.Z.D5 + d3 * v.X.D5 + d4 * v.Y.D5 + d5 * v.Z.D5;
        result.D6 = d0 * u.X.D6 + d1 * u.Y.D6 + d2 * u.Z.D6 + d3 * v.X.D6 + d4 * v.Y.D6 + d5 * v.Z.D6;
        result.D7 = d0 * u.X.D7 + d1 * u.Y.D7 + d2 * u.Z.D7 + d3 * v.X.D7 + d4 * v.Y.D7 + d5 * v.Z.D7;
        result.D8 = d0 * u.X.D8 + d1 * u.Y.D8 + d2 * u.Z.D8 + d3 * v.X.D8 + d4 * v.Y.D8 + d5 * v.Z.D8;
        result.D9 = d0 * u.X.D9 + d1 * u.Y.D9 + d2 * u.Z.D9 + d3 * v.X.D9 + d4 * v.Y.D9 + d5 * v.Z.D9;
        result.D10 = d0 * u.X.D10 + d1 * u.Y.D10 + d2 * u.Z.D10 + d3 * v.X.D10 + d4 * v.Y.D10 + d5 * v.Z.D10;
        result.D11 = d0 * u.X.D11 + d1 * u.Y.D11 + d2 * u.Z.D11 + d3 * v.X.D11 + d4 * v.Y.D11 + d5 * v.Z.D11;

        result.D0D0 = d0 * u.X.D0D0 + d1 * u.Y.D0D0 + d2 * u.Z.D0D0 + d3 * v.X.D0D0 + d4 * v.Y.D0D0 + d5 * v.Z.D0D0 + v.X.D0 * u.X.D0 + v.Y.D0 * u.Y.D0 + v.Z.D0 * u.Z.D0 + u.X.D0 * v.X.D0 + u.Y.D0 * v.Y.D0 + u.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * u.X.D0D1 + d1 * u.Y.D0D1 + d2 * u.Z.D0D1 + d3 * v.X.D0D1 + d4 * v.Y.D0D1 + d5 * v.Z.D0D1 + v.X.D0 * u.X.D1 + v.Y.D0 * u.Y.D1 + v.Z.D0 * u.Z.D1 + u.X.D0 * v.X.D1 + u.Y.D0 * v.Y.D1 + u.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * u.X.D0D2 + d1 * u.Y.D0D2 + d2 * u.Z.D0D2 + d3 * v.X.D0D2 + d4 * v.Y.D0D2 + d5 * v.Z.D0D2 + v.X.D0 * u.X.D2 + v.Y.D0 * u.Y.D2 + v.Z.D0 * u.Z.D2 + u.X.D0 * v.X.D2 + u.Y.D0 * v.Y.D2 + u.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * u.X.D0D3 + d1 * u.Y.D0D3 + d2 * u.Z.D0D3 + d3 * v.X.D0D3 + d4 * v.Y.D0D3 + d5 * v.Z.D0D3 + v.X.D0 * u.X.D3 + v.Y.D0 * u.Y.D3 + v.Z.D0 * u.Z.D3 + u.X.D0 * v.X.D3 + u.Y.D0 * v.Y.D3 + u.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * u.X.D0D4 + d1 * u.Y.D0D4 + d2 * u.Z.D0D4 + d3 * v.X.D0D4 + d4 * v.Y.D0D4 + d5 * v.Z.D0D4 + v.X.D0 * u.X.D4 + v.Y.D0 * u.Y.D4 + v.Z.D0 * u.Z.D4 + u.X.D0 * v.X.D4 + u.Y.D0 * v.Y.D4 + u.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * u.X.D0D5 + d1 * u.Y.D0D5 + d2 * u.Z.D0D5 + d3 * v.X.D0D5 + d4 * v.Y.D0D5 + d5 * v.Z.D0D5 + v.X.D0 * u.X.D5 + v.Y.D0 * u.Y.D5 + v.Z.D0 * u.Z.D5 + u.X.D0 * v.X.D5 + u.Y.D0 * v.Y.D5 + u.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * u.X.D0D6 + d1 * u.Y.D0D6 + d2 * u.Z.D0D6 + d3 * v.X.D0D6 + d4 * v.Y.D0D6 + d5 * v.Z.D0D6 + v.X.D0 * u.X.D6 + v.Y.D0 * u.Y.D6 + v.Z.D0 * u.Z.D6 + u.X.D0 * v.X.D6 + u.Y.D0 * v.Y.D6 + u.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * u.X.D0D7 + d1 * u.Y.D0D7 + d2 * u.Z.D0D7 + d3 * v.X.D0D7 + d4 * v.Y.D0D7 + d5 * v.Z.D0D7 + v.X.D0 * u.X.D7 + v.Y.D0 * u.Y.D7 + v.Z.D0 * u.Z.D7 + u.X.D0 * v.X.D7 + u.Y.D0 * v.Y.D7 + u.Z.D0 * v.Z.D7;
        result.D0D8 = d0 * u.X.D0D8 + d1 * u.Y.D0D8 + d2 * u.Z.D0D8 + d3 * v.X.D0D8 + d4 * v.Y.D0D8 + d5 * v.Z.D0D8 + v.X.D0 * u.X.D8 + v.Y.D0 * u.Y.D8 + v.Z.D0 * u.Z.D8 + u.X.D0 * v.X.D8 + u.Y.D0 * v.Y.D8 + u.Z.D0 * v.Z.D8;
        result.D0D9 = d0 * u.X.D0D9 + d1 * u.Y.D0D9 + d2 * u.Z.D0D9 + d3 * v.X.D0D9 + d4 * v.Y.D0D9 + d5 * v.Z.D0D9 + v.X.D0 * u.X.D9 + v.Y.D0 * u.Y.D9 + v.Z.D0 * u.Z.D9 + u.X.D0 * v.X.D9 + u.Y.D0 * v.Y.D9 + u.Z.D0 * v.Z.D9;
        result.D0D10 = d0 * u.X.D0D10 + d1 * u.Y.D0D10 + d2 * u.Z.D0D10 + d3 * v.X.D0D10 + d4 * v.Y.D0D10 + d5 * v.Z.D0D10 + v.X.D0 * u.X.D10 + v.Y.D0 * u.Y.D10 + v.Z.D0 * u.Z.D10 + u.X.D0 * v.X.D10 + u.Y.D0 * v.Y.D10 + u.Z.D0 * v.Z.D10;
        result.D0D11 = d0 * u.X.D0D11 + d1 * u.Y.D0D11 + d2 * u.Z.D0D11 + d3 * v.X.D0D11 + d4 * v.Y.D0D11 + d5 * v.Z.D0D11 + v.X.D0 * u.X.D11 + v.Y.D0 * u.Y.D11 + v.Z.D0 * u.Z.D11 + u.X.D0 * v.X.D11 + u.Y.D0 * v.Y.D11 + u.Z.D0 * v.Z.D11;
        result.D1D1 = d0 * u.X.D1D1 + d1 * u.Y.D1D1 + d2 * u.Z.D1D1 + d3 * v.X.D1D1 + d4 * v.Y.D1D1 + d5 * v.Z.D1D1 + v.X.D1 * u.X.D1 + v.Y.D1 * u.Y.D1 + v.Z.D1 * u.Z.D1 + u.X.D1 * v.X.D1 + u.Y.D1 * v.Y.D1 + u.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * u.X.D1D2 + d1 * u.Y.D1D2 + d2 * u.Z.D1D2 + d3 * v.X.D1D2 + d4 * v.Y.D1D2 + d5 * v.Z.D1D2 + v.X.D1 * u.X.D2 + v.Y.D1 * u.Y.D2 + v.Z.D1 * u.Z.D2 + u.X.D1 * v.X.D2 + u.Y.D1 * v.Y.D2 + u.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * u.X.D1D3 + d1 * u.Y.D1D3 + d2 * u.Z.D1D3 + d3 * v.X.D1D3 + d4 * v.Y.D1D3 + d5 * v.Z.D1D3 + v.X.D1 * u.X.D3 + v.Y.D1 * u.Y.D3 + v.Z.D1 * u.Z.D3 + u.X.D1 * v.X.D3 + u.Y.D1 * v.Y.D3 + u.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * u.X.D1D4 + d1 * u.Y.D1D4 + d2 * u.Z.D1D4 + d3 * v.X.D1D4 + d4 * v.Y.D1D4 + d5 * v.Z.D1D4 + v.X.D1 * u.X.D4 + v.Y.D1 * u.Y.D4 + v.Z.D1 * u.Z.D4 + u.X.D1 * v.X.D4 + u.Y.D1 * v.Y.D4 + u.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * u.X.D1D5 + d1 * u.Y.D1D5 + d2 * u.Z.D1D5 + d3 * v.X.D1D5 + d4 * v.Y.D1D5 + d5 * v.Z.D1D5 + v.X.D1 * u.X.D5 + v.Y.D1 * u.Y.D5 + v.Z.D1 * u.Z.D5 + u.X.D1 * v.X.D5 + u.Y.D1 * v.Y.D5 + u.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * u.X.D1D6 + d1 * u.Y.D1D6 + d2 * u.Z.D1D6 + d3 * v.X.D1D6 + d4 * v.Y.D1D6 + d5 * v.Z.D1D6 + v.X.D1 * u.X.D6 + v.Y.D1 * u.Y.D6 + v.Z.D1 * u.Z.D6 + u.X.D1 * v.X.D6 + u.Y.D1 * v.Y.D6 + u.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * u.X.D1D7 + d1 * u.Y.D1D7 + d2 * u.Z.D1D7 + d3 * v.X.D1D7 + d4 * v.Y.D1D7 + d5 * v.Z.D1D7 + v.X.D1 * u.X.D7 + v.Y.D1 * u.Y.D7 + v.Z.D1 * u.Z.D7 + u.X.D1 * v.X.D7 + u.Y.D1 * v.Y.D7 + u.Z.D1 * v.Z.D7;
        result.D1D8 = d0 * u.X.D1D8 + d1 * u.Y.D1D8 + d2 * u.Z.D1D8 + d3 * v.X.D1D8 + d4 * v.Y.D1D8 + d5 * v.Z.D1D8 + v.X.D1 * u.X.D8 + v.Y.D1 * u.Y.D8 + v.Z.D1 * u.Z.D8 + u.X.D1 * v.X.D8 + u.Y.D1 * v.Y.D8 + u.Z.D1 * v.Z.D8;
        result.D1D9 = d0 * u.X.D1D9 + d1 * u.Y.D1D9 + d2 * u.Z.D1D9 + d3 * v.X.D1D9 + d4 * v.Y.D1D9 + d5 * v.Z.D1D9 + v.X.D1 * u.X.D9 + v.Y.D1 * u.Y.D9 + v.Z.D1 * u.Z.D9 + u.X.D1 * v.X.D9 + u.Y.D1 * v.Y.D9 + u.Z.D1 * v.Z.D9;
        result.D1D10 = d0 * u.X.D1D10 + d1 * u.Y.D1D10 + d2 * u.Z.D1D10 + d3 * v.X.D1D10 + d4 * v.Y.D1D10 + d5 * v.Z.D1D10 + v.X.D1 * u.X.D10 + v.Y.D1 * u.Y.D10 + v.Z.D1 * u.Z.D10 + u.X.D1 * v.X.D10 + u.Y.D1 * v.Y.D10 + u.Z.D1 * v.Z.D10;
        result.D1D11 = d0 * u.X.D1D11 + d1 * u.Y.D1D11 + d2 * u.Z.D1D11 + d3 * v.X.D1D11 + d4 * v.Y.D1D11 + d5 * v.Z.D1D11 + v.X.D1 * u.X.D11 + v.Y.D1 * u.Y.D11 + v.Z.D1 * u.Z.D11 + u.X.D1 * v.X.D11 + u.Y.D1 * v.Y.D11 + u.Z.D1 * v.Z.D11;
        result.D2D2 = d0 * u.X.D2D2 + d1 * u.Y.D2D2 + d2 * u.Z.D2D2 + d3 * v.X.D2D2 + d4 * v.Y.D2D2 + d5 * v.Z.D2D2 + v.X.D2 * u.X.D2 + v.Y.D2 * u.Y.D2 + v.Z.D2 * u.Z.D2 + u.X.D2 * v.X.D2 + u.Y.D2 * v.Y.D2 + u.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * u.X.D2D3 + d1 * u.Y.D2D3 + d2 * u.Z.D2D3 + d3 * v.X.D2D3 + d4 * v.Y.D2D3 + d5 * v.Z.D2D3 + v.X.D2 * u.X.D3 + v.Y.D2 * u.Y.D3 + v.Z.D2 * u.Z.D3 + u.X.D2 * v.X.D3 + u.Y.D2 * v.Y.D3 + u.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * u.X.D2D4 + d1 * u.Y.D2D4 + d2 * u.Z.D2D4 + d3 * v.X.D2D4 + d4 * v.Y.D2D4 + d5 * v.Z.D2D4 + v.X.D2 * u.X.D4 + v.Y.D2 * u.Y.D4 + v.Z.D2 * u.Z.D4 + u.X.D2 * v.X.D4 + u.Y.D2 * v.Y.D4 + u.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * u.X.D2D5 + d1 * u.Y.D2D5 + d2 * u.Z.D2D5 + d3 * v.X.D2D5 + d4 * v.Y.D2D5 + d5 * v.Z.D2D5 + v.X.D2 * u.X.D5 + v.Y.D2 * u.Y.D5 + v.Z.D2 * u.Z.D5 + u.X.D2 * v.X.D5 + u.Y.D2 * v.Y.D5 + u.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * u.X.D2D6 + d1 * u.Y.D2D6 + d2 * u.Z.D2D6 + d3 * v.X.D2D6 + d4 * v.Y.D2D6 + d5 * v.Z.D2D6 + v.X.D2 * u.X.D6 + v.Y.D2 * u.Y.D6 + v.Z.D2 * u.Z.D6 + u.X.D2 * v.X.D6 + u.Y.D2 * v.Y.D6 + u.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * u.X.D2D7 + d1 * u.Y.D2D7 + d2 * u.Z.D2D7 + d3 * v.X.D2D7 + d4 * v.Y.D2D7 + d5 * v.Z.D2D7 + v.X.D2 * u.X.D7 + v.Y.D2 * u.Y.D7 + v.Z.D2 * u.Z.D7 + u.X.D2 * v.X.D7 + u.Y.D2 * v.Y.D7 + u.Z.D2 * v.Z.D7;
        result.D2D8 = d0 * u.X.D2D8 + d1 * u.Y.D2D8 + d2 * u.Z.D2D8 + d3 * v.X.D2D8 + d4 * v.Y.D2D8 + d5 * v.Z.D2D8 + v.X.D2 * u.X.D8 + v.Y.D2 * u.Y.D8 + v.Z.D2 * u.Z.D8 + u.X.D2 * v.X.D8 + u.Y.D2 * v.Y.D8 + u.Z.D2 * v.Z.D8;
        result.D2D9 = d0 * u.X.D2D9 + d1 * u.Y.D2D9 + d2 * u.Z.D2D9 + d3 * v.X.D2D9 + d4 * v.Y.D2D9 + d5 * v.Z.D2D9 + v.X.D2 * u.X.D9 + v.Y.D2 * u.Y.D9 + v.Z.D2 * u.Z.D9 + u.X.D2 * v.X.D9 + u.Y.D2 * v.Y.D9 + u.Z.D2 * v.Z.D9;
        result.D2D10 = d0 * u.X.D2D10 + d1 * u.Y.D2D10 + d2 * u.Z.D2D10 + d3 * v.X.D2D10 + d4 * v.Y.D2D10 + d5 * v.Z.D2D10 + v.X.D2 * u.X.D10 + v.Y.D2 * u.Y.D10 + v.Z.D2 * u.Z.D10 + u.X.D2 * v.X.D10 + u.Y.D2 * v.Y.D10 + u.Z.D2 * v.Z.D10;
        result.D2D11 = d0 * u.X.D2D11 + d1 * u.Y.D2D11 + d2 * u.Z.D2D11 + d3 * v.X.D2D11 + d4 * v.Y.D2D11 + d5 * v.Z.D2D11 + v.X.D2 * u.X.D11 + v.Y.D2 * u.Y.D11 + v.Z.D2 * u.Z.D11 + u.X.D2 * v.X.D11 + u.Y.D2 * v.Y.D11 + u.Z.D2 * v.Z.D11;
        result.D3D3 = d0 * u.X.D3D3 + d1 * u.Y.D3D3 + d2 * u.Z.D3D3 + d3 * v.X.D3D3 + d4 * v.Y.D3D3 + d5 * v.Z.D3D3 + v.X.D3 * u.X.D3 + v.Y.D3 * u.Y.D3 + v.Z.D3 * u.Z.D3 + u.X.D3 * v.X.D3 + u.Y.D3 * v.Y.D3 + u.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * u.X.D3D4 + d1 * u.Y.D3D4 + d2 * u.Z.D3D4 + d3 * v.X.D3D4 + d4 * v.Y.D3D4 + d5 * v.Z.D3D4 + v.X.D3 * u.X.D4 + v.Y.D3 * u.Y.D4 + v.Z.D3 * u.Z.D4 + u.X.D3 * v.X.D4 + u.Y.D3 * v.Y.D4 + u.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * u.X.D3D5 + d1 * u.Y.D3D5 + d2 * u.Z.D3D5 + d3 * v.X.D3D5 + d4 * v.Y.D3D5 + d5 * v.Z.D3D5 + v.X.D3 * u.X.D5 + v.Y.D3 * u.Y.D5 + v.Z.D3 * u.Z.D5 + u.X.D3 * v.X.D5 + u.Y.D3 * v.Y.D5 + u.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * u.X.D3D6 + d1 * u.Y.D3D6 + d2 * u.Z.D3D6 + d3 * v.X.D3D6 + d4 * v.Y.D3D6 + d5 * v.Z.D3D6 + v.X.D3 * u.X.D6 + v.Y.D3 * u.Y.D6 + v.Z.D3 * u.Z.D6 + u.X.D3 * v.X.D6 + u.Y.D3 * v.Y.D6 + u.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * u.X.D3D7 + d1 * u.Y.D3D7 + d2 * u.Z.D3D7 + d3 * v.X.D3D7 + d4 * v.Y.D3D7 + d5 * v.Z.D3D7 + v.X.D3 * u.X.D7 + v.Y.D3 * u.Y.D7 + v.Z.D3 * u.Z.D7 + u.X.D3 * v.X.D7 + u.Y.D3 * v.Y.D7 + u.Z.D3 * v.Z.D7;
        result.D3D8 = d0 * u.X.D3D8 + d1 * u.Y.D3D8 + d2 * u.Z.D3D8 + d3 * v.X.D3D8 + d4 * v.Y.D3D8 + d5 * v.Z.D3D8 + v.X.D3 * u.X.D8 + v.Y.D3 * u.Y.D8 + v.Z.D3 * u.Z.D8 + u.X.D3 * v.X.D8 + u.Y.D3 * v.Y.D8 + u.Z.D3 * v.Z.D8;
        result.D3D9 = d0 * u.X.D3D9 + d1 * u.Y.D3D9 + d2 * u.Z.D3D9 + d3 * v.X.D3D9 + d4 * v.Y.D3D9 + d5 * v.Z.D3D9 + v.X.D3 * u.X.D9 + v.Y.D3 * u.Y.D9 + v.Z.D3 * u.Z.D9 + u.X.D3 * v.X.D9 + u.Y.D3 * v.Y.D9 + u.Z.D3 * v.Z.D9;
        result.D3D10 = d0 * u.X.D3D10 + d1 * u.Y.D3D10 + d2 * u.Z.D3D10 + d3 * v.X.D3D10 + d4 * v.Y.D3D10 + d5 * v.Z.D3D10 + v.X.D3 * u.X.D10 + v.Y.D3 * u.Y.D10 + v.Z.D3 * u.Z.D10 + u.X.D3 * v.X.D10 + u.Y.D3 * v.Y.D10 + u.Z.D3 * v.Z.D10;
        result.D3D11 = d0 * u.X.D3D11 + d1 * u.Y.D3D11 + d2 * u.Z.D3D11 + d3 * v.X.D3D11 + d4 * v.Y.D3D11 + d5 * v.Z.D3D11 + v.X.D3 * u.X.D11 + v.Y.D3 * u.Y.D11 + v.Z.D3 * u.Z.D11 + u.X.D3 * v.X.D11 + u.Y.D3 * v.Y.D11 + u.Z.D3 * v.Z.D11;
        result.D4D4 = d0 * u.X.D4D4 + d1 * u.Y.D4D4 + d2 * u.Z.D4D4 + d3 * v.X.D4D4 + d4 * v.Y.D4D4 + d5 * v.Z.D4D4 + v.X.D4 * u.X.D4 + v.Y.D4 * u.Y.D4 + v.Z.D4 * u.Z.D4 + u.X.D4 * v.X.D4 + u.Y.D4 * v.Y.D4 + u.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * u.X.D4D5 + d1 * u.Y.D4D5 + d2 * u.Z.D4D5 + d3 * v.X.D4D5 + d4 * v.Y.D4D5 + d5 * v.Z.D4D5 + v.X.D4 * u.X.D5 + v.Y.D4 * u.Y.D5 + v.Z.D4 * u.Z.D5 + u.X.D4 * v.X.D5 + u.Y.D4 * v.Y.D5 + u.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * u.X.D4D6 + d1 * u.Y.D4D6 + d2 * u.Z.D4D6 + d3 * v.X.D4D6 + d4 * v.Y.D4D6 + d5 * v.Z.D4D6 + v.X.D4 * u.X.D6 + v.Y.D4 * u.Y.D6 + v.Z.D4 * u.Z.D6 + u.X.D4 * v.X.D6 + u.Y.D4 * v.Y.D6 + u.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * u.X.D4D7 + d1 * u.Y.D4D7 + d2 * u.Z.D4D7 + d3 * v.X.D4D7 + d4 * v.Y.D4D7 + d5 * v.Z.D4D7 + v.X.D4 * u.X.D7 + v.Y.D4 * u.Y.D7 + v.Z.D4 * u.Z.D7 + u.X.D4 * v.X.D7 + u.Y.D4 * v.Y.D7 + u.Z.D4 * v.Z.D7;
        result.D4D8 = d0 * u.X.D4D8 + d1 * u.Y.D4D8 + d2 * u.Z.D4D8 + d3 * v.X.D4D8 + d4 * v.Y.D4D8 + d5 * v.Z.D4D8 + v.X.D4 * u.X.D8 + v.Y.D4 * u.Y.D8 + v.Z.D4 * u.Z.D8 + u.X.D4 * v.X.D8 + u.Y.D4 * v.Y.D8 + u.Z.D4 * v.Z.D8;
        result.D4D9 = d0 * u.X.D4D9 + d1 * u.Y.D4D9 + d2 * u.Z.D4D9 + d3 * v.X.D4D9 + d4 * v.Y.D4D9 + d5 * v.Z.D4D9 + v.X.D4 * u.X.D9 + v.Y.D4 * u.Y.D9 + v.Z.D4 * u.Z.D9 + u.X.D4 * v.X.D9 + u.Y.D4 * v.Y.D9 + u.Z.D4 * v.Z.D9;
        result.D4D10 = d0 * u.X.D4D10 + d1 * u.Y.D4D10 + d2 * u.Z.D4D10 + d3 * v.X.D4D10 + d4 * v.Y.D4D10 + d5 * v.Z.D4D10 + v.X.D4 * u.X.D10 + v.Y.D4 * u.Y.D10 + v.Z.D4 * u.Z.D10 + u.X.D4 * v.X.D10 + u.Y.D4 * v.Y.D10 + u.Z.D4 * v.Z.D10;
        result.D4D11 = d0 * u.X.D4D11 + d1 * u.Y.D4D11 + d2 * u.Z.D4D11 + d3 * v.X.D4D11 + d4 * v.Y.D4D11 + d5 * v.Z.D4D11 + v.X.D4 * u.X.D11 + v.Y.D4 * u.Y.D11 + v.Z.D4 * u.Z.D11 + u.X.D4 * v.X.D11 + u.Y.D4 * v.Y.D11 + u.Z.D4 * v.Z.D11;
        result.D5D5 = d0 * u.X.D5D5 + d1 * u.Y.D5D5 + d2 * u.Z.D5D5 + d3 * v.X.D5D5 + d4 * v.Y.D5D5 + d5 * v.Z.D5D5 + v.X.D5 * u.X.D5 + v.Y.D5 * u.Y.D5 + v.Z.D5 * u.Z.D5 + u.X.D5 * v.X.D5 + u.Y.D5 * v.Y.D5 + u.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * u.X.D5D6 + d1 * u.Y.D5D6 + d2 * u.Z.D5D6 + d3 * v.X.D5D6 + d4 * v.Y.D5D6 + d5 * v.Z.D5D6 + v.X.D5 * u.X.D6 + v.Y.D5 * u.Y.D6 + v.Z.D5 * u.Z.D6 + u.X.D5 * v.X.D6 + u.Y.D5 * v.Y.D6 + u.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * u.X.D5D7 + d1 * u.Y.D5D7 + d2 * u.Z.D5D7 + d3 * v.X.D5D7 + d4 * v.Y.D5D7 + d5 * v.Z.D5D7 + v.X.D5 * u.X.D7 + v.Y.D5 * u.Y.D7 + v.Z.D5 * u.Z.D7 + u.X.D5 * v.X.D7 + u.Y.D5 * v.Y.D7 + u.Z.D5 * v.Z.D7;
        result.D5D8 = d0 * u.X.D5D8 + d1 * u.Y.D5D8 + d2 * u.Z.D5D8 + d3 * v.X.D5D8 + d4 * v.Y.D5D8 + d5 * v.Z.D5D8 + v.X.D5 * u.X.D8 + v.Y.D5 * u.Y.D8 + v.Z.D5 * u.Z.D8 + u.X.D5 * v.X.D8 + u.Y.D5 * v.Y.D8 + u.Z.D5 * v.Z.D8;
        result.D5D9 = d0 * u.X.D5D9 + d1 * u.Y.D5D9 + d2 * u.Z.D5D9 + d3 * v.X.D5D9 + d4 * v.Y.D5D9 + d5 * v.Z.D5D9 + v.X.D5 * u.X.D9 + v.Y.D5 * u.Y.D9 + v.Z.D5 * u.Z.D9 + u.X.D5 * v.X.D9 + u.Y.D5 * v.Y.D9 + u.Z.D5 * v.Z.D9;
        result.D5D10 = d0 * u.X.D5D10 + d1 * u.Y.D5D10 + d2 * u.Z.D5D10 + d3 * v.X.D5D10 + d4 * v.Y.D5D10 + d5 * v.Z.D5D10 + v.X.D5 * u.X.D10 + v.Y.D5 * u.Y.D10 + v.Z.D5 * u.Z.D10 + u.X.D5 * v.X.D10 + u.Y.D5 * v.Y.D10 + u.Z.D5 * v.Z.D10;
        result.D5D11 = d0 * u.X.D5D11 + d1 * u.Y.D5D11 + d2 * u.Z.D5D11 + d3 * v.X.D5D11 + d4 * v.Y.D5D11 + d5 * v.Z.D5D11 + v.X.D5 * u.X.D11 + v.Y.D5 * u.Y.D11 + v.Z.D5 * u.Z.D11 + u.X.D5 * v.X.D11 + u.Y.D5 * v.Y.D11 + u.Z.D5 * v.Z.D11;
        result.D6D6 = d0 * u.X.D6D6 + d1 * u.Y.D6D6 + d2 * u.Z.D6D6 + d3 * v.X.D6D6 + d4 * v.Y.D6D6 + d5 * v.Z.D6D6 + v.X.D6 * u.X.D6 + v.Y.D6 * u.Y.D6 + v.Z.D6 * u.Z.D6 + u.X.D6 * v.X.D6 + u.Y.D6 * v.Y.D6 + u.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * u.X.D6D7 + d1 * u.Y.D6D7 + d2 * u.Z.D6D7 + d3 * v.X.D6D7 + d4 * v.Y.D6D7 + d5 * v.Z.D6D7 + v.X.D6 * u.X.D7 + v.Y.D6 * u.Y.D7 + v.Z.D6 * u.Z.D7 + u.X.D6 * v.X.D7 + u.Y.D6 * v.Y.D7 + u.Z.D6 * v.Z.D7;
        result.D6D8 = d0 * u.X.D6D8 + d1 * u.Y.D6D8 + d2 * u.Z.D6D8 + d3 * v.X.D6D8 + d4 * v.Y.D6D8 + d5 * v.Z.D6D8 + v.X.D6 * u.X.D8 + v.Y.D6 * u.Y.D8 + v.Z.D6 * u.Z.D8 + u.X.D6 * v.X.D8 + u.Y.D6 * v.Y.D8 + u.Z.D6 * v.Z.D8;
        result.D6D9 = d0 * u.X.D6D9 + d1 * u.Y.D6D9 + d2 * u.Z.D6D9 + d3 * v.X.D6D9 + d4 * v.Y.D6D9 + d5 * v.Z.D6D9 + v.X.D6 * u.X.D9 + v.Y.D6 * u.Y.D9 + v.Z.D6 * u.Z.D9 + u.X.D6 * v.X.D9 + u.Y.D6 * v.Y.D9 + u.Z.D6 * v.Z.D9;
        result.D6D10 = d0 * u.X.D6D10 + d1 * u.Y.D6D10 + d2 * u.Z.D6D10 + d3 * v.X.D6D10 + d4 * v.Y.D6D10 + d5 * v.Z.D6D10 + v.X.D6 * u.X.D10 + v.Y.D6 * u.Y.D10 + v.Z.D6 * u.Z.D10 + u.X.D6 * v.X.D10 + u.Y.D6 * v.Y.D10 + u.Z.D6 * v.Z.D10;
        result.D6D11 = d0 * u.X.D6D11 + d1 * u.Y.D6D11 + d2 * u.Z.D6D11 + d3 * v.X.D6D11 + d4 * v.Y.D6D11 + d5 * v.Z.D6D11 + v.X.D6 * u.X.D11 + v.Y.D6 * u.Y.D11 + v.Z.D6 * u.Z.D11 + u.X.D6 * v.X.D11 + u.Y.D6 * v.Y.D11 + u.Z.D6 * v.Z.D11;
        result.D7D7 = d0 * u.X.D7D7 + d1 * u.Y.D7D7 + d2 * u.Z.D7D7 + d3 * v.X.D7D7 + d4 * v.Y.D7D7 + d5 * v.Z.D7D7 + v.X.D7 * u.X.D7 + v.Y.D7 * u.Y.D7 + v.Z.D7 * u.Z.D7 + u.X.D7 * v.X.D7 + u.Y.D7 * v.Y.D7 + u.Z.D7 * v.Z.D7;
        result.D7D8 = d0 * u.X.D7D8 + d1 * u.Y.D7D8 + d2 * u.Z.D7D8 + d3 * v.X.D7D8 + d4 * v.Y.D7D8 + d5 * v.Z.D7D8 + v.X.D7 * u.X.D8 + v.Y.D7 * u.Y.D8 + v.Z.D7 * u.Z.D8 + u.X.D7 * v.X.D8 + u.Y.D7 * v.Y.D8 + u.Z.D7 * v.Z.D8;
        result.D7D9 = d0 * u.X.D7D9 + d1 * u.Y.D7D9 + d2 * u.Z.D7D9 + d3 * v.X.D7D9 + d4 * v.Y.D7D9 + d5 * v.Z.D7D9 + v.X.D7 * u.X.D9 + v.Y.D7 * u.Y.D9 + v.Z.D7 * u.Z.D9 + u.X.D7 * v.X.D9 + u.Y.D7 * v.Y.D9 + u.Z.D7 * v.Z.D9;
        result.D7D10 = d0 * u.X.D7D10 + d1 * u.Y.D7D10 + d2 * u.Z.D7D10 + d3 * v.X.D7D10 + d4 * v.Y.D7D10 + d5 * v.Z.D7D10 + v.X.D7 * u.X.D10 + v.Y.D7 * u.Y.D10 + v.Z.D7 * u.Z.D10 + u.X.D7 * v.X.D10 + u.Y.D7 * v.Y.D10 + u.Z.D7 * v.Z.D10;
        result.D7D11 = d0 * u.X.D7D11 + d1 * u.Y.D7D11 + d2 * u.Z.D7D11 + d3 * v.X.D7D11 + d4 * v.Y.D7D11 + d5 * v.Z.D7D11 + v.X.D7 * u.X.D11 + v.Y.D7 * u.Y.D11 + v.Z.D7 * u.Z.D11 + u.X.D7 * v.X.D11 + u.Y.D7 * v.Y.D11 + u.Z.D7 * v.Z.D11;
        result.D8D8 = d0 * u.X.D8D8 + d1 * u.Y.D8D8 + d2 * u.Z.D8D8 + d3 * v.X.D8D8 + d4 * v.Y.D8D8 + d5 * v.Z.D8D8 + v.X.D8 * u.X.D8 + v.Y.D8 * u.Y.D8 + v.Z.D8 * u.Z.D8 + u.X.D8 * v.X.D8 + u.Y.D8 * v.Y.D8 + u.Z.D8 * v.Z.D8;
        result.D8D9 = d0 * u.X.D8D9 + d1 * u.Y.D8D9 + d2 * u.Z.D8D9 + d3 * v.X.D8D9 + d4 * v.Y.D8D9 + d5 * v.Z.D8D9 + v.X.D8 * u.X.D9 + v.Y.D8 * u.Y.D9 + v.Z.D8 * u.Z.D9 + u.X.D8 * v.X.D9 + u.Y.D8 * v.Y.D9 + u.Z.D8 * v.Z.D9;
        result.D8D10 = d0 * u.X.D8D10 + d1 * u.Y.D8D10 + d2 * u.Z.D8D10 + d3 * v.X.D8D10 + d4 * v.Y.D8D10 + d5 * v.Z.D8D10 + v.X.D8 * u.X.D10 + v.Y.D8 * u.Y.D10 + v.Z.D8 * u.Z.D10 + u.X.D8 * v.X.D10 + u.Y.D8 * v.Y.D10 + u.Z.D8 * v.Z.D10;
        result.D8D11 = d0 * u.X.D8D11 + d1 * u.Y.D8D11 + d2 * u.Z.D8D11 + d3 * v.X.D8D11 + d4 * v.Y.D8D11 + d5 * v.Z.D8D11 + v.X.D8 * u.X.D11 + v.Y.D8 * u.Y.D11 + v.Z.D8 * u.Z.D11 + u.X.D8 * v.X.D11 + u.Y.D8 * v.Y.D11 + u.Z.D8 * v.Z.D11;
        result.D9D9 = d0 * u.X.D9D9 + d1 * u.Y.D9D9 + d2 * u.Z.D9D9 + d3 * v.X.D9D9 + d4 * v.Y.D9D9 + d5 * v.Z.D9D9 + v.X.D9 * u.X.D9 + v.Y.D9 * u.Y.D9 + v.Z.D9 * u.Z.D9 + u.X.D9 * v.X.D9 + u.Y.D9 * v.Y.D9 + u.Z.D9 * v.Z.D9;
        result.D9D10 = d0 * u.X.D9D10 + d1 * u.Y.D9D10 + d2 * u.Z.D9D10 + d3 * v.X.D9D10 + d4 * v.Y.D9D10 + d5 * v.Z.D9D10 + v.X.D9 * u.X.D10 + v.Y.D9 * u.Y.D10 + v.Z.D9 * u.Z.D10 + u.X.D9 * v.X.D10 + u.Y.D9 * v.Y.D10 + u.Z.D9 * v.Z.D10;
        result.D9D11 = d0 * u.X.D9D11 + d1 * u.Y.D9D11 + d2 * u.Z.D9D11 + d3 * v.X.D9D11 + d4 * v.Y.D9D11 + d5 * v.Z.D9D11 + v.X.D9 * u.X.D11 + v.Y.D9 * u.Y.D11 + v.Z.D9 * u.Z.D11 + u.X.D9 * v.X.D11 + u.Y.D9 * v.Y.D11 + u.Z.D9 * v.Z.D11;
        result.D10D10 = d0 * u.X.D10D10 + d1 * u.Y.D10D10 + d2 * u.Z.D10D10 + d3 * v.X.D10D10 + d4 * v.Y.D10D10 + d5 * v.Z.D10D10 + v.X.D10 * u.X.D10 + v.Y.D10 * u.Y.D10 + v.Z.D10 * u.Z.D10 + u.X.D10 * v.X.D10 + u.Y.D10 * v.Y.D10 + u.Z.D10 * v.Z.D10;
        result.D10D11 = d0 * u.X.D10D11 + d1 * u.Y.D10D11 + d2 * u.Z.D10D11 + d3 * v.X.D10D11 + d4 * v.Y.D10D11 + d5 * v.Z.D10D11 + v.X.D10 * u.X.D11 + v.Y.D10 * u.Y.D11 + v.Z.D10 * u.Z.D11 + u.X.D10 * v.X.D11 + u.Y.D10 * v.Y.D11 + u.Z.D10 * v.Z.D11;
        result.D11D11 = d0 * u.X.D11D11 + d1 * u.Y.D11D11 + d2 * u.Z.D11D11 + d3 * v.X.D11D11 + d4 * v.Y.D11D11 + d5 * v.Z.D11D11 + v.X.D11 * u.X.D11 + v.Y.D11 * u.Y.D11 + v.Z.D11 * u.Z.D11 + u.X.D11 * v.X.D11 + u.Y.D11 * v.Y.D11 + u.Z.D11 * v.Z.D11;

        return result;
    }
}
