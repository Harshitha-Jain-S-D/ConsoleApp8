using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string input = "bananas";
        string longestPalindrome = LongestPalindromicSubstring(input);
        Console.WriteLine("Longest palindromic substring of \"" + input + "\" is \"" + longestPalindrome + "\"");
    }

    static string LongestPalindromicSubstring(string input)
    {
        int length = input.Length;
        bool[,] dp = new bool[length, length];
        int maxLength = 1;
        int start = 0;

        // Single character substrings are palindromes
        for (int i = 0; i < length; i++)
        {
            dp[i, i] = true;
        }

        // Check for palindromes of length 2
        for (int i = 0; i < length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                dp[i, i + 1] = true;
                start = i;
                maxLength = 2;
            }
        }

        // Check for palindromes of length greater than 2
        for (int len = 3; len <= length; len++)
        {
            for (int i = 0; i < length - len + 1; i++)
            {
                int j = i + len - 1; // Ending index of current substring
                if (input[i] == input[j] && dp[i + 1, j - 1])
                {
                    dp[i, j] = true;
                    start = i;
                    maxLength = len;
                }
            }
        }

        return input.Substring(start, maxLength);
    }
}