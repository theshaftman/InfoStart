using System;
using System.Collections.Generic;

class OddOrEvenProduct
{
    static void Main()
    {
        for (; ; )
        {
            Console.Write("Write your numbers(divided by space): ");
            string number = Console.ReadLine();

            string[] nums = number.Split(' ');
            List<int> numsInts = new List<int>();
            string result = "yes";
            int n;

            for (int i = 0; i < nums.Length; i++)
            {
                int numbers;

                if (int.TryParse(nums[i], out numbers))
                {
                    n = int.Parse(nums[i]);
                    numsInts.Add(n);
                }
            }
            int evenProduct = 1;
            int oddProduct = 1;

            for (int i = 0; i < numsInts.Count; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= numsInts[i];
                }
                else
                {
                    evenProduct *= numsInts[i];
                }
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine(result);
                Console.WriteLine("Product = {0}", evenProduct);
            }
            else
            {
                result = "no";
                Console.WriteLine(result);
                Console.WriteLine("Odd product = {0}", oddProduct);
                Console.WriteLine("Even product = {0}", evenProduct);
            }
            Console.WriteLine();
        }
    }
}
