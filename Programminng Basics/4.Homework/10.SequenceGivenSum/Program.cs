using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            Console.Write("Write 'Sum': ");
            int sum = int.Parse(Console.ReadLine());
            int start = 0;
            int sumNum = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                sumNum += array[i];
                start = i;

                for (int j = (i + 1); j < array.Length; j++)
                {
                    sumNum += array[j];

                    if (sumNum == sum)
                    {
                        for (int k = start; k <= j; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                sumNum = 0;
            }
            Console.WriteLine();
        }
    }
}
