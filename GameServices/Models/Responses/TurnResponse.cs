using System.Runtime.Serialization;

namespace GameServices.Models.Responses
{
	[DataContract]
	public class TurnResponse
	{
		[DataMember]
		public int MoveDirection { get; set; }
		[DataMember]
		public int ShootDirection { get; set; }
		[DataMember]
		public string PlayerId { get; set; }
	}
}
