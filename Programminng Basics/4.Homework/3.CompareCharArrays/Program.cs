using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("First Array(devided by space): ");
            string arrayFirst = Console.ReadLine();
            char[] arrayA = arrayFirst.ToCharArray();
            int firstLength = arrayA.Length;

            Console.Write("Second Array(devided by space): ");
            string arraySecond = Console.ReadLine();
            char[] arrayB = arraySecond.ToCharArray();
            int secondLength = arrayB.Length;

            string result = "0";

            if (firstLength == secondLength)
            {
                for (int i = 0; i < arrayA.Length; i++)
                {
                    if (arrayA[i] > arrayB[i])
                    {
                        result = "2";
                        break;
                    }
                    else if (arrayA[i] < arrayB[i])
                    {
                        result = "1";
                        break;
                    }
                }

                switch (result)
                {
                    case "0": Console.WriteLine("Arrays are equal!"); break;
                    case "1": Console.WriteLine("First array is First!"); break;
                    case "2": Console.WriteLine("Second array is First!"); break;
                }
            }
            else if (firstLength > secondLength)
            {
                Console.WriteLine("Error: First array is Bigger!");
            }
            else
            {
                Console.WriteLine("Error: Second is Bigger!");
            }
            Console.WriteLine();
        }
    }
}
