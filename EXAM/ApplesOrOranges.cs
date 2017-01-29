using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apples_Or_Oranges
{
    class ApplesOrOranges
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] c = new char[n.Length];
            c = n.ToCharArray();

            int sumOdd, sumEven;
            sumEven = sumOdd = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if ((c[i]) % 2 != 0)
                {

                    sumEven += c[i] - 48;

                }
                else //if ((c[i]) % 2 == 0)
                {
                    sumOdd += c[i] - 48;

                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("both {0}", sumEven);
            }
            else
            {
                Console.WriteLine(sumEven > sumOdd ? "orange " + sumEven : "apple " + sumOdd);
            }
            
        }
    }
}
