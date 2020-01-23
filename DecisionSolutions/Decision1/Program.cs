using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, hightest=-99;
            int first;             //declare and default to 0
            int second;            //declare and default to 0
            int highest = -99;     //declare and set to -99
            string message;        //declare and default to null
            string inputValue;     //declare and default to null

            Console.Write("Enter the first number:\t\t");
            inputValue = Console.ReadLine();
            first = int.Parse(inputValue);

            //Reuse inputValue because the previous contents of input value have now been stored elsewhere
            Console.Write("Enter the second number:\t");
            inputValue = Console.ReadLine();
            second = int.Parse(inputValue);

            if(first > second)
            {
                //true path coding block
                //the condition on the if statement is true
                highest = first;
                message = "first"; 

            }
            else
            {
                //false path coding block
                //the condition on the if statement is false
                highest = second;
                message = "second";

            }//e(nd)o(f)f(alse)

            Console.WriteLine($"First = {first}, Second = {second}" +
                $", the {message} number entered had the higher value: {highest}");
            Console.ReadKey();
        }//eom(ethod)
    }//eoc(lass)
}//eon(amespace)
