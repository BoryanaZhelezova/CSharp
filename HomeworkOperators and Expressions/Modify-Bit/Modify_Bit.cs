using System;

class Modify_Bit
{
    static void Main()
    {
        int P;
        ulong N;
        bool isValidN = ulong.TryParse(Console.ReadLine(), out N);
        bool isValidP = int.TryParse(Console.ReadLine(), out P);
        int value = int.Parse(Console.ReadLine());
        ulong mask = (ulong)1 << P;

        if (isValidN && isValidP)
        {
            if (value == 0)
            { 
                N = N & (~(mask));
            }
            else if (value ==1)
            {
                N = N | (mask);
            }
            Console.WriteLine("{0}", N);
        }
        else
        {
            Console.WriteLine("Not valid entry!");
        }
    }
}

