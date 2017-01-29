using System;

class Prime_check
{
    static void Main()
    {
        string isPrime = "true";
        int num;
        bool isInt = int.TryParse(Console.ReadLine(), out num);

        if (isInt)
        {
            if (num <= 1)
            {
                isPrime = "false";
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = "false";
                    }
                }
            }
            Console.WriteLine(isPrime);
        }
    }
}
