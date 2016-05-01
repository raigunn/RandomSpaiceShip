using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace Services
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class RestDemoServices : IRestDemoServices
	{
		public string Ping(string word)
		{
			return "Ping " + word;
		}

		public PingResponse Json()
		{
			var response = new PingResponse();
			response.Ping = "argg, you got me";
			return response;
		}

		public TurnResponse Turn()
		{
			var turn = new TurnResponse();
			turn.MoveDirection = "1";
			turn.ShootDirection = "2";
			return turn;
		}
	}
}
