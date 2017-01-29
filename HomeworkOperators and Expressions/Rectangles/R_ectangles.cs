using System;

class R_ectangles
{
    static void Main()
    {
        double area, perimeter;
        double width, height;

        bool isValidWidth = double.TryParse(Console.ReadLine(), out width);
        bool isValidHeight = double.TryParse(Console.ReadLine(), out height);

        if (isValidHeight && isValidWidth)
        {
            area = width * height;
            perimeter = 2 * width + 2 * height;

            Console.WriteLine("{0} {1}", area.ToString("F2"), perimeter.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Not Valid entry");
        }
    }
}

