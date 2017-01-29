using System;

class Fibonacci_Numbers
{
    static void Main()
    {
        uint n = Convert.ToUInt32(Console.ReadLine());
        long x1 = 0;
        long x2 = 1;
        long x3;

        Console.Write(x1 + ", " + x2);

        for (int i = 0; i < n - 2; i++)
        {
            x3 = x1 + x2;
            x1 = x2;
            x2 = x3;

            Console.Write(", " + x3);
        }
        Console.WriteLine();
    }
}


        //    ///VQRNO
        //    long iPrevious = -1;
        //    long iNext = 1;
        //    uint iNumber;

        //    iNumber = uint.Parse(Console.ReadLine());

        //    for (int i = 0; i < iNumber; i++)
        //    {

        //        long iSum = iNext + iPrevious;
        //        iPrevious = iNext;
        //        iNext = iSum;

        //        Console.Write(iSum + ", ");
        //    }
        //    Console.WriteLine();
        //}

 

    //int n = int.Parse(Console.ReadLine());

//if (n==1)
//{
//    Console.WriteLine(0);
//}
//else
//{
//    ulong x1 = 0;
//    ulong x2 = 1;
//    Console.WriteLine(x1 + ", " + x2);
//    ulong x3 = 0;

//    for (int i = 2; i < n; i++)
//    {
//        x3 = x1 + x2;
//        Console.Write(x3 + " ");
//        x1 = x2;
//        x2 = x3;
//    }

//}





//uint n = Convert.ToUInt32(Console.ReadLine());
//long x1 = 0;
//long x2 = 1;
//long x3;

//Console.Write(x1 + ", " + x2);

//for (int i = 0; i < n - 2; i++)
//{
//    x3 = x1 + x2;
//    x1 = x2;
//    x2 = x3;

//    Console.Write(", " + x3);
//}
//Console.WriteLine();



//uint N;

//N = Convert.ToUInt32(Console.ReadLine());

//long first = 0;
//long second = 1;
//long next;

//Console.Write(first + ", " + second);

//for (uint i = 0; i < N - 2; i++)
//{
//    next = first + second;

//    first = second;
//    second = next;

//    Console.Write(", " + next);
//}

//Console.WriteLine();
//

