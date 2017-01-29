using System;

class Four_digits
{
    static void Main()
    {
        int fourDigitN;
        bool isValid = int.TryParse(Console.ReadLine(), out fourDigitN);

        if (isValid)
        {
            int firstN = fourDigitN % 10;
            int secondN = (fourDigitN / 10) % 10;
            int thirdN = (fourDigitN / 100) % 10;
            int fourth = (fourDigitN / 1000) % 10;

            if (fourth != 0)
            {
                Console.WriteLine(fourth + thirdN + secondN + firstN);

                Console.WriteLine((firstN * 1000 + secondN * 100 + thirdN * 10 + fourth).ToString("D4"));

                Console.WriteLine((firstN * 1000 + fourth * 100 + thirdN * 10 + secondN).ToString("D4"));

                Console.WriteLine((fourth * 1000 + secondN * 100 + thirdN * 10 + firstN).ToString("D4"));
            }
            else
            {
                Console.WriteLine("Not valid entry");
            }
        }
    }
}

