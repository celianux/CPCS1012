using Microsoft.Win32; //required for the OpenFileDialogue 
using System;
using System.Collections.Generic;
using System.IO; //required to do file I/O
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    
    class Program
    {
        //This is required for your code when using OpenFileDialog
        [STAThread]
        static void Main(string[] args)
        {
            string Full_Path_File_Name = "";

            //You can prompt for the file name

            //location

            //1. The file will always be in the same location
            //set up the path name
            //string FolderPath = @"C:\Users\cnicholls2\documents\github\CPCS1012\";

            //*********************************************************************

            //2. Use methods within the software to access the general special folders 
            //  of your Windows file system
            //Documents, Downloads, Pictures, Music

            //This GetFolderPath will return C:\Users\xxxx\thespecialfoldername
            //For the following statement C:\Users\cnicholls2\documents
            //string specialpathname = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Now, you must add any additional path structure to get to the specific 
            //  folder within the special folder
            //string FolderPath = specialpathname + @"\GitHub\CPCS1012\";


            //**********************************************************************

            //for 1. & 2.
            //I will assume that the required filed will always be found at the root of the course class repository

            //Console.Write("Enter the file name, eg. myfile.txt\t");
            //string FileName = Console.ReadLine();

            //Full_Path_File_Name = FolderPath + FileName;

            //***********************************************************************




            //Is there a way to browse for a file? 
            //Yes, you can call the OpenFileDialog
            //This is the dialogue window that you see on your system
            //  when you go browsing for a file within an application

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;

            //Setup for reading a file
            //A string variable is required to receive the data 
            //  from the file.
            //The string will be filled with one row from your file
            //  on each file read.
            string readValue = "";

            //Use a variable to count the rows in the file (optional)

            int counter = 0;

            //Include what is referred to as "User Friendly Error Handling"
            //This is your try/catch/finally structure
            //The finally portion is ONLY needed if you need to close a 
            //  connection to a data source

            StreamReader reader = null;
            try
            {

                //in the try is the code you will attempt to exectute
                //if an error happens during the execution of the code
                //      an Exception is thrown by the system
                //Any exception thrown by the system is passed to the 
                //  catch{} coding block for processing

                //To test the Try/Catch I will introduce a BAD path name
                //Full_Path_File_Name = @"C:\Users\cnicholls2\documents\github\CPCS1012\bob.txt";


                //Add the .NET framework class that contains the code that
                //  will do the read of the file
                //the required I/O class for reading is StreamReader located
                //  in the namespace System.IO
                //To attach the reader to the file, you need to pass the 
                //  full path file name (fully qualified file name) as 
                //  an argument to the class while it is being created.
                //The reader is referred to as an instance of the class (StreamReader)
                //The instance is physically created when the new command is 
                //  used in conjunction with the class name. 

                reader = new StreamReader(Full_Path_File_Name);
            
                //Gets a single row of the file
                readValue = reader.ReadLine();

                //If your line that was "read" is null, you have reached the 
                //  end of the file (eof)

                while(readValue != null) //stop when you reach the end of the file
                {
                    counter++;
                    Console.WriteLine($"File line {counter} has a value of {readValue}\n");

                    //Get the next line
                    readValue = reader.ReadLine();
                }

            }//eof try
            catch(Exception ex)
            {
                // .Message hols the error that occurred during the processing of the 
                //  code in your try {...}
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                //This is used if you need to close a data source such as an open file
                reader.Close();
            }

            Console.ReadKey();

        }
    }
}
