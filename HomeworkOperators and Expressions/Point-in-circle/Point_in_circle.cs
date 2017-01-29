using System;

class Point_in_circle
{
    static void Main()
    {
        double x, y;
        bool isValidx = double.TryParse(Console.ReadLine(), out x);
        bool isValidy = double.TryParse(Console.ReadLine(), out y);

        if (isValidx && isValidy)
        {
            double p = x * x + y * y;
            if (p <= 4)
            {
                Console.WriteLine("yes {0}", Math.Sqrt(p).ToString("F2"));
            }
            else
            {
                Console.WriteLine("no {0}", Math.Sqrt(p).ToString("F2"));
            }
        }
    }
}

