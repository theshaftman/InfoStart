using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            List<int> arrayA = new List<int>();
            List<int> arrayB = new List<int>();

            Console.Write("First Array: ");
            string firstArray = Console.ReadLine();
            string[] first = firstArray.Split(' ');

            Console.Write("Second Array: ");
            string secondArray = Console.ReadLine();
            string[] second = secondArray.Split(' ');

            int result = 0;

            for (int i = 0; i < first.Length; i++)
            {
                arrayA.Add(Convert.ToInt32(first[i]));
            }

            for (int i = 0; i < second.Length; i++)
            {
                arrayB.Add(Convert.ToInt32(second[i]));
            }

            int maxA = arrayA.Count;
            int maxB = arrayB.Count;

            if (maxA == maxB)
            {
                for (int i = 0; i < arrayA.Count; i++)
                {

                    if (arrayA[i] > arrayB[i])
                    {
                        result = 2;
                        break;
                    }
                    else if (arrayA[i] < arrayB[i])
                    {
                        result = 1;
                        break;
                    }
                }

                switch (result)
                {
                    case 0: Console.WriteLine("Arrays are equal!"); break;
                    case 1: Console.WriteLine("First array is First!"); break;
                    case 2: Console.WriteLine("Second array is First!"); break;
                }
            }
            else if (maxA > maxB)
            {
                Console.WriteLine("Error: First is Bigger!");
            }
            else
            {
                Console.WriteLine("Error: Second is Bigger!");
            }
            Console.WriteLine();
        }
    }
}
