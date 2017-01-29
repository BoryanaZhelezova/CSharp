using System;

class Matrix_of_Numbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int row = 0; row < N; row++)
        {
            for (int col = 1; col < N + 1; col++)
            {
                if (col + row > 9)
                {
                    Console.Write("{0} ", col + row);
                }
                else
                {
                    Console.Write("{0}  ", col + row);
                }
            }

            Console.Write("{0} ", row);
            Console.WriteLine();
        }

    }
}


