using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            Console.Write("Write array: ");
            string numbers = Console.ReadLine();

            string[] nums = numbers.Split(' ');
            int n = nums.Length;
            int[] array = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                array[i] = int.Parse(nums[i]);
            }

            int sum = 0;
            int mostFrequent = 1;
            int mostNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        sum++;
                    }
                }

                if (sum > mostFrequent)
                {
                    mostFrequent = sum;
                    mostNumber = array[i];
                }
                sum = 0;
            }
            Console.WriteLine("Result: Most frequent number is {0} ({1} times)", mostNumber, mostFrequent);
            Console.WriteLine();
        }
    }
}
