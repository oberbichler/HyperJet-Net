namespace HyperJet.Tests;

using Xunit;

public class DScalarTests
{
    [Fact]
    public void EvaluateTest()
    {
        var f = new D3Scalar(1, 2, 3, 4);

        var t = f.Evaluate(2, 3, 4);

        Assert.Equal(30, t);
    }
}
