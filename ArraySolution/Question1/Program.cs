﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            int[] driverArray = new int [25];
            int logicalsize = ReadandLoadArray(driverArray, 25);
            int sum = 0;
            for (int index = 0; index < logicalsize; index++)
            {
                sum += driverArray[index];
            }
            if (logicalsize > 0)
            {
                Console.WriteLine($"The average of the {logicalsize} numbers is {(double)sum/(double)logicalsize}");
            }
            else
            {
                Console.WriteLine($"You have no numbers to calculate an average.");
            }
        }

        static int ReadandLoadArray (int[] myArray, int physicalsize)
        {
            //pass to your method the array reference address
            //changes to the array within this method will alter the ORIGINAL array in the Main() method
            //physicalsize is passed by Value (a copy of the original value)
            //any change to the physicalsize REMAINS within this method and
            //  DOES not affect the original value in Main()

            int logicalsize = 0;
         
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
            return logicalsize;
        }
    }
}