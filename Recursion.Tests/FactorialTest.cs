namespace Recursion.Tests
{
    public class FactorialTest
    {
        [Fact]
        public void CalculateZeroFactorial()
        {
            var fact = new Factorial();

            var expected = 1;
            var actual = fact.CalcFactorial(0);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateMinusValueFactorial()
        {
            var fact = new Factorial();

            var expected = 1;
            var actual = fact.CalcFactorial(-1);

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CalculateFiveFactorial()
        {
            var fact = new Factorial();

            var expected = 120;
            var actual = fact.CalcFactorial(5);

            Assert.Equal(expected, actual);
        }
    }
}