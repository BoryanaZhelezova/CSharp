using System;

class Point_Circle_Rectangle
{
    static void Main()
    {
        double x, y;

        bool isValidX = double.TryParse(Console.ReadLine(), out x);
        bool isValidY = double.TryParse(Console.ReadLine(), out y);
        //double x = double.Parse(Console.ReadLine());
        //double y = double.Parse(Console.ReadLine());

        if (isValidX && isValidY)
        {
            bool insideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 2.25;
            bool insideRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);
            Console.Write(insideCircle ? "inside circle" : "outside circle");
            Console.WriteLine(insideRectangle ? " inside rectangle" : " outside rectangle");
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }

    }
}