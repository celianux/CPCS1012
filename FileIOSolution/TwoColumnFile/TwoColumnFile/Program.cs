using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;


namespace TwoColumnFile
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
         
            string Full_Path_File_Name = "";

            
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;

           
            string readValue = "";

         
            int counter = 0;

         

            StreamReader reader = null;
            try
            {
               
                reader = new StreamReader(Full_Path_File_Name);

                
                readValue = reader.ReadLine();

             
                while (readValue != null) 
                {
                    counter++;
                    //Console.WriteLine($"File line {counter} has a value of {readValue}\n");

                    //You must know how the individual values are separated on the file line (record)
                    //Many times this is done using a comma (,)
                    //Files that use a comma are generally referred to as comma separated values (csv)
                    //Each record that is read is processed through a loop to extract each value.
                    //A system method exists which allows one to split the values apart
                    //This method is .Split('delimiter')
                    //The delimiter is the character used to separate the values on the file record
                    int columncounter = 0;
                    foreach(var columnitem in readValue.Split(','))
                    {
                        columncounter++;
                        Console.WriteLine($"Row {counter} Column {columncounter} has a value of {columnitem}");
                    }

                    
                    readValue = reader.ReadLine();
                }
            } //eof try
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }


            Console.ReadKey();
        }
    }
}
