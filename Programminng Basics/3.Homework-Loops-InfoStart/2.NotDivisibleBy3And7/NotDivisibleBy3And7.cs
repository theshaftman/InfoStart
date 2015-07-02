using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        for (; ; )
        {
            Console.Write("Write 'N': ");
            string number = Console.ReadLine();
            int numbers;

            if (int.TryParse(number, out numbers))
            {
                int num = int.Parse(number);

                Console.Write("Result: ");
                for (int i = 1; i <= num; i++)
                {
                    if ((i % 3 != 0) && (i % 7 != 0))
                    {
                        Console.Write("{0} ", i);
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error: You hadn`t written an (int) number!");
            }
            Console.WriteLine();
        }
    }
}
