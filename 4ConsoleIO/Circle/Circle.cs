using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double p = 2 * Math.PI * r;
            double s = Math.PI * (Math.Pow(r, 2));

            Console.WriteLine("{0} {1}", p.ToString("F2"), s.ToString("F2"));
        }
    }
}
