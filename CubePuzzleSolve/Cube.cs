using System;
namespace Application
{
	public class Cube
	{
		private readonly string[,,] cells;

		public Cube(int size)
		{
			this.Size = size;
			this.cells = new string[size, size, size];
		}

		public int Size  {
			get;
			private set;
		}
	}
}

