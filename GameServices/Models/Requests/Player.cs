using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Models.Requests
{
	[DataContract]
	public class Player
	{
		[DataMember]
		public string Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public string Url { get; set; }
		[DataMember]
		public Position Position { get; set; }
		[DataMember]
		public int ShootDirection { get; set; }
		[DataMember]
		public string Me { get; set; }

		public Player(string id, string name, string url, Position position, int shootDirection, string me)
		{
			Id = id;
			Name = name;
			Url = url;
			Position = position;
			ShootDirection = shootDirection;
			Me = me;
		}
	}
}
