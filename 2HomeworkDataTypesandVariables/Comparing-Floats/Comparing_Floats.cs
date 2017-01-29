using System;

class Comparing_Floats
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        
        const double eps = 0.000001;

        double comp = Math.Abs(number1 - number2);

        if (comp >= eps)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}
/*
 * namespace _3.ComparisonOfFloatingPointNumbers
{
    class Program
    {
        static void Main()
        {
            bool result = false;
            //Console.WriteLine("\u2192");
            Console.WriteLine("Enter the first number:");
            double number1 = double.Parse(Console.ReadLine());
            //string sNumber1 = Convert.ToString(number1);
 
            Console.WriteLine("Enter the second number:");
            double number2 = double.Parse(Console.ReadLine());
 
            double deduction = number1 - number2;
            deduction = Math.Abs(deduction);
            Console.WriteLine(deduction);
            if (deduction < 0.000001)
            {
                result = true;
            }
            Console.WriteLine("({0};{1})\u2192{2}",number1,number2,result);
        }
    }
}
 */

