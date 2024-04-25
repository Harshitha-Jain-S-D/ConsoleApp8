
using System;
 
class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Input the original string: ");
        string originalString = Console.ReadLine();

        Console.Write("Input the string to be searched for: ");
        string searchString = Console.ReadLine();

        Console.Write("Input the string to be inserted: ");
        string insertString = Console.ReadLine();

        string modifiedString = InsertSubstringAfterFirst(originalString, searchString, insertString);

        Console.WriteLine("The modified string is: \"" + modifiedString + "\"");
    }

    static string InsertSubstringAfterFirst(string original, string search, string insert)
    {
        int index = original.IndexOf(search);
        if (index == -1)
        {
            return original; // Return original string if search string is not found
        }

        // Insert the new substring after the first occurrence of the search string
        string modifiedString = original.Substring(0, index + search.Length) + insert + original.Substring(index + search.Length);

        return modifiedString;
    }
}