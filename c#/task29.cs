using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the value of n:");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        Console.WriteLine("The first " + n + " natural numbers are:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }

        Console.WriteLine("\nThe sum of the first " + n + " natural numbers is: " + sum);
    }
}
