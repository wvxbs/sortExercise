using System;
using sortExercise.src;

namespace sortExercise
{
	class Program
	{
		public static void Main(string[] args)
		{
			retrieveDataFromFile r = new retrieveDataFromFile(@"C:\Users\GabrielFerreira\Documents\repos\sortExercise\src\scrambled.txt");
			writeToFile wr = new writeToFile();
			Sorter s = new Sorter();
			int [] ordenedArray = s.quickSort(r.fileData());
			wr.saveDataToNewFile(ordenedArray);
		}
	}
}