using System;

class BitExchange
{
    static void Main()
    {
        uint n;
        bool isInt = uint.TryParse(Console.ReadLine(), out n);

        if (isInt)
        {
            n = ((~(7u << 24 | 7u << 3)) & n) | (((n & (7u << 3)) << 21) | ((n & (7u << 24)) >> 21));
            Console.WriteLine("{0}", n);
        }
        else
        {
            Console.WriteLine("Not valid entry!");
        }
    }
}

