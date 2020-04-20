using System;
using System.IO;
        
namespace sortExercise.src
{
    class writeToFile
    {

        public void saveDataToNewFile (int[] ScrambledFileData) {
            StreamWriter sw = new StreamWriter(@"C:\Users\GabrielFerreira\Documents\repos\sortExercise\src\result.txt");
            for(int i =0; i < ScrambledFileData.Length; i++) {
                sw.WriteLine(ScrambledFileData[i]);
            }
            Console.WriteLine("data writen");
        }
    }
}