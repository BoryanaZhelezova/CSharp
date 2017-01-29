using System;
using System.Numerics;

class Calculate_Again
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        BigInteger fact1, fact2;
        fact1 = fact2 = 1;

        for (int i = 1; i <= N; i++)
        {
            if (i<= K)
            {
                
                fact2 *= i;
            }

            fact1 *= i;
        }

        Console.WriteLine(fact1/fact2);
    }
}


