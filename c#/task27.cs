using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two integers separated by a comma:");
        string[] input = Console.ReadLine().Split(',');
        int num1 = int.Parse(input[0]);
        int num2 = int.Parse(input[1]);

        int diff1 = Math.Abs(num1 - 50);
        int diff2 = Math.Abs(num2 - 50);

        if (diff1 < diff2)
        {
            Console.WriteLine(num1);
        }
        else if (diff2 < diff1)
        {
            Console.WriteLine(num2);
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}
