﻿class Program
{
    static void Main()
    {
        byte v1 = 10;
        Console.WriteLine(v1);
        Console.WriteLine($"Byte Size : {sizeof(byte)} Minimum : {byte.MinValue} Maximum : {byte.MaxValue}");

        short v2 = 100;
        Console.WriteLine(v2);
        Console.WriteLine($"Short Size : {sizeof(short)} Minimum : {short.MinValue} Maximum : {short.MaxValue}");

        int v3 = 1000;
        Console.WriteLine(v3);
        Console.WriteLine($"Int Size : {sizeof(int)} Minimum : {int.MinValue} Maximum : {int.MaxValue}");

        long v4 = 10000;
        Console.WriteLine(v4);
        Console.WriteLine($"Long Size : {sizeof(long)} Minimum : {long.MinValue} Maximum : {long.MaxValue}");

        float v5 = 10000.456f;
        Console.WriteLine(v5);
        Console.WriteLine($"Float Size : {sizeof(float)} Minimum : {float.MinValue} Maximum : {float.MaxValue}");

        double v6 = 10000.456;
        Console.WriteLine(v6);
        Console.WriteLine($"Double Size : {sizeof(double)} Minimum : {double.MinValue} Maximum : {double.MaxValue}");

        decimal v7 = 10000.456m;
        Console.WriteLine(v7);
        Console.WriteLine($"Decimal Size : {sizeof(decimal)} Minimum : {decimal.MinValue} Maximum : {decimal.MaxValue}");

        bool v8 = true;
        Console.WriteLine($"Bool Size : {sizeof(bool)}");

        char division = 'A';
        Console.WriteLine(division);
        Console.WriteLine($"Char Size : {sizeof(char)}");

        char currency = '$';
        Console.WriteLine(currency);

        string name = "Vishal";
        Console.WriteLine(name);

        Console.ReadLine();
    }
}