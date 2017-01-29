using System;

class Isosceles_Triangle
{
    static void Main()
    {
        int spaces = 4;
        int Az = 1;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < spaces; j++)
            {
                Console.Write("   ");
            }
            for (int j = 0; j < Az; j++)
            {
                Console.Write("\u00A9");
            }
            Console.WriteLine();
            Az++;
            spaces--;
        }

        /*
        Console.WriteLine("         \u00A9     ");
        Console.WriteLine("      \u00A9  \u00A9");
        Console.WriteLine("    \u00A9      \u00A9");
        Console.WriteLine(" \u00A9      \u00A9      \u00A9     \u00A9");
        */
    }

}

