﻿using System;
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
                Console.WriteLine("A) Play Even or Odd");
                Console.WriteLine("B) Play Heads or Tails");
                Console.WriteLine("C) Get the Sum of Squares");
                Console.WriteLine("X) Exit\n");
                Console.Write("Enter your menu option:\t");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                {
                    case "A":
                        {

                            //place any logic to do in case A
                            //Console.WriteLine("You entered the menu option of A.\n\n");

                            Even_Or_Odds();
                            break; //the break is part of the case, NOT the method
                        }
                    case "B":
                        {
                            //Console.WriteLine("You entered the menu option of B.\n\n");


                            //place the Heads or Tails game in this case
                            //validate that an H or T was entered, if not, repeat query for input


                            //Create a method that holds the actual code for this case 
                            //the B case will CALL the method to execute
                            //this action is referred to as the calling statement
                            //calling the method requires your code to use the method name
                            //your program will branch to the requested method
                            //when the method has finished, your program will return 
                            //      to the next executable statement AFTER the method call.

                            Heads_Or_Tails_Game(); //calling statement
                            break;


                        }
                    case "C":
                        {
                            //Console.WriteLine("You entered the menu option of C.\n\n");
                            //the sum of squares
                            //enter a positive integer number (validate)
                            //loop n times where n is the integer number (1 to n)
                            //within the loop your calculation is total += loopnumber * loopnumber
                            //after the loop, display your integer number and its sum of squares
                            //entered 4
                            //loop 4 times 1) 1*1, 2) 2*2, 3) 3*3, 4) 4*4 final total =30

                            //create a shared input method to obtain an integer value
                            int number = GetIntegerInput("Enter a number greater than 0:\t");
                            if(number < 1)
                            {
                                Console.WriteLine($"{number} is not greater than 0. Unable to calculate the sum of squares.");
                            }
                            else
                            {
                                int sumofsquares = 0;
                                sumofsquares = SumofSquares(number); 
                                Console.WriteLine($"{sumofsquares} is the sum of squares for {number}");
                            }

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
        }//eom main 

        //the syntax for a method requires 
        //Method Header

        //accesstype followed by a returndatatype followed by the MethodName([list of parameters])
        //{
        //  your method code
        //}//eom

        //accesstype: public or private
        //            protected, internal, have static reference

        //returndatatype: if you are returning nothing use the key word void 
        //                otherwise, return a single value such as int, double, decimal, DateTime etc.

        //MethodName: continuous string of characters which will be used within 
        //            your program code to reference this coding block
        //            it is best to use a meaningful name

        //[list of parameters] this is a set of local variables that will be used 
        //          to receive values from the calling statement

        //          a parameter is a set of datatype and variablename
        //          parameters are separated by using a comma , 
        
        static public void Heads_Or_Tails_Game()
        {
            int headCount = 0;
            int tailCount = 0;
            string inputString = "";

            do
            {

                //validation
                do
                {
                    Console.Write("Enter an H (heads) or T (tails) or Q to quit\n");
                    inputString = Console.ReadLine();

                } while (!inputString.ToUpper().Equals("H") &&
                        !inputString.ToUpper().Equals("T") &&
                        !inputString.ToUpper().Equals("Q"));

                if (inputString.ToUpper().Equals("H") ||
                        inputString.ToUpper().Equals("T"))
                {
                    //heads or tails
                    if (inputString.ToUpper().Equals("H"))
                    {
                        headCount++;
                        Console.WriteLine($"\n {inputString.ToUpper()} is heads");
                    }
                    else
                    {
                        tailCount++; 
                        Console.WriteLine($"\n {inputString.ToUpper()} is tails");
                    }
                }
                else
                {
                    if(headCount > tailCount)
                    {
                        Console.WriteLine($"Heads wins over Tails: {headCount} to {tailCount}");

                    }else if (headCount< tailCount)
                    {
                        Console.WriteLine($"Tails wins over Heads: {tailCount} to {headCount}");
                    }
                    else
                    {
                        Console.WriteLine($"Heads and Tails tied: {headCount} to {tailCount}");
                    }
                    //quit
                    Console.WriteLine("\n\nThank you for playing.");
                }

            } while (!inputString.ToUpper().Equals("Q"));

        }//eom Heads_Or_Tails_Game

        static public void Even_Or_Odds()
        {
            int number = -1;

            while (number != 0)
            {
              

                number = GetIntegerInput("Enter a positive whole number OR enter 0 to quit:\t");

                if (number > 0)
                {
                    if (number % 2 == 0)
                    {

                        Console.WriteLine($"{number} is an even value.\n\n");

                    }
                    else
                    {
                        Console.WriteLine($"{number} is an odd value.\n\n");
                    }


                }
                else
                {

                    if (number == 0)
                    {
                        Console.WriteLine($"Thank you. Come again.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is invalid. Try Again.\n\n");
                    }

                }


             }//eol while

        }//eom Even_Or_Odds //subroutine (a method that does not return anything)

        static public int SumofSquares(int seednumber) //function (a method returning a value)
        {
            //loop n times where n is the integer number (1 to n)
            //within the loop your calculation is total += loopnumber * loopnumber
            //after the loop, display your integer number and its sum of squares
            //entered 4
            //loop 4 times 1) 1*1, 2) 2*2, 3) 3*3, 4) 4*4 final total =30
            int finalsquare = 0;

            for(int loopcounter = 1; loopcounter <= seednumber; loopcounter++)
            {
                finalsquare += loopcounter * loopcounter;
            };

            return finalsquare;
        }

        static public int GetIntegerInput(string promptline)
        {
            bool validFlag = false;
            string inputString = "";
            int number = 0;

            do
            {
                Console.Write(promptline);
                inputString = Console.ReadLine();
                if (int.TryParse(inputString, out number))
                {
                    validFlag = true;
                }

            } while (validFlag == false);

            //If your method indicates that a return datatype is specified
            //you MUST have at least one return statement in your method code
            return number;
        }

    }
}
