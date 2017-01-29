using System;

class Moon_Gravity
{
    static void Main()
    {
        double number = Convert.ToDouble(Console.ReadLine());

        if (number > 0 && number < 1000)
        {
            double wl = number * 0.17;
            Console.WriteLine(wl.ToString("F3"));
        }
    }
}

