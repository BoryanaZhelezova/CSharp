using System;

class Declare_Variables
{
    static void Main()
    {
        byte b1 = 97;
        sbyte b2 = -115;
        short b3 = -10000;
        ushort b4 = 52130;
        int b5 = 4825932;
        uint b6 = 4825932;
        long b7 = 4825932;
        ulong b8 = 4825932;


        //Float or Double
        double b9 = 34.567839023f;
        float b10 = 12.345f;
        double b11 = 8923.1234857f;
        float b12 = 3456.091f;

        Console.WriteLine("Numbers: {0} {1} {2} {3}", b9, b10, b11, b12);


        //Variable in Hexadecimal Format
        int numberHex = 0xFE;

        Console.WriteLine("HexadecimalCalculator {0}", numberHex);


        //Unicode Character
        int code = 42;
        Console.WriteLine("The hexadecimal representation of code 42 is: {0:X}", code);
        char symbol = '\u002A';
        Console.WriteLine("The symbol is: {0}", symbol);

        //Boolean Variable
        bool isFemale = true;
        Console.WriteLine(isFemale);
    }
}

