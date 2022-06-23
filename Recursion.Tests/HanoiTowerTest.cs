using Xunit.Abstractions;

namespace Recursion.Tests;

public class HanoiTowerTest
{
    private readonly ITestOutputHelper _output;

    public HanoiTowerTest(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void TestOneWithABC()
    {
        var hanoi = new TowersOfHanoi();
        hanoi.Print(1, 'A', 'B', 'C');
        var expected = "A --> B";
        // _output.WriteLine(expected);

        Assert.True(false);
    }
}