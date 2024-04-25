using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        string input = Console.ReadLine();

        string codeWords = GenerateCodeWords(input);

        Console.WriteLine("Output: " + codeWords);
    }

    static string GenerateCodeWords(string input)
    {
        char[] characters = input.ToUpper().ToCharArray(); // Convert to uppercase for simplicity

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLetter(characters[i]))
            {
                characters[i] = (char)(characters[i] + 3); // Replace with the third succeeding letter
                if (characters[i] > 'Z')
                {
                    characters[i] = (char)(characters[i] - 26); // Wrap around if needed
                }
            }
            // Do nothing for non-alphabetic characters
        }

        return new string(characters);
    }
}