using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            char[] alphabetOne = new char[26]
            {
                'A', 'B', 'C', 'D', 'E', 'F',
                'G', 'H', 'I', 'J', 'K', 'L',
                'M', 'N', 'O', 'P', 'Q', 'R',
                'S', 'T', 'U', 'V', 'W', 'X',
                'Y', 'Z'
            };

            char[] alphabetTwo = new char[26]
            {
                'a', 'b', 'c', 'd', 'e', 'f',
                'g', 'h', 'i', 'j', 'k', 'l',
                'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x',
                'y', 'z'
            };

            Console.Write("Write characters: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabetOne.Length; j++)
                {
                    if (word[i] == alphabetOne[j] )
                    {
                        int number = j + 1;
                        Console.Write("{0} ", number);
                    }
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabetTwo.Length; j++)
                {
                    if (word[i] == alphabetTwo[j])
                    {
                        int number = j + 1;
                        Console.Write("{0} ", number);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
