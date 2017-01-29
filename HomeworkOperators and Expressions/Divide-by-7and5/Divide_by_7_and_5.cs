using System;

class Divide_by_7_and_5
{
    static void Main()
    {
        int number;
        bool isInt = int.TryParse(Console.ReadLine(), out number);

        if (isInt)
        {
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("true {0}", number);
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
        else
        {
            Console.WriteLine("Not Valid entry");
        }

    }
}

