class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine($"You entered: {input}");

        //if(input == 10)
        //{
        //    Console.WriteLine("TEN");
        //}
        //else
        //{
        //    Console.WriteLine("NOT TEN");
        //}

        //string result = (input == 10) ? "TEN" : "NOT TEN";
        //Console.WriteLine(result);

        //if (input == 10)
        //{
        //    Console.WriteLine("TEN");
        //}
        //else if (input == 20)
        //{
        //    Console.WriteLine("TWENTY");
        //}
        //else if (input == 30)
        //{
        //    Console.WriteLine("THIRTY");
        //}
        //else
        //{
        //    Console.WriteLine("NOT 10 20 or 30");
        //}

        switch (input)
        {
            case 5:
            case 10:
                Console.WriteLine("FIVE or TEN");
                break;            
            case 20:
                Console.WriteLine("TWENTY");
                break;
            case 30:
                Console.WriteLine("THIRTY");
                break;
            default:
                Console.WriteLine("NOT 10 20 or 30");
                break;
        }

        if(input % 2 == 0)
        {
            Console.WriteLine($"{input} is EVEN NUMBER");
        }
        else
        {
            Console.WriteLine($"{input} is ODD NUMBER");
        }

        Console.ReadLine();
    }
}