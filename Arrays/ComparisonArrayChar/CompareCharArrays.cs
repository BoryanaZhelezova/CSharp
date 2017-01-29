using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareCharArrays
{
    static void Main()
    {
        string arrA = Console.ReadLine();
        string arrB = Console.ReadLine();

        bool areEqual = true;
        string result = string.Empty;

        int length = Math.Min(arrA.Length, arrB.Length);

        for (int i = 0; i < length; i++)
        {
            if (arrA[i] != arrB[i])
            {
                areEqual = false;
                result = (arrA[i] < arrB[i]) ? "<" : ">";
                break;
            }
            else
            {
                if (arrA.Length != arrB.Length)
                {
                    areEqual = false;
                    result = (arrA.Length < arrB.Length) ? "<" : ">";
                }
            }
        }
        Console.WriteLine(areEqual ? "=" : result);
    }
}

/*
 static void Main()
        {
            string s1 = Console.ReadLine(); string s2 = Console.ReadLine();

            string result = "=";

            int length = Math.Min(s1.Length, s2.Length);

            for (int i = 0; i < length; i++)
            {
                if (s1[i] < s2[i])
                {
                    result = "<"; break;
                }
                else if (s1[i] > s2[i])
                {
                    result = ">"; break;
                }
                else
                {
                    if (s1.Length > s2.Length)
                    {
                        result = ">";
                    }
                    else if (s1.Length < s2.Length)
                    {
                        result = "<";
                    }
                }
            }

            Console.WriteLine(result);
        }*/
