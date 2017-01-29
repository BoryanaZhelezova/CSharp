using System;

class N_th_Bit
{
    static void Main()
    {
        long p;
        int n;
        bool isValidP = long.TryParse(Console.ReadLine(), out p);
        bool isValidN = int.TryParse(Console.ReadLine(), out n);

        if (isValidN && isValidP)
        {
            Console.WriteLine(((p >> n) & 1) == 0 ? "0" : "1");
        }
        else
        {
            Console.WriteLine("Not valid entry");
        }
    }
}

