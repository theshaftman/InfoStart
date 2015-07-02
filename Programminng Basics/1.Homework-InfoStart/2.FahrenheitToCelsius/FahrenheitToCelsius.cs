using System;

class Program
{
    //Calculating celsius from given fahrenheit
    static float FahrenheitToCelsius(float fahrenheit)
    {
        float celsius = (fahrenheit - 32f) / 1.8f;
        return celsius;
    }

    static void Main()
    {
        //Repeating Loop
        while (true)
        {
            //float fahreheit = 0f;
            Console.Write("Write Fahrenheit temperature: ");
            string number = Console.ReadLine();
            float numbers;

            //Checking if the number is (float)
            if (float.TryParse(number, out numbers))
            {
                float fahrenheit = float.Parse(number);
                char deg = (char)176;

                Console.WriteLine("{0}{2}F = {1:0.00}{2}C", fahrenheit, FahrenheitToCelsius(fahrenheit), deg);
            }

            Console.WriteLine();
        }
    }
}
