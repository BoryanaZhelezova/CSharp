using System;
 
class Decimal_to_Binary
{
    static void Main()
    {
        long dNum = long.Parse(Console.ReadLine());
        long remainder;

        string binary = string.Empty;

        while (dNum > 0)
        {
            remainder = dNum % 2;
            dNum /= 2;
            binary = remainder.ToString() + binary;
        }
        Console.WriteLine(binary);
    }
}

