using System.Reflection;

class Program
{
    static void Main()
    {
        #region Student Class use at runtime

        ////Student s1 = new Student();
        ////s1.PrintA();

        //Assembly assembly = Assembly.GetExecutingAssembly();
        //Type studentType = assembly.GetType("Student");

        //MethodInfo printA = studentType.GetMethod("PrintA");

        //object s1 = Activator.CreateInstance(studentType);
        //printA.Invoke(s1, null);

        //MethodInfo printB = studentType.GetMethod("PrintB");
        //printB.Invoke(null, null);

        //MethodInfo printC = studentType.GetMethod("PrintC");
        //printC.Invoke(s1, new object[] { "Vishal" });

        //MethodInfo printD = studentType.GetMethod("PrintD", BindingFlags.NonPublic | BindingFlags.Instance);
        //printD.Invoke(s1, null);

        #endregion Student Class use at runtime

        Assembly assembly = Assembly.GetExecutingAssembly();
        Type customerType = assembly.GetType("Customer");

        MethodInfo[] methods = customerType.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }

        PropertyInfo[] properties = customerType.GetProperties();

        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.PropertyType} {property.Name}");
        }

        Console.ReadLine();
    }
}

public class Student
{
    public void PrintA()
    {
        Console.WriteLine("PrintA");
    }

    public static void PrintB()
    {
        Console.WriteLine("PrintB");
    }

    public void PrintC(string name)
    {
        Console.WriteLine($"PrintC : {name}");
    }

    void PrintD()
    {
        Console.WriteLine("PrintD");
    }
}

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Customer()
    {

    }

    public void PrintA() { }
}