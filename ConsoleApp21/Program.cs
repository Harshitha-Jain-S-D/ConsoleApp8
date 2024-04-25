using System;
 
class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Input any number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("The digits in the number " + number + " are: ");
        DisplayDigits(number);
        Console.WriteLine();
    }

    static void DisplayDigits(int number)
    {
        if (number / 10 != 0)
        {
            DisplayDigits(number / 10); // Recursive call with quotient
        }
        Console.Write(number % 10 + " "); // Print the last digit
    }
}