using System;

class From1ToN
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Write 'N': ");
            string number = Console.ReadLine();
            int numbers;

            if (int.TryParse(number, out numbers))
            {
                int num = int.Parse(number);

                for (int i = 1; i <= num; i++)
                {
                    Console.Write("{0} ", i);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error: You hadn`t written a number!");
            }

            Console.WriteLine();
        }
    }
}
