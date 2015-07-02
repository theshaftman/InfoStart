using System;

class Circle
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Write Radius 'r': ");
            string radius = Console.ReadLine();
            double number;

            if (double.TryParse(radius, out number))
            {
                double r = double.Parse(radius);
                double perimeter = 2 * Math.PI * r;
                double area = Math.PI * (r * r);

                Console.WriteLine("The perimeter P = {0:0.00}", perimeter);
                Console.WriteLine("The area S = {0:0.00}", area);
            }
            else
            {
                Console.WriteLine("Error: You hadn`t entered a number!");
            }
            Console.WriteLine();
        }
    }
}
