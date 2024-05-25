using System;

public enum Fruit
{
    Apple,
    Banana,
    Orange,
    Grapes,
    Pineapple
}

class Program5
{
    static void Main()
    {
        Fruit myFruit = Fruit.Apple;
        Console.WriteLine("My favorite fruit is: " + myFruit);

        Console.WriteLine("\nAvailable fruits:");
        foreach (Fruit fruit in Enum.GetValues(typeof(Fruit)))
        {
            Console.WriteLine(fruit);
        }
    }
}
