using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden20130624
{
    class Garden
    {
        static void Main(string[] args)
        {
            int t1, t2, c1, c2, p1, p2, ca1, ca2, cab1, cab2, b;
            int area = 0;

            t1 = int.Parse(Console.ReadLine());
            t2 = int.Parse(Console.ReadLine());
            c1 = int.Parse(Console.ReadLine());
            c2 = int.Parse(Console.ReadLine());
            p1 = int.Parse(Console.ReadLine());
            p2 = int.Parse(Console.ReadLine());
            ca1 = int.Parse(Console.ReadLine());
            ca2 = int.Parse(Console.ReadLine());
            cab1 = int.Parse(Console.ReadLine());
            cab2 = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            double costs = t1 * 0.5 + c1 * 0.4 + p1 * 0.25 + ca1* 0.6 + cab1* 0.3 + b* 0.4;

            Console.WriteLine("Total costs: {0:F2}", costs);

            area = 250 - (t2 + c2 + p2 + ca2 + cab2);

            if (area > 0)
            {
                Console.WriteLine("Beans area : {0}", area);
            }
            else if (area == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
