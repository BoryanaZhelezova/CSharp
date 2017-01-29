using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Horror
{
    class TheHorror
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] c = new char[n.Length];
            c = n.ToCharArray();

            int sum = 0;
            int count = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                    sum += c[i]-48;
                    
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
        }

    }
}