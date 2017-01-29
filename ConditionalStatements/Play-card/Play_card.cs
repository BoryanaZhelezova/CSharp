using System;

class Play_card
{
    static void Main()
    {
        string card = Convert.ToString(Console.ReadLine());

        switch (card)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "A":
            case "K":
            case "J":
            case "Q":
                Console.WriteLine("yes"+" " + card);
                break;
            default:
                Console.WriteLine("no" + " "+ card);
                break;
        }
    }
}

