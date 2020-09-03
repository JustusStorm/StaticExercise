using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    class TempConverter
    {

        public static int CelsiusToFahrenheit(int temp)
        {
             return (((temp / 5) * 9) + 32);
        }

        public static int FahrenheitToCelsius(int temp)
        {
            return (((temp - 32) * 5) / 9);
        }
    }
}
