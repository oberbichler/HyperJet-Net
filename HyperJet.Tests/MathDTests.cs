namespace HyperJet.Tests;

using Xunit;

using static HyperJet.MathD;
using static HyperJet.Tests.Assertions;

public class MathDTests
{
    readonly D3Scalar da = new(3, 6, -9, 0);
    readonly D3Scalar db = new(2, 4, -9, 10);
    readonly D3Scalar dc = new(0.6, 8, 0, -8);

    readonly DD3Scalar dda = new(3, 6, -9, 0, 0, 8, -7, 10, 1, 1);
    readonly DD3Scalar ddb = new(2, 4, -9, 10, 2, 2, 0, 2, 10, 1);
    readonly DD3Scalar ddc = new(0.6, 8, 0, -8, 1, 3, -2, -3, 5, 7);

    /// Negative

    [Fact]
    public void NegativeOfD3ScalarTest()
    {
        var r = -da;

        AssertAllClose(new double[] { -3, -6, 9, 0 }, r);
    }

    [Fact]
    public void NegativeOfDD3ScalarTest()
    {
        var r = -dda;

        AssertAllClose(new double[] { -3, -6, 9, 0, 0, -8, 7, -10, -1, -1 }, r);
    }

    // Add

    [Fact]
    public void AddD3ScalarToDD3ScalarTest()
    {
        var r = da + db;

        AssertAllClose(new double[] { 5, 10, -18, 10 }, r);
    }

    [Fact]
    public void AddDD3ScalarToDD3ScalarTest()
    {
        var r = dda + ddb;

        AssertAllClose(new double[] { 5, 10, -18, 10, 2, 10, -7, 12, 11, 2 }, r);
    }

    // Subtract

    [Fact]
    public void SubtractD3ScalarFromDD3ScalarTest()
    {
        var r = da - db;

        AssertAllClose(new double[] { 1, 2, 0, -10 }, r);
    }

    [Fact]
    public void SubtractDD3ScalarFromDD3ScalarTest()
    {
        var r = dda - ddb;

        AssertAllClose(new double[] { 1, 2, 0, -10, -2, 6, -7, 8, -9, 0 }, r);
    }

    // Multiply

    [Fact]
    public void MultiplyD3ScalarWithDD3ScalarTest()
    {
        var r = da * db;

        AssertAllClose(new double[] { 6, 24, -45, 30 }, r);
    }

    [Fact]
    public void MultiplyDD3ScalarWithDD3ScalarTest()
    {
        var r = dda * ddb;

        AssertAllClose(new double[] { 6, 24, -45, 30, 54, -68, 46, 188, -58, 5 }, r);
    }

    // Divide

    [Fact]
    public void DivideD3ScalarByDD3ScalarTest()
    {
        var r = da / db;

        AssertAllClose(new double[] { 1.5, 0, 2.25, -7.5 }, r);
    }

    [Fact]
    public void DivideDD3ScalarByDD3ScalarTest()
    {
        var r = dda / ddb;

        AssertAllClose(new double[] { 1.5, 0, 2.25, -7.5, -1.5, -2, 11.5, 23.75, -52, 74.75 }, r);
    }

    // Reciprocal

    [Fact]
    public void ReciprocalOfD3ScalarTest()
    {
        var r = 1 / da;

        AssertAllClose(new double[] { 0.3333333333333333, -0.6666666666666666, 1, 0 }, r);
    }

    [Fact]
    public void ReciprocalOfDD3ScalarTest()
    {
        var r = 1 / dda;

        AssertAllClose(new double[] { 0.3333333333333333, -0.6666666666666666, 1, 0, 2.6666666666666665, -4.888888888888889, 0.7777777777777777, 4.888888888888889, -0.1111111111111111, -0.1111111111111111 }, r);
    }

    // Pow

    [Fact]
    public void PowOfD3ScalarTest()
    {
        var r = Pow(da, 3.5);

        AssertAllClose(new double[] { 46.76537180435969, 327.3576026305178, -491.0364039457767, 0 }, r);
    }

    [Fact]
    public void PowOfDD3ScalarTest()
    {
        var r = Pow(dda, 3.5);

        AssertAllClose(new double[] { 46.76537180435969, 327.3576026305178, -491.0364039457767, 0, 1636.788013152589, -2018.7052162215264, -381.91720306893745, 4228.369033977521, 54.559600438419636, 54.559600438419636 }, r);
    }

    // Sqrt

    [Fact]
    public void SqrtOfD3ScalarTest()
    {
        var r = Sqrt(da);

        AssertAllClose(new double[] { 1.7320508075688772, 1.7320508075688772, -2.598076211353316, 0 }, r);
    }

    [Fact]
    public void SqrtOfDD3ScalarTest()
    {
        var r = Sqrt(dda);

        AssertAllClose(new double[] { 1.7320508075688772, 1.7320508075688772, -2.598076211353316, 0, -1.7320508075688772, 4.907477288111819, -2.02072594216369, -1.0103629710818454, 0.28867513459481287, 0.28867513459481287 }, r);
    }

    // Cbrt

    [Fact]
    public void CbrtOfD3ScalarTest()
    {
        var r = Cbrt(da);

        AssertAllClose(new double[] { 1.4422495703074083, 0.961499713538272, -1.442249570307408, 0 }, r);
    }

    [Fact]
    public void CbrtOfDD3ScalarTest()
    {
        var r = Cbrt(dda);

        AssertAllClose(new double[] { 1.4422495703074083, 0.961499713538272, -1.442249570307408, 0, -1.2819996180510296, 3.2049990451275736, -1.1217496657946506, -1.2819996180510298, 0.16024995225637867, 0.16024995225637867 }, r);
    }

    // Cos

    [Fact]
    public void CosOfD3ScalarTest()
    {
        var r = Cos(da);

        AssertAllClose(new double[] { -0.9899924966004454, -0.8467200483592032, 1.2700800725388048, 0 }, r);
    }

    [Fact]
    public void CosOfDD3ScalarTest()
    {
        var r = Cos(dda);

        AssertAllClose(new double[] { -0.9899924966004454, -0.8467200483592032, 1.2700800725388048, 0, 35.639729877616034, -54.588554880903, 0.9878400564190705, 78.7781921440374, -0.1411200080598672, -0.1411200080598672 }, r);
    }

    // Sin

    [Fact]
    public void SinOfD3ScalarTest()
    {
        var r = Sin(da);

        AssertAllClose(new double[] { 0.1411200080598672, -5.939954979602673, 8.909932469404009, 0 }, r);
    }

    [Fact]
    public void SinOfDD3ScalarTest()
    {
        var r = Sin(dda);

        AssertAllClose(new double[] { 0.1411200080598672, -5.939954979602673, 8.909932469404009, 0, -5.080320290155219, -0.2994595375707343, 6.929947476203118, -21.330645618853698, -0.9899924966004454, -0.9899924966004454 }, r);
    }

    // Tan

    [Fact]
    public void TanOfD3ScalarTest()
    {
        var r = Tan(da);

        AssertAllClose(new double[] { -0.1425465430742778, 6.121917101654561, -9.182875652481842, 0 }, r);
    }

    [Fact]
    public void TanOfDD3ScalarTest()
    {
        var r = Tan(dda);

        AssertAllClose(new double[] { -0.1425465430742778, 6.121917101654561, -9.182875652481842, 0, -10.471897437937917, 23.87040229244629, -7.142236618596987, -13.358574065936043, 1.0203195169424268, 1.0203195169424268 }, r);
    }

    // Acos

    [Fact]
    public void AcosOfD3ScalarTest()
    {
        var r = Acos(dc);

        AssertAllClose(new double[] { 0.9272952180016123, -10, 0, 10 }, r);
    }

    [Fact]
    public void AcosOfDD3ScalarTest()
    {
        var r = Acos(ddc);

        AssertAllClose(new double[] { 0.9272952180016123, -10, 0, 10, -76.25, -3.75, 77.5, 3.75, -6.25, -83.75 }, r);
    }

