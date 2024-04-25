
using System;
using System.Collections.Generic;
 
class MainClass
{
    public static void Main(string[] args)
    {
        string word1 = "teshahset";
        string word2 = "hello";
        string word3 = "call 911";

        Console.WriteLine("Unrepeated(\"" + word1 + "\") → \"" + RemoveRepeatedChars(word1) + "\"");
        Console.WriteLine("Unrepeated(\"" + word2 + "\") → \"" + RemoveRepeatedChars(word2) + "\"");
        Console.WriteLine("Unrepeated(\"" + word3 + "\") → \"" + RemoveRepeatedChars(word3) + "\"");
    }

    static string RemoveRepeatedChars(string word)
    {
        HashSet<char> seenChars = new HashSet<char>();
        string result = "";

        foreach (char c in word)
        {
            if (!seenChars.Contains(c))
            {
                result += c;
                seenChars.Add(c);
            }
        }

        return result;
    }
}