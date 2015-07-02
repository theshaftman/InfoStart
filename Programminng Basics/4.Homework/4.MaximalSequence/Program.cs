using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 2, 1, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int count = 0;
        int countMax = 1;
        int len = 1;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                len++;
            }
            if (numbers[i] != numbers[i + 1])
            {
                len = 1;
            }
            if (len > countMax)
            {
                countMax = len;
                count = numbers[i];
            }
        }
        Console.WriteLine("The longest sequence is {0} \"{1}\"", countMax, count);
        Console.WriteLine();
    }
}
