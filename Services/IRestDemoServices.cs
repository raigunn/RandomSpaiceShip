using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using Services.Models.Requests;
using Services.Models.Responses;

//http://www.progware.org/Blog/post/A-simple-REST-service-in-C.aspx
namespace Services
{
	[ServiceContract(Name = "RestDemoServices")]
  public interface IRestDemoServices
  {
		[OperationContract]
		[WebGet(UriTemplate = Routing.GetClientRoute, BodyStyle = WebMessageBodyStyle.Bare)]
		string Ping(string word);

		[OperationContract]
		[WebGet(UriTemplate = Routing.GetJsonRoute, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
		PingResponse Json();


		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = Routing.GetTurnRoute, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
		TurnResponse Turn(GameState gameState);
	}
}
