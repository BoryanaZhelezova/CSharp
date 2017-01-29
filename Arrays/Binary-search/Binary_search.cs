using System;

class Binary_search
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int numberX = int.Parse(Console.ReadLine());

        int counter = 0;
        int startIndex = 0;
        int endIndex = n - 1;
        int midIndex = (endIndex - startIndex) / 2;
        int result = -1;

        while (counter <= n/2)
        {
            if (array[midIndex] == numberX)
            {
                result = midIndex;
                break;
            }
            else if (array[midIndex] < numberX)
            {
                startIndex = midIndex + 1;
                midIndex = (endIndex + startIndex ) / 2;
                counter++;
            }
            else
            {
                endIndex = midIndex - 1;
                midIndex = (startIndex + endIndex) / 2;
                counter++;
            }
        }
        Console.WriteLine(result);

    }
}
