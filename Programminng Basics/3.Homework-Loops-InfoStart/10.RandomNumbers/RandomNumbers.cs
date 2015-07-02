using System;

class RandomNumbers
{
    static void Main()
    {
        for (; ; )
        {
            Console.Write("Write number of numbers 'n': ");
            string number = Console.ReadLine();
            Console.Write("Write 'Min': ");
            string minNumber = Console.ReadLine();
            Console.Write("Write 'Max': ");
            string maxNumber = Console.ReadLine();
            int numbers;

            if (int.TryParse(number, out numbers) &&
                int.TryParse(minNumber, out numbers) &&
                int.TryParse(maxNumber, out numbers))
            {
                int num = int.Parse(number);
                int min = int.Parse(minNumber);
                int max = int.Parse(maxNumber);
                Random randomNumber = new Random();

                Console.Write("Result: ");
                for (int i = 0; i < num; i++)
                {
                    int nums = randomNumber.Next(min, (max + 1));
                    Console.Write("{0} ", nums);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error: Wrong (int) number!");
            }
            Console.WriteLine();
        }
    }
}
