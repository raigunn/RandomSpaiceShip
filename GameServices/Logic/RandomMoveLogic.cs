using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServices.Models.Requests;

namespace GameServices.Logic
{
	public class RandomMoveLogic : IMoveLogic
	{
		// convenience
		private readonly List<int> _availableDirections;

		// up = 0, right = 1, down = 2, left = 3
		public RandomMoveLogic(GridSize gridSize, Position currentPosition)
		{
			// convenience
			var gridWidth = gridSize.Cols;
			var gridHeight = gridSize.Rows;
			var x = currentPosition.X;
			var y = currentPosition.Y;
			_availableDirections = Directions.Available(gridWidth, gridHeight, x, y);
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
