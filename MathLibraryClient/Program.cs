using l1 = Library1;
using Library2;
using Library2.LibraryV2;

class Program
{
    static void Main()
    {
        // Library1.Calculator c1 = new Library1.Calculator();
        l1.Calculator c1 = new l1.Calculator();
        int result = c1.Add(10, 10);
        Console.WriteLine(result);

        // Library2.Calculator c2 = new Library2.Calculator();
        Calculator c2 = new Calculator();
        result = c2.Sub(10,10);
        Console.WriteLine(result);

        Utility u = new Utility();
        result = u.GetOtp();
        Console.WriteLine(result);

        A a1 = new A();

        Console.ReadLine();
    }
}