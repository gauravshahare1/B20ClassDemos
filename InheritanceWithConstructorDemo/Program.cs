class Program
{
    static void Main()
    {
        // Person p1 = new Person();
        // Employee e1 = new Employee();
        // Person p2 = new Employee();

        // Employee e1 = new Employee("GOOD MORNING !!!");

        Employee e1 = new Employee("GOOD MORNING !!!", 1000);
        e1.Print();

        Console.ReadLine();
    }
}

class Mammals
{
    public Mammals()
    {
        Console.WriteLine("Mammals() Called");
    }
}

class Person // : Mammals
{
    public string Name = "Person";

    //public Person()
    //{
    //    Console.WriteLine("Person() Called");
    //}

    public Person(string message)
    {
        Console.WriteLine("Person(string message) Called");
    }

    public Person(int num)
    {
        Console.WriteLine($"Person(int num) : {num} Called");
    }
}
class Employee : Person
{
    public string Name = "Employee";

    //public Employee()
    //{
    //    Console.WriteLine("Employee() Called");
    //}

    // public Employee(string message) : base(message)
    public Employee(string message) : base(10)
    {
        Console.WriteLine("Employee(string message) Called");
    }

    public Employee(string message, int num) : base(num)
    {
        Console.WriteLine("Employee(string message, int num) Called");
    }

    public void Print()
    {
        // Console.WriteLine(Name); // Employee
        // Console.WriteLine(this.Name); // Employee
        Console.WriteLine(base.Name); // Person
    }
}