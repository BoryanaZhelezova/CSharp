using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.Write(Convert.ToString(a , 16).PadLeft(10, ' ').ToUpper());
        Console.Write("|" + Convert.ToString(a, 2).PadLeft(10, '0') + "|");

        Console.Write("{0, 10:F2}" + "|", b);
        Console.WriteLine("{0, -10:F3}" + "|", c);
    }
}

