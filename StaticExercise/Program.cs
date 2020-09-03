using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = 100;

            var fTemp = TempConverter.CelsiusToFahrenheit(temp);
            Console.WriteLine(fTemp);

            var cTemp = TempConverter.FahrenheitToCelsius(fTemp);
            Console.WriteLine(cTemp);

            Console.ReadLine();
        }
    }
}
