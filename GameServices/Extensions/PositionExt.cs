using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServices.Models.Requests;

namespace GameServices.Extensions
{
	public static class PositionExt
	{
		public static void Log(this Position position)
		{
			Console.WriteLine($"position: ({position.X}, {position.Y})");
		}
	}
}
