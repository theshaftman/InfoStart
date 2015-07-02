using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        for (; ; )
        {
            Console.Write("Write hexadecimal number: ");
            string number = Console.ReadLine();
            long num = Convert.ToInt64(number, 16);

            Console.WriteLine("{0}", num);
        }
    }
}
