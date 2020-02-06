using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeLetter = "c";
            string percentageRange;

            //a case structure can be used when you have a single argument value 
            //compared to a series of literal values

            //the structure begins with the switch(argument value) {...}
            //within the switch structure you have "cases" 
            //a "case" represents one "if" test against the argument value
            //the case must end with a "break;" command
            //the "break" sends your execution to the end of the switch structure

            //the last case in your switch is a special case called "default"
            //"default" DOES NOT test against a literal value
            //default executes if NONE of the previous cases were executed

            //you can have multiple case statements coded for a particular 
            //case coding block
            //multiple case statements for a particular case coding block are
            //implied logical OR (||) tests
            //The case test is a relational equal (==) test

            //switch (gradeLetter)
            //{
            //    case "a":
            //    case "A":
            //        {
            //            //logic for this particular case
            //            percentageRange = "85-100";
            //            break;
            //        }
            //    case "b":
            //    case "B":
            //        {
            //            //logic for this particular case
            //            percentageRange = "70-84";
            //            break;
            //        }
            //    case "c":
            //    case "C":
            //        {
            //            //logic for this particular case
            //            percentageRange = "55-69";
            //            break;
            //        }
            //    case "d":
            //    case "D":
            //        {
            //            //logic for this particular case
            //            percentageRange = "40-54";
            //            break;
            //        }
            //    case "f":
            //    case "F":
            //        {
            //            //logic for this particular case
            //            percentageRange = "0-39";
            //            break;
            //        }
            //    default:
            //        {
            //            //the implied test on this case is "none of the above"
            //            percentageRange = "an invalid letter grade!";
            //            break;
            //        }
            //}//e(nd)o(f)s(witch)

            

            switch (gradeLetter.ToUpper())
            {
                case "A":
                    {
                        //logic for this particular case
                        percentageRange = "85-100";
                        break;
                    }
                case "B":
                    {
                        //logic for this particular case
                        percentageRange = "70-84";
                        break;
                    }
                case "C":
                    {
                        //logic for this particular case
                        percentageRange = "55-69";
                        break;
                    }
                case "D":
                    {
                        //logic for this particular case
                        percentageRange = "40-54";
                        break;
                    }
                case "F":
                    {
                        //logic for this particular case
                        percentageRange = "0-39";
                        break;
                    }
                default:
                    {
                        //the implied test on this case is "none of the above"
                        percentageRange = "an invalid letter grade!";
                        break;
                    }
            }//e(nd)o(f)s(witch)

            Console.WriteLine($"Your grade letter ({gradeLetter}) is {percentageRange}");

            Console.ReadKey(); //when using debugging to stop the autoclose of your display

            //example 2 Print out the month name

            int monthNumber = 7;

            //if (monthNumber == 1)
            //{

            //}
            //else if (monthNumber == 2) etc.
            //There is a single argument variable
            //This single argument variable will be tested against multiple constant values

            //The case test is  an == test ONLY

            switch (monthNumber)
            {
                case 1:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is January");
                        break;
                    }
                case 2:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is February");
                        break;
                    }
                case 3:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is March");
                        break;
                    }
                case 4:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is April");
                        break;
                    }
                case 5:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is May");
                        break;
                    }
                case 6:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is June");
                        break;
                    }
                case 7:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is July");
                        break;
                    }
                case 8:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is August");
                        break;
                    }
                case 9:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is September");
                        break;
                    }
                case 10:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is October");
                        break;
                    }
                case 11:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is November");
                        break;
                    }
                case 12:
                    {
                        //do any logic that is required when month number is 1
                        //this could be one line of code or 1000000 lines of code
                        Console.WriteLine("the name of the month is December");
                        break;
                    }
                default:
                    {
                        //this logic is done if one of the previous cases was not executed.
                        //any necessary logic
                        Console.WriteLine("Too late in the year to think any more.");
                        break;
                    }
            }


        }
    }
}
