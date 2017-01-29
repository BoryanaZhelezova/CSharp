using System;

class Exchange_numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double temp;

        if (a > b)
        {
            temp = b;
            b = a;
            a = temp;
        }
        Console.WriteLine(a + " " + b);
    }
}

