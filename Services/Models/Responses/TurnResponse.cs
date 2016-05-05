using System.Runtime.Serialization;

namespace Services.Models.Responses
{
	[DataContract]
	public class TurnResponse
	{
		[DataMember]
		public int MoveDirection { get; set; }
		[DataMember]
		public int ShootDirection { get; set; }
	}
}
