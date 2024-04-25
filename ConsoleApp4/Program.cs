class Program
{
    static void Main(string[] args)
    {
        string input = "TiGer Is A LaRgE-HeArTeD GentlEmAN witH BounDleSS CouRAgE";
        string output = ToggleCase(input);
        Console.WriteLine("Output character: " + output);
    }

    static string ToggleCase(string str)
    {
        char[] chars = str.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] >= 'A' && chars[i] <= 'Z')
            {
                // Uppercase to lowercase
                chars[i] = (char)(chars[i] + 32);
            }
            else if (chars[i] >= 'a' && chars[i] <= 'z')
            {
                // Lowercase to uppercase
                chars[i] = (char)(chars[i] - 32);
            }
        }
        return new string(chars);
    }
}