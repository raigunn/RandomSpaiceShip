using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Services.Logic;
using Services.Models.Requests;
using Services.Models.Responses;


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

		public TurnResponse Turn(GameState gameState)
		{
			var turnResponse = new TurnResponse();

			int move = GetMoveDirection(new RandomMoveLogic(gameState.GridSize, gameState.Players[0]));
			int shoot = GetShootDirection(new RandomShootLogic(gameState.GridSize, gameState.Players[0]));

			turnResponse.MoveDirection = move;
			turnResponse.ShootDirection = shoot;
			return turnResponse;
		}


		public int GetMoveDirection(IMoveLogic iMoveLogic)
		{
			return iMoveLogic.Direction;
		}

		public int GetShootDirection(IShootLogic iShootLogic)
		{
			return iShootLogic.Direction;
		}
	}
}
