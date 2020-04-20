using System;

namespace sortExercise.src
{
	class Exercises 
	{
        retrieveDataFromFile r = new retrieveDataFromFile(@"C:\Users\GabrielFerreira\Documents\repos\sortExercise\src\scrambled.txt");
		writeToFile wr = new writeToFile();
		Sorter s = new Sorter();

		public void firstExercise ()
		{
			int [] ordenedArray = s.quickSort(r.fileData());
			wr.saveDataToNewFile(ordenedArray);
		}
		
		public void secondExercise ()
		{
			
		}

		public void thirdExercise ()
		{
			
		}
	}
}