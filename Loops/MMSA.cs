using System;

class MMSA
{
    static void Main()
    {
        //anzahl
        int N = int.Parse(Console.ReadLine());

        double min = 1000;
        double max = -1000;
        double sum = 0;

        for (int i = 0; i < N; i++)
        {
            double n = double.Parse(Console.ReadLine());

            if (n > max)
            {
                max = n;
            }
            if (n < min)
            {
                min = n;
            }
            sum += n;
        }
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", sum/N);
    }
}
