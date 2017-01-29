using System;

class Not_Divisible_Numbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 7 !=0 && i % 3 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}

