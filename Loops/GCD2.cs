using System;

class GCD2
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int a = Math.Abs(int.Parse(input[0]));
        int b = Math.Abs(int.Parse(input[1]));

        int temp = a;

        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            else
            {
                temp = a;
                a = b % a;
                b = temp;
            }
        }

        Console.WriteLine(a == 0 ? b : a);
    }
}

