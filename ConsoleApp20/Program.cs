using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("bugger(39) → " + Bugger(39));
        Console.WriteLine("bugger(999) → " + Bugger(999));
        Console.WriteLine("bugger(4) → " + Bugger(4));
    }

    static int Bugger(int number)
    {
        int persistence = 0;

        while (number >= 10)
        {
            int product = 1;
            // Multiply the digits of the number
            while (number > 0)
            {
                int digit = number % 10;
                product *= digit;
                number /= 10;
            }
            number = product; // Assign the product to the number
            persistence++; // Increment persistence count
        }

        return persistence;
    }
}