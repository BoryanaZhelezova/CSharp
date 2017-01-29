using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeds2016
{
    class Speeds
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            double s = 0.0;
            int biggestCount = 0;
            double biggestSpeed = 0.0;
            int tempCount = 0;
            double tempSpeed = 0.0;
            double groupSpeed = double.MaxValue;

            for (int i = 0; i < c; i++)
            {
                s = double.Parse(Console.ReadLine());

                if (s > groupSpeed)
                {
                    tempSpeed += s;
                    tempCount++;

                    if (tempCount > biggestCount || tempSpeed > biggestSpeed)
                    {
                        biggestCount = tempCount;
                        biggestSpeed = tempSpeed;
                    }
                }
                else
                {
                    tempCount = 1;
                    tempSpeed = s;
                    groupSpeed = s;

                    if (tempCount > biggestCount)
                    {
                        biggestCount = tempCount;
                        biggestSpeed = tempSpeed;
                    }
                }
            }

            Console.WriteLine(biggestSpeed);
        }
    }
}

