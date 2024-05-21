using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input 5 elements in the array:");

        int[] array = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("element - " + i + " : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThe elements in the array:");

        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }
}
