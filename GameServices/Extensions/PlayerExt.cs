using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServices.Models.Requests;

namespace GameServices.Extensions
{
	public static class PlayerExt
	{
		public static void Log(this Player player)
		{
			Console.WriteLine($"player id: {player.Id}");
			Console.WriteLine($"player name: {player.Name}");
			player.Position.Log();
		}
	}
}
