using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logical conditions are two or more conditions separated by a logical operator (logic operation)
            //
            //relative operators
            // >, >=, <, <=, ==, !=
            //operand operator operand
            // high > low
            //
            //logical operators
            // || (pipe) - "or" operator, && - "and" operator, ! - "not" operator

            int Age = 6;

            if (Age > 4)
            {
                Console.WriteLine("Too young");
            }
            else if (Age > 14)
            {
                Console.WriteLine("Too old");
            }
            else
            {
                Console.WriteLine("Welcome to the league");
            }

            //But what about using logical conditions/operators
            //NOTE the operand is repeated for each relative test condition
            // (Age < 4 || > 14) is incorrect syntax

            //Truth table
            // conditions    or  and
            // T   T         T    T
            // T   F         T    F
            // F   T         T    F
            // F   F         F    F

            //Summary: && is only true if BOTH relative conditions are True
            //         || is only false if BOTH relative conditions are False

            if (Age < 4 || Age > 14)
            {
                //one does NOT know if the age is less than or greater than
                Console.WriteLine("Sorry you are not in the age bracket for this league");
            }
            else
            {
                Console.WriteLine("Welcome to the league");
            }
        }
    }
}
