using System;

namespace Numbers_from_1_to_N
{
    class Program
    {
        static void Main()
        {
            int n;
            bool isInt = int.TryParse(Console.ReadLine(), out n);

            if (isInt)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Not valid entry");
            }


            
        }
    }
}
