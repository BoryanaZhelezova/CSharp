using System;

class Quadratic_Equation
{
    static void Main()
    {
        double a, b, c, x1, x2, d;
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());

        d = (b * b) - (4.0* a * c);

        if (d > 0)
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine(x1 < x2 ? x1.ToString("F2") + "\n" + x2.ToString("F2") : x2.ToString("F2") + "\n" + x1.ToString("F2"));
        }
        else if (d == 0)
        {
            x1 = x2 = -b / (2 * a);
            Console.WriteLine(x1.ToString("F2"));
        }
        else
        {
            Console.WriteLine("no real roots");
        }    
    }
}

