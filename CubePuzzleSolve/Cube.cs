using System;
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

