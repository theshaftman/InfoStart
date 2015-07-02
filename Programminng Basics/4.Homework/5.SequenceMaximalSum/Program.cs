using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            //int[] numbers = { 3, 2, 3, 4, 2, 2, 4, 5, 6, 2 };

            Console.Write("Wrie array(divided by space): ");
            string num = Console.ReadLine();
            string[] nums = num.Split(' ');
            int[] numbers = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = Convert.ToInt32(nums[i]);
            }

            int counter = 1;
            int maxCounter = 1;
            int index = 0;
            int startIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startIndex = index;
                    }
                }
                else
                {
                    counter = 1;
                    index = i;
                }
            }

            int endIndex = startIndex + maxCounter;

            Console.Write("Result: ");
            for (int i = startIndex; i < endIndex; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

            if (counter > maxCounter)
            {
                maxCounter = counter;
            }
            Console.WriteLine("\n{0} increasing numbers", maxCounter);
            Console.WriteLine();
        }
    }
}
