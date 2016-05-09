using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.Requests
{
	[DataContract]
	public class Player
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public Position Position { get; set; }
		[DataMember]
		public int ShootDirection { get; set; }

		public Player(int id, string name, Position position, int shootDirection)
		{
			Id = id;
			Name = name;
			Position = position;
			ShootDirection = shootDirection;
		}
	}
}
