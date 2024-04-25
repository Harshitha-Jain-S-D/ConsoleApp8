using System;
 
class MainClass
{
    public static void Main(string[] args)
    {
        string sentence = "What do you know about me? Out of everything I found nothing for you";
        string substring = "ou";
        int occurrences = FindSubstringOccurrences(sentence, substring);
        Console.WriteLine("Occurrences of \"" + substring + "\": " + occurrences);
    }

    static int FindSubstringOccurrences(string sentence, string substring)
    {
        int occurrences = 0;
        int substringLength = substring.Length;

        // Iterate through the sentence
        for (int i = 0; i <= sentence.Length - substringLength; i++)
        {
            // Check if the substring matches the portion of the sentence starting at index i
            bool match = true;
            for (int j = 0; j < substringLength; j++)
            {
                if (sentence[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }
            // If a match is found, increment the occurrences count
            if (match)
            {
                occurrences++;
            }
        }
        return occurrences;
    }
}