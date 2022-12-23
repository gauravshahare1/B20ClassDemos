class Program
{
    static void Main()
    {
        //string n = "100";
        //int i;
        //bool b = int.TryParse(n, out i);

        //string name = "Main";
        //Console.WriteLine(name); // Main
        //PrintA(name);
        //Console.WriteLine(name); // Main

        //string name = "Main";
        ////string name;
        ///*        Console.WriteLine(name);*/ // Main
        //PrintA(ref name);
        //Console.WriteLine(name); // PrintA

        int a = 10, b = 5, add, sub, mul, div;

        Operation(a, b, out add, out sub, out mul, out div);
        Console.WriteLine($"Addition : {add}");
        Console.WriteLine($"Substraction : {sub}");
        Console.WriteLine($"Multiplication : {mul}");
        Console.WriteLine($"Division : {div}");

        Console.ReadLine();
    }

    //static void PrintA(string name)
    //{
    //    name = "PrintA";
    //}

    //static void PrintA(ref string name)
    //{
    //    // name = "PrintA";
    //}

    static void Operation(int a, int b, 
        out int add, out int sub, out int mul, out int div)
    {
        add = a + b;
        sub = a - b;
        mul = a * b;
        div = a / b;
    }
}