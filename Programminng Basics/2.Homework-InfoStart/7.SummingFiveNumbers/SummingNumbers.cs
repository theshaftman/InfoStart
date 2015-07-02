using System;

class SummingNumbers
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Write 5 numbers divided by (space): ");
            string numbers = Console.ReadLine();

            string[] array = numbers.Split(' ');

            if (array.Length <= 5 && array.Length > 4)
            {
                int numB = 0;
                int result = 1;

                for (int i = 0; i < array.Length; i++)
                {
                    int num = int.Parse(array[i]);
                    result = num + numB;
                    numB = result;

                    Console.Write("{0}+", array[i]);
                }

                Console.WriteLine("= {0}", result);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error: You had written MORE or LESS than 5 numbers!");
            }
            
            Console.WriteLine();
        }
    }
}
