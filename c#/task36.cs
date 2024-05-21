using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the size of array:");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Input " + size + " elements in the array in ascending order:");

        for (int i = 0; i < size; i++)
        {
            Console.Write("element - " + i + " : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Input the position where to delete:");
        int position = int.Parse(Console.ReadLine());
        
        if (position < 0 || position >= size)
        {
            Console.WriteLine("Invalid position!");
            return;
        }

        for (int i = position; i < size - 1; i++)
        {
            array[i] = array[i + 1];
        }

        size--;

        Console.WriteLine("The array after deletion:");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("element - " + i + " : " + array[i]);
        }
    }
}
