using System;
class Third_digit
{
    static void Main()
    {
        int N;
        bool isValid = int.TryParse(Console.ReadLine(), out N);

        if (isValid)
        {
            int division = (N / 100) % 10;
            if (division == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", division);
            }
        }
    }
}

/*
class Third_digit
{
    static void Main()
    {
        int N;
        bool isValid = false;

        do
        {
            isValid = int.TryParse(Console.ReadLine(), out N);
        } while (!isValid);

        int division = (N / 100) % 10;

        if (division == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", division);
        }
    }
}
*/

/*
 class Third_digit
{
    static void Main()
    {
        int N;
        bool isValid = int.TryParse(Console.ReadLine(), out N);

        if (isValid)
        {
            if (N>0)
            {
                int division = (N / 100) % 10;
                if (division == 7)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false {0}", division);
                }
            }
        }
    }
}
*/
