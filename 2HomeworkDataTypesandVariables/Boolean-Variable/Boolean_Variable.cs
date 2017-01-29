using System;

class Boolean_Variable
{
    static void Main()
    {
        Console.WriteLine("Are you female: ");
        Console.WriteLine("Type in random lowercase letter for \"yes\" and random uppercase letter for \"no\"");
        Console.WriteLine("Only the first letter on the line counts!");

        char check = (char)Console.Read();

        bool isFemale = false;

        if (Char.IsLetter(check))
        {
            if (Char.IsLower(check))
            {
                isFemale = true;
                Console.WriteLine("Statement {0}", isFemale);

            }
            else
            {
                Console.WriteLine("Maj sam...");
            }

        }
        else
        {
            Console.WriteLine("Input not correct!");
        }

    }
}

