using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace sortExercise.src
{
    class retrieveDataFromFile
    {
        public retrieveDataFromFile ()
        {

        }

        public ArrayList ReturnFileData()
        {
            ArrayList ParsedLines = new ArrayList();
            try
            {
                string[] Lines = File.ReadAllLines(@"C:\Users\GabrielFerreira\Documents\repos\sortExercise\src\scrambled.txt");

                foreach (string line in Lines) 
                {
                    ParsedLines.Add(Convert.ToInt32(line));
                }
            }
            catch (System.IO.DirectoryNotFoundException e) { Console.WriteLine(e); }

            return ParsedLines;
        }
    }
}
