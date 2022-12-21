class Program
{
    static void Main()
    {
        string firstName = "Anil";
        Console.WriteLine(firstName);

        //string firstNameInUpper = firstName.ToUpper();
        //Console.WriteLine(firstNameInUpper);

        Console.WriteLine(firstName.ToUpper());
        Console.WriteLine(firstName.ToLower());

        //string reverseName = firstName.Reverse().ToString();
        //Console.WriteLine(reverseName);

        Console.WriteLine(firstName.Length);

        firstName = "     Anil    ";
        Console.WriteLine(firstName.Trim());

        firstName = "\"Anil\"";
        Console.WriteLine(firstName);

        firstName = "\\Anil\\";
        Console.WriteLine(firstName);

        firstName = "Anil\nRathod";
        Console.WriteLine(firstName);

        firstName = "Anil\tRathod\\";
        Console.WriteLine(firstName);

        //string filePath = "E:\\Vikul Coach\\DOT NET TRAINING\\Batches\\Study Material\\Books - Edited";
        string filePath = @"E:\Vikul Coach\DOT NET TRAINING\Batches\Study Material\Books - Edited";
        Console.WriteLine(filePath);

        firstName = "Anil";
        string lastName = "Rathod";

        string fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);

        fullName = string.Concat(firstName, " ", lastName);
        Console.WriteLine(fullName);

        fullName = string.Join(',', firstName, lastName);
        Console.WriteLine(fullName);

        fullName = string.Format($"Full Name = {firstName} {lastName}");
        Console.WriteLine(fullName);

        Console.WriteLine($"FullName = {lastName},{firstName}");

        int a = 10, b = 10;
        Console.WriteLine(a + b);

        string n1 = a.ToString();
        string n2 = b.ToString();
        Console.WriteLine(n1 + n2);



        Console.ReadLine();
    }
}