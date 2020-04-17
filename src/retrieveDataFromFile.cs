using System;
using System.Collections;
using System.IO;

namespace sortExercise.src
{
    class retrieveDataFromFile
    {
        public retrieveDataFromFile (){}

        string[] Lines = File.ReadAllLines(@"C:\Users\GabrielFerreira\Documents\repos\sortExercise\src\scrambled.txt");

        public int[] ReturnFileData()
        {
            int[] ParsedLines = new int[]{}; 
            try
            {
                string[] Lines = File.ReadAllLines(@"C:\Users\GabrielFerreira\Documents\repos\sortExercise\src\scrambled.txt");

                for (int i = 0; i > Lines.Length; i++) 
                {
                    ParsedLines[i] = Convert.ToInt16(Lines[i]);
                }
            }
            catch (System.IO.DirectoryNotFoundException e) { Console.WriteLine(e); }

            return ParsedLines;
        }

        public int OrignalFileLineCount () 
        {
            return Lines.Length;
        }
    }
}
