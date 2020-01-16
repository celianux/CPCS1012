using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Implement a temperature converter from Celsius to Fahrenheit
             * Jan 15/20
             */

            //input: Celsius temperature
            //  string inputTemp
            //  double theCelsiusTemperature

            //output: Fahrenheit temperature
            //  double theFahrenheitTemperature

            //expression (calculation): (ctemp * 9/5) + 32 = ftemp

            //check with ctemp = 0, expect ftemp = 32
            //check with ctemp = -40, expect ftemp = -40
            //check with ctemp = 100, expect ftemp = 212

            //prompt for a temperature
            //  .write keeps your cursor on the same line

            Console.Write("Enter a Celsius temperature:\t");

            //to obtain the keystrokes that the user types (input)
            //  use .ReadLine()
            //data comes into the program as a string

            string inputTemp = Console.ReadLine();

            //convert the string to a double
            //to do this, you will use parsing
            //  syntax: datatypeTo.Parse(string)

            double theCelsiusTemperature = double.Parse(inputTemp);

            //calculation using the conversion expression

            double theFahrenheitTemperature = (theCelsiusTemperature * (9.0d / 5.0d)) + 32.0d;

            //output
            //.WriteLine() automatically goes to the next line

            Console.WriteLine($"The Celsius temperature of {theCelsiusTemperature} in" + $"Fahrenheit is {theFahrenheitTemperature}");

            //to ensure that your display stays whether you run without debugging (Crtl + F5)
            //or running with debugging (F5 or the Start button)
            //add a .ReadLine()

            Console.ReadLine(); 



        }
    }
}
