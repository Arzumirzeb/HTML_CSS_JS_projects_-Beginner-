using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input number of terms: ");
        int numberOfTerms = int.Parse(Console.ReadLine());

        Console.WriteLine("Expected Output:");

        for (int i = 1; i <= numberOfTerms; i++)
        {
            int cube = i * i * i;
            Console.WriteLine("Number is: " + i + " and cube of the " + i + " is: " + cube);
        }
    }
}
