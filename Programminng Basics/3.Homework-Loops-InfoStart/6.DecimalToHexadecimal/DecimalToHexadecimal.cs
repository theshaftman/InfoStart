using System;

class DecimalToHexadecimal
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
                //string hex = Convert.ToString(num, 16);

                Console.WriteLine("Hexadecimal number: {0:X}", num);
            }
            else
            {
                Console.WriteLine("Error: Wrong (long) number!");
            }
            Console.WriteLine();
        }
    }
}
