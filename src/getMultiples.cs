using System;
using System.Collections.Generic;

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
            List<int> l = new List<int>();

            for(int i = 0; i < ScrambledFileData.Length; i++) 
            {
                if(ScrambledFileData[i] % Num == 0) 
                {
                    l.Add(ScrambledFileData[i]);
                } 
            }



            return l.ToArray();
        }
    }
}