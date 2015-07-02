using System;

class DecimalToBinary
{
    static void Main()
    {
        for (; ; )
        {
            Console.Write("Write decimal number: ");
            string number = Console.ReadLine();
            long numbers;

            if (long.TryParse(number, out numbers))
            {
                long num = long.Parse(number);
                string bin = Convert.ToString(num, 2);

                Console.WriteLine("Binary number: {0}", bin);
            }
            else
            {
                Console.WriteLine("Error: Wrong (long) number!");
            }
            Console.WriteLine();
        }
    }
}
