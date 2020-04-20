using System;
using sortExercise.src;

namespace sortExercise
{
	class Program
	{
		public static void Main(string[] args)
		{
			int select = 0;

			Exercises e = new Exercises();

			Console.WriteLine("Exercício 1: \n digite 1");
			Console.WriteLine("Exercício 2: \n digite 2");
			Console.WriteLine("Exercício 3: \n digite 3");
			select = Convert.ToInt32(Console.ReadLine());

			switch(select)
			{
				case 1:
					e.firstExercise();
				break;
				case 2:
					e.secondExercise();
				break;
				case 3:
					e.thirdExercise();
				break;
				default:
					Console.WriteLine("error");
				break;
			}
		}
	}
}