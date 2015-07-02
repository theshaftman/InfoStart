using System;

class MatrixOfNumbers
{
    static void Main()
    {
        for (; ; )
        {
            Console.Write("Write 'n': ");
            string number = Console.ReadLine();
            int numbers;

            if (int.TryParse(number, out numbers))
            {
                int num = int.Parse(number);
                int build = 1;

                if ((num <= 20) && (num > 0))
                {
                    for (int row = 1; row <= num; row++)
                    {
                        build = row;

                        for (int col = 1; col <= num; col++)
                        {
                            Console.Write("{0, -2} ", build);
                            build++;
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Error: Number is OVER 20 or LESS than 1!");
                }
            }
            else
            {
                Console.WriteLine("Error: Wrong (int) number!");
            }
            Console.WriteLine();
        }
    }
}
