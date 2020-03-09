using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SequentialSearchFind
{ 
    class Program
    {
    [STAThread]
    static void Main(string[] args)
        {
            //Declare an integer array of 25 elements
            int[] myArray = new int[25];

            //Need an integer variable to indicate the "logical size" of the array
            //The "logical size" refers to the number of elements in the array
            //The declared size (25) is referred to as the physical size

            int logicalsize = 0;
            int physicalsize = 25;

            string Full_Path_File_Name = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readValue = "";
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();
                while (readValue != null && logicalsize < physicalsize) 
                {

                    myArray[logicalsize] = int.Parse(readValue);
                    logicalsize++;

                    readValue = reader.ReadLine();
                }

            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                reader.Close();
            }

            Console.WriteLine($"The number of elements in the array is {logicalsize}");
            for (int loopcounter = 0; loopcounter < logicalsize; loopcounter++)
            {
                Console.WriteLine($"At array index {loopcounter} there is a value of {myArray[loopcounter]}");
            }

            //Sequential Search
            //Is it there?

            Console.Write($"Enter a number:\t");
            int searcharg = int.Parse(Console.ReadLine());

            bool found = false;
            int searchindex = 0;
            //condition expression 
            // a) continue to look until you have looked at everything (stop after looking at all elements)
            // b) continue if NOT found (stop if found)
            //searchcounter is an index (0 based)
            //logicalsize is a natural count (1 based)

            while(searchindex < logicalsize && !found)
            {
                if(myArray[searchindex] == searcharg)
                {
                    //number was found
                    //stop
                    //searchcounter will be the index of the array location where the searcharg (search argument) was first found
                    found = true;
                }
                else
                { 
                    //increment to look at the next element in the array
                    searchindex++;
                }
            }

            if(found)
            {
                Console.WriteLine($"{searcharg} was found at index {searchindex}");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found anywhere in the {logicalsize} array elements");
            }

            //Count the number of occurrences in the array
            searchindex = 0;
            int foundcount = 0;
            found = false;

            //this could also be coded using a for loop BECAUSE you are looking at ALL the elements (actual/exact count)
            //for(int searchindex = 0; searchindex < logicalsize; searchindex++)
            //I do NOT want to stop when I find the first occurrence in the loop
            
            while (searchindex < logicalsize)
            {
                if (myArray[searchindex] == searcharg)
                {
                    //number was found
                    //stop
                    //searchcounter will be the index of the array location where the searcharg (search argument) was first found
                    found = true;
                    foundcount++;
                }
             
                    searchindex++;
              
            }

            //if (foundcount > 0) then you would not need the boolean found flag
            if (found)
            {
                Console.WriteLine($"{foundcount} occurrences of {searcharg} were found in the array.");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found anywhere in the {logicalsize} array elements");
            }

        }

    }
}
