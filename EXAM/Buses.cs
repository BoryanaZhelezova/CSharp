using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    class Buses
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            int groupNumber = 0;
            int groupSpeed = int.MaxValue;

            for (int i = 0; i < c; i++)
            {
                int busSpeed = int.Parse(Console.ReadLine());

                if (busSpeed <= groupSpeed)
                {
                    groupNumber++;
                    groupSpeed = busSpeed;
                }
            }
            Console.WriteLine(groupNumber);
        }
    }
}

