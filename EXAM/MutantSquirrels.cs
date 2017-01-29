using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MutantSquirrels201625Apr
{
    class MutantSquirrels
    {
        static void Main(string[] args)
        {
            long T, B, S, N;

            T = long.Parse(Console.ReadLine());
            B = long.Parse(Console.ReadLine());
            S = long.Parse(Console.ReadLine());
            N = long.Parse(Console.ReadLine());

            decimal result = 0;

            decimal multi = T * B * S * N;

            if (multi % 2 == 0)
            {
                result = multi * 376439;
            }
            else
            {
                result = multi / 7;
            }
            Console.WriteLine("{0:F3}", result);
        }
    }
}
