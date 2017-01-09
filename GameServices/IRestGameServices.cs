using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using GameServices.Models.Requests;
using GameServices.Models.Responses;

//http://www.progware.org/Blog/post/A-simple-REST-service-in-C.aspx
namespace GameServices
{
	[ServiceContract(Name = "RestDemoServices")]
  public interface IRestGameServices
  {
		[OperationContract]
		[WebGet(UriTemplate = Routing.GetPingRoute, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
		PingResponse Ping();

		[OperationContract]
		[WebGet(UriTemplate = Routing.GetRegisterRoute, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
		RegisterResponse Register(string id);
		
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = Routing.GetTurnRoute, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
		TurnResponse Turn(GameState gameState);
	}
}
