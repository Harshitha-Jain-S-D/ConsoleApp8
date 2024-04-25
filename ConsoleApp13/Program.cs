using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("num_of_digits(11) → " + NumOfDigits(11));
        Console.WriteLine("num_of_digits(10) → " + NumOfDigits(10));
        Console.WriteLine("num_of_digits(12) → " + NumOfDigits(12));
        Console.WriteLine("num_of_digits(1000) → " + NumOfDigits(1000));
    }

    static int NumOfDigits(int number)
    {
        if (number == 0) return 1; // Edge case when the number is 0

        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
}