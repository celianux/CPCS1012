using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //Prompt for a number
            //display "positive" if greater than zero
            //display "negative" if less than zero
            //and "zero" if equal to zero

            Console.WriteLine($"Question 1\n");

            int numArg = -1;
            if (numArg == 0)
            {
                Console.WriteLine($"Thr number {numArg} is zero");
            }
            else
            {
                if (numArg > 0)
                {
                    Console.WriteLine($"The number {numArg} is positive");
                }
                else
                {
                    Console.WriteLine($"The number {numArg} is negative");
                }
            }

            Console.WriteLine("\n\n");


            //Question 2
            //Determine the cost of theatre admission based on age
            //Prompt for age and display correct admission amount

            int Age = 13;
            if (Age < 7)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Child FREE $0.00");

            }
            else if (Age < 18)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Student $9.80");
            }
            else if (Age < 55)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Adult $11.35");
            }
            else
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Senior $10.00");
            }



            if (Age > 54)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Senior $10.00");
            }
            else if (Age > 17)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Adult $11.35");
            }
            else if (Age > 6)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of :  Student $9.80");
            }
            else
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Child FREE $0.00");
            }


            //Nested

            if (Age > 54)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Senior $10.00");
            }
            else
            {
                if (Age > 17)
                { 
                    Console.WriteLine($"Your age of {Age} has an admission fee of : Adult $11.35");
                }
                else 
                {
                    if (Age > 6)
                    {
                        Console.WriteLine($"Your age of {Age} has an admission fee of :  Student $9.80");
                    }
                    else
                    {
                        Console.WriteLine($"Your age of {Age} has an admission fee of : Child FREE $0.00");
                    }
                }
            }



            //Question 3

            //Question 4

            double Earnings = 25000;
            decimal taxAmount = 0.00m;

            const decimal FIVEPERCENT = 0.05m;
            const decimal SEVENPERCENT = 0.07m;
            const decimal NINEPERCENT = 0.09m;

            //using column aligned output
            //the syntax for formatting {variable, columnsize:formatstring}
            //variable is the data to output
            //columnsize is the amount (a number) of character spacing to be used for the column
            //positive columnsize is right aligned
            //negative columnsize is left-aligned 
            //formatstring is your string format
            //put out the tax table as a column formatted table

            //using a \t character will give columns depending on the length of your output string (inconsistent)


            Console.WriteLine("Taxable Income \t Tax Calculation");
            Console.WriteLine("Up to $50,000 \t $0 + 5% of amount over $0");
            Console.WriteLine("Up to $100,000 \t $2,500 + 7% of amount over $50,000");
            Console.WriteLine("$100,000 and over \t $6,000 + 9% of amount over $100,000\n\n");

            Console.WriteLine("Tax Calculation \t Taxable Income");
            Console.WriteLine("$0 + 5% of amount over $0 \t Up to $50,000 ");
            Console.WriteLine("$2,500 + 7% of amount over $50,000 \t Up to $100,000");
            Console.WriteLine("$6,000 + 9% of amount over $100,000 \t $100,000 and over\n\n");


            if (Earnings <= 50000)
            {
                //taxAmount is a decimal
                //Earnings is a double
                //the compiler does not like the mixture of data types
                //solutions: 
                //      a) make earnings a decimal
                //      b) make everything a double 
                //      c) cast the Earnings temporarily to a decimal *****
                
                taxAmount = (decimal)Earnings * FIVEPERCENT; 
            }
            else
            {
                if (Earnings <= 100000)
                {
                    taxAmount = 2500.00m + ((decimal)Earnings - 50000) * SEVENPERCENT; //or (decimal)(Earnings - 50000) casting the entire expression
                }
                else
                {
                    taxAmount = 6000.00m + ((decimal)Earnings - 100000) * NINEPERCENT;
                }
            }
            
            //Dollar amounts can be notated with 
            // a) formatting using 0.00 (without $) or $0.00 (with $)
            // b) a small c (currency) will have an automatic $ and needed commas: built in format is $#,##0.00
            //you can use the # sign as a digit placeholder in your format
            //the # is used as "if digit space needed, use it"

            Console.WriteLine($"Earnings: {Earnings:$#,##0.00}\t Taxes: {taxAmount:$#,##0.00}");

            //Output using column printing
            Console.WriteLine("{0, 15} {1, 13}", "Earnings:", "Taxes:");
            Console.WriteLine($"{Earnings, 13:$#,###.00} {taxAmount, 15:c}");
            Console.WriteLine("\n");



            if (Earnings <= 50000)
            {
              

                taxAmount = (decimal)Earnings * FIVEPERCENT;
            }
            else if (Earnings <= 100000)
            {
                    taxAmount = 2500.00m + ((decimal)Earnings - 50000) * SEVENPERCENT; //or (decimal)(Earnings - 50000) casting the entire expression
            }
            else
            {
                    taxAmount = 6000.00m + ((decimal)Earnings - 100000) * NINEPERCENT;
            }
            Console.WriteLine($"Earnings: {Earnings:c}\t Taxes: {taxAmount:c}");
        }
    }
}
