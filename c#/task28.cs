using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number to check:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the integers separated by spaces:");
        string[] input = Console.ReadLine().Split();
        int[] array = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            array[i] = int.Parse(input[i]);
        }

        if (array[0] == number)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
