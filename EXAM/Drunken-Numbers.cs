using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drunken_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int r = int.Parse(Console.ReadLine());
            string s;


            int middle;
            int beersM, beersV;
            beersM = beersV = 0;

            for (int i = 0; i < r; i++)
            {
                s = Console.ReadLine();
                char[] c = new char[s.Length];
                c = s.ToCharArray();


                middle = s.Length / 2;


                if (s.Length % 2 != 0)
                {
                    for (int j = 0; j <= middle; j++)
                    {
                        beersM += (c[j] - 48);

                    }
                }
                else
                {
                    for (int j = 0; j < middle; j++)
                    {
                        beersM += (c[j] - 48);

                    }
                }

                for (int k = middle; k < s.Length; k++)
                {
                    beersV += (c[k] - 48);
                }

            }
            if (beersM != beersV)
            {
                Console.WriteLine(beersM > beersV ? "M " + (beersM - beersV) : "V " + (beersV - beersM));
            }
            else
            {
                Console.WriteLine("No " + (beersM + beersV));
            }
            
        }
    }
}
