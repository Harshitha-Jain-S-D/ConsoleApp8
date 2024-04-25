using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int num1 = 12;
        int num2 = 18;

        int lcm = LCM(num1, num2);
        int gcd = GCD(num1, num2);

        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
    }

    // Recursive function to find LCM
    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    // Recursive function to find GCD
    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return GCD(b, a % b);
    }
}