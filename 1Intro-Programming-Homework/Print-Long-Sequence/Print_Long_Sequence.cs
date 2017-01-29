using System;

class Print_Long_Sequence
{
    static void Main()
    {
        int numberPrint = 0;

        for (int count = 2; count < 1002; count++)
        {
            if (count % 2 == 0)
            {
                numberPrint = count;
            }
            else
            {
                numberPrint = -count;
            }

            Console.WriteLine(numberPrint);

        }
    }

}