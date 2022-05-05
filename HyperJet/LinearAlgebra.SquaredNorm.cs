namespace HyperJet;
public static partial class LinearAlgebraD
{
    public static D1Scalar SquaredNorm(D1Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D1Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;

        return result;
    }

    public static D2Scalar SquaredNorm(D2Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D2Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;

        return result;
    }

    public static D3Scalar SquaredNorm(D3Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D3Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;

        return result;
    }

    public static D4Scalar SquaredNorm(D4Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D4Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;

        return result;
    }

    public static D5Scalar SquaredNorm(D5Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D5Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;

        return result;
    }

    public static D6Scalar SquaredNorm(D6Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D6Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;

        return result;
    }

    public static D7Scalar SquaredNorm(D7Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D7Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;

        return result;
    }

    public static D8Scalar SquaredNorm(D8Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D8Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;

        return result;
    }

    public static D9Scalar SquaredNorm(D9Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D9Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;
        result.D8 = d0 * v.X.D8 + d1 * v.Y.D8 + d2 * v.Z.D8;

        return result;
    }

    public static D10Scalar SquaredNorm(D10Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D10Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;
        result.D8 = d0 * v.X.D8 + d1 * v.Y.D8 + d2 * v.Z.D8;
        result.D9 = d0 * v.X.D9 + d1 * v.Y.D9 + d2 * v.Z.D9;

        return result;
    }

    public static D11Scalar SquaredNorm(D11Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D11Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;
        result.D8 = d0 * v.X.D8 + d1 * v.Y.D8 + d2 * v.Z.D8;
        result.D9 = d0 * v.X.D9 + d1 * v.Y.D9 + d2 * v.Z.D9;
        result.D10 = d0 * v.X.D10 + d1 * v.Y.D10 + d2 * v.Z.D10;

        return result;
    }

    public static D12Scalar SquaredNorm(D12Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new D12Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;
        result.D8 = d0 * v.X.D8 + d1 * v.Y.D8 + d2 * v.Z.D8;
        result.D9 = d0 * v.X.D9 + d1 * v.Y.D9 + d2 * v.Z.D9;
        result.D10 = d0 * v.X.D10 + d1 * v.Y.D10 + d2 * v.Z.D10;
        result.D11 = d0 * v.X.D11 + d1 * v.Y.D11 + d2 * v.Z.D11;

        return result;
    }

    public static DD1Scalar SquaredNorm(DD1Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD1Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;

        return result;
    }

    public static DD2Scalar SquaredNorm(DD2Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD2Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;

        return result;
    }

    public static DD3Scalar SquaredNorm(DD3Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD3Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;

        return result;
    }

    public static DD4Scalar SquaredNorm(DD4Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD4Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * v.X.D0D3 + d1 * v.Y.D0D3 + d2 * v.Z.D0D3 + 2 * v.X.D0 * v.X.D3 + 2 * v.Y.D0 * v.Y.D3 + 2 * v.Z.D0 * v.Z.D3;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * v.X.D1D3 + d1 * v.Y.D1D3 + d2 * v.Z.D1D3 + 2 * v.X.D1 * v.X.D3 + 2 * v.Y.D1 * v.Y.D3 + 2 * v.Z.D1 * v.Z.D3;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * v.X.D2D3 + d1 * v.Y.D2D3 + d2 * v.Z.D2D3 + 2 * v.X.D2 * v.X.D3 + 2 * v.Y.D2 * v.Y.D3 + 2 * v.Z.D2 * v.Z.D3;
        result.D3D3 = d0 * v.X.D3D3 + d1 * v.Y.D3D3 + d2 * v.Z.D3D3 + 2 * v.X.D3 * v.X.D3 + 2 * v.Y.D3 * v.Y.D3 + 2 * v.Z.D3 * v.Z.D3;

        return result;
    }

    public static DD5Scalar SquaredNorm(DD5Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD5Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * v.X.D0D3 + d1 * v.Y.D0D3 + d2 * v.Z.D0D3 + 2 * v.X.D0 * v.X.D3 + 2 * v.Y.D0 * v.Y.D3 + 2 * v.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * v.X.D0D4 + d1 * v.Y.D0D4 + d2 * v.Z.D0D4 + 2 * v.X.D0 * v.X.D4 + 2 * v.Y.D0 * v.Y.D4 + 2 * v.Z.D0 * v.Z.D4;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * v.X.D1D3 + d1 * v.Y.D1D3 + d2 * v.Z.D1D3 + 2 * v.X.D1 * v.X.D3 + 2 * v.Y.D1 * v.Y.D3 + 2 * v.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * v.X.D1D4 + d1 * v.Y.D1D4 + d2 * v.Z.D1D4 + 2 * v.X.D1 * v.X.D4 + 2 * v.Y.D1 * v.Y.D4 + 2 * v.Z.D1 * v.Z.D4;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * v.X.D2D3 + d1 * v.Y.D2D3 + d2 * v.Z.D2D3 + 2 * v.X.D2 * v.X.D3 + 2 * v.Y.D2 * v.Y.D3 + 2 * v.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * v.X.D2D4 + d1 * v.Y.D2D4 + d2 * v.Z.D2D4 + 2 * v.X.D2 * v.X.D4 + 2 * v.Y.D2 * v.Y.D4 + 2 * v.Z.D2 * v.Z.D4;
        result.D3D3 = d0 * v.X.D3D3 + d1 * v.Y.D3D3 + d2 * v.Z.D3D3 + 2 * v.X.D3 * v.X.D3 + 2 * v.Y.D3 * v.Y.D3 + 2 * v.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * v.X.D3D4 + d1 * v.Y.D3D4 + d2 * v.Z.D3D4 + 2 * v.X.D3 * v.X.D4 + 2 * v.Y.D3 * v.Y.D4 + 2 * v.Z.D3 * v.Z.D4;
        result.D4D4 = d0 * v.X.D4D4 + d1 * v.Y.D4D4 + d2 * v.Z.D4D4 + 2 * v.X.D4 * v.X.D4 + 2 * v.Y.D4 * v.Y.D4 + 2 * v.Z.D4 * v.Z.D4;

        return result;
    }

    public static DD6Scalar SquaredNorm(DD6Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD6Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * v.X.D0D3 + d1 * v.Y.D0D3 + d2 * v.Z.D0D3 + 2 * v.X.D0 * v.X.D3 + 2 * v.Y.D0 * v.Y.D3 + 2 * v.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * v.X.D0D4 + d1 * v.Y.D0D4 + d2 * v.Z.D0D4 + 2 * v.X.D0 * v.X.D4 + 2 * v.Y.D0 * v.Y.D4 + 2 * v.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * v.X.D0D5 + d1 * v.Y.D0D5 + d2 * v.Z.D0D5 + 2 * v.X.D0 * v.X.D5 + 2 * v.Y.D0 * v.Y.D5 + 2 * v.Z.D0 * v.Z.D5;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * v.X.D1D3 + d1 * v.Y.D1D3 + d2 * v.Z.D1D3 + 2 * v.X.D1 * v.X.D3 + 2 * v.Y.D1 * v.Y.D3 + 2 * v.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * v.X.D1D4 + d1 * v.Y.D1D4 + d2 * v.Z.D1D4 + 2 * v.X.D1 * v.X.D4 + 2 * v.Y.D1 * v.Y.D4 + 2 * v.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * v.X.D1D5 + d1 * v.Y.D1D5 + d2 * v.Z.D1D5 + 2 * v.X.D1 * v.X.D5 + 2 * v.Y.D1 * v.Y.D5 + 2 * v.Z.D1 * v.Z.D5;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * v.X.D2D3 + d1 * v.Y.D2D3 + d2 * v.Z.D2D3 + 2 * v.X.D2 * v.X.D3 + 2 * v.Y.D2 * v.Y.D3 + 2 * v.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * v.X.D2D4 + d1 * v.Y.D2D4 + d2 * v.Z.D2D4 + 2 * v.X.D2 * v.X.D4 + 2 * v.Y.D2 * v.Y.D4 + 2 * v.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * v.X.D2D5 + d1 * v.Y.D2D5 + d2 * v.Z.D2D5 + 2 * v.X.D2 * v.X.D5 + 2 * v.Y.D2 * v.Y.D5 + 2 * v.Z.D2 * v.Z.D5;
        result.D3D3 = d0 * v.X.D3D3 + d1 * v.Y.D3D3 + d2 * v.Z.D3D3 + 2 * v.X.D3 * v.X.D3 + 2 * v.Y.D3 * v.Y.D3 + 2 * v.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * v.X.D3D4 + d1 * v.Y.D3D4 + d2 * v.Z.D3D4 + 2 * v.X.D3 * v.X.D4 + 2 * v.Y.D3 * v.Y.D4 + 2 * v.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * v.X.D3D5 + d1 * v.Y.D3D5 + d2 * v.Z.D3D5 + 2 * v.X.D3 * v.X.D5 + 2 * v.Y.D3 * v.Y.D5 + 2 * v.Z.D3 * v.Z.D5;
        result.D4D4 = d0 * v.X.D4D4 + d1 * v.Y.D4D4 + d2 * v.Z.D4D4 + 2 * v.X.D4 * v.X.D4 + 2 * v.Y.D4 * v.Y.D4 + 2 * v.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * v.X.D4D5 + d1 * v.Y.D4D5 + d2 * v.Z.D4D5 + 2 * v.X.D4 * v.X.D5 + 2 * v.Y.D4 * v.Y.D5 + 2 * v.Z.D4 * v.Z.D5;
        result.D5D5 = d0 * v.X.D5D5 + d1 * v.Y.D5D5 + d2 * v.Z.D5D5 + 2 * v.X.D5 * v.X.D5 + 2 * v.Y.D5 * v.Y.D5 + 2 * v.Z.D5 * v.Z.D5;

        return result;
    }

