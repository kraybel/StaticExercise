using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please specify a Fahrenheit temp to convert to Celsius: ");
            var cel = TempConverter.FahrenheitToCelsius(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"The Celsius temp would be {cel}");
            Console.WriteLine();
            Console.Write("Please specify a Celsius temp to convert to Fahrenheit: ");
            var fahr = TempConverter.CelsiusToFahrenheit(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"The Fahrenheit temp would be {fahr}");
        }
    }
}
