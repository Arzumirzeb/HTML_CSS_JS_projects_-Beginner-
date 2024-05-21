using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine(number + " * " + i + " = " + result);
        }
    }
}
