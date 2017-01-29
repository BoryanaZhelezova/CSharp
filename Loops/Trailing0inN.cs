using System;
using System.Numerics;

// ne smqta za po-malko ot 5!

class Trailing0inN
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());

        BigInteger count = 0; // number of trailing zeros

        for (int i = 5; i <= N; i *= 5)
        {
            count += N / i;
        }

        Console.WriteLine(count);
    }
}

//BigInteger num = BigInteger.Parse(Console.ReadLine());

//BigInteger factorial = 1;
//BigInteger zero = 0;
//int sum = 5;

//        while (num >= sum)
//        {
//            factorial *= num;
//            num--;
//            zero += (num / sum);
//            sum *= 5;

//        }
//        Console.WriteLine(factorial);
//        Console.WriteLine(zero);

