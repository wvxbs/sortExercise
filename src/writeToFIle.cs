using System;
using System.IO;

namespace sortExercise.src
{
    class writeToFile
    {
        int [] ScrambledFileData = new int[]{};

        public writeToFile(int []scrambledfiledata)
        {
            Console.WriteLine(scrambledfiledata.Length);
            for(int i = 0; i > scrambledfiledata.Length; i++)
            {
                this.ScrambledFileData[i] = scrambledfiledata[i];
            }
        }

        public void saveDataToNewFile () 
        {
            Console.WriteLine(ScrambledFileData.Length);          
        }
    }
}