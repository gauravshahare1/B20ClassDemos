class Program
{
    static void Main()
    {
        //A a1 = new A(); a1.Print(); // A
        //B b1 = new B(); b1.Print(); // B

        A a1 = new B(); a1.Print(); // A   B    B
        A a2 = new C(); a2.Print(); // A    B   C
        B b1 = new C();b1.Print(); // B     B   C

        // A = B - Ok
        // A = C - Ok
        // D = A - Not Ok 
        // A = D - Ok
        // B = D - Ok
        // D = C - Not Ok

        Console.ReadLine();
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
    //public new void Print()
    //{
    //    Console.WriteLine("B");
    //}
    public override void Print()
    {
        Console.WriteLine("B");
    }
}
class C : B
{
    //public new void Print()
    //{
    //    Console.WriteLine("C");
    //}
    public override void Print()
    {
        Console.WriteLine("C");
    }
}

class D : C
{
    public new void Print()
    {
        Console.WriteLine("D");
    }
}