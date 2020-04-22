using System;
using sortExercise.src;

namespace sortExercise
{
	class Program
	{
		public static void Main(string[] args)
		{
			retrieveDataFromFile r = new retrieveDataFromFile(@"C:\Users\GabrielFerreira\Documents\repos\sortExercise\src\scrambled.txt");

			int select = 0;

			Console.WriteLine("Exercício 1: \n digite 1");
			Console.WriteLine("Exercício 2: \n digite 2");
			Console.WriteLine("Exercício 3: \n digite 3");
			select = Convert.ToInt32(Console.ReadLine());

			switch(select)
			{
				case 1:
					writeToFile wr = new writeToFile(@"C:\Users\GabrielFerreira\documents\repos\sortExercise\src\ex1Result.txt");
					Sorter s = new Sorter();
					int [] ordenedArray = s.quickSort(r.fileData());
					wr.saveDataToNewFile(ordenedArray);
				break;
				case 2:
					Multiplier m = new Multiplier(1953, 5378);
					m.Result(r.fileData());
				break;
				case 3:
					writeToFile wt = new writeToFile(@"C:\Users\GabrielFerreira\documents\repos\sortExercise\src\ex2Result.txt");		
					getMultiples gt = new getMultiples(350, r.fileData());
					wt.saveDataToNewFile(gt.CalculateMultiples());		
				break;
				default:
					Console.WriteLine("error");
				break;
			}
		}
	}
}