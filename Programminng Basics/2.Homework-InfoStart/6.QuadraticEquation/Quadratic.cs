using System;

class Quadratic
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculate roots of \"ax^2 + bx + c = 0\".");
            Console.Write("Number 'a': ");
            string numberA = Console.ReadLine();
            Console.Write("Number 'b': ");
            string numberB = Console.ReadLine();
            Console.Write("Number 'c': ");
            string numberC = Console.ReadLine();
            double number;

            if (double.TryParse(numberA, out number) &&
                double.TryParse(numberB, out number) &&
                double.TryParse(numberC, out number))
            {
                double a = double.Parse(numberA);
                double b = double.Parse(numberB);
                double c = double.Parse(numberC);
                double d = (b * b) - (4 * a * c);
                double root1;
                double root2;

                if (d > 0)
                {
                    double num = 2 * a;
                    double num1 = -b - Math.Sqrt(d);
                    double num2 = -b + Math.Sqrt(d);
                    root1 = num1 / num;
                    root2 = num2 / num;
                    Console.WriteLine("Two roots: x1 = {0}, x2 = {1}", root1, root2);
                }
                else if (d == 0)
                {
                    root1 = -b / (2 * a);

                    Console.WriteLine("One root: x1 = x2 = {0}", root1);
                }
                else
                {
                    Console.WriteLine("The quadratic DOESN`T have any roots!");
                }

            }
            else
            {
                Console.WriteLine("Error: You hadn`t entered a (double) number!");
            }

            Console.WriteLine();
        }
    }
}
