using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logic
{
	public static class Directions
	{
		// figure out available moves
		// if x == 0, then cannot move left
		// if x == gridSize - 1, then cannot move right
		// if y == 0, cannot move up
		// if y == gridSize - 1, cannot move down
		public static List<int> Available(int gridWidth, int gridHeight, int x, int y)
		{
			List<int> availableDirections = new List<int>();
			if (x > 0) availableDirections.Add(3);
			if (x < gridWidth - 2) availableDirections.Add(1);
			if (y > 0) availableDirections.Add(0);
			if (y < gridHeight - 2) availableDirections.Add(2);
			return availableDirections;
		}

		//Function to get random number
		private static readonly Random random = new Random();
		private static readonly object syncLock = new object();
		public static int RandomNumber(int min, int max)
		{
			lock (syncLock)
			{ // synchronize
				return random.Next(min, max);
			}
		}
	}
}