    // Asin

    [Fact]
    public void AsinOfD3ScalarTest()
    {
        var r = Asin(dc);

        AssertAllClose(new double[] { 0.6435011087932844, 10, 0, -10 }, r);
    }

    [Fact]
    public void AsinOfDD3ScalarTest()
    {
        var r = Asin(ddc);

        AssertAllClose(new double[] { 0.6435011087932844, 10, 0, -10, 76.25, 3.75, -77.5, -3.75, 6.25, 83.75 }, r);
    }

    // Atan

    [Fact]
    public void AtanOfD3ScalarTest()
    {
        var r = Atan(dc);

        AssertAllClose(new double[] { 0.5404195002705842, 5.882352941176471, 0, -5.882352941176471 }, r);
    }

    [Fact]
    public void AtanOfDD3ScalarTest()
    {
        var r = Atan(ddc);

        AssertAllClose(new double[] { 0.5404195002705842, 5.882352941176471, 0, -5.882352941176471, -40.78719723183392, 2.2058823529411766, 40.051903114186864, -2.2058823529411766, 3.6764705882352944, -36.37543252595157 }, r);
    }

    // Atan2

    [Fact]
    public void Atan2OfDoubleAndD3ScalarTest()
    {
        var r = Atan2(3.5, da);

        AssertAllClose(new double[] { 0.8621700546672264, -0.9882352941176471, 1.4823529411764707, 0 }, r);
    }

    [Fact]
    public void Atan2OfDoubleAndDD3ScalarTest()
    {
        var r = Atan2(3.5, dda);

        AssertAllClose(new double[] { 0.8621700546672264, -0.9882352941176471, 1.4823529411764707, 0, 1.6741868512110725, -3.828927335640138, 1.1529411764705881, 2.1198615916955017, -0.16470588235294117, -0.16470588235294117 }, r);
    }


    [Fact]
    public void Atan2OfD3ScalarAndDoubleTest()
    {
        var r = Atan2(da, 3.5);

        AssertAllClose(new double[] { 0.7086262721276703, 0.9882352941176471, -1.4823529411764707, 0 }, r);
    }

    [Fact]
    public void Atan2OfDD3ScalarAndDoubleTest()
    {
        var r = Atan2(dda, 3.5);

        AssertAllClose(new double[] { 0.7086262721276703, 0.9882352941176471, -1.4823529411764707, 0, -1.6741868512110725, 3.828927335640138, -1.1529411764705881, -2.1198615916955017, 0.16470588235294117, 0.16470588235294117 }, r);
    }


    [Fact]
    public void Atan2OfD3ScalarAndD3ScalarTest()
    {
        var r = Atan2(da, db);

        AssertAllClose(new double[] { 0.982793723247329, 0, 0.6923076923076925, -2.307692307692308 }, r);
    }

    [Fact]
    public void Atan2OfDD3ScalarAndDD3ScalarTest()
    {
        var r = Atan2(dda, ddb);

        AssertAllClose(new double[] { 0.982793723247329, 0, 0.6923076923076925, -2.307692307692308, -0.46153846153846156, -0.6153846153846158, 3.5384615384615388, 5.869822485207102, -11.207100591715978, 7.0236686390532554 }, r);
    }

    // Hypot

    [Fact]
    public void HypotOfDoubleAndD3ScalarTest()
    {
        var r = Hypot(3.5, da);

        AssertAllClose(new double[] { 4.6097722286464435, 3.904748240735811, -5.857122361103716, 0 }, r);
    }

    [Fact]
    public void HypotOfDoubleAndDD3ScalarTest()
    {
        var r = Hypot(3.5, dda);

        AssertAllClose(new double[] { 4.6097722286464435, 3.904748240735811, -5.857122361103716, 0, 4.501945030495405, -1.5465865580953597, -4.55553961419178, 16.637290053174347, 0.6507913734559685, 0.6507913734559685 }, r);
    }


