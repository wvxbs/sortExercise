using System;
using sortExercise.src;

namespace sortExercise
{
	class Program
	{
		public static void Main(string[] args)
		{
			retrieveDataFromFile r = new retrieveDataFromFile();
			Sorter s = new Sorter();
			Console.WriteLine(Convert.ToString(r.ReturnFileData().Length));
			writeToFile wr = new writeToFile(r.ReturnFileData());
			s.quickSort(r.ReturnFileData());
			wr.saveDataToNewFile();
		}
	}
}