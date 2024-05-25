using System;

class Program3
{
    static void Main()
    {
        string[] fruits = { "Apple", "Banana", "Orange", "Grapes", "Pineapple" };

        Console.WriteLine("Original array:");
        PrintArray(fruits);

        Array.Sort(fruits);

        Console.WriteLine("\nSorted array:");
        PrintArray(fruits);
    }

    static void PrintArray(string[] arr)
    {
        foreach (string element in arr)
        {
            Console.WriteLine(element);
        }
    }
}
