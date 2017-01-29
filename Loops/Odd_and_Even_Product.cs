using System;

class Odd_and_Even_Product
{
    static void Main()
    {
        //anzahl
        int n = int.Parse(Console.ReadLine());
        ulong produktEven = 1;
        ulong produktOdd = 1;

        string str = Console.ReadLine();
        string[] string_numbers = str.Split(' ');

        for (int i = 0; i < string_numbers.Length; i++)
        { 
            if ((i + 1) % 2 == 0)
            {
                produktEven *= ulong.Parse(string_numbers[i]);
            }
            else
            {
                produktOdd *= ulong.Parse(string_numbers[i]);
            }
        }

        Console.WriteLine(produktOdd == produktEven ? "yes {0}" : "no {0} {1}", produktOdd, produktEven);
    }
}