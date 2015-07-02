using System;

class SumNumbers
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Number A: ");
            string numberA = Console.ReadLine();
            Console.Write("Number B: ");
            string numberB = Console.ReadLine();
            Console.Write("Number C: ");
            string numberC = Console.ReadLine();

            double numbers;
            if (double.TryParse(numberA, out numbers) &&
                double.TryParse(numberB, out numbers) &&
                double.TryParse(numberC, out numbers))
            {
                double numA = double.Parse(numberA);
                double numB = double.Parse(numberB);
                double numC = double.Parse(numberC);

                double sum = numA + numB + numC;
                Console.WriteLine("{0} + {1} + {2} = {3}", numA, numB, numC, sum);
            }
            else
            {
                Console.WriteLine("Error: You hadn`t entered a (double) number!");
            }

            Console.WriteLine();
        }
    }
}
