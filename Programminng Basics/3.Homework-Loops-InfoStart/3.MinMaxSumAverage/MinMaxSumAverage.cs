using System;

class MinMaxSumAverage
{
    static void Main()
    {
        for (; ; )
        {
            Console.Write("Write the number of numbers: ");
            string number = Console.ReadLine();
            int numbers;

            if (int.TryParse(number, out numbers))
            {
                int num = int.Parse(number);
                int[] endNumbers = new int[num];

                for (int i = 0; i < num; i++)
                {
                    Console.Write("Write number: ");
                    string nums = Console.ReadLine();

                    if (int.TryParse(nums, out numbers))
                    {
                        int n = int.Parse(nums);
                        endNumbers[i] = n;
                    }
                    else
                    {
                        Console.WriteLine("Error: Wrong (int) number!");
                    }
                }
                Console.WriteLine();

                int minValue = Int32.MaxValue;
                int maxValue = Int32.MinValue;
                int sum = 0;
                for (int i = 0; i < endNumbers.Length; i++)
                {
                    if (endNumbers[i] < minValue)
                    {
                        minValue = endNumbers[i];
                    }
                    if (endNumbers[i] > maxValue)
                    {
                        maxValue = endNumbers[i];
                    }

                    sum += endNumbers[i];
                }
                float average = (float)sum / endNumbers.Length;

                Console.WriteLine("Min value: {0}", minValue);
                Console.WriteLine("Max value: {0}", maxValue);
                Console.WriteLine("Sum = {0}", sum);
                Console.WriteLine("Average: {0:F2}", average);
            }
            else
            {
                Console.WriteLine("Error: Not (int) number!");
            }
            Console.WriteLine();
        }
    }
}
