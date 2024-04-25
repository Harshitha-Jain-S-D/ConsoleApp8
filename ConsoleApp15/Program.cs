using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        string input = Console.ReadLine();

        string reversedString = ReverseWords(input);

        Console.WriteLine("Output: " + reversedString);
    }

    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}