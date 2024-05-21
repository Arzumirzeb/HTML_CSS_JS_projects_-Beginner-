using System;

class Program10
{
    static void Main()
    {
        int[] sortedArray = { 2, 4, 6, 8, 10 };

        Console.WriteLine("Original sorted array:");
        foreach (var item in sortedArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.Write("Input the value to insert into the sorted array: ");
        string input = Console.ReadLine();
        int newValue = int.Parse(input);

        sortedArray = InsertIntoSortedArray(sortedArray, newValue);

        Console.WriteLine("Updated sorted array:");
        foreach (var item in sortedArray)
        {
            Console.Write(item + " ");
        }
    }

    static int[] InsertIntoSortedArray(int[] array, int value)
    {
        int[] newArray = new int[array.Length + 1];
        int i = 0;

        while (i < array.Length && array[i] < value)
        {
            newArray[i] = array[i];
            i++;
        }

        newArray[i] = value;

        for (int j = i; j < array.Length; j++)
        {
            newArray[j + 1] = array[j];
        }

        return newArray;
    }
}
