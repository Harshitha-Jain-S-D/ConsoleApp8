using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int n = 5; // Change this value to adjust the size of the diamond
        PrintDiamondPattern(n);
    }

    static void PrintDiamondPattern(int n)
    {
        // Upper half of the diamond
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write("★");
            }
            Console.Write("*");

            for (int k = 1; k <= 2 * i - 3; k++)
            {
                Console.Write("★");
            }
            if (i != 1)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Lower half of the diamond
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write("★");
            }
            Console.Write("*");

            for (int k = 1; k <= 2 * i - 3; k++)
            {
                Console.Write("★");
            }
            if (i != 1)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}