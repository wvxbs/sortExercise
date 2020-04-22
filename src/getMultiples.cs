using System;

namespace sortExercise.src 
{
    class getMultiples 
    {
        int Num = 0;
        int [] ScrambledFileData;
        int [] Result = new int []{};

        public getMultiples (int num, int[] ScrambledFileData)
        {
            this.Num = num;
            this.ScrambledFileData = ScrambledFileData;
        }

        public int [] CalculateMultiples ()
        {
            for(int i = 0; i < ScrambledFileData.Length; i++) 
            {
                if(ScrambledFileData[i] != 0) Result[i] = ScrambledFileData[i]; 
            }
            return Result;
        }
    }
}