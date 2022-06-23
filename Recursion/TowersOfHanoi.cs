namespace Recursion;

public class TowersOfHanoi
{
    public void Print(int number, char x, char y, char z)
    {
        if (number == 1)
        {
            Console.WriteLine(x + " --> " + y);
        }
        else
        {
            Print(number - 1, x, z, y);
            Console.WriteLine(x + " --> " + y);
            Print(number - 1, z, y, x);
        }
    }
}