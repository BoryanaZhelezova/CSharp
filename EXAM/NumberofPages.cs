using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberofPages
{
    class NumberofPages
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            int N = 0;

            while (D > 0)
            {
                N++;
                int currentPage = N;
                while (currentPage > 0)
                {
                    D--;
                    currentPage /= 10;
                }
            }

            Console.WriteLine(N);
        }
    }
}
