class Program
{
    static void Main()
    {
        #region array - single dimensional array

        //string n1 = "Mahesh";
        //string n2 = "Sartaj";
        //string n3 = "Shyam";
        //string n4 = "Shakil";

        //// string[] names;
        //// string[] names = new string[5];
        //string[] names = new string[] { "Mahesh", "Sartaj", "Shyam", "Shakil" };

        //Console.WriteLine(names[0]); // Mahesh
        //Console.WriteLine(names[2]); // Shyam
        //// Console.WriteLine(names[4]); // IndexOutOfRangeException
        //// names[4] = "Pramila"; // IndexOutOfRangeException

        //for (int i = 0; i < names.Length; i++)
        //{
        //    Console.Write($"{names[i]} ");
        //}

        //Console.WriteLine(); // new line

        //// int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] % 2 == 0)
        //    {
        //        Console.WriteLine($"{numbers[i]} : EVEN");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{numbers[i]} : ODD");
        //    }
        //}

        //int[] nums = { 10, 45, 213, 78, 213, 75, 111 };
        //// Console.WriteLine($"Highest numbers is : {nums[3]}");
        //int highestNumber = 0;

        //for(int i = 0; i < nums.Length; i++)
        //{
        //    highestNumber = nums[i];

        //    for (int j = 0; j < nums.Length; j++)
        //    {
        //        if (nums[i] == nums[j])
        //            continue;

        //        if (nums[j] > highestNumber)
        //        {
        //            highestNumber = nums[j];
        //        }
        //    }
        //    //  { 10, 45, 213, 78, 55, 75, 111 }
        //}

        //Console.WriteLine($"Highest Number : {highestNumber}");

        #endregion array - single dimensional array

        // string[] names = { "Mahesh", "Prakash", "Vikas"};

        string[,] names = {
            { "Mahesh", "M" },
            { "Prakash", "P" },
            { "Vikas", "V" }
        };

        for(int i = 0; i < 3; i++)
        {
            for(int j= 0; j < 2; j++)
            {
                Console.Write($"{names[i,j]} ");
            }
            Console.WriteLine(); // new line
        }

        Console.ReadLine();
    }
}