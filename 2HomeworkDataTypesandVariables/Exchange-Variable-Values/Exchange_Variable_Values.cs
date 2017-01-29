using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exchange_Variable_Values
{
    public static void Main()
    {
        //Third Variable
          int a = 5;
          int b = 10;

          Console.WriteLine("Declare \n{0}\n{1}", a, b);

          int temp = b;
          b = a;
          a = temp;

          Console.WriteLine("After: \n {0} {1}", a, b); 

        //Placeholder
       /* int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Before:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("After:");
        Console.WriteLine("a = {0}", b);
        Console.WriteLine("b = {0}", a);*/
    }
}

