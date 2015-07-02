using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            //int[] array = { 1, 3, 4, 17, 2, 6, 5, 13 };

            Console.Write("Write the string(devided by space): ");
            string numbers = Console.ReadLine();
            string[] nums = numbers.Split(' ');
            int n = nums.Length;
            int[] array = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                int number = int.Parse(nums[i]);
                array[i] = number;
            }

            for (int first = 0; first < array.Length; first++)
            {
                for (int second = 0; second < array.Length; second++)
                {
                    if (array[second] < array[first])
                    {
                        int min = array[first];
                        array[first] = array[second];
                        array[second] = min;
                    }
                }
            }

            Console.Write("Selected: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