    [Fact]
    public void HypotOfD3ScalarAndDoubleTest()
    {
        var r = Hypot(da, 3.5);

        AssertAllClose(new double[] { 4.6097722286464435, 3.904748240735811, -5.857122361103716, 0 }, r);
    }

    [Fact]
    public void HypotOfDD3ScalarAndDoubleTest()
    {
        var r = Hypot(dda, 3.5);

        AssertAllClose(new double[] { 4.6097722286464435, 3.904748240735811, -5.857122361103716, 0, 4.501945030495405, -1.5465865580953597, -4.55553961419178, 16.637290053174347, 0.6507913734559685, 0.6507913734559685 }, r);
    }


    [Fact]
    public void HypotOfTwoD3ScalarTest()
    {
        var r = Hypot(da, db);

        AssertAllClose(new double[] { 3.605551275463989, 7.211102550927979, -12.480754415067656, 5.547001962252292 }, r);
    }

    [Fact]
    public void HypotOfTwoDD3ScalarTest()
    {
        var r = Hypot(dda, ddb);

        AssertAllClose(new double[] { 3.605551275463989, 7.211102550927979, -12.480754415067656, 5.547001962252292, 1.109400392450457, 7.765802747153209, -5.824352060364907, 11.158007793299802, 0.6187040650204487, 20.5879111291287 }, r);
    }


    [Fact]
    public void HypotOfDoubleAndTwoD3ScalarTest()
    {
        var r = Hypot(3.5, db, dc);

        AssertAllClose(new double[] { 4.075536774462966, 3.140690590796266, -4.416596143307249, 3.7295700765705653 }, r);
    }

    [Fact]
    public void HypotOfDoubleAndTwoDD3ScalarTest()
    {
        var r = Hypot(3.5, ddb, ddc);

        AssertAllClose(new double[] { 4.075536774462966, 3.140690590796266, -4.416596143307249, 3.7295700765705653, 18.33772255011287, -4.006549064084816, -9.057316297204697, 15.628291935929463, -12.397874925391246, 38.34839818481181 }, r);
    }


    [Fact]
    public void HypotOfTwoDoubleAndD3ScalarTest()
    {
        var r = Hypot(3.5, 1.5, dc);

        AssertAllClose(new double[] { 3.8548670534792766, 1.2451791289838847, 0, -1.2451791289838847 }, r);
    }

    [Fact]
    public void HypotOfTwoDoubleAndDD3ScalarTest()
    {
        var r = Hypot(3.5, 1.5, ddc);

        AssertAllClose(new double[] { 3.8548670534792766, 1.2451791289838847, 0, -1.2451791289838847, 16.355824484228705, 0.4669421733689567, -16.511471875351695, -0.4669421733689567, 0.778236955614928, 17.28970883096662 }, r);
    }


    [Fact]
    public void HypotOfThreeD3ScalarTest()
    {
        var r = Hypot(da, db, dc);

        AssertAllClose(new double[] { 3.655133376499413, 8.426505089534574, -12.311452241203112, 4.158534979250829 }, r);
    }

    [Fact]
    public void HypotOfThreeDD3ScalarTest()
    {
        var r = Hypot(dda, ddb, ddc);

        AssertAllClose(new double[] { 3.655133376499413, 8.426505089534574, -12.311452241203112, 4.158534979250829, 13.568317997617083, 11.912702078128088, -22.226799352934012, 11.662541232189056, -3.502579493239155, 42.654144395590244 }, r);
    }

    // Penalty

    [Fact]
    public void PenaltyOfD3ScalarTest()
    {
        var r = Penalty(3.5, da);

        AssertAllClose(new double[] { 15.75, 63, -94.5, 0 }, r);
    }

    [Fact]
    public void PenaltyOfDD3ScalarTest()
    {
        var r = Penalty(3.5, dda);

        AssertAllClose(new double[] { 15.75, 63, -94.5, 0, 126, -105, -73.5, 388.5, 10.5, 10.5 }, r);
    }
}