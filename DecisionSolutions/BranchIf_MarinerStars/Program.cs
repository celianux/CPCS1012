using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchIf_MarinerStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int starLevel = 4;
            string msg = "";

            if(starLevel < 1)
            {
                msg = "Welcome to Holland America cruises. You have yet to earn special benefits.";  
            }
            else if (starLevel < 2)
            {
                msg = "You can receive any of the 1-star benefits of the Mariner program.";
            }
            else if (starLevel < 3)
            {
                msg = "You can receive any of the 2-star benefits of the Mariner program.";
            }
            else if (starLevel < 4)
            {
                msg = "You can receive any of the 3-star benefits of the Mariner program.";
            }
            else if (starLevel < 5)
            {
                msg = "You can receive any of the 4-star benefits of the Mariner program.";
            }
            else
            {
                msg = "You can receive any of the 5-star benefits of the Mariner program.";
            }

            Console.WriteLine(msg);
        }
    }
}
