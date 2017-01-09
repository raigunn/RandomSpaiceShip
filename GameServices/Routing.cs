using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServices
{
	public static class Routing
	{
		public const string GetPingRoute = "/Ping";
		public const string GetTurnRoute = "/Turn";
		public const string GetRegisterRoute = "/Register/{id}";
	}
}