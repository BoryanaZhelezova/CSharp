using System;
using System.Numerics;

class Binary_to_Decimal
{
    static void Main()
    {
        string text = Console.ReadLine();
        BigInteger numberInBinary = BigInteger.Parse(text);

        BigInteger lastBitValue = 0;
        BigInteger numberInDecimal = 0;

        for (int bitPos = 0; bitPos < text.Length; bitPos++)
        {
            lastBitValue = numberInBinary % 10;
            numberInBinary = numberInBinary / 10;
            numberInDecimal = numberInDecimal + lastBitValue * (BigInteger)Math.Pow(2, bitPos);
        }
        Console.WriteLine(numberInDecimal);
    }
}
/*            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();

            int result = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[charArray.Length - i - 1] == '1')
                {
                    // calculate 2 to the power of i and add it to result
                    result += 1 << i;
                }
            }

            //for (int i = charArray.Length - 1; i >= 0; i--)
            //{
            //    if (charArray[i] == '1')
            //    {
            //        result += 1 << charArray.Length - 1 - i;
            //    }
            //}

            Console.WriteLine(result);*/

