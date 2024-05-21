using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("\nHere are the options:");
            Console.WriteLine("1- Addition.");
            Console.WriteLine("2- Subtraction.");
            Console.WriteLine("3- Multiplication.");
            Console.WriteLine("4- Division.");
            Console.WriteLine("5- Exit.");

            Console.WriteLine("\nInput your choice:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The Addition of " + num1 + " and " + num2 + " is: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("The Subtraction of " + num1 + " and " + num2 + " is: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("The Multiplication of " + num1 + " and " + num2 + " is: " + (num1 * num2));
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine("The Division of " + num1 + " and " + num2 + " is: " + (num1 / num2));
                    else
                        Console.WriteLine("Division by zero is undefined.");
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
