using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using Services.Logic;
using Services.Models.Requests;
using Services.Models.Responses;


namespace Services
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, IncludeExceptionDetailInFaults = true)]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class RestDemoServices : IRestDemoServices
	{
		public PingResponse Ping()
		{
			var response = new PingResponse();
			response.Ping = "argg, you got me";
			return response;
		}

		public TurnResponse Turn(GameState gameState)
		{
			var turnResponse = new TurnResponse();

			int move = GetMoveDirection(new RandomMoveLogic(gameState.GridSize, gameState.Players[0].Position));
			int shoot = GetShootDirection(new RandomShootLogic(gameState.GridSize, gameState.Players[0].Position));

			turnResponse.MoveDirection = move;
			turnResponse.ShootDirection = shoot;
			Thread.Sleep(2000);
			Console.WriteLine("default 1: " + move + " : " + shoot);
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