    public static DD7Scalar SquaredNorm(DD7Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD7Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * v.X.D0D3 + d1 * v.Y.D0D3 + d2 * v.Z.D0D3 + 2 * v.X.D0 * v.X.D3 + 2 * v.Y.D0 * v.Y.D3 + 2 * v.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * v.X.D0D4 + d1 * v.Y.D0D4 + d2 * v.Z.D0D4 + 2 * v.X.D0 * v.X.D4 + 2 * v.Y.D0 * v.Y.D4 + 2 * v.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * v.X.D0D5 + d1 * v.Y.D0D5 + d2 * v.Z.D0D5 + 2 * v.X.D0 * v.X.D5 + 2 * v.Y.D0 * v.Y.D5 + 2 * v.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * v.X.D0D6 + d1 * v.Y.D0D6 + d2 * v.Z.D0D6 + 2 * v.X.D0 * v.X.D6 + 2 * v.Y.D0 * v.Y.D6 + 2 * v.Z.D0 * v.Z.D6;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * v.X.D1D3 + d1 * v.Y.D1D3 + d2 * v.Z.D1D3 + 2 * v.X.D1 * v.X.D3 + 2 * v.Y.D1 * v.Y.D3 + 2 * v.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * v.X.D1D4 + d1 * v.Y.D1D4 + d2 * v.Z.D1D4 + 2 * v.X.D1 * v.X.D4 + 2 * v.Y.D1 * v.Y.D4 + 2 * v.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * v.X.D1D5 + d1 * v.Y.D1D5 + d2 * v.Z.D1D5 + 2 * v.X.D1 * v.X.D5 + 2 * v.Y.D1 * v.Y.D5 + 2 * v.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * v.X.D1D6 + d1 * v.Y.D1D6 + d2 * v.Z.D1D6 + 2 * v.X.D1 * v.X.D6 + 2 * v.Y.D1 * v.Y.D6 + 2 * v.Z.D1 * v.Z.D6;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * v.X.D2D3 + d1 * v.Y.D2D3 + d2 * v.Z.D2D3 + 2 * v.X.D2 * v.X.D3 + 2 * v.Y.D2 * v.Y.D3 + 2 * v.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * v.X.D2D4 + d1 * v.Y.D2D4 + d2 * v.Z.D2D4 + 2 * v.X.D2 * v.X.D4 + 2 * v.Y.D2 * v.Y.D4 + 2 * v.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * v.X.D2D5 + d1 * v.Y.D2D5 + d2 * v.Z.D2D5 + 2 * v.X.D2 * v.X.D5 + 2 * v.Y.D2 * v.Y.D5 + 2 * v.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * v.X.D2D6 + d1 * v.Y.D2D6 + d2 * v.Z.D2D6 + 2 * v.X.D2 * v.X.D6 + 2 * v.Y.D2 * v.Y.D6 + 2 * v.Z.D2 * v.Z.D6;
        result.D3D3 = d0 * v.X.D3D3 + d1 * v.Y.D3D3 + d2 * v.Z.D3D3 + 2 * v.X.D3 * v.X.D3 + 2 * v.Y.D3 * v.Y.D3 + 2 * v.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * v.X.D3D4 + d1 * v.Y.D3D4 + d2 * v.Z.D3D4 + 2 * v.X.D3 * v.X.D4 + 2 * v.Y.D3 * v.Y.D4 + 2 * v.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * v.X.D3D5 + d1 * v.Y.D3D5 + d2 * v.Z.D3D5 + 2 * v.X.D3 * v.X.D5 + 2 * v.Y.D3 * v.Y.D5 + 2 * v.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * v.X.D3D6 + d1 * v.Y.D3D6 + d2 * v.Z.D3D6 + 2 * v.X.D3 * v.X.D6 + 2 * v.Y.D3 * v.Y.D6 + 2 * v.Z.D3 * v.Z.D6;
        result.D4D4 = d0 * v.X.D4D4 + d1 * v.Y.D4D4 + d2 * v.Z.D4D4 + 2 * v.X.D4 * v.X.D4 + 2 * v.Y.D4 * v.Y.D4 + 2 * v.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * v.X.D4D5 + d1 * v.Y.D4D5 + d2 * v.Z.D4D5 + 2 * v.X.D4 * v.X.D5 + 2 * v.Y.D4 * v.Y.D5 + 2 * v.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * v.X.D4D6 + d1 * v.Y.D4D6 + d2 * v.Z.D4D6 + 2 * v.X.D4 * v.X.D6 + 2 * v.Y.D4 * v.Y.D6 + 2 * v.Z.D4 * v.Z.D6;
        result.D5D5 = d0 * v.X.D5D5 + d1 * v.Y.D5D5 + d2 * v.Z.D5D5 + 2 * v.X.D5 * v.X.D5 + 2 * v.Y.D5 * v.Y.D5 + 2 * v.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * v.X.D5D6 + d1 * v.Y.D5D6 + d2 * v.Z.D5D6 + 2 * v.X.D5 * v.X.D6 + 2 * v.Y.D5 * v.Y.D6 + 2 * v.Z.D5 * v.Z.D6;
        result.D6D6 = d0 * v.X.D6D6 + d1 * v.Y.D6D6 + d2 * v.Z.D6D6 + 2 * v.X.D6 * v.X.D6 + 2 * v.Y.D6 * v.Y.D6 + 2 * v.Z.D6 * v.Z.D6;

        return result;
    }

    public static DD8Scalar SquaredNorm(DD8Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD8Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * v.X.D0D3 + d1 * v.Y.D0D3 + d2 * v.Z.D0D3 + 2 * v.X.D0 * v.X.D3 + 2 * v.Y.D0 * v.Y.D3 + 2 * v.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * v.X.D0D4 + d1 * v.Y.D0D4 + d2 * v.Z.D0D4 + 2 * v.X.D0 * v.X.D4 + 2 * v.Y.D0 * v.Y.D4 + 2 * v.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * v.X.D0D5 + d1 * v.Y.D0D5 + d2 * v.Z.D0D5 + 2 * v.X.D0 * v.X.D5 + 2 * v.Y.D0 * v.Y.D5 + 2 * v.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * v.X.D0D6 + d1 * v.Y.D0D6 + d2 * v.Z.D0D6 + 2 * v.X.D0 * v.X.D6 + 2 * v.Y.D0 * v.Y.D6 + 2 * v.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * v.X.D0D7 + d1 * v.Y.D0D7 + d2 * v.Z.D0D7 + 2 * v.X.D0 * v.X.D7 + 2 * v.Y.D0 * v.Y.D7 + 2 * v.Z.D0 * v.Z.D7;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * v.X.D1D3 + d1 * v.Y.D1D3 + d2 * v.Z.D1D3 + 2 * v.X.D1 * v.X.D3 + 2 * v.Y.D1 * v.Y.D3 + 2 * v.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * v.X.D1D4 + d1 * v.Y.D1D4 + d2 * v.Z.D1D4 + 2 * v.X.D1 * v.X.D4 + 2 * v.Y.D1 * v.Y.D4 + 2 * v.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * v.X.D1D5 + d1 * v.Y.D1D5 + d2 * v.Z.D1D5 + 2 * v.X.D1 * v.X.D5 + 2 * v.Y.D1 * v.Y.D5 + 2 * v.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * v.X.D1D6 + d1 * v.Y.D1D6 + d2 * v.Z.D1D6 + 2 * v.X.D1 * v.X.D6 + 2 * v.Y.D1 * v.Y.D6 + 2 * v.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * v.X.D1D7 + d1 * v.Y.D1D7 + d2 * v.Z.D1D7 + 2 * v.X.D1 * v.X.D7 + 2 * v.Y.D1 * v.Y.D7 + 2 * v.Z.D1 * v.Z.D7;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * v.X.D2D3 + d1 * v.Y.D2D3 + d2 * v.Z.D2D3 + 2 * v.X.D2 * v.X.D3 + 2 * v.Y.D2 * v.Y.D3 + 2 * v.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * v.X.D2D4 + d1 * v.Y.D2D4 + d2 * v.Z.D2D4 + 2 * v.X.D2 * v.X.D4 + 2 * v.Y.D2 * v.Y.D4 + 2 * v.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * v.X.D2D5 + d1 * v.Y.D2D5 + d2 * v.Z.D2D5 + 2 * v.X.D2 * v.X.D5 + 2 * v.Y.D2 * v.Y.D5 + 2 * v.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * v.X.D2D6 + d1 * v.Y.D2D6 + d2 * v.Z.D2D6 + 2 * v.X.D2 * v.X.D6 + 2 * v.Y.D2 * v.Y.D6 + 2 * v.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * v.X.D2D7 + d1 * v.Y.D2D7 + d2 * v.Z.D2D7 + 2 * v.X.D2 * v.X.D7 + 2 * v.Y.D2 * v.Y.D7 + 2 * v.Z.D2 * v.Z.D7;
        result.D3D3 = d0 * v.X.D3D3 + d1 * v.Y.D3D3 + d2 * v.Z.D3D3 + 2 * v.X.D3 * v.X.D3 + 2 * v.Y.D3 * v.Y.D3 + 2 * v.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * v.X.D3D4 + d1 * v.Y.D3D4 + d2 * v.Z.D3D4 + 2 * v.X.D3 * v.X.D4 + 2 * v.Y.D3 * v.Y.D4 + 2 * v.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * v.X.D3D5 + d1 * v.Y.D3D5 + d2 * v.Z.D3D5 + 2 * v.X.D3 * v.X.D5 + 2 * v.Y.D3 * v.Y.D5 + 2 * v.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * v.X.D3D6 + d1 * v.Y.D3D6 + d2 * v.Z.D3D6 + 2 * v.X.D3 * v.X.D6 + 2 * v.Y.D3 * v.Y.D6 + 2 * v.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * v.X.D3D7 + d1 * v.Y.D3D7 + d2 * v.Z.D3D7 + 2 * v.X.D3 * v.X.D7 + 2 * v.Y.D3 * v.Y.D7 + 2 * v.Z.D3 * v.Z.D7;
        result.D4D4 = d0 * v.X.D4D4 + d1 * v.Y.D4D4 + d2 * v.Z.D4D4 + 2 * v.X.D4 * v.X.D4 + 2 * v.Y.D4 * v.Y.D4 + 2 * v.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * v.X.D4D5 + d1 * v.Y.D4D5 + d2 * v.Z.D4D5 + 2 * v.X.D4 * v.X.D5 + 2 * v.Y.D4 * v.Y.D5 + 2 * v.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * v.X.D4D6 + d1 * v.Y.D4D6 + d2 * v.Z.D4D6 + 2 * v.X.D4 * v.X.D6 + 2 * v.Y.D4 * v.Y.D6 + 2 * v.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * v.X.D4D7 + d1 * v.Y.D4D7 + d2 * v.Z.D4D7 + 2 * v.X.D4 * v.X.D7 + 2 * v.Y.D4 * v.Y.D7 + 2 * v.Z.D4 * v.Z.D7;
        result.D5D5 = d0 * v.X.D5D5 + d1 * v.Y.D5D5 + d2 * v.Z.D5D5 + 2 * v.X.D5 * v.X.D5 + 2 * v.Y.D5 * v.Y.D5 + 2 * v.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * v.X.D5D6 + d1 * v.Y.D5D6 + d2 * v.Z.D5D6 + 2 * v.X.D5 * v.X.D6 + 2 * v.Y.D5 * v.Y.D6 + 2 * v.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * v.X.D5D7 + d1 * v.Y.D5D7 + d2 * v.Z.D5D7 + 2 * v.X.D5 * v.X.D7 + 2 * v.Y.D5 * v.Y.D7 + 2 * v.Z.D5 * v.Z.D7;
        result.D6D6 = d0 * v.X.D6D6 + d1 * v.Y.D6D6 + d2 * v.Z.D6D6 + 2 * v.X.D6 * v.X.D6 + 2 * v.Y.D6 * v.Y.D6 + 2 * v.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * v.X.D6D7 + d1 * v.Y.D6D7 + d2 * v.Z.D6D7 + 2 * v.X.D6 * v.X.D7 + 2 * v.Y.D6 * v.Y.D7 + 2 * v.Z.D6 * v.Z.D7;
        result.D7D7 = d0 * v.X.D7D7 + d1 * v.Y.D7D7 + d2 * v.Z.D7D7 + 2 * v.X.D7 * v.X.D7 + 2 * v.Y.D7 * v.Y.D7 + 2 * v.Z.D7 * v.Z.D7;

        return result;
    }

    public static DD9Scalar SquaredNorm(DD9Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD9Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;
        result.D8 = d0 * v.X.D8 + d1 * v.Y.D8 + d2 * v.Z.D8;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * v.X.D0D3 + d1 * v.Y.D0D3 + d2 * v.Z.D0D3 + 2 * v.X.D0 * v.X.D3 + 2 * v.Y.D0 * v.Y.D3 + 2 * v.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * v.X.D0D4 + d1 * v.Y.D0D4 + d2 * v.Z.D0D4 + 2 * v.X.D0 * v.X.D4 + 2 * v.Y.D0 * v.Y.D4 + 2 * v.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * v.X.D0D5 + d1 * v.Y.D0D5 + d2 * v.Z.D0D5 + 2 * v.X.D0 * v.X.D5 + 2 * v.Y.D0 * v.Y.D5 + 2 * v.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * v.X.D0D6 + d1 * v.Y.D0D6 + d2 * v.Z.D0D6 + 2 * v.X.D0 * v.X.D6 + 2 * v.Y.D0 * v.Y.D6 + 2 * v.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * v.X.D0D7 + d1 * v.Y.D0D7 + d2 * v.Z.D0D7 + 2 * v.X.D0 * v.X.D7 + 2 * v.Y.D0 * v.Y.D7 + 2 * v.Z.D0 * v.Z.D7;
        result.D0D8 = d0 * v.X.D0D8 + d1 * v.Y.D0D8 + d2 * v.Z.D0D8 + 2 * v.X.D0 * v.X.D8 + 2 * v.Y.D0 * v.Y.D8 + 2 * v.Z.D0 * v.Z.D8;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * v.X.D1D3 + d1 * v.Y.D1D3 + d2 * v.Z.D1D3 + 2 * v.X.D1 * v.X.D3 + 2 * v.Y.D1 * v.Y.D3 + 2 * v.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * v.X.D1D4 + d1 * v.Y.D1D4 + d2 * v.Z.D1D4 + 2 * v.X.D1 * v.X.D4 + 2 * v.Y.D1 * v.Y.D4 + 2 * v.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * v.X.D1D5 + d1 * v.Y.D1D5 + d2 * v.Z.D1D5 + 2 * v.X.D1 * v.X.D5 + 2 * v.Y.D1 * v.Y.D5 + 2 * v.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * v.X.D1D6 + d1 * v.Y.D1D6 + d2 * v.Z.D1D6 + 2 * v.X.D1 * v.X.D6 + 2 * v.Y.D1 * v.Y.D6 + 2 * v.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * v.X.D1D7 + d1 * v.Y.D1D7 + d2 * v.Z.D1D7 + 2 * v.X.D1 * v.X.D7 + 2 * v.Y.D1 * v.Y.D7 + 2 * v.Z.D1 * v.Z.D7;
        result.D1D8 = d0 * v.X.D1D8 + d1 * v.Y.D1D8 + d2 * v.Z.D1D8 + 2 * v.X.D1 * v.X.D8 + 2 * v.Y.D1 * v.Y.D8 + 2 * v.Z.D1 * v.Z.D8;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * v.X.D2D3 + d1 * v.Y.D2D3 + d2 * v.Z.D2D3 + 2 * v.X.D2 * v.X.D3 + 2 * v.Y.D2 * v.Y.D3 + 2 * v.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * v.X.D2D4 + d1 * v.Y.D2D4 + d2 * v.Z.D2D4 + 2 * v.X.D2 * v.X.D4 + 2 * v.Y.D2 * v.Y.D4 + 2 * v.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * v.X.D2D5 + d1 * v.Y.D2D5 + d2 * v.Z.D2D5 + 2 * v.X.D2 * v.X.D5 + 2 * v.Y.D2 * v.Y.D5 + 2 * v.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * v.X.D2D6 + d1 * v.Y.D2D6 + d2 * v.Z.D2D6 + 2 * v.X.D2 * v.X.D6 + 2 * v.Y.D2 * v.Y.D6 + 2 * v.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * v.X.D2D7 + d1 * v.Y.D2D7 + d2 * v.Z.D2D7 + 2 * v.X.D2 * v.X.D7 + 2 * v.Y.D2 * v.Y.D7 + 2 * v.Z.D2 * v.Z.D7;
        result.D2D8 = d0 * v.X.D2D8 + d1 * v.Y.D2D8 + d2 * v.Z.D2D8 + 2 * v.X.D2 * v.X.D8 + 2 * v.Y.D2 * v.Y.D8 + 2 * v.Z.D2 * v.Z.D8;
        result.D3D3 = d0 * v.X.D3D3 + d1 * v.Y.D3D3 + d2 * v.Z.D3D3 + 2 * v.X.D3 * v.X.D3 + 2 * v.Y.D3 * v.Y.D3 + 2 * v.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * v.X.D3D4 + d1 * v.Y.D3D4 + d2 * v.Z.D3D4 + 2 * v.X.D3 * v.X.D4 + 2 * v.Y.D3 * v.Y.D4 + 2 * v.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * v.X.D3D5 + d1 * v.Y.D3D5 + d2 * v.Z.D3D5 + 2 * v.X.D3 * v.X.D5 + 2 * v.Y.D3 * v.Y.D5 + 2 * v.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * v.X.D3D6 + d1 * v.Y.D3D6 + d2 * v.Z.D3D6 + 2 * v.X.D3 * v.X.D6 + 2 * v.Y.D3 * v.Y.D6 + 2 * v.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * v.X.D3D7 + d1 * v.Y.D3D7 + d2 * v.Z.D3D7 + 2 * v.X.D3 * v.X.D7 + 2 * v.Y.D3 * v.Y.D7 + 2 * v.Z.D3 * v.Z.D7;
        result.D3D8 = d0 * v.X.D3D8 + d1 * v.Y.D3D8 + d2 * v.Z.D3D8 + 2 * v.X.D3 * v.X.D8 + 2 * v.Y.D3 * v.Y.D8 + 2 * v.Z.D3 * v.Z.D8;
        result.D4D4 = d0 * v.X.D4D4 + d1 * v.Y.D4D4 + d2 * v.Z.D4D4 + 2 * v.X.D4 * v.X.D4 + 2 * v.Y.D4 * v.Y.D4 + 2 * v.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * v.X.D4D5 + d1 * v.Y.D4D5 + d2 * v.Z.D4D5 + 2 * v.X.D4 * v.X.D5 + 2 * v.Y.D4 * v.Y.D5 + 2 * v.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * v.X.D4D6 + d1 * v.Y.D4D6 + d2 * v.Z.D4D6 + 2 * v.X.D4 * v.X.D6 + 2 * v.Y.D4 * v.Y.D6 + 2 * v.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * v.X.D4D7 + d1 * v.Y.D4D7 + d2 * v.Z.D4D7 + 2 * v.X.D4 * v.X.D7 + 2 * v.Y.D4 * v.Y.D7 + 2 * v.Z.D4 * v.Z.D7;
        result.D4D8 = d0 * v.X.D4D8 + d1 * v.Y.D4D8 + d2 * v.Z.D4D8 + 2 * v.X.D4 * v.X.D8 + 2 * v.Y.D4 * v.Y.D8 + 2 * v.Z.D4 * v.Z.D8;
        result.D5D5 = d0 * v.X.D5D5 + d1 * v.Y.D5D5 + d2 * v.Z.D5D5 + 2 * v.X.D5 * v.X.D5 + 2 * v.Y.D5 * v.Y.D5 + 2 * v.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * v.X.D5D6 + d1 * v.Y.D5D6 + d2 * v.Z.D5D6 + 2 * v.X.D5 * v.X.D6 + 2 * v.Y.D5 * v.Y.D6 + 2 * v.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * v.X.D5D7 + d1 * v.Y.D5D7 + d2 * v.Z.D5D7 + 2 * v.X.D5 * v.X.D7 + 2 * v.Y.D5 * v.Y.D7 + 2 * v.Z.D5 * v.Z.D7;
        result.D5D8 = d0 * v.X.D5D8 + d1 * v.Y.D5D8 + d2 * v.Z.D5D8 + 2 * v.X.D5 * v.X.D8 + 2 * v.Y.D5 * v.Y.D8 + 2 * v.Z.D5 * v.Z.D8;
        result.D6D6 = d0 * v.X.D6D6 + d1 * v.Y.D6D6 + d2 * v.Z.D6D6 + 2 * v.X.D6 * v.X.D6 + 2 * v.Y.D6 * v.Y.D6 + 2 * v.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * v.X.D6D7 + d1 * v.Y.D6D7 + d2 * v.Z.D6D7 + 2 * v.X.D6 * v.X.D7 + 2 * v.Y.D6 * v.Y.D7 + 2 * v.Z.D6 * v.Z.D7;
        result.D6D8 = d0 * v.X.D6D8 + d1 * v.Y.D6D8 + d2 * v.Z.D6D8 + 2 * v.X.D6 * v.X.D8 + 2 * v.Y.D6 * v.Y.D8 + 2 * v.Z.D6 * v.Z.D8;
        result.D7D7 = d0 * v.X.D7D7 + d1 * v.Y.D7D7 + d2 * v.Z.D7D7 + 2 * v.X.D7 * v.X.D7 + 2 * v.Y.D7 * v.Y.D7 + 2 * v.Z.D7 * v.Z.D7;
        result.D7D8 = d0 * v.X.D7D8 + d1 * v.Y.D7D8 + d2 * v.Z.D7D8 + 2 * v.X.D7 * v.X.D8 + 2 * v.Y.D7 * v.Y.D8 + 2 * v.Z.D7 * v.Z.D8;
        result.D8D8 = d0 * v.X.D8D8 + d1 * v.Y.D8D8 + d2 * v.Z.D8D8 + 2 * v.X.D8 * v.X.D8 + 2 * v.Y.D8 * v.Y.D8 + 2 * v.Z.D8 * v.Z.D8;

        return result;
    }

    public static DD10Scalar SquaredNorm(DD10Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD10Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;
        result.D8 = d0 * v.X.D8 + d1 * v.Y.D8 + d2 * v.Z.D8;
        result.D9 = d0 * v.X.D9 + d1 * v.Y.D9 + d2 * v.Z.D9;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * v.X.D0D3 + d1 * v.Y.D0D3 + d2 * v.Z.D0D3 + 2 * v.X.D0 * v.X.D3 + 2 * v.Y.D0 * v.Y.D3 + 2 * v.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * v.X.D0D4 + d1 * v.Y.D0D4 + d2 * v.Z.D0D4 + 2 * v.X.D0 * v.X.D4 + 2 * v.Y.D0 * v.Y.D4 + 2 * v.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * v.X.D0D5 + d1 * v.Y.D0D5 + d2 * v.Z.D0D5 + 2 * v.X.D0 * v.X.D5 + 2 * v.Y.D0 * v.Y.D5 + 2 * v.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * v.X.D0D6 + d1 * v.Y.D0D6 + d2 * v.Z.D0D6 + 2 * v.X.D0 * v.X.D6 + 2 * v.Y.D0 * v.Y.D6 + 2 * v.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * v.X.D0D7 + d1 * v.Y.D0D7 + d2 * v.Z.D0D7 + 2 * v.X.D0 * v.X.D7 + 2 * v.Y.D0 * v.Y.D7 + 2 * v.Z.D0 * v.Z.D7;
        result.D0D8 = d0 * v.X.D0D8 + d1 * v.Y.D0D8 + d2 * v.Z.D0D8 + 2 * v.X.D0 * v.X.D8 + 2 * v.Y.D0 * v.Y.D8 + 2 * v.Z.D0 * v.Z.D8;
        result.D0D9 = d0 * v.X.D0D9 + d1 * v.Y.D0D9 + d2 * v.Z.D0D9 + 2 * v.X.D0 * v.X.D9 + 2 * v.Y.D0 * v.Y.D9 + 2 * v.Z.D0 * v.Z.D9;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * v.X.D1D3 + d1 * v.Y.D1D3 + d2 * v.Z.D1D3 + 2 * v.X.D1 * v.X.D3 + 2 * v.Y.D1 * v.Y.D3 + 2 * v.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * v.X.D1D4 + d1 * v.Y.D1D4 + d2 * v.Z.D1D4 + 2 * v.X.D1 * v.X.D4 + 2 * v.Y.D1 * v.Y.D4 + 2 * v.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * v.X.D1D5 + d1 * v.Y.D1D5 + d2 * v.Z.D1D5 + 2 * v.X.D1 * v.X.D5 + 2 * v.Y.D1 * v.Y.D5 + 2 * v.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * v.X.D1D6 + d1 * v.Y.D1D6 + d2 * v.Z.D1D6 + 2 * v.X.D1 * v.X.D6 + 2 * v.Y.D1 * v.Y.D6 + 2 * v.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * v.X.D1D7 + d1 * v.Y.D1D7 + d2 * v.Z.D1D7 + 2 * v.X.D1 * v.X.D7 + 2 * v.Y.D1 * v.Y.D7 + 2 * v.Z.D1 * v.Z.D7;
        result.D1D8 = d0 * v.X.D1D8 + d1 * v.Y.D1D8 + d2 * v.Z.D1D8 + 2 * v.X.D1 * v.X.D8 + 2 * v.Y.D1 * v.Y.D8 + 2 * v.Z.D1 * v.Z.D8;
        result.D1D9 = d0 * v.X.D1D9 + d1 * v.Y.D1D9 + d2 * v.Z.D1D9 + 2 * v.X.D1 * v.X.D9 + 2 * v.Y.D1 * v.Y.D9 + 2 * v.Z.D1 * v.Z.D9;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * v.X.D2D3 + d1 * v.Y.D2D3 + d2 * v.Z.D2D3 + 2 * v.X.D2 * v.X.D3 + 2 * v.Y.D2 * v.Y.D3 + 2 * v.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * v.X.D2D4 + d1 * v.Y.D2D4 + d2 * v.Z.D2D4 + 2 * v.X.D2 * v.X.D4 + 2 * v.Y.D2 * v.Y.D4 + 2 * v.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * v.X.D2D5 + d1 * v.Y.D2D5 + d2 * v.Z.D2D5 + 2 * v.X.D2 * v.X.D5 + 2 * v.Y.D2 * v.Y.D5 + 2 * v.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * v.X.D2D6 + d1 * v.Y.D2D6 + d2 * v.Z.D2D6 + 2 * v.X.D2 * v.X.D6 + 2 * v.Y.D2 * v.Y.D6 + 2 * v.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * v.X.D2D7 + d1 * v.Y.D2D7 + d2 * v.Z.D2D7 + 2 * v.X.D2 * v.X.D7 + 2 * v.Y.D2 * v.Y.D7 + 2 * v.Z.D2 * v.Z.D7;
        result.D2D8 = d0 * v.X.D2D8 + d1 * v.Y.D2D8 + d2 * v.Z.D2D8 + 2 * v.X.D2 * v.X.D8 + 2 * v.Y.D2 * v.Y.D8 + 2 * v.Z.D2 * v.Z.D8;
        result.D2D9 = d0 * v.X.D2D9 + d1 * v.Y.D2D9 + d2 * v.Z.D2D9 + 2 * v.X.D2 * v.X.D9 + 2 * v.Y.D2 * v.Y.D9 + 2 * v.Z.D2 * v.Z.D9;
        result.D3D3 = d0 * v.X.D3D3 + d1 * v.Y.D3D3 + d2 * v.Z.D3D3 + 2 * v.X.D3 * v.X.D3 + 2 * v.Y.D3 * v.Y.D3 + 2 * v.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * v.X.D3D4 + d1 * v.Y.D3D4 + d2 * v.Z.D3D4 + 2 * v.X.D3 * v.X.D4 + 2 * v.Y.D3 * v.Y.D4 + 2 * v.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * v.X.D3D5 + d1 * v.Y.D3D5 + d2 * v.Z.D3D5 + 2 * v.X.D3 * v.X.D5 + 2 * v.Y.D3 * v.Y.D5 + 2 * v.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * v.X.D3D6 + d1 * v.Y.D3D6 + d2 * v.Z.D3D6 + 2 * v.X.D3 * v.X.D6 + 2 * v.Y.D3 * v.Y.D6 + 2 * v.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * v.X.D3D7 + d1 * v.Y.D3D7 + d2 * v.Z.D3D7 + 2 * v.X.D3 * v.X.D7 + 2 * v.Y.D3 * v.Y.D7 + 2 * v.Z.D3 * v.Z.D7;
        result.D3D8 = d0 * v.X.D3D8 + d1 * v.Y.D3D8 + d2 * v.Z.D3D8 + 2 * v.X.D3 * v.X.D8 + 2 * v.Y.D3 * v.Y.D8 + 2 * v.Z.D3 * v.Z.D8;
        result.D3D9 = d0 * v.X.D3D9 + d1 * v.Y.D3D9 + d2 * v.Z.D3D9 + 2 * v.X.D3 * v.X.D9 + 2 * v.Y.D3 * v.Y.D9 + 2 * v.Z.D3 * v.Z.D9;
        result.D4D4 = d0 * v.X.D4D4 + d1 * v.Y.D4D4 + d2 * v.Z.D4D4 + 2 * v.X.D4 * v.X.D4 + 2 * v.Y.D4 * v.Y.D4 + 2 * v.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * v.X.D4D5 + d1 * v.Y.D4D5 + d2 * v.Z.D4D5 + 2 * v.X.D4 * v.X.D5 + 2 * v.Y.D4 * v.Y.D5 + 2 * v.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * v.X.D4D6 + d1 * v.Y.D4D6 + d2 * v.Z.D4D6 + 2 * v.X.D4 * v.X.D6 + 2 * v.Y.D4 * v.Y.D6 + 2 * v.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * v.X.D4D7 + d1 * v.Y.D4D7 + d2 * v.Z.D4D7 + 2 * v.X.D4 * v.X.D7 + 2 * v.Y.D4 * v.Y.D7 + 2 * v.Z.D4 * v.Z.D7;
        result.D4D8 = d0 * v.X.D4D8 + d1 * v.Y.D4D8 + d2 * v.Z.D4D8 + 2 * v.X.D4 * v.X.D8 + 2 * v.Y.D4 * v.Y.D8 + 2 * v.Z.D4 * v.Z.D8;
        result.D4D9 = d0 * v.X.D4D9 + d1 * v.Y.D4D9 + d2 * v.Z.D4D9 + 2 * v.X.D4 * v.X.D9 + 2 * v.Y.D4 * v.Y.D9 + 2 * v.Z.D4 * v.Z.D9;
        result.D5D5 = d0 * v.X.D5D5 + d1 * v.Y.D5D5 + d2 * v.Z.D5D5 + 2 * v.X.D5 * v.X.D5 + 2 * v.Y.D5 * v.Y.D5 + 2 * v.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * v.X.D5D6 + d1 * v.Y.D5D6 + d2 * v.Z.D5D6 + 2 * v.X.D5 * v.X.D6 + 2 * v.Y.D5 * v.Y.D6 + 2 * v.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * v.X.D5D7 + d1 * v.Y.D5D7 + d2 * v.Z.D5D7 + 2 * v.X.D5 * v.X.D7 + 2 * v.Y.D5 * v.Y.D7 + 2 * v.Z.D5 * v.Z.D7;
        result.D5D8 = d0 * v.X.D5D8 + d1 * v.Y.D5D8 + d2 * v.Z.D5D8 + 2 * v.X.D5 * v.X.D8 + 2 * v.Y.D5 * v.Y.D8 + 2 * v.Z.D5 * v.Z.D8;
        result.D5D9 = d0 * v.X.D5D9 + d1 * v.Y.D5D9 + d2 * v.Z.D5D9 + 2 * v.X.D5 * v.X.D9 + 2 * v.Y.D5 * v.Y.D9 + 2 * v.Z.D5 * v.Z.D9;
        result.D6D6 = d0 * v.X.D6D6 + d1 * v.Y.D6D6 + d2 * v.Z.D6D6 + 2 * v.X.D6 * v.X.D6 + 2 * v.Y.D6 * v.Y.D6 + 2 * v.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * v.X.D6D7 + d1 * v.Y.D6D7 + d2 * v.Z.D6D7 + 2 * v.X.D6 * v.X.D7 + 2 * v.Y.D6 * v.Y.D7 + 2 * v.Z.D6 * v.Z.D7;
        result.D6D8 = d0 * v.X.D6D8 + d1 * v.Y.D6D8 + d2 * v.Z.D6D8 + 2 * v.X.D6 * v.X.D8 + 2 * v.Y.D6 * v.Y.D8 + 2 * v.Z.D6 * v.Z.D8;
        result.D6D9 = d0 * v.X.D6D9 + d1 * v.Y.D6D9 + d2 * v.Z.D6D9 + 2 * v.X.D6 * v.X.D9 + 2 * v.Y.D6 * v.Y.D9 + 2 * v.Z.D6 * v.Z.D9;
        result.D7D7 = d0 * v.X.D7D7 + d1 * v.Y.D7D7 + d2 * v.Z.D7D7 + 2 * v.X.D7 * v.X.D7 + 2 * v.Y.D7 * v.Y.D7 + 2 * v.Z.D7 * v.Z.D7;
        result.D7D8 = d0 * v.X.D7D8 + d1 * v.Y.D7D8 + d2 * v.Z.D7D8 + 2 * v.X.D7 * v.X.D8 + 2 * v.Y.D7 * v.Y.D8 + 2 * v.Z.D7 * v.Z.D8;
        result.D7D9 = d0 * v.X.D7D9 + d1 * v.Y.D7D9 + d2 * v.Z.D7D9 + 2 * v.X.D7 * v.X.D9 + 2 * v.Y.D7 * v.Y.D9 + 2 * v.Z.D7 * v.Z.D9;
        result.D8D8 = d0 * v.X.D8D8 + d1 * v.Y.D8D8 + d2 * v.Z.D8D8 + 2 * v.X.D8 * v.X.D8 + 2 * v.Y.D8 * v.Y.D8 + 2 * v.Z.D8 * v.Z.D8;
        result.D8D9 = d0 * v.X.D8D9 + d1 * v.Y.D8D9 + d2 * v.Z.D8D9 + 2 * v.X.D8 * v.X.D9 + 2 * v.Y.D8 * v.Y.D9 + 2 * v.Z.D8 * v.Z.D9;
        result.D9D9 = d0 * v.X.D9D9 + d1 * v.Y.D9D9 + d2 * v.Z.D9D9 + 2 * v.X.D9 * v.X.D9 + 2 * v.Y.D9 * v.Y.D9 + 2 * v.Z.D9 * v.Z.D9;

        return result;
    }

    public static DD11Scalar SquaredNorm(DD11Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD11Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;
        result.D8 = d0 * v.X.D8 + d1 * v.Y.D8 + d2 * v.Z.D8;
        result.D9 = d0 * v.X.D9 + d1 * v.Y.D9 + d2 * v.Z.D9;
        result.D10 = d0 * v.X.D10 + d1 * v.Y.D10 + d2 * v.Z.D10;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * v.X.D0D3 + d1 * v.Y.D0D3 + d2 * v.Z.D0D3 + 2 * v.X.D0 * v.X.D3 + 2 * v.Y.D0 * v.Y.D3 + 2 * v.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * v.X.D0D4 + d1 * v.Y.D0D4 + d2 * v.Z.D0D4 + 2 * v.X.D0 * v.X.D4 + 2 * v.Y.D0 * v.Y.D4 + 2 * v.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * v.X.D0D5 + d1 * v.Y.D0D5 + d2 * v.Z.D0D5 + 2 * v.X.D0 * v.X.D5 + 2 * v.Y.D0 * v.Y.D5 + 2 * v.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * v.X.D0D6 + d1 * v.Y.D0D6 + d2 * v.Z.D0D6 + 2 * v.X.D0 * v.X.D6 + 2 * v.Y.D0 * v.Y.D6 + 2 * v.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * v.X.D0D7 + d1 * v.Y.D0D7 + d2 * v.Z.D0D7 + 2 * v.X.D0 * v.X.D7 + 2 * v.Y.D0 * v.Y.D7 + 2 * v.Z.D0 * v.Z.D7;
        result.D0D8 = d0 * v.X.D0D8 + d1 * v.Y.D0D8 + d2 * v.Z.D0D8 + 2 * v.X.D0 * v.X.D8 + 2 * v.Y.D0 * v.Y.D8 + 2 * v.Z.D0 * v.Z.D8;
        result.D0D9 = d0 * v.X.D0D9 + d1 * v.Y.D0D9 + d2 * v.Z.D0D9 + 2 * v.X.D0 * v.X.D9 + 2 * v.Y.D0 * v.Y.D9 + 2 * v.Z.D0 * v.Z.D9;
        result.D0D10 = d0 * v.X.D0D10 + d1 * v.Y.D0D10 + d2 * v.Z.D0D10 + 2 * v.X.D0 * v.X.D10 + 2 * v.Y.D0 * v.Y.D10 + 2 * v.Z.D0 * v.Z.D10;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * v.X.D1D3 + d1 * v.Y.D1D3 + d2 * v.Z.D1D3 + 2 * v.X.D1 * v.X.D3 + 2 * v.Y.D1 * v.Y.D3 + 2 * v.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * v.X.D1D4 + d1 * v.Y.D1D4 + d2 * v.Z.D1D4 + 2 * v.X.D1 * v.X.D4 + 2 * v.Y.D1 * v.Y.D4 + 2 * v.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * v.X.D1D5 + d1 * v.Y.D1D5 + d2 * v.Z.D1D5 + 2 * v.X.D1 * v.X.D5 + 2 * v.Y.D1 * v.Y.D5 + 2 * v.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * v.X.D1D6 + d1 * v.Y.D1D6 + d2 * v.Z.D1D6 + 2 * v.X.D1 * v.X.D6 + 2 * v.Y.D1 * v.Y.D6 + 2 * v.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * v.X.D1D7 + d1 * v.Y.D1D7 + d2 * v.Z.D1D7 + 2 * v.X.D1 * v.X.D7 + 2 * v.Y.D1 * v.Y.D7 + 2 * v.Z.D1 * v.Z.D7;
        result.D1D8 = d0 * v.X.D1D8 + d1 * v.Y.D1D8 + d2 * v.Z.D1D8 + 2 * v.X.D1 * v.X.D8 + 2 * v.Y.D1 * v.Y.D8 + 2 * v.Z.D1 * v.Z.D8;
        result.D1D9 = d0 * v.X.D1D9 + d1 * v.Y.D1D9 + d2 * v.Z.D1D9 + 2 * v.X.D1 * v.X.D9 + 2 * v.Y.D1 * v.Y.D9 + 2 * v.Z.D1 * v.Z.D9;
        result.D1D10 = d0 * v.X.D1D10 + d1 * v.Y.D1D10 + d2 * v.Z.D1D10 + 2 * v.X.D1 * v.X.D10 + 2 * v.Y.D1 * v.Y.D10 + 2 * v.Z.D1 * v.Z.D10;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * v.X.D2D3 + d1 * v.Y.D2D3 + d2 * v.Z.D2D3 + 2 * v.X.D2 * v.X.D3 + 2 * v.Y.D2 * v.Y.D3 + 2 * v.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * v.X.D2D4 + d1 * v.Y.D2D4 + d2 * v.Z.D2D4 + 2 * v.X.D2 * v.X.D4 + 2 * v.Y.D2 * v.Y.D4 + 2 * v.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * v.X.D2D5 + d1 * v.Y.D2D5 + d2 * v.Z.D2D5 + 2 * v.X.D2 * v.X.D5 + 2 * v.Y.D2 * v.Y.D5 + 2 * v.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * v.X.D2D6 + d1 * v.Y.D2D6 + d2 * v.Z.D2D6 + 2 * v.X.D2 * v.X.D6 + 2 * v.Y.D2 * v.Y.D6 + 2 * v.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * v.X.D2D7 + d1 * v.Y.D2D7 + d2 * v.Z.D2D7 + 2 * v.X.D2 * v.X.D7 + 2 * v.Y.D2 * v.Y.D7 + 2 * v.Z.D2 * v.Z.D7;
        result.D2D8 = d0 * v.X.D2D8 + d1 * v.Y.D2D8 + d2 * v.Z.D2D8 + 2 * v.X.D2 * v.X.D8 + 2 * v.Y.D2 * v.Y.D8 + 2 * v.Z.D2 * v.Z.D8;
        result.D2D9 = d0 * v.X.D2D9 + d1 * v.Y.D2D9 + d2 * v.Z.D2D9 + 2 * v.X.D2 * v.X.D9 + 2 * v.Y.D2 * v.Y.D9 + 2 * v.Z.D2 * v.Z.D9;
        result.D2D10 = d0 * v.X.D2D10 + d1 * v.Y.D2D10 + d2 * v.Z.D2D10 + 2 * v.X.D2 * v.X.D10 + 2 * v.Y.D2 * v.Y.D10 + 2 * v.Z.D2 * v.Z.D10;
        result.D3D3 = d0 * v.X.D3D3 + d1 * v.Y.D3D3 + d2 * v.Z.D3D3 + 2 * v.X.D3 * v.X.D3 + 2 * v.Y.D3 * v.Y.D3 + 2 * v.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * v.X.D3D4 + d1 * v.Y.D3D4 + d2 * v.Z.D3D4 + 2 * v.X.D3 * v.X.D4 + 2 * v.Y.D3 * v.Y.D4 + 2 * v.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * v.X.D3D5 + d1 * v.Y.D3D5 + d2 * v.Z.D3D5 + 2 * v.X.D3 * v.X.D5 + 2 * v.Y.D3 * v.Y.D5 + 2 * v.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * v.X.D3D6 + d1 * v.Y.D3D6 + d2 * v.Z.D3D6 + 2 * v.X.D3 * v.X.D6 + 2 * v.Y.D3 * v.Y.D6 + 2 * v.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * v.X.D3D7 + d1 * v.Y.D3D7 + d2 * v.Z.D3D7 + 2 * v.X.D3 * v.X.D7 + 2 * v.Y.D3 * v.Y.D7 + 2 * v.Z.D3 * v.Z.D7;
        result.D3D8 = d0 * v.X.D3D8 + d1 * v.Y.D3D8 + d2 * v.Z.D3D8 + 2 * v.X.D3 * v.X.D8 + 2 * v.Y.D3 * v.Y.D8 + 2 * v.Z.D3 * v.Z.D8;
        result.D3D9 = d0 * v.X.D3D9 + d1 * v.Y.D3D9 + d2 * v.Z.D3D9 + 2 * v.X.D3 * v.X.D9 + 2 * v.Y.D3 * v.Y.D9 + 2 * v.Z.D3 * v.Z.D9;
        result.D3D10 = d0 * v.X.D3D10 + d1 * v.Y.D3D10 + d2 * v.Z.D3D10 + 2 * v.X.D3 * v.X.D10 + 2 * v.Y.D3 * v.Y.D10 + 2 * v.Z.D3 * v.Z.D10;
        result.D4D4 = d0 * v.X.D4D4 + d1 * v.Y.D4D4 + d2 * v.Z.D4D4 + 2 * v.X.D4 * v.X.D4 + 2 * v.Y.D4 * v.Y.D4 + 2 * v.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * v.X.D4D5 + d1 * v.Y.D4D5 + d2 * v.Z.D4D5 + 2 * v.X.D4 * v.X.D5 + 2 * v.Y.D4 * v.Y.D5 + 2 * v.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * v.X.D4D6 + d1 * v.Y.D4D6 + d2 * v.Z.D4D6 + 2 * v.X.D4 * v.X.D6 + 2 * v.Y.D4 * v.Y.D6 + 2 * v.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * v.X.D4D7 + d1 * v.Y.D4D7 + d2 * v.Z.D4D7 + 2 * v.X.D4 * v.X.D7 + 2 * v.Y.D4 * v.Y.D7 + 2 * v.Z.D4 * v.Z.D7;
        result.D4D8 = d0 * v.X.D4D8 + d1 * v.Y.D4D8 + d2 * v.Z.D4D8 + 2 * v.X.D4 * v.X.D8 + 2 * v.Y.D4 * v.Y.D8 + 2 * v.Z.D4 * v.Z.D8;
        result.D4D9 = d0 * v.X.D4D9 + d1 * v.Y.D4D9 + d2 * v.Z.D4D9 + 2 * v.X.D4 * v.X.D9 + 2 * v.Y.D4 * v.Y.D9 + 2 * v.Z.D4 * v.Z.D9;
        result.D4D10 = d0 * v.X.D4D10 + d1 * v.Y.D4D10 + d2 * v.Z.D4D10 + 2 * v.X.D4 * v.X.D10 + 2 * v.Y.D4 * v.Y.D10 + 2 * v.Z.D4 * v.Z.D10;
        result.D5D5 = d0 * v.X.D5D5 + d1 * v.Y.D5D5 + d2 * v.Z.D5D5 + 2 * v.X.D5 * v.X.D5 + 2 * v.Y.D5 * v.Y.D5 + 2 * v.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * v.X.D5D6 + d1 * v.Y.D5D6 + d2 * v.Z.D5D6 + 2 * v.X.D5 * v.X.D6 + 2 * v.Y.D5 * v.Y.D6 + 2 * v.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * v.X.D5D7 + d1 * v.Y.D5D7 + d2 * v.Z.D5D7 + 2 * v.X.D5 * v.X.D7 + 2 * v.Y.D5 * v.Y.D7 + 2 * v.Z.D5 * v.Z.D7;
        result.D5D8 = d0 * v.X.D5D8 + d1 * v.Y.D5D8 + d2 * v.Z.D5D8 + 2 * v.X.D5 * v.X.D8 + 2 * v.Y.D5 * v.Y.D8 + 2 * v.Z.D5 * v.Z.D8;
        result.D5D9 = d0 * v.X.D5D9 + d1 * v.Y.D5D9 + d2 * v.Z.D5D9 + 2 * v.X.D5 * v.X.D9 + 2 * v.Y.D5 * v.Y.D9 + 2 * v.Z.D5 * v.Z.D9;
        result.D5D10 = d0 * v.X.D5D10 + d1 * v.Y.D5D10 + d2 * v.Z.D5D10 + 2 * v.X.D5 * v.X.D10 + 2 * v.Y.D5 * v.Y.D10 + 2 * v.Z.D5 * v.Z.D10;
        result.D6D6 = d0 * v.X.D6D6 + d1 * v.Y.D6D6 + d2 * v.Z.D6D6 + 2 * v.X.D6 * v.X.D6 + 2 * v.Y.D6 * v.Y.D6 + 2 * v.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * v.X.D6D7 + d1 * v.Y.D6D7 + d2 * v.Z.D6D7 + 2 * v.X.D6 * v.X.D7 + 2 * v.Y.D6 * v.Y.D7 + 2 * v.Z.D6 * v.Z.D7;
        result.D6D8 = d0 * v.X.D6D8 + d1 * v.Y.D6D8 + d2 * v.Z.D6D8 + 2 * v.X.D6 * v.X.D8 + 2 * v.Y.D6 * v.Y.D8 + 2 * v.Z.D6 * v.Z.D8;
        result.D6D9 = d0 * v.X.D6D9 + d1 * v.Y.D6D9 + d2 * v.Z.D6D9 + 2 * v.X.D6 * v.X.D9 + 2 * v.Y.D6 * v.Y.D9 + 2 * v.Z.D6 * v.Z.D9;
        result.D6D10 = d0 * v.X.D6D10 + d1 * v.Y.D6D10 + d2 * v.Z.D6D10 + 2 * v.X.D6 * v.X.D10 + 2 * v.Y.D6 * v.Y.D10 + 2 * v.Z.D6 * v.Z.D10;
        result.D7D7 = d0 * v.X.D7D7 + d1 * v.Y.D7D7 + d2 * v.Z.D7D7 + 2 * v.X.D7 * v.X.D7 + 2 * v.Y.D7 * v.Y.D7 + 2 * v.Z.D7 * v.Z.D7;
        result.D7D8 = d0 * v.X.D7D8 + d1 * v.Y.D7D8 + d2 * v.Z.D7D8 + 2 * v.X.D7 * v.X.D8 + 2 * v.Y.D7 * v.Y.D8 + 2 * v.Z.D7 * v.Z.D8;
        result.D7D9 = d0 * v.X.D7D9 + d1 * v.Y.D7D9 + d2 * v.Z.D7D9 + 2 * v.X.D7 * v.X.D9 + 2 * v.Y.D7 * v.Y.D9 + 2 * v.Z.D7 * v.Z.D9;
        result.D7D10 = d0 * v.X.D7D10 + d1 * v.Y.D7D10 + d2 * v.Z.D7D10 + 2 * v.X.D7 * v.X.D10 + 2 * v.Y.D7 * v.Y.D10 + 2 * v.Z.D7 * v.Z.D10;
        result.D8D8 = d0 * v.X.D8D8 + d1 * v.Y.D8D8 + d2 * v.Z.D8D8 + 2 * v.X.D8 * v.X.D8 + 2 * v.Y.D8 * v.Y.D8 + 2 * v.Z.D8 * v.Z.D8;
        result.D8D9 = d0 * v.X.D8D9 + d1 * v.Y.D8D9 + d2 * v.Z.D8D9 + 2 * v.X.D8 * v.X.D9 + 2 * v.Y.D8 * v.Y.D9 + 2 * v.Z.D8 * v.Z.D9;
        result.D8D10 = d0 * v.X.D8D10 + d1 * v.Y.D8D10 + d2 * v.Z.D8D10 + 2 * v.X.D8 * v.X.D10 + 2 * v.Y.D8 * v.Y.D10 + 2 * v.Z.D8 * v.Z.D10;
        result.D9D9 = d0 * v.X.D9D9 + d1 * v.Y.D9D9 + d2 * v.Z.D9D9 + 2 * v.X.D9 * v.X.D9 + 2 * v.Y.D9 * v.Y.D9 + 2 * v.Z.D9 * v.Z.D9;
        result.D9D10 = d0 * v.X.D9D10 + d1 * v.Y.D9D10 + d2 * v.Z.D9D10 + 2 * v.X.D9 * v.X.D10 + 2 * v.Y.D9 * v.Y.D10 + 2 * v.Z.D9 * v.Z.D10;
        result.D10D10 = d0 * v.X.D10D10 + d1 * v.Y.D10D10 + d2 * v.Z.D10D10 + 2 * v.X.D10 * v.X.D10 + 2 * v.Y.D10 * v.Y.D10 + 2 * v.Z.D10 * v.Z.D10;

        return result;
    }

    public static DD12Scalar SquaredNorm(DD12Vector3 v)
    {
        var constant = v.X.Constant * v.X.Constant + v.Y.Constant * v.Y.Constant + v.Z.Constant * v.Z.Constant;

        var result = new DD12Scalar(constant);

        var d0 = 2 * v.X.Constant;
        var d1 = 2 * v.Y.Constant;
        var d2 = 2 * v.Z.Constant;

        result.D0 = d0 * v.X.D0 + d1 * v.Y.D0 + d2 * v.Z.D0;
        result.D1 = d0 * v.X.D1 + d1 * v.Y.D1 + d2 * v.Z.D1;
        result.D2 = d0 * v.X.D2 + d1 * v.Y.D2 + d2 * v.Z.D2;
        result.D3 = d0 * v.X.D3 + d1 * v.Y.D3 + d2 * v.Z.D3;
        result.D4 = d0 * v.X.D4 + d1 * v.Y.D4 + d2 * v.Z.D4;
        result.D5 = d0 * v.X.D5 + d1 * v.Y.D5 + d2 * v.Z.D5;
        result.D6 = d0 * v.X.D6 + d1 * v.Y.D6 + d2 * v.Z.D6;
        result.D7 = d0 * v.X.D7 + d1 * v.Y.D7 + d2 * v.Z.D7;
        result.D8 = d0 * v.X.D8 + d1 * v.Y.D8 + d2 * v.Z.D8;
        result.D9 = d0 * v.X.D9 + d1 * v.Y.D9 + d2 * v.Z.D9;
        result.D10 = d0 * v.X.D10 + d1 * v.Y.D10 + d2 * v.Z.D10;
        result.D11 = d0 * v.X.D11 + d1 * v.Y.D11 + d2 * v.Z.D11;

        result.D0D0 = d0 * v.X.D0D0 + d1 * v.Y.D0D0 + d2 * v.Z.D0D0 + 2 * v.X.D0 * v.X.D0 + 2 * v.Y.D0 * v.Y.D0 + 2 * v.Z.D0 * v.Z.D0;
        result.D0D1 = d0 * v.X.D0D1 + d1 * v.Y.D0D1 + d2 * v.Z.D0D1 + 2 * v.X.D0 * v.X.D1 + 2 * v.Y.D0 * v.Y.D1 + 2 * v.Z.D0 * v.Z.D1;
        result.D0D2 = d0 * v.X.D0D2 + d1 * v.Y.D0D2 + d2 * v.Z.D0D2 + 2 * v.X.D0 * v.X.D2 + 2 * v.Y.D0 * v.Y.D2 + 2 * v.Z.D0 * v.Z.D2;
        result.D0D3 = d0 * v.X.D0D3 + d1 * v.Y.D0D3 + d2 * v.Z.D0D3 + 2 * v.X.D0 * v.X.D3 + 2 * v.Y.D0 * v.Y.D3 + 2 * v.Z.D0 * v.Z.D3;
        result.D0D4 = d0 * v.X.D0D4 + d1 * v.Y.D0D4 + d2 * v.Z.D0D4 + 2 * v.X.D0 * v.X.D4 + 2 * v.Y.D0 * v.Y.D4 + 2 * v.Z.D0 * v.Z.D4;
        result.D0D5 = d0 * v.X.D0D5 + d1 * v.Y.D0D5 + d2 * v.Z.D0D5 + 2 * v.X.D0 * v.X.D5 + 2 * v.Y.D0 * v.Y.D5 + 2 * v.Z.D0 * v.Z.D5;
        result.D0D6 = d0 * v.X.D0D6 + d1 * v.Y.D0D6 + d2 * v.Z.D0D6 + 2 * v.X.D0 * v.X.D6 + 2 * v.Y.D0 * v.Y.D6 + 2 * v.Z.D0 * v.Z.D6;
        result.D0D7 = d0 * v.X.D0D7 + d1 * v.Y.D0D7 + d2 * v.Z.D0D7 + 2 * v.X.D0 * v.X.D7 + 2 * v.Y.D0 * v.Y.D7 + 2 * v.Z.D0 * v.Z.D7;
        result.D0D8 = d0 * v.X.D0D8 + d1 * v.Y.D0D8 + d2 * v.Z.D0D8 + 2 * v.X.D0 * v.X.D8 + 2 * v.Y.D0 * v.Y.D8 + 2 * v.Z.D0 * v.Z.D8;
        result.D0D9 = d0 * v.X.D0D9 + d1 * v.Y.D0D9 + d2 * v.Z.D0D9 + 2 * v.X.D0 * v.X.D9 + 2 * v.Y.D0 * v.Y.D9 + 2 * v.Z.D0 * v.Z.D9;
        result.D0D10 = d0 * v.X.D0D10 + d1 * v.Y.D0D10 + d2 * v.Z.D0D10 + 2 * v.X.D0 * v.X.D10 + 2 * v.Y.D0 * v.Y.D10 + 2 * v.Z.D0 * v.Z.D10;
        result.D0D11 = d0 * v.X.D0D11 + d1 * v.Y.D0D11 + d2 * v.Z.D0D11 + 2 * v.X.D0 * v.X.D11 + 2 * v.Y.D0 * v.Y.D11 + 2 * v.Z.D0 * v.Z.D11;
        result.D1D1 = d0 * v.X.D1D1 + d1 * v.Y.D1D1 + d2 * v.Z.D1D1 + 2 * v.X.D1 * v.X.D1 + 2 * v.Y.D1 * v.Y.D1 + 2 * v.Z.D1 * v.Z.D1;
        result.D1D2 = d0 * v.X.D1D2 + d1 * v.Y.D1D2 + d2 * v.Z.D1D2 + 2 * v.X.D1 * v.X.D2 + 2 * v.Y.D1 * v.Y.D2 + 2 * v.Z.D1 * v.Z.D2;
        result.D1D3 = d0 * v.X.D1D3 + d1 * v.Y.D1D3 + d2 * v.Z.D1D3 + 2 * v.X.D1 * v.X.D3 + 2 * v.Y.D1 * v.Y.D3 + 2 * v.Z.D1 * v.Z.D3;
        result.D1D4 = d0 * v.X.D1D4 + d1 * v.Y.D1D4 + d2 * v.Z.D1D4 + 2 * v.X.D1 * v.X.D4 + 2 * v.Y.D1 * v.Y.D4 + 2 * v.Z.D1 * v.Z.D4;
        result.D1D5 = d0 * v.X.D1D5 + d1 * v.Y.D1D5 + d2 * v.Z.D1D5 + 2 * v.X.D1 * v.X.D5 + 2 * v.Y.D1 * v.Y.D5 + 2 * v.Z.D1 * v.Z.D5;
        result.D1D6 = d0 * v.X.D1D6 + d1 * v.Y.D1D6 + d2 * v.Z.D1D6 + 2 * v.X.D1 * v.X.D6 + 2 * v.Y.D1 * v.Y.D6 + 2 * v.Z.D1 * v.Z.D6;
        result.D1D7 = d0 * v.X.D1D7 + d1 * v.Y.D1D7 + d2 * v.Z.D1D7 + 2 * v.X.D1 * v.X.D7 + 2 * v.Y.D1 * v.Y.D7 + 2 * v.Z.D1 * v.Z.D7;
        result.D1D8 = d0 * v.X.D1D8 + d1 * v.Y.D1D8 + d2 * v.Z.D1D8 + 2 * v.X.D1 * v.X.D8 + 2 * v.Y.D1 * v.Y.D8 + 2 * v.Z.D1 * v.Z.D8;
        result.D1D9 = d0 * v.X.D1D9 + d1 * v.Y.D1D9 + d2 * v.Z.D1D9 + 2 * v.X.D1 * v.X.D9 + 2 * v.Y.D1 * v.Y.D9 + 2 * v.Z.D1 * v.Z.D9;
        result.D1D10 = d0 * v.X.D1D10 + d1 * v.Y.D1D10 + d2 * v.Z.D1D10 + 2 * v.X.D1 * v.X.D10 + 2 * v.Y.D1 * v.Y.D10 + 2 * v.Z.D1 * v.Z.D10;
        result.D1D11 = d0 * v.X.D1D11 + d1 * v.Y.D1D11 + d2 * v.Z.D1D11 + 2 * v.X.D1 * v.X.D11 + 2 * v.Y.D1 * v.Y.D11 + 2 * v.Z.D1 * v.Z.D11;
        result.D2D2 = d0 * v.X.D2D2 + d1 * v.Y.D2D2 + d2 * v.Z.D2D2 + 2 * v.X.D2 * v.X.D2 + 2 * v.Y.D2 * v.Y.D2 + 2 * v.Z.D2 * v.Z.D2;
        result.D2D3 = d0 * v.X.D2D3 + d1 * v.Y.D2D3 + d2 * v.Z.D2D3 + 2 * v.X.D2 * v.X.D3 + 2 * v.Y.D2 * v.Y.D3 + 2 * v.Z.D2 * v.Z.D3;
        result.D2D4 = d0 * v.X.D2D4 + d1 * v.Y.D2D4 + d2 * v.Z.D2D4 + 2 * v.X.D2 * v.X.D4 + 2 * v.Y.D2 * v.Y.D4 + 2 * v.Z.D2 * v.Z.D4;
        result.D2D5 = d0 * v.X.D2D5 + d1 * v.Y.D2D5 + d2 * v.Z.D2D5 + 2 * v.X.D2 * v.X.D5 + 2 * v.Y.D2 * v.Y.D5 + 2 * v.Z.D2 * v.Z.D5;
        result.D2D6 = d0 * v.X.D2D6 + d1 * v.Y.D2D6 + d2 * v.Z.D2D6 + 2 * v.X.D2 * v.X.D6 + 2 * v.Y.D2 * v.Y.D6 + 2 * v.Z.D2 * v.Z.D6;
        result.D2D7 = d0 * v.X.D2D7 + d1 * v.Y.D2D7 + d2 * v.Z.D2D7 + 2 * v.X.D2 * v.X.D7 + 2 * v.Y.D2 * v.Y.D7 + 2 * v.Z.D2 * v.Z.D7;
        result.D2D8 = d0 * v.X.D2D8 + d1 * v.Y.D2D8 + d2 * v.Z.D2D8 + 2 * v.X.D2 * v.X.D8 + 2 * v.Y.D2 * v.Y.D8 + 2 * v.Z.D2 * v.Z.D8;
        result.D2D9 = d0 * v.X.D2D9 + d1 * v.Y.D2D9 + d2 * v.Z.D2D9 + 2 * v.X.D2 * v.X.D9 + 2 * v.Y.D2 * v.Y.D9 + 2 * v.Z.D2 * v.Z.D9;
        result.D2D10 = d0 * v.X.D2D10 + d1 * v.Y.D2D10 + d2 * v.Z.D2D10 + 2 * v.X.D2 * v.X.D10 + 2 * v.Y.D2 * v.Y.D10 + 2 * v.Z.D2 * v.Z.D10;
        result.D2D11 = d0 * v.X.D2D11 + d1 * v.Y.D2D11 + d2 * v.Z.D2D11 + 2 * v.X.D2 * v.X.D11 + 2 * v.Y.D2 * v.Y.D11 + 2 * v.Z.D2 * v.Z.D11;
        result.D3D3 = d0 * v.X.D3D3 + d1 * v.Y.D3D3 + d2 * v.Z.D3D3 + 2 * v.X.D3 * v.X.D3 + 2 * v.Y.D3 * v.Y.D3 + 2 * v.Z.D3 * v.Z.D3;
        result.D3D4 = d0 * v.X.D3D4 + d1 * v.Y.D3D4 + d2 * v.Z.D3D4 + 2 * v.X.D3 * v.X.D4 + 2 * v.Y.D3 * v.Y.D4 + 2 * v.Z.D3 * v.Z.D4;
        result.D3D5 = d0 * v.X.D3D5 + d1 * v.Y.D3D5 + d2 * v.Z.D3D5 + 2 * v.X.D3 * v.X.D5 + 2 * v.Y.D3 * v.Y.D5 + 2 * v.Z.D3 * v.Z.D5;
        result.D3D6 = d0 * v.X.D3D6 + d1 * v.Y.D3D6 + d2 * v.Z.D3D6 + 2 * v.X.D3 * v.X.D6 + 2 * v.Y.D3 * v.Y.D6 + 2 * v.Z.D3 * v.Z.D6;
        result.D3D7 = d0 * v.X.D3D7 + d1 * v.Y.D3D7 + d2 * v.Z.D3D7 + 2 * v.X.D3 * v.X.D7 + 2 * v.Y.D3 * v.Y.D7 + 2 * v.Z.D3 * v.Z.D7;
        result.D3D8 = d0 * v.X.D3D8 + d1 * v.Y.D3D8 + d2 * v.Z.D3D8 + 2 * v.X.D3 * v.X.D8 + 2 * v.Y.D3 * v.Y.D8 + 2 * v.Z.D3 * v.Z.D8;
        result.D3D9 = d0 * v.X.D3D9 + d1 * v.Y.D3D9 + d2 * v.Z.D3D9 + 2 * v.X.D3 * v.X.D9 + 2 * v.Y.D3 * v.Y.D9 + 2 * v.Z.D3 * v.Z.D9;
        result.D3D10 = d0 * v.X.D3D10 + d1 * v.Y.D3D10 + d2 * v.Z.D3D10 + 2 * v.X.D3 * v.X.D10 + 2 * v.Y.D3 * v.Y.D10 + 2 * v.Z.D3 * v.Z.D10;
        result.D3D11 = d0 * v.X.D3D11 + d1 * v.Y.D3D11 + d2 * v.Z.D3D11 + 2 * v.X.D3 * v.X.D11 + 2 * v.Y.D3 * v.Y.D11 + 2 * v.Z.D3 * v.Z.D11;
        result.D4D4 = d0 * v.X.D4D4 + d1 * v.Y.D4D4 + d2 * v.Z.D4D4 + 2 * v.X.D4 * v.X.D4 + 2 * v.Y.D4 * v.Y.D4 + 2 * v.Z.D4 * v.Z.D4;
        result.D4D5 = d0 * v.X.D4D5 + d1 * v.Y.D4D5 + d2 * v.Z.D4D5 + 2 * v.X.D4 * v.X.D5 + 2 * v.Y.D4 * v.Y.D5 + 2 * v.Z.D4 * v.Z.D5;
        result.D4D6 = d0 * v.X.D4D6 + d1 * v.Y.D4D6 + d2 * v.Z.D4D6 + 2 * v.X.D4 * v.X.D6 + 2 * v.Y.D4 * v.Y.D6 + 2 * v.Z.D4 * v.Z.D6;
        result.D4D7 = d0 * v.X.D4D7 + d1 * v.Y.D4D7 + d2 * v.Z.D4D7 + 2 * v.X.D4 * v.X.D7 + 2 * v.Y.D4 * v.Y.D7 + 2 * v.Z.D4 * v.Z.D7;
        result.D4D8 = d0 * v.X.D4D8 + d1 * v.Y.D4D8 + d2 * v.Z.D4D8 + 2 * v.X.D4 * v.X.D8 + 2 * v.Y.D4 * v.Y.D8 + 2 * v.Z.D4 * v.Z.D8;
        result.D4D9 = d0 * v.X.D4D9 + d1 * v.Y.D4D9 + d2 * v.Z.D4D9 + 2 * v.X.D4 * v.X.D9 + 2 * v.Y.D4 * v.Y.D9 + 2 * v.Z.D4 * v.Z.D9;
        result.D4D10 = d0 * v.X.D4D10 + d1 * v.Y.D4D10 + d2 * v.Z.D4D10 + 2 * v.X.D4 * v.X.D10 + 2 * v.Y.D4 * v.Y.D10 + 2 * v.Z.D4 * v.Z.D10;
        result.D4D11 = d0 * v.X.D4D11 + d1 * v.Y.D4D11 + d2 * v.Z.D4D11 + 2 * v.X.D4 * v.X.D11 + 2 * v.Y.D4 * v.Y.D11 + 2 * v.Z.D4 * v.Z.D11;
        result.D5D5 = d0 * v.X.D5D5 + d1 * v.Y.D5D5 + d2 * v.Z.D5D5 + 2 * v.X.D5 * v.X.D5 + 2 * v.Y.D5 * v.Y.D5 + 2 * v.Z.D5 * v.Z.D5;
        result.D5D6 = d0 * v.X.D5D6 + d1 * v.Y.D5D6 + d2 * v.Z.D5D6 + 2 * v.X.D5 * v.X.D6 + 2 * v.Y.D5 * v.Y.D6 + 2 * v.Z.D5 * v.Z.D6;
        result.D5D7 = d0 * v.X.D5D7 + d1 * v.Y.D5D7 + d2 * v.Z.D5D7 + 2 * v.X.D5 * v.X.D7 + 2 * v.Y.D5 * v.Y.D7 + 2 * v.Z.D5 * v.Z.D7;
        result.D5D8 = d0 * v.X.D5D8 + d1 * v.Y.D5D8 + d2 * v.Z.D5D8 + 2 * v.X.D5 * v.X.D8 + 2 * v.Y.D5 * v.Y.D8 + 2 * v.Z.D5 * v.Z.D8;
        result.D5D9 = d0 * v.X.D5D9 + d1 * v.Y.D5D9 + d2 * v.Z.D5D9 + 2 * v.X.D5 * v.X.D9 + 2 * v.Y.D5 * v.Y.D9 + 2 * v.Z.D5 * v.Z.D9;
        result.D5D10 = d0 * v.X.D5D10 + d1 * v.Y.D5D10 + d2 * v.Z.D5D10 + 2 * v.X.D5 * v.X.D10 + 2 * v.Y.D5 * v.Y.D10 + 2 * v.Z.D5 * v.Z.D10;
        result.D5D11 = d0 * v.X.D5D11 + d1 * v.Y.D5D11 + d2 * v.Z.D5D11 + 2 * v.X.D5 * v.X.D11 + 2 * v.Y.D5 * v.Y.D11 + 2 * v.Z.D5 * v.Z.D11;
        result.D6D6 = d0 * v.X.D6D6 + d1 * v.Y.D6D6 + d2 * v.Z.D6D6 + 2 * v.X.D6 * v.X.D6 + 2 * v.Y.D6 * v.Y.D6 + 2 * v.Z.D6 * v.Z.D6;
        result.D6D7 = d0 * v.X.D6D7 + d1 * v.Y.D6D7 + d2 * v.Z.D6D7 + 2 * v.X.D6 * v.X.D7 + 2 * v.Y.D6 * v.Y.D7 + 2 * v.Z.D6 * v.Z.D7;
        result.D6D8 = d0 * v.X.D6D8 + d1 * v.Y.D6D8 + d2 * v.Z.D6D8 + 2 * v.X.D6 * v.X.D8 + 2 * v.Y.D6 * v.Y.D8 + 2 * v.Z.D6 * v.Z.D8;
        result.D6D9 = d0 * v.X.D6D9 + d1 * v.Y.D6D9 + d2 * v.Z.D6D9 + 2 * v.X.D6 * v.X.D9 + 2 * v.Y.D6 * v.Y.D9 + 2 * v.Z.D6 * v.Z.D9;
        result.D6D10 = d0 * v.X.D6D10 + d1 * v.Y.D6D10 + d2 * v.Z.D6D10 + 2 * v.X.D6 * v.X.D10 + 2 * v.Y.D6 * v.Y.D10 + 2 * v.Z.D6 * v.Z.D10;
        result.D6D11 = d0 * v.X.D6D11 + d1 * v.Y.D6D11 + d2 * v.Z.D6D11 + 2 * v.X.D6 * v.X.D11 + 2 * v.Y.D6 * v.Y.D11 + 2 * v.Z.D6 * v.Z.D11;
        result.D7D7 = d0 * v.X.D7D7 + d1 * v.Y.D7D7 + d2 * v.Z.D7D7 + 2 * v.X.D7 * v.X.D7 + 2 * v.Y.D7 * v.Y.D7 + 2 * v.Z.D7 * v.Z.D7;
        result.D7D8 = d0 * v.X.D7D8 + d1 * v.Y.D7D8 + d2 * v.Z.D7D8 + 2 * v.X.D7 * v.X.D8 + 2 * v.Y.D7 * v.Y.D8 + 2 * v.Z.D7 * v.Z.D8;
        result.D7D9 = d0 * v.X.D7D9 + d1 * v.Y.D7D9 + d2 * v.Z.D7D9 + 2 * v.X.D7 * v.X.D9 + 2 * v.Y.D7 * v.Y.D9 + 2 * v.Z.D7 * v.Z.D9;
        result.D7D10 = d0 * v.X.D7D10 + d1 * v.Y.D7D10 + d2 * v.Z.D7D10 + 2 * v.X.D7 * v.X.D10 + 2 * v.Y.D7 * v.Y.D10 + 2 * v.Z.D7 * v.Z.D10;
        result.D7D11 = d0 * v.X.D7D11 + d1 * v.Y.D7D11 + d2 * v.Z.D7D11 + 2 * v.X.D7 * v.X.D11 + 2 * v.Y.D7 * v.Y.D11 + 2 * v.Z.D7 * v.Z.D11;
        result.D8D8 = d0 * v.X.D8D8 + d1 * v.Y.D8D8 + d2 * v.Z.D8D8 + 2 * v.X.D8 * v.X.D8 + 2 * v.Y.D8 * v.Y.D8 + 2 * v.Z.D8 * v.Z.D8;
        result.D8D9 = d0 * v.X.D8D9 + d1 * v.Y.D8D9 + d2 * v.Z.D8D9 + 2 * v.X.D8 * v.X.D9 + 2 * v.Y.D8 * v.Y.D9 + 2 * v.Z.D8 * v.Z.D9;
        result.D8D10 = d0 * v.X.D8D10 + d1 * v.Y.D8D10 + d2 * v.Z.D8D10 + 2 * v.X.D8 * v.X.D10 + 2 * v.Y.D8 * v.Y.D10 + 2 * v.Z.D8 * v.Z.D10;
        result.D8D11 = d0 * v.X.D8D11 + d1 * v.Y.D8D11 + d2 * v.Z.D8D11 + 2 * v.X.D8 * v.X.D11 + 2 * v.Y.D8 * v.Y.D11 + 2 * v.Z.D8 * v.Z.D11;
        result.D9D9 = d0 * v.X.D9D9 + d1 * v.Y.D9D9 + d2 * v.Z.D9D9 + 2 * v.X.D9 * v.X.D9 + 2 * v.Y.D9 * v.Y.D9 + 2 * v.Z.D9 * v.Z.D9;
        result.D9D10 = d0 * v.X.D9D10 + d1 * v.Y.D9D10 + d2 * v.Z.D9D10 + 2 * v.X.D9 * v.X.D10 + 2 * v.Y.D9 * v.Y.D10 + 2 * v.Z.D9 * v.Z.D10;
        result.D9D11 = d0 * v.X.D9D11 + d1 * v.Y.D9D11 + d2 * v.Z.D9D11 + 2 * v.X.D9 * v.X.D11 + 2 * v.Y.D9 * v.Y.D11 + 2 * v.Z.D9 * v.Z.D11;
        result.D10D10 = d0 * v.X.D10D10 + d1 * v.Y.D10D10 + d2 * v.Z.D10D10 + 2 * v.X.D10 * v.X.D10 + 2 * v.Y.D10 * v.Y.D10 + 2 * v.Z.D10 * v.Z.D10;
        result.D10D11 = d0 * v.X.D10D11 + d1 * v.Y.D10D11 + d2 * v.Z.D10D11 + 2 * v.X.D10 * v.X.D11 + 2 * v.Y.D10 * v.Y.D11 + 2 * v.Z.D10 * v.Z.D11;
        result.D11D11 = d0 * v.X.D11D11 + d1 * v.Y.D11D11 + d2 * v.Z.D11D11 + 2 * v.X.D11 * v.X.D11 + 2 * v.Y.D11 * v.Y.D11 + 2 * v.Z.D11 * v.Z.D11;

        return result;
    }
}
