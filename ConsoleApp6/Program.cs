using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string sentence = "It waS a cOLD AND foggy WintEr MorNiNg, I WenT ouT in SearCH of ElusiVe LEoParD";
        char[] characters = sentence.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            // Check if the character is a lowercase letter
            if (characters[i] >= 'a' && characters[i] <= 'z')
            {
                // Convert it to uppercase using ASCII values
                characters[i] = (char)(characters[i] - 32);
            }
        }

        string uppercaseSentence = new string(characters);
        Console.WriteLine(uppercaseSentence);
    }
}