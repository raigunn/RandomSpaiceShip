using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Models.Requests;

namespace Services.Logic
{
	public class RandomShootLogic : IShootLogic
	{
		// convenience
		private readonly int _gridWidth;
		private readonly int _gridHeight;
		private readonly int _x;
		private readonly int _y;
		private readonly List<int> _availableDirections;

		// up = 0, right = 1, down = 2, left = 3
		public RandomShootLogic(int[] gridSize, Position currentPosition)
		{
			// convenience
			_gridWidth = gridSize[0];
			_gridHeight = gridSize[1];
			_x = currentPosition.X;
			_y = currentPosition.Y;
			_availableDirections = Directions.Available(_gridWidth, _gridHeight, _x, _y);
		}

		public int Direction
		{
			get
			{
				int index = Directions.RandomNumber(0, _availableDirections.Count);
				int direction = _availableDirections[index];
				return direction; 
			}
		}

	}
}
