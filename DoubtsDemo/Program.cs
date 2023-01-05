using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Starts");
        
        Console.WriteLine($"Welcome, {args[0]}");

        return;

        Console.WriteLine("Main Ends");

        //string name = "Vishal";
        //char[] reverseName = name.Reverse().ToArray();
        //string result = new string(reverseName);
        //Console.WriteLine($"Input : {name} Output : {result}");

        // Student.PrintInstituteDetails();
        //Fact(5);

        //int result = Factorial(5);
        //Console.WriteLine(result); // 120

        // ParentMethod();

        //A a1 = new B();
        //a1.Print(); // A

        //A a2 = new D();
        //a2.Print(); // A    B

        //Console.WriteLine("Please enter a number");
        //int num = Convert.ToInt32(Console.ReadLine());
        //double result= Math.Sqrt(num);

        //Console.WriteLine($"{num} is square of {result}");

        //Student s1 = new Student();
        //Student s2 = new Student();
        //Student s3 = s1; // s1 & s3 will point to same object

        //Employee e1 = new Employee();
        //e1.Print();

        Console.ReadLine();
    }

    static void Fact(int num)
    {
        int result = 1;
        for (int i = num; i > 0; i--)
        {
            result *= i;
        }
        Console.WriteLine($"Factorial of Number {num} is {result}");
    }

    static int Factorial(int num)
    {
        if (num == 1)
            return 1;

        return num * Factorial(num - 1);
    }

    static void ParentMethod()
    {
        Console.WriteLine("Parent Method Called");

        static void ChildMethod()
        {
            Console.WriteLine("Child Method Called");
        }

        ChildMethod();
    }

    static void PrintA(int a = 10, params int[] numbers)
    {

    }

}

class Student
{
    public string FirstName;
    public string LastName;
    public static string CourseName;
    public static string TrainerName;

    public void Print()
    {
        Console.WriteLine("Print");
    }

    public static void PrintInstituteDetails()
    {
        Student s = new Student();
        s.Print();

        Console.WriteLine($"Course Name : {CourseName} Trainer Name : {TrainerName}");
    }
}


class A
{
    public virtual void Print()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("B");
    }
}

class C : A
{
    public override void Print()
    {
        Console.WriteLine("C");
    }
}

//class D : B, C
//{

//}

class Person
{
    public void Print() { }
}

class Employee : Person
{
    public void Print(string message) { }
}