using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MMSA_1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("min = {0}", array.Min());
        Console.WriteLine("max = {0}", array.Max());
        Console.WriteLine("sum = {0}", array.Sum());
        Console.WriteLine("avg = {0:F2}", array.Average());
    }
}

