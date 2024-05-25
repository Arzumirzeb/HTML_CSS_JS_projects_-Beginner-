using System;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name + ", Age: " + Age);
    }
}

class Program6
{
    static void Main()
    {
        Student student1 = new Student("Alice", 20);
        Student student2 = new Student("Bob", 22);

        Console.WriteLine("Student 1:");
        student1.DisplayInfo();

        Console.WriteLine("\nStudent 2:");
        student2.DisplayInfo();
    }
}
