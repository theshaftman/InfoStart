using System;

class PrintCards
{
    static void Main()
    {
        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        char hearts = '\x03';
        char diamond = '\x04';
        char clubs = '\x05';
        char spades = '\x06';

        Console.WriteLine("All cards: ");
        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (j)
                {
                    case 1:
                        {
                            Console.Write("{0}{1} ", cards[i], clubs);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("{0}{1} ", cards[i], diamond);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("{0}{1} ", cards[i], hearts);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("{0}{1} ", cards[i], spades);
                            break;
                        }
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
