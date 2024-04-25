class Program {
    static void Main(string[] args) {
        string input = "abcdef";
 
        string middle = FindMiddleCharacters(input);
        Console.WriteLine("Middle character(s): " + middle);
    }
 
    static string FindMiddleCharacters(string str) {
        int length = str.Length;
        if (length % 2 == 0) {
            // Even length
            int middleIndex = length / 2 - 1;
            return str.Substring(middleIndex, 2);
        } else {
            // Odd length
            int middleIndex = length / 2;
            return str[middleIndex].ToString();
        }
    }
}