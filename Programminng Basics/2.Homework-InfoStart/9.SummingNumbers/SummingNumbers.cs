using System;

class SummingNumbers
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Write count of numbers: ");
            string count = Console.ReadLine();
            int numbers;

            if (int.TryParse(count, out numbers))
            {
                int cou = int.Parse(count);
                double result = 1;
                double numB = 0;

                for (int i = 0; i < cou; i++)
                {
                    Console.Write("Write number: ");
                    string number = Console.ReadLine();
                    double numsDouble;

                    if (double.TryParse(number, out numsDouble))
                    {
                        double num = double.Parse(number);
                        result = num + numB;
                        numB = result;
                    }
                    else
                    {
                        Console.WriteLine("Error: Wrong number!");
                        break;
                    }
                }

                Console.WriteLine("Sum = {0}", result);
            }
            else
            {
                Console.WriteLine("Error: You hadn`t written count correctly!");
            }
            Console.WriteLine();
        }
    }
}
