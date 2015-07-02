using System;

class Program
{
    static int BinarySearch(int[] arr, int search)
    {
        Array.Sort(arr);
        int max = arr.Length - 1;
        int min = 0;

        while (max >= min)
        {
            int midPoint = (min + max) / 2;
            if (arr[midPoint] < search)
            {
                min = midPoint + 1;
            }
            else if (arr[midPoint] > search)
            {
                max = midPoint - 1;
            }
            else
            {
                return midPoint;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 3, 12, 43, 25, 67, 2, 29, 36, 55, 21, 19, 18 };
        int search = 21;

        Console.WriteLine("In sorted array: {0}", BinarySearch(arr, search));
    }
}
