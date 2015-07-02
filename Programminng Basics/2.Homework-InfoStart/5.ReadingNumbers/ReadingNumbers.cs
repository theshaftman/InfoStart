using System;

class ReadingNumbers
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Number A(int): ");
            string numberA = Console.ReadLine();
            Console.Write("Number B(float): ");
            string numberB = Console.ReadLine();
            Console.Write("Number C(float): ");
            string numberC = Console.ReadLine();
            int numbersInt;
            float numbersFloat;

            if (int.TryParse(numberA, out numbersInt) &&
                float.TryParse(numberB, out numbersFloat) && 
                float.TryParse(numberC, out numbersFloat))
            {
                int numA = int.Parse(numberA);
                float numB = float.Parse(numberB);
                float numC = float.Parse(numberC);

                if (numA >= 0 && numA <= 500)
                {
                    string binA = Convert.ToString(numA, 2);
                    Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:F3}|", numA, binA, numB, numC);
                }
                else
                {
                    Console.WriteLine("Error: 0 >= 'A' >= 500!");
                }
            }
            else
            {
                Console.WriteLine("Error: Wrong number!");
            }

            Console.WriteLine();
        }
    }
}
