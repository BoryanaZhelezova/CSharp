using System;
using System.Numerics;

class Catalan_Numbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        BigInteger fact1, fact2;
        fact1 = fact2 = 1;

        for (int i = 1; i <= 2*N; i++)
        {
            fact1 *= i;
            
        }
        for (int i = 1; i <= N; i++)
        {
            fact2 *= i;
        }
        
        Console.WriteLine(fact1 / (fact2 * (fact2 * (N+1))));
    }
}

