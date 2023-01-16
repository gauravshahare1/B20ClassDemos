partial class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }

    public Student()
    {
        // int i = PrintS();
        // use of i result
    }

    partial void PrintS();
}

interface IA
{
    void Print();
}

interface IB { }

class A { }
class B { }