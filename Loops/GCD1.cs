using System;

class GCD1
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int remainder;

        while (y != 0)
        {
            remainder = x % y;
            x = y;
            y = remainder;
        }
        Console.WriteLine("{0}", x);
    }
}

