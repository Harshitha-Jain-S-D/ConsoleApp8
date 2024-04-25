using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Input the number of elements to store in the array [maximum 5 digits]: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[n];
        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i}: ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nThe Permutations with a combination of " + n + " digits are:");
        GeneratePermutations(nums, 0, n);
    }

    static void GeneratePermutations(int[] nums, int start, int n)
    {
        if (start == n - 1)
        {
            PrintArray(nums);
            return;
        }

        for (int i = start; i < n; i++)
        {
            Swap(nums, start, i);
            GeneratePermutations(nums, start + 1, n);
            Swap(nums, start, i); // Backtrack
        }
    }

    static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    static void PrintArray(int[] nums)
    {
        foreach (var num in nums)
        {
            Console.Write(num);
        }
        Console.Write(" ");
    }
}