using System;

namespace Play_with_the_VS_Debugger
{
    class Program
    {
        static void Main()
        {
            int number = 0;
            for (int count = 1; count <= 1000; count++)
            {
                number = count;
                Console.WriteLine("{0}", number);
                Console.WriteLine("{0}", count %2 == 0 ? count : -count);
            }
        }

    }
}
