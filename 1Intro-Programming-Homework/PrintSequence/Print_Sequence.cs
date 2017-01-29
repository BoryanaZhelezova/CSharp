using System;

class Print_Sequence
{
    static void Main()
    {
        int numberPrint = 0;
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                numberPrint = i;
            }
            else
            {
                numberPrint = -i;
            }

            Console.WriteLine(numberPrint);
        }
    }
}