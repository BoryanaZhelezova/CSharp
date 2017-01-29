using System;

class Hex_to_Decimal
{
    static void Main()
    {
        string hexNum = Console.ReadLine();
        long dNum = 0;
        

        long temp = 0;

        for (int i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[hexNum.Length -1 - i])
            {
                case 'A': temp = 10; break;
                case 'B': temp = 11; break;
                case 'C': temp = 12; break;
                case 'D': temp = 13; break;
                case 'E': temp = 14; break;
                case 'F': temp = 15; break;
                default: temp = -48 + (int)hexNum[hexNum.Length - 1 - i]; break;//// -48 because of ASCII
            }
            dNum += temp * (long)Math.Pow(16, i);
        }

        Console.WriteLine(dNum);
    }
}
