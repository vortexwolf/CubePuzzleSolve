using System;

namespace CubePuzzleSolve
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var testFigure = PuzzleConfig.Figure1;

			var cube1 = testFigure.AddToEmptyCube(4);
			if (cube1 != null)
			{
				Console.WriteLine(cube1);
			}
			else 
			{
				Console.WriteLine("Can't create the cube.");
			}
		}
	}
}
