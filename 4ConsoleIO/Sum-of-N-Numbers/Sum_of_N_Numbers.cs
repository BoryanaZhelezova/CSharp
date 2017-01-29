using System;

class Sum_of_N_Numbers
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        double sum = 0.00;

        for (int i = 0; i < n; i++)
        {
            double num = Convert.ToDouble(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine(sum);
    }
}

