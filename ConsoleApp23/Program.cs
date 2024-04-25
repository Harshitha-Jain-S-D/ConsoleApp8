using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Input Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        DisplayPlaceValues(number);
    }

    static void DisplayPlaceValues(int number)
    {
        int placeValue = 1;
        int divisor = 1;

        // Find the largest power of 10 less than or equal to the number
        while (number / divisor >= 10)
        {
            divisor *= 10;
            placeValue *= 10;
        }

        // Iterate through each digit of the number and calculate its place value
        while (placeValue > 0)
        {
            int digit = number / placeValue;
            Console.WriteLine("Output: " + digit * placeValue);
            number %= placeValue; // Remove the processed digit from the number
            placeValue /= 10; // Move to the next lower place value
        }
    }
}