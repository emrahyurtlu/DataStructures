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
        // Arrange
        var hanoi = new TowersOfHanoi();
        var expected = "A --> B";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        
        // Act
        hanoi.Print(1, 'A', 'B', 'C');

        // Assert
        Assert.Equal(expected, stringWriter.ToString());
    }
}