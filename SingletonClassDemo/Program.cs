class Program
{
    static void Main()
    {
        //Customer c1 = new Customer();
        //Customer c2 = new Customer();

        Customer c1 = Customer.Instance;
        Customer c2 = Customer.Instance;

        if (c1.Equals(c2))
        {
            Console.WriteLine("SAME");
        }
        else
        {
            Console.WriteLine("NOT SAME");
        }

        Customer c3 = Customer.Instance;

        //if (c2.Equals(c3))
        //{
        //    Console.WriteLine("SAME");
        //}
        //else
        //{
        //    Console.WriteLine("NOT SAME");
        //}

        Console.ReadLine();
    }
}

public class Customer
{
    static Customer _obj = null;
    static int _counter = 1;

    private Customer()
    {

    }

    public static Customer Instance
    {
        get
        {
            //if (_obj == null)
            //{
            //    _obj = new Customer();
            //}

            if (_obj == null || _counter <= 2)
            {
                _obj = new Customer();
                _counter++;
            }
            else
            {
                throw new Exception("Only Two Objects Are Possible");
            }

            return _obj;
        }
    }
}