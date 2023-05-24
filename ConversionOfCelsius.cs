using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
    public class ConversionOfCelsius
    {
      
       public static void call()
        {
            Console.Write("Enter the value in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Convert Celsius to Kelvin
            double kelvin = celsius + 273.15;

            // Convert Celsius to Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Kelvin = " + kelvin + "K");
            Console.WriteLine("Fahrenheit = " + fahrenheit + "F");
        }
    }

}

