using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] sequence = { 1, 2, 3, 3, 4, 5, 5, 6, 6, 7, 8, 9, 9 }; // Example sequence

        int prev = sequence[0];
        bool foundDuplicate = false;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] == prev)
            {
                Console.WriteLine("Duplicate found: " + sequence[i]);
                foundDuplicate = true;
                break; // Assuming only one duplicate exists
            }
            prev = sequence[i];
        }

        if (!foundDuplicate)
        {
            Console.WriteLine("No duplicates found.");
        }
    }
}