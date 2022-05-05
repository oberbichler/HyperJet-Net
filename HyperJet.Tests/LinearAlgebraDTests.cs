namespace HyperJet.Tests;

using Xunit;

using static HyperJet.LinearAlgebraD;
using static HyperJet.Tests.Assertions;

public class LinearAlgebraDTests
{
    private readonly D3Vector3 du;
    private readonly D3Vector3 dv;

    private readonly DD3Vector3 ddu;
    private readonly DD3Vector3 ddv;

    public LinearAlgebraDTests()
    {
        var dux = new D3Scalar(1, 2, 3, -4);
        var duy = new D3Scalar(2, 6, -9, 0);
        var duz = new D3Scalar(3, 6, -9, 0);

        var dvx = new D3Scalar(2, 4, -9, 10);
        var dvy = new D3Scalar(-6, 5, 7, -7);
        var dvz = new D3Scalar(1, 8, 0, -8);

        du = new D3Vector3(dux, duy, duz);
        dv = new D3Vector3(dvx, dvy, dvz);


        var ddux = new DD3Scalar(1, 2, 3, -4, 5, -6, 7, 8, 9, 10);
        var dduy = new DD3Scalar(2, 6, -9, 0, 0, 8, -7, 10, 1, 1);
        var dduz = new DD3Scalar(3, 6, -9, 0, 0, 8, -7, 10, 1, 1);

        var ddvx = new DD3Scalar(2, 4, -9, 10, 2, 2, 0, 2, 10, 1);
        var ddvy = new DD3Scalar(-6, 5, 7, -7, 1, 3, 1, -1, 0, 9);
        var ddvz = new DD3Scalar(1, 8, 0, -8, 1, 3, -2, -3, 5, 7);

        ddu = new DD3Vector3(ddux, dduy, dduz);
        ddv = new DD3Vector3(ddvx, ddvy, ddvz);
    }

    // Dot

    [Fact]
    public void DotOfD3Vector3Test()
    {
        var r = Dot(du, dv);

        AssertAllClose(new double[] { -7, 12, 56, -36 }, r);
    }

    [Fact]
    public void DotOfDD3Vector3Test()
    {
        var r = Dot(ddu, ddv);

        AssertAllClose(new double[] { -7, 12, 56, -36, 189, -116, -41, -223, 239, -25 }, r);
    }

    // SquaredNorm

    [Fact]
    public void SquaredNormOfD3Vector3Test()
    {
        var r = SquaredNorm(du);

        AssertAllClose(new double[] { 14, 64, -84, -8 }, r);
    }

    [Fact]
    public void SquaredNormOfDD3Vector3Test()
    {
        var r = SquaredNorm(ddu);

        AssertAllClose(new double[] { 14, 64, -84, -8, 162, -136, -72, 458, 4, 62 }, r);
    }

    // Norm

    [Fact]
    public void NormOfD3Vector3Test()
    {
        var r = Norm(du);

        AssertAllClose(new double[] { 3.7416573867739413, 8.55235974119758, -11.224972160321824, -1.0690449676496976 }, r);
    }

    [Fact]
    public void NormOfDD3Vector3Test()
    {
        var r = Norm(ddu);

        AssertAllClose(new double[] { 3.7416573867739413, 8.55235974119758, -11.224972160321824, -1.0690449676496976, 2.099909757883335, 7.483314773547882, -7.177873354219398, 27.527907916979714, -2.6726124191242437, 7.979657079956672 }, r);
    }

    // Cross

    [Fact]
    public void CrossOfD3Vector3Test()
    {
        var r = Cross(du, dv);

        AssertAllClose(new double[] { 20, 43, -84, 5 }, r.X);
        AssertAllClose(new double[] { 5, 14, -48, 42 }, r.Y);
        AssertAllClose(new double[] { -10, -27, 25, -3 }, r.Z);
    }

    [Fact]
    public void CrossOfDD3Vector3Test()
    {
        var r = Cross(ddu, ddv);

        AssertAllClose(new double[] { 20, 43, -84, 5, 35, -16, -62, 193, 26, -6 }, r.X);
        AssertAllClose(new double[] { 5, 14, -48, 42, 16, -89, 89, 183, -48, -76 }, r.Y);
        AssertAllClose(new double[] { -10, -27, 25, -3, -61, 138, -121, -193, -35, 1 }, r.Z);
    }
}