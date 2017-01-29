using System;
using System.Numerics;

class Calculate_3
{
    static void Main()
    {
        //N! / (K! * (N - K)!)

        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        BigInteger fact1, fact2, fact3;

        fact1 = fact2 = fact3 = 1;


        for (int i = 1, j = 1; i <= N; i++)
        {
            if (j < K)
            {
                j++;
                fact2 *= j;
            }

            fact1 *= i;
        }

        for (int i = 1; i <= (N-K); i++)
        {
            fact3 *= i;
        }

        Console.WriteLine(fact1 / (fact2 * fact3));
    }
}

