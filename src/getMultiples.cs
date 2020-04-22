using System;

namespace sortExercise.src 
{
    class getMultiples 
    {
        int Num = 0;
        int [] ScrambledFileData;

        public getMultiples (int num, int[] ScrambledFileData)
        {
            this.Num = num;
            this.ScrambledFileData = ScrambledFileData;
        }

        public int [] CalculateMultiples ()
        {
            int [] Result = new int [ScrambledFileData.Length];

            for(int i = 0; i < ScrambledFileData.Length; i++) 
            {
                if(ScrambledFileData[i] % Num == 0) 
                {
                    Result[i] = ScrambledFileData[i];
                } 
            }

            return Result;
        }
    }
}