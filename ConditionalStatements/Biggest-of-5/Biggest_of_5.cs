using System;

class Biggest_of_5
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double temp = a;

        if ((b > a) && (b > c) && (b > d) && (b > e))
        {
            temp = b;
        }
        else if ((c > a) && (c > b) && (c > d) && (c > e))
        {
            temp = c;
        }
        else if ((d > a) && (d > b) && (d > c) && (d > e))
        {
            temp = d;
        }
        else if ((e > a) && (e > b) && (e > c) && (e > d))
        {
            temp = e;
        }

        Console.WriteLine(temp);
    }
}
/*
 * using System;

namespace BiggestOf5
{
    class BiggestOf5
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
        {
            Console.WriteLine(a);
            return;
        }
        if ((b >= a) && (b >= c) && (b >= d) && (b >= c))
        {
            Console.WriteLine(b);
            return;
        }
        if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
        {
            Console.WriteLine(c);
            return;
        }
        if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
        {
            Console.WriteLine(d);
            return;
        }
        if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
        {
            Console.WriteLine(e);
            return;
        }
 */

