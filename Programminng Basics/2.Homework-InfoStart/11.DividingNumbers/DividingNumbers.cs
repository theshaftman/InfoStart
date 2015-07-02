using System;

class DividingNumbers
{
    static void Main()
    {
        while (true)
        {
            Console.Write("First number: ");
            string firstNum = Console.ReadLine();
            Console.Write("End number: ");
            string endNum = Console.ReadLine();
            int numbers;

            if (int.TryParse(firstNum, out numbers) && int.TryParse(endNum, out numbers))
            {
                int endNumber = int.Parse(endNum);
                int p = 0;
                Console.Write("Result: ");
                int firstNumber = int.Parse(firstNum);

                for (; firstNumber <= endNumber; firstNumber++)
                {
                    int num = 5;
                    if (firstNumber % num == 0)
                    {
                        p += 1;
                        Console.Write("{0} ", firstNumber);
                    }
                }

                Console.WriteLine("\nNumbers 'p': {0}", p);
            }
            else
            {
                Console.WriteLine("Error: Numbers are NOT (int)!");
            }

            Console.WriteLine();
        }
    }
}
