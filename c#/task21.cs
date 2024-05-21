using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter four integers separated by commas:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');

        int[] nums = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        int largest = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > largest)
            {
                largest = nums[i];
            }
        }
 
        Console.WriteLine("The largest number is:" + largest);
    }
}
