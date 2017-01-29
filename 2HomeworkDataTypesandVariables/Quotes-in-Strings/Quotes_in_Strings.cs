using System;

class Quotes_in_Strings
{
    static void Main()
    {
        string string1 = "The \"use\" of quotations causes difficulties.";
        string string2 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("{0}\n{1}", string1, string2);
    }
}

