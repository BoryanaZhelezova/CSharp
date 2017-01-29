using System;

class Int_Double_String
{
    static void Main()
    {
        int a;
        double b;
        string text, input;

        input = Console.ReadLine();

        if (input == "integer")
        {
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + 1);
        }
        else if (input == "real")
        {
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:F2}", b + 1);
        }
        else if (input == "text")
        {
            text = Console.ReadLine();
            Console.WriteLine(text + "*");
        }
    }
}

