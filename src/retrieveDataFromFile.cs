using System;
using System.IO;

namespace sortExercise.src
{
    class retrieveDataFromFile
    {
        String FilePath = "";
        public retrieveDataFromFile (string filepath){
            this.FilePath = filepath;
        }

        private string[] AccessFileData()
        {
            Console.WriteLine($"Arquivo localizado em {FilePath}");
            string[] FileLineContent = File.ReadAllLines(""+ FilePath + "");

            return FileLineContent;
        }

        private int [] ParseFileData() {
            string [] bruteFileData = AccessFileData();    
            int[] parsedFileData = Array.ConvertAll(bruteFileData, int.Parse);

            return parsedFileData;
            }

        public int [] fileData() {
            int[] parsedFileData = ParseFileData();
            
            return parsedFileData;
        }
    }  
}
