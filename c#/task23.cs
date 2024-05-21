using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input an integer:");
        int number = int.Parse(Console.ReadLine());

        bool isMultipleOf5Or11 = (number % 5 == 0) || (number % 11 == 0);

        Console.WriteLine(isMultipleOf5Or11);
    }
}
