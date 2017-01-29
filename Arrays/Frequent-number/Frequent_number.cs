using System;

class Frequent_number
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int maxCount = int.MinValue;
        int currentCount = 1;
        int number = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        
        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                number = arr[i];
            }
        }
        if (n == 1)
        {
            maxCount = 1;
            number = arr[0];
        }
        Console.WriteLine("{0} ({1} times)", number, maxCount);
    }
}


