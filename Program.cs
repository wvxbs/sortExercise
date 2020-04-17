using System;
using System.IO;
using sortExercise.src;

namespace sortExercise
{
	class Program
	{
		public static void Main(string[] args) 
		{
			retrieveDataFromFile r = new retrieveDataFromFile();
			Sorter s = new Sorter();
			foreach(int i in r.ReturnFileData()){
				Console.WriteLine(i);
			}
			///Console.WriteLine(FileDataArray);
		}
	}
}