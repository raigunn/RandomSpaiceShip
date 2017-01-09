using System.Runtime.Serialization;

namespace GameServices.Models.Responses
{
	[DataContract]
	public class PingResponse
	{
		[DataMember(Name = "ping")]
		public string Ping { get; set; }
	}
}
