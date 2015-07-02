using System;

class Fibonacci
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Write how many numbers of Fibonacci you need: ");
            string number = Console.ReadLine();
            int numbers;

            if (int.TryParse(number, out numbers))
            {
                int num = int.Parse(number);
                int numA = 0;
                int numB = 1;
                int result = 1;
                Console.Write("Result 0 1 ");

                for (int i = 0; i < (num - 2); i++)
                {
                    result = numA + numB;
                    numA = numB;
                    numB = result;

                    Console.Write( "{0} ", result);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error: You hadn`t written a (int) number!");
            }

            Console.WriteLine();
        }
    }
}
