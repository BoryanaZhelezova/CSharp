using System;

class ThirdBit
{
    static void Main()
    {
        int number;
        bool isInt = int.TryParse(Console.ReadLine(), out number);

        if (isInt)
        {
            Console.WriteLine(((number >> 3) & 1) == 0 ? "0" : "1");
        }
        else
        {
            Console.WriteLine("Not valid entry!");
        }
    }
}

//using System;

//class ThirdBit
//{
//    static void Main()
//    {
//        uint number;
//        bool isInt = uint.TryParse(Console.ReadLine(), out number);

//        uint remainder;
//        string result = string.Empty;

//        if (isInt)
//        {
//            Console.WriteLine(((number >> 3) & 1) == 0 ? "0" : "1");

//            while (number > 0)
//            {
//                remainder = number % 2;
//                number /= 2;
//                result = remainder.ToString() + result;
//            }
//            Console.WriteLine("binary {0}", result);
//        }
//        else
//        {
//            Console.WriteLine("Not valid entry!");
//        }
//    }
//}