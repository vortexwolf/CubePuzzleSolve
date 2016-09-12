using System;

namespace CubePuzzleSolve
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var testFigure = PuzzleConfig.Figure8;
			var yRotations = testFigure.GetRotations();

			foreach (var rotation in yRotations)
			{
				Console.WriteLine(rotation);
				Console.WriteLine("------");
			}
		}
	}
}
