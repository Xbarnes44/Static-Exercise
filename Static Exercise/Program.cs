using Static_Exercise;
using System;

namespace StaticExercise
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"{TempConverter.FahrenheitToCelsius(50.0)}");

            Console.WriteLine($"{TempConverter.CelsiusToFahrenheit(10.0)}");
        }

       
    }
}
