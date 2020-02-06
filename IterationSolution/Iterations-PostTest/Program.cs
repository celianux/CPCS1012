using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_PostTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            const int Two = 2;
            string inputValue;
            string answer = "";

            //The loop structure demonstrated in this sample is a Post-Test
            //Post-Test is also known as "Do Until"
            //Post-Test executes the code ONCE BEFORE the loop condition is tested 
            //After the code has executed, the Post-Test condition is tested for true
            //If the condition is still true the loop code is re-executed 
            //if the condition is false the loop terminates and execution continues with the remainder of the program

            do
            {
                //within this coding block you are inside your loop
                //this loop will terminate if answer is not Y or y.

                //TODO: place your loop logic here

                Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);

                if ((number % Two) == 0)
                {
                    Console.WriteLine($"Your number, {number}, is even");
                }
                else
                {
                    Console.WriteLine($"Your number, {number}, is odd");
                }//eof

                //ask if the user wishes to continue to play the game
                //give the user an opportunity to exit the loop 
                Console.Write("\n\nDo you wish to continue playing the Even or Odd Game?\t");
                answer = Console.ReadLine();
            }
            while (answer.ToUpper().Equals("Y"));
                
            Console.WriteLine("\n\nYou terminated the loop with your last answer.");
            Console.ReadKey();
        }
    }
}
