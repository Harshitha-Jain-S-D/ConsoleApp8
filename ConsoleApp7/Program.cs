using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int number = 56;
        Console.WriteLine("Prime Factors of " + number + " = " + GetPrimeFactors(number));
    }

    static string GetPrimeFactors(int n)
    {
        string primeFactors = "";

        // Iterate from 2 to the square root of n
        for (int i = 2; i * i <= n; i++)
        {
            // Check if i is a factor of n
            while (n % i == 0)
            {
                // If i is a factor, append it to the primeFactors string
                primeFactors += i + "x";
                // Reduce n by dividing it by i
                n /= i;
            }
        }

        // If n is still greater than 1, it means it is a prime number itself
        if (n > 1)
        {
            primeFactors += n;
        }

        // Remove the trailing 'x' from the primeFactors string, if any
        if (primeFactors.EndsWith("x"))
        {
            primeFactors = primeFactors.Substring(0, primeFactors.Length - 1);
        }

        return primeFactors;
    }
}