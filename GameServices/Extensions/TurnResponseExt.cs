using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServices.Models.Responses;

namespace GameServices.Extensions
{
	public static class TurnResponseExt
	{
		public static void Log(this TurnResponse turnResponse)
		{
			Console.WriteLine($"move: {turnResponse.MoveDirection}, shoot: {turnResponse.ShootDirection}");
		}
	}
}
