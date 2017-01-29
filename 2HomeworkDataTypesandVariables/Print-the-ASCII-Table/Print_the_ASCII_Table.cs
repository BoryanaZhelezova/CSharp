using System;

class Print_the_ASCII_Table
{
    static void Main()
    {
         for (char c = (char)033; c<=(char)126; c++)
         {
             Console.Write(c);
         }
    }
}

//for (int i = 33; i <= 126; i++)
//{
//    Console.Write((char)i);
//}