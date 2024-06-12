using System;

// A parent class called Person
public class Person
{
    private string _name;

    public Person(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}

// A child class called Student
public class Student : Person
{
    private string _number;

    // Calling the parent constructor using "base"
    public Student(string name, string number) : base(name)
    {
        _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }

    public void DisplayStudentInfo()
    {
        string name = GetName();
        string number = base.GetName();
        Console.WriteLine($"Student Number: {number}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student("John Doe", "12345");
        student.DisplayStudentInfo();
        
    }
}
