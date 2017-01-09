using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Threading;
using GameServices.Extensions;
using GameServices.Logic;
using GameServices.Models.Requests;
using GameServices.Models.Responses;


namespace GameServices
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, IncludeExceptionDetailInFaults = true)]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class RestGameServices : IRestGameServices
	{
		/// <summary>
		/// { "Ping" : { "type" : string } }
		/// </summary>
		/// <returns></returns>
		public PingResponse Ping()
		{
			var response = new PingResponse();
			response.Ping = "argg, you got me";
			return response;
		}
		/// <summary>
		/// { "ShipName" : { "type" : string } }
		/// </summary>
		/// <returns></returns>
		public RegisterResponse Register(string id)
		{
			RegisterResponse response = new RegisterResponse() {ShipName = "RandomSpaiceShip " + id};
			return response;
		}

		public TurnResponse Turn(GameState gameState)
		{
			var turnResponse = new TurnResponse();
			Player player = gameState.Players.SingleOrDefault(x => x.Me == "true");
			if (player == null) return turnResponse;  // todo: error handling

			Position preMovePosition = player.Position;
			int directionToMove = new RandomMoveLogic(gameState.GridSize, preMovePosition).Direction;

			// figure out new position, then send to shoot generator.
			Position postMovePosition = Directions.ConvertDirectionToPosition(directionToMove, preMovePosition);

			int directionToShoot = new RandomShootLogic(gameState.GridSize, postMovePosition).Direction;

			turnResponse.MoveDirection = directionToMove;
			turnResponse.ShootDirection = directionToShoot;
			turnResponse.PlayerId = player.Id;

			Thread.Sleep(2000); // simulate a slow response time
			player.Log();
			turnResponse.Log();
			Console.WriteLine();
			return turnResponse;
		}
	}
}
