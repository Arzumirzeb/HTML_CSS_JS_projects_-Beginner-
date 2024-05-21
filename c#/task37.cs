using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 7 };
        Array.Sort(array, (a, b) => b.CompareTo(a));

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
