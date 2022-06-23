namespace Recursion;

public class Factorial
{
    public decimal CalcFactorial(int number)
    {
        if (number < 2) return 1;

        return number * CalcFactorial(number - 1);
    }
}