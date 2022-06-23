namespace Recursion;

public class Fibonacci
{
    public decimal CalcFibonacci(int number)
    {
        if (number < 1)
            return 0;

        if (number < 3)
            return 1;

        return CalcFibonacci(number - 1) + CalcFibonacci(number - 2);
    }
}