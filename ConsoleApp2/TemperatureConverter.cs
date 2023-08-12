using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TemperatureConverter
    {
        public double CelsiusToFahrenheit(string celsiusTemp)
        {
            double celsius=double.Parse(celsiusTemp);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        public double FahrenheitToCelsius (string fahrenheitTemp)
        {
            double fahrenheit = double.Parse(fahrenheitTemp);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
