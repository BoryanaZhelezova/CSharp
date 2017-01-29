using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_American_Pie2013
{
    class Problem1AmericanPie
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            long div1 = a * d + c * b;
            long div2 = b * d;

            decimal sum = ((decimal)div1 / div2);

            if (sum >=1)
            {
                Console.WriteLine((long)sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
            Console.WriteLine(div1 + "/" + div2);

        }
    }
}
/*
 *             double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double sum = (a/b) + (c/d);

            double div1 = a * d + c * b;
            double div2 = b * d;
            Console.WriteLine("{0}/{1}", div1, div2);

            if (sum >= 1)
            {
                sum = (int)sum;

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
 */
