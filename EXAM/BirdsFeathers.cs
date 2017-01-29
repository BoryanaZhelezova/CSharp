using System;
using System.Numerics;
using System.Threading;
using System.Globalization;

class BirdsFeathers
{
    static void Main()
    {
        BigInteger B = BigInteger.Parse(Console.ReadLine());
        BigInteger F = BigInteger.Parse(Console.ReadLine());

        double average = 0;
        double divide = (double)F / (double)B;

        if (B % 2 == 0)
        {
            average = divide * 123123123123;
        }
        else
        {
            
            average = divide / 317;
        }

        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        Console.WriteLine("{0:F4}", average);
    }
}

/*
 *             const ulong multiplier = 123123123123;
            const uint divisor = 317;

            ulong birdsCount = ulong.Parse(Console.ReadLine());
            ulong feathersCount = ulong.Parse(Console.ReadLine());

            if (birdsCount == 0 || feathersCount == 0)
            {
                Console.WriteLine("0.0000");
                return;
            }

            double feathersPerBird = (double)feathersCount / birdsCount;
            double result = birdsCount % 2 == 0 ? feathersPerBird * multiplier : feathersPerBird / divisor;

            Console.WriteLine("{0:F4}", result);
 */
