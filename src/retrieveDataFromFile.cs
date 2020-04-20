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
                for (int i = 0; i > Lines.Length; i++)
                {
                    ParsedLines[i] = int.Parse(Lines[i]);
                    Console.WriteLine(ParsedLines[i]);
                }
            }
            catch (System.IO.DirectoryNotFoundException e) 
            { 
                Console.WriteLine(e);
            }
            return ParsedLines;    
        }

        public int OrignalFileLineCount ()
        {
            return Lines.Length;
        }
    }
}