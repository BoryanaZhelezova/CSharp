using System;

class Calculate
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1.0;
        ulong factorial = 1;

        for (ulong i = 1; i <= N; i++)
        {
            factorial *= i;
            sum += factorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}


/*Ne RAboti
 * using System.Numerics;
 *         double x = double.Parse(Console.ReadLine());
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        double sum = 1;

        for (BigInteger i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:f5", sum);
 */
