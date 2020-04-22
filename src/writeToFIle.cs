using System;
using System.IO;
        
namespace sortExercise.src
{
    class writeToFile
    {
        string FilePath = "";

        public writeToFile(string FilePath)
        {
            this.FilePath = FilePath;
        }

        public void saveDataToNewFile (int[] ScrambledFileData) 
        {
            using(StreamWriter sw = new StreamWriter(FilePath))
            {
                for(int i =0; i < ScrambledFileData.Length; i++) 
                {
                    sw.WriteLine(ScrambledFileData[i]);
                }
            }
            Console.WriteLine("data writen");
        }
    }
}