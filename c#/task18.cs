using System;

class Program3
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 6, 7, 8, 9, 10 };

        if (array1.Length != array2.Length)
        {
            Console.WriteLine("Arrays must have the same length for element-wise multiplication.");
            return;
        }

        int[] resultArray = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            resultArray[i] = array1[i] * array2[i];
        }

        Console.WriteLine("Result of element-wise multiplication:");
        foreach (var item in resultArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
