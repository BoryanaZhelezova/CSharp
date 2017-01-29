using System;

class Trapezoids
{
    static void Main()
    {
        double a, b, height;
        double area;

        bool isValida = double.TryParse(Console.ReadLine(), out a);
        bool isValidb = double.TryParse(Console.ReadLine(), out b);
        bool isValidHeight = double.TryParse(Console.ReadLine(), out height);

        if (isValidHeight && isValida && isValidb)
        {
            area = ((a + b) / 2) * height;

            Console.WriteLine("{0}", area.ToString("F7"));
        }
        else
        {
            Console.WriteLine("Not Valid entry");
        }
    }
}

