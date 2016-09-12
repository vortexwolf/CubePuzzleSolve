﻿using System;
namespace CubePuzzleSolve
{
	public static class PuzzleConfig
	{
		public static Figure Figure1 = new Figure("F1", new int[4, 4, 3]
		{
			{ { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } },
			{ { 1, 0, 0 }, { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } },
			{ { 0, 0, 0 }, { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } },
			{ { 0, 0, 0 }, { 1, 0, 0 }, { 1, 1, 1 }, { 0, 0, 1 } },
		});

		public static Figure Figure2 = new Figure("F2", new int[2, 3, 4]
		{
			{ { 0, 0, 1, 1 }, { 0, 0, 1, 0 }, { 1, 0, 0, 0 } },
			{ { 1, 0, 0, 0 }, { 1, 1, 1, 0 }, { 1, 0, 0, 0 } },
		});

		public static Figure Figure3 = new Figure("F3", new int[2, 3, 4]
		{
			{ { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 1, 1, 1 } },
			{ { 1, 0, 0, 0 }, { 1, 1, 0, 0 }, { 0, 1, 0, 1 } },
		});

		public static Figure Figure4 = new Figure("F4", new int[2, 4, 4]
		{
			{ { 0, 0, 1, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 } },
			{ { 0, 1, 1, 0 }, { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } },
		});

		public static Figure Figure5 = new Figure("F5", new int[2, 3, 4]
		{
			{ { 1, 0, 0, 1 }, { 1, 1, 0, 1 }, { 0, 0, 0, 0 } },
			{ { 0, 0, 0, 0 }, { 0, 1, 1, 1 }, { 0, 0, 1, 0 } },
		});

		public static Figure Figure6 = new Figure("F6", new int[2, 2, 4]
		{
			{ { 0, 0, 1, 1 }, { 1, 0, 0, 1 } },
			{ { 0, 1, 1, 0 }, { 1, 1, 0, 0 } }
		});

		public static Figure Figure7 = new Figure("F7", new int[2, 2, 4]
		{
			{ { 0, 0, 0, 0 }, { 0, 0, 1, 1 } },
			{ { 1, 1, 1, 0 }, { 1, 0, 1, 0 } }
		});

		public static Figure Figure8 = new Figure("F8", new int[1, 2, 2]
		{
			{ { 1, 1 }, { 1, 0 } }
		});
	}
}

