using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic menu setup
            //loop: post-loop
            //loop contents
            //  prompt for a menu option
            //  switch with case for each option, default is bad menu option
            //  within the case we will simply output a message

            //decide how to terminate your loop

            string menuOption = "";

            do
            {
                //Prompts
                Console.WriteLine("Select an option from the following menu");
                Console.WriteLine("A) Do case A");
                Console.WriteLine("B) Do case B");
                Console.WriteLine("C) Do case C");
                Console.WriteLine("X) Exit\n");
                Console.Write("Enter your menu option:\t");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                {
                    case "A":
                        {
                            //place any logic to do in case A
                            Console.WriteLine("You entered the menu option of A.\n\n");
                            break;
                        }
                    case "B":
                        {
                            //place the Heads or Tails game in this case
                            //validate that an H or T was entered, if not, repeat query for input
                            Console.WriteLine("You entered the menu option of B.\n\n");
                            break;
                        }
                    case "C":
                        {
                            //the sum of squares
                            //enter a positive integer number (validate)
                            //loop n times where n is the integer number (1 to n)
                            //within the loop your calculation is total += loopnumber * loopnumber
                            //after the loop, display your integer number and its sum of squares
                            //entered 4
                            //loop 4 times 1) 1*1, 2) 2*2, 3) 3*3, 4) 4*4 final total =30
                            Console.WriteLine("You entered the menu option of C.\n\n");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you. Come again.\n\n");
                            break;
                        }
                    default:
                        {
                            //this case acts as a validation for the proper value of a menuOption 
                            Console.WriteLine($"Your menu option choice of {menuOption} is incorrect. Try again.\n\n");
                            break;
                        }
                }

            }
            while (menuOption.ToUpper() != "X");
            Console.ReadKey();
        }
    }
}
