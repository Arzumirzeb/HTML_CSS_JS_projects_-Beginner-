using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the 5 numbers:");

        int sum = 0;
        int count = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Number " + (i+1) + ": ");
            int num = int.Parse(Console.ReadLine());
            sum += num;
            count++;
        }

        double average = (double)sum / count;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
    }
}
