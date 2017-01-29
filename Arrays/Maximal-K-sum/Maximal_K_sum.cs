using System;

class Maximal_K_sum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int maxSum = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        Array.Reverse(array);

        for (int i = 0; i < k; i++)
        {
            maxSum += array[i];
        }
        Console.WriteLine(maxSum);
    }
}

