using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubePuzzleSolve
{
	public class Figure
	{
		private readonly int[,,] cells;
		private List<Figure> rotations;
		
		public Figure(string name, int[,,] cells)
		{
			this.Name = name;
			this.cells = cells;
			this.Z = cells.GetLength(0);
			this.Y = cells.GetLength(1);
			this.X = cells.GetLength(2);
		}

		public string Name
		{
			get;
			private set;
		}

		public int Z
		{
			get;
			private set;
		}

		public int Y
		{
			get;
			private set;
		}

		public int X
		{
			get;
			private set;
		}

		public List<Figure> GetRotations()
		{
			if (this.rotations == null)
			{
				this.rotations = CalculateRotations(this);
			}

			return this.rotations;
		}

		private static List<Figure> CalculateRotations(Figure original)
		{
			var allRotations = new List<Figure>();

			var xRotations = GetAxisRotations(original, RotateX);
			foreach (var xRotation in xRotations)
			{
				var yRotations = GetAxisRotations(xRotation, RotateY);
				foreach (var yRotation in yRotations)
				{
					var zRotations = GetAxisRotations(yRotation, RotateZ);
					foreach (var zRotation in zRotations)
					{
						allRotations.Add(zRotation);
					}
				}
			}

			var uniqueRotations = new List<Figure>();
			foreach (var rotation in allRotations)
			{
				if (!uniqueRotations.Any(ur => Figure.AreSameRotations(ur, rotation)))
				{
					uniqueRotations.Add(rotation);
				}
			}

			return uniqueRotations;
		}

		// rotate over X or other axis
		private static List<Figure> GetAxisRotations(Figure original, Func<Figure, Figure> rotateFunc)
		{
			var rotations = new List<Figure>();

			var current = original;
			for (var i = 0; i < 4; i++)
			{
				rotations.Add(current);
				current = rotateFunc(current);
			}

			return rotations;
		}

		private static Figure RotateX(Figure original)
		{
			var newCells = new int[original.Y, original.Z, original.X];

			for (var i = 0; i < original.Z; i++)
			{
				for (var j = 0; j < original.Y; j++)
				{
					for (var k = 0; k < original.X; k++)
					{
						newCells[j, original.Z - i - 1, k] = original.cells[i, j, k];
					}
				}
			}

			return new Figure(original.Name, newCells);
		}

		private static Figure RotateY(Figure original)
		{
			var newCells = new int[original.X, original.Y, original.Z];

			for (var i = 0; i < original.Z; i++)
			{
				for (var j = 0; j < original.Y; j++)
				{
					for (var k = 0; k < original.X; k++)
					{
						newCells[k, j, original.Z - i - 1] = original.cells[i, j, k];
					}
				}
			}

			return new Figure(original.Name, newCells);
		}

		private static Figure RotateZ(Figure original)
		{
			var newCells = new int[original.Z, original.X, original.Y];

			for (var i = 0; i < original.Z; i++)
			{
				for (var j = 0; j < original.Y; j++)
				{
					for (var k = 0; k < original.X; k++)
					{
						newCells[i, k, original.Y - j - 1] = original.cells[i, j, k];
					}
				}
			}

			return new Figure(original.Name, newCells);
		}

		private static bool AreSameRotations(Figure figure1, Figure figure2)
		{
			if (figure1.X != figure2.X
				|| figure1.Y != figure2.Y
				|| figure1.Z != figure2.Z)
			{
				return false;
			}

			for (var i = 0; i < figure1.Z; i++)
			{
				for (var j = 0; j < figure1.Y; j++)
				{
					for (var k = 0; k < figure1.X; k++)
					{
						if (figure1.cells[i, j, k] != figure2.cells[i, j, k])
						{
							return false;
						}
					}
				}
			}

			return true;
		}

		public override String ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine("Figure " + this.Name);

			for (var i = 0; i < this.Z; i++)
			{
				builder.AppendLine("Layer Z" + i);
				for (var j = 0; j < this.Y; j++)
				{
					var row = Enumerable.Range(0, this.X).Select(k => this.cells[i, j, k]);
					builder.AppendLine(String.Join(", ", row));
				}
				if (i != this.Z - 1)
				{
					builder.AppendLine();
				}
			}

			return builder.ToString();
		}
	}
}

