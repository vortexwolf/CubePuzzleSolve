using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubePuzzleSolve
{
	public class Cube
	{
		public Cube(int size)
		{
			this.Size = size;
			this.Cells = new string[size, size, size];
			this.Figures = new List<Figure>();
		}

		public int Size  
		{
			get;
			private set;
		}

		public string[,,] Cells
		{
			get;
			private set;
		}

		public List<Figure> Figures
		{
			get;
			private set;
		}

		/// <summary>
		/// Creates a copy of this cube so that this one isn't changed.
		/// </summary>
		public Cube Clone()
		{
			var cube = new Cube(this.Size);
			cube.Cells = (string[,,])this.Cells.Clone();
			cube.Figures = this.Figures.ToList();

			return cube;
		}

		/// <summary>
		/// Returns whether all cells of this cube are filled by figures.
		/// </summary>
		/// <returns>Whether this cube is full.</returns>
		public bool IsSolved()
		{
			for (var i = 0; i < this.Size; i++)
			{
				for (var j = 0; j < this.Size; j++)
				{
					for (var k = 0; k < this.Size; k++)
					{
						if (this.Cells[i, j, k] == null)
						{
							return false;
						}
					}
				}
			}

			return true;
		}

		/// <summary>
		/// Returns whether the specified coordinates exist in this cube.
		/// </summary>
		/// <returns>Whether the specified coordinates exist in this cube.</returns>
		public bool IsInRange(int zPos, int yPos, int xPos)
		{
			return zPos >= 0 && zPos < this.Size
				   && yPos >= 0 && yPos < this.Size
                   && xPos >= 0 && xPos < this.Size;
		}

		public override String ToString()
		{
			StringBuilder builder = new StringBuilder();

			for (var i = 0; i < this.Size; i++)
			{
				builder.AppendLine("Layer Z" + i);
				for (var j = 0; j < this.Size; j++)
				{
					var row = Enumerable.Range(0, this.Size).Select(k => this.Cells[i, j, k]);
					builder.AppendLine(String.Join(", ", row));
				}
				if (i != this.Size - 1)
				{
					builder.AppendLine();
				}
			}

			return builder.ToString();
		}
	}
}

