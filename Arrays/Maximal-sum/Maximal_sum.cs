//https://github.com/BogdanDimov/CSharp-Homework-Part2/blob/master/MaximalSum/MaximalSum.cs
using System;

class Maximal_sum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxsum, beginmax, endmax, sum;
        maxsum = beginmax = sum =0;
        endmax = -1;

        for (int i = 0; i < n; i++)
        {
            sum = 0;

            for (int k = i; k < n; k++)
            {
                sum += array[k];
                if (sum > maxsum)
                {
                    maxsum = sum;
                    beginmax = i;
                    endmax = k;
                }
            }
        }
        Console.WriteLine(maxsum);
    }
}

