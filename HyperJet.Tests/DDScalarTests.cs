namespace HyperJet.Tests;

using Xunit;

public class DDScalarTests
{
    [Fact]
    public void EvaluateTest()
    {
        var f = new DD3Scalar(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

        var t = f.Evaluate(2, 3, 4);

        Assert.Equal(356, t);
    }
}
