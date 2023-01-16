class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.RollNumber = 1;
        s1.Name = "";
        s1.InsertStudentToDB();
        // s1.PrintS();

        Console.ReadLine();
    }
}