using System;
namespace CubePuzzleSolve
{
	/// <summary>
	/// The position of the cell in the cube or in the figure.
	/// </summary>
	public class CellPosition
	{
		public CellPosition(int z, int y, int x)
		{
			this.Z = z;
			this.Y = y;
			this.X = x;
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
	}
}

