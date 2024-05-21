using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the first number to multiply: ");
        string input1 = Console.ReadLine();
        int number1 = int.Parse(input1);

        Console.Write("Input the second number to multiply: ");
        string input2 = Console.ReadLine();
        int number2 = int.Parse(input2);

        int result = number1 * number2;

        Console.WriteLine("The result of the multiplication is: " + result);
    }
}
