using System;

class Odd_or_Even
{
    static void Main()
    {
        int number;
        bool isInt = int.TryParse(Console.ReadLine(), out number);

        if (isInt)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("even {0} ", number);
            }
            else
            {
                Console.WriteLine("odd {0}", number);
            }
        }
        else
        {
            Console.WriteLine("Not valid entry");

        }
    }
}

