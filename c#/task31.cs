using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the number of elements to store in the array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Input " + n + " number of elements in the array:");

        // Read elements into the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("element - " + i + " : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Display elements in reverse order
        Console.WriteLine("\nThe elements in reverse order:");

        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}
