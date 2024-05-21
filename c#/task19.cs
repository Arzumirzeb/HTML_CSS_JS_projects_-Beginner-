using System;

class Program4
{
    static void Main()
    {
        
        Console.WriteLine("Input first integer:");
        int firstInt = Convert.ToInt32(Console.ReadLine());

       
        Console.WriteLine("Input second integer:");
        int secondInt = Convert.ToInt32(Console.ReadLine());

     
        bool result = (firstInt < 0 && secondInt > 0) || (firstInt > 0 && secondInt < 0);

        Console.WriteLine("Result:" + result
        );
    }
}
