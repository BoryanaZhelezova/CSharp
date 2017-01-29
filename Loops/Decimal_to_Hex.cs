using System;

class Decimal_to_Hex
{
    static void Main()
    {
        long dNum = long.Parse(Console.ReadLine());
        long remainder;

        string hex = string.Empty;
        string temp = string.Empty;

        while (dNum > 0)
        {
            remainder = dNum % 16;            

            if (remainder < 10)
            {
                hex += remainder.ToString();
            }
            else
            {
                switch (remainder)
                {
                    case 10: temp = "A"; break;
                    case 11: temp = "B"; break;
                    case 12: temp = "C"; break;
                    case 13: temp = "D"; break;
                    case 14: temp = "E"; break;
                    case 15: temp = "F"; break;
                   
                }
                hex += temp.ToString();
            }
            dNum /= 16;
        }

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            Console.Write(hex[i]);
        }
        Console.WriteLine();
    }
}

