using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Input any number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int digitCount = CountDigits(number);

        Console.WriteLine("The number " + number + " contains the number of digits: " + digitCount);
    }

    static int CountDigits(int number)
    {
        if (number == 0)
        {
            return 0; // Base case: number has no digits
        }
        return 1 + CountDigits(number / 10); // Recursive call with quotient and increment the count
    }
}