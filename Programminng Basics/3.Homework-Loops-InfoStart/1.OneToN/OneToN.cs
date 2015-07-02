using System;

class OneToN
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
                    Console.Write("{0} ", i);
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
