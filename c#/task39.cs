using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer between 1 and 5:");
        int number = int.Parse(Console.ReadLine());

        string word = "";

        switch (number)
        {
            case 1:
                word = "one";
                break;
            case 2:
                word = "two";
                break;
            case 3:
                word = "three";
                break;
            case 4:
                word = "four";
                break;
            case 5:
                word = "five";
                break;
            default:
                word = "Invalid input";
                break;
        }

        Console.WriteLine("The word representation of " + number + " is: " + word);
    }
}
