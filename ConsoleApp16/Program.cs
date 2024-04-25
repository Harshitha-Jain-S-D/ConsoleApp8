
using System;
 
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        string input = Console.ReadLine();

        string reversedCaseString = ReverseCase(input);

        Console.WriteLine("Output: " + reversedCaseString);
    }

    static string ReverseCase(string input)
    {
        char[] characters = input.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLower(characters[i]))
            {
                characters[i] = char.ToUpper(characters[i]);
            }
            else if (char.IsUpper(characters[i]))
            {
                characters[i] = char.ToLower(characters[i]);
            }
            // Do nothing for non-alphabetic characters
        }

        return new string(characters);
    }
}