using System;
using System.Collections.Generic;

class Program5
{
    static void Main()
    {
        // Variables
        int age = 25;
        double price = 19.99;
        string name = "John Doe";
        bool isAlive = true;

        // Function usage
        int result = Add(5, 3); // result is 8
        Console.WriteLine("Result of Add: " + result);

        // Control structures
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("Positive number");
        }
        else if (number < 0)
        {
            Console.WriteLine("Negative number");
        }
        else
        {
            Console.WriteLine("Zero");
        }

        // Array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // List
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        names.Add("Dave");

        // Dictionary
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["Alice"] = 30;
        ages["Bob"] = 25;

        // For loop
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // While loop
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine(j);
            j++;
        }

        // Foreach loop
        foreach (string name11 in names)
        {
            Console.WriteLine(name11);
        }

        // Enum usage
        DaysOfWeek today = DaysOfWeek.Wednesday;
        Console.WriteLine("Today is: " + today);

        // Class usage
        Person person = new Person("John", 30);
        person.Introduce();

        // Property usage in a class
        Person2 person2 = new Person2();
        person2.Name = "Jane";
        person2.Age = 28;
        Console.WriteLine("Person2: " + person2.Name + ", " + person2.Age);

        // Scope example
        ScopeExample scopeExample = new ScopeExample();
        scopeExample.Method();
    }

    // Function
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Enum
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    // Class
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Introduce()
        {
            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");
        }
    }

    // Class with properties
    public class Person2
    {
        private string name2;
        private int age2;

        public string Name
        {
            get { return name2; }
            set { name2 = value; }
        }

        public int Age
        {
            get { return age2; }
            set { age2 = value; }
        }
    }

    // Scope example
    public class ScopeExample
    {
        private int classLevelVariable = 0;

        public void Method()
        {
            int methodLevelVariable = 1;

            if (true)
            {
                int blockLevelVariable = 2;
                Console.WriteLine(blockLevelVariable);
            }
        }
    }
}
