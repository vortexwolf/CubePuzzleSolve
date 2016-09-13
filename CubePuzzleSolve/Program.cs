using System;

namespace CubePuzzleSolve
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var cube = RecursiveSolve(new Cube(4), 0);
			if (cube != null)
			{
				Console.WriteLine(cube);
				Console.WriteLine("============");
				Console.WriteLine("Figures: ");
				Console.WriteLine("============");
				foreach (var figure in cube.Figures)
				{
					Console.WriteLine(figure);
					Console.WriteLine("------------");
				}
			}
			else 
			{
				Console.WriteLine("Can't create the cube.");
			}
		}

		private static Cube RecursiveSolve(Cube cube, int figureIndex)
		{
			if (cube.IsSolved())
			{
				return cube;
			}

			if (figureIndex >= PuzzleConfig.AllFigures.Length)
			{
				return null;
			}

			var currentFigure = PuzzleConfig.AllFigures[figureIndex];
			var currentRotations = currentFigure.GetRotations();
			// check all figure rotations
			foreach (var figureRotation in currentRotations)
			{
				// check all possible cubes for each rotation
				var possibleCubes = figureRotation.GetPossibleNewCubes(cube);
				foreach (var possibleCube in possibleCubes)
				{
					var solvedCube = RecursiveSolve(possibleCube, figureIndex + 1);
					if (solvedCube != null)
					{
						return solvedCube;
					}
				}
			}

			return null;
		}
	}
}
