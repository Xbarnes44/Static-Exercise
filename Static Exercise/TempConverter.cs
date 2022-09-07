using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Exercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double Fardegree)
        {
            return (Fardegree -32) *.5556;
        }

        public static double CelsiusToFahrenheit(double Fardegree)
        {
            return Fardegree *1.8 + 32;
        }

    }
   
}
