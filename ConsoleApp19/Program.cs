using System;

class MainClass
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter alphanumeric: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                break; // Exit the loop if input is empty
            }

            GeneratePattern(input);
            Console.WriteLine("Ready");
        }
    }

    static void GeneratePattern(string input)
    {
        Console.Write("Pattern: ");
        bool useFirstChar = true;

        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                Console.Write(useFirstChar ? c : '0');
                useFirstChar = !useFirstChar; // Toggle between using the character and '0'
            }
        }

        Console.WriteLine();
    }
}