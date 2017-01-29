using System;

class Compare_arrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int[] arrayM = new int[n];


        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            arrayM[i] = int.Parse(Console.ReadLine());
        }

        bool equal = true;

        for (int j = 0; j < n; j++)
        {
            if (arrayM[j] != array[j])
            {
                equal = false;
                break;
            }
        }
        if (equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}


