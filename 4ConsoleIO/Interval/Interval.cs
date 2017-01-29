using System;

class Interval
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int interval = Math.Abs(m - n);

        for (int i = 1; i < interval; i++)
        {
            if ((n + i) % 5 == 0)
            {
                //Console.WriteLine(i);
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

