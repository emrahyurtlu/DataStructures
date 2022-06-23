namespace Recursion.Tests;

public class FibonacciTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    [InlineData(7, 13)]
    [InlineData(8, 21)]
    [InlineData(-1, 0)]
    public void CalculateFibSeries(int number, int expected)
    {
        var fib = new Fibonacci();
        var actual = fib.CalcFibonacci(number);

        Assert.Equal(expected, actual);
    }
}