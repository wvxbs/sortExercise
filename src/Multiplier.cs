using System;

namespace sortExercise.src 
{
    class Multiplier 
    {
        long ArrayPosition = 0;
        long Num = 0;

        public Multiplier (long ArrayPosition, long Num) 
        {
            this.ArrayPosition = ArrayPosition;
            this.Num = Num;
        }

        public void Result (int []ScrambledFileData)
        {
            long Val = Convert.ToInt64(ScrambledFileData[ArrayPosition -1]);
            Console.WriteLine(Multiply(Val));
        }

        private string Multiply (long Val) 
        {
            long Result = 0;

            Result = Num * Val;

            string ResultText = $"O Resultado de {Val} vezes {Num} é igual a {Result}";;

            return ResultText;
        }
    }
}