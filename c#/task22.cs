using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Odd numbers from 7 to 77:");

        for (int i = 7; i <= 77; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
