using System;

class FindMax
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Number A: ");
            string numberA = Console.ReadLine();
            Console.Write("Number B: ");
            string numberB = Console.ReadLine();
            double number;

            if (double.TryParse(numberA, out number) && double.TryParse(numberB, out number))
            {
                double numA = double.Parse(numberA);
                double numB = double.Parse(numberB);
                double max = Math.Max(numA, numB);

                Console.WriteLine("Greater: {0}", max);
            }
            else
            {
                Console.WriteLine("Error: You hadn`t entered a number!");
            }

            Console.WriteLine();
        }
    }
}
