using System;

class Program5
{
    static void Main()
    {

        Console.WriteLine("Input the first number:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input the second number:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double sum = firstNumber + secondNumber;
        Console.WriteLine("Addition Result: " + sum);

        double difference = firstNumber - secondNumber;
        Console.WriteLine("Subtraction Result: " + difference);

        double product = firstNumber * secondNumber;
        Console.WriteLine("Multiplication Result: " + product);

    
        if (secondNumber != 0)
        {
            double quotient = firstNumber / secondNumber;
            Console.WriteLine("Division Result: " + quotient);
        }
        else
        {
            Console.WriteLine("Division by zero is undefined.");
        }
    }
}
