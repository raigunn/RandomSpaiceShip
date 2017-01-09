using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Models.Requests
{
	[DataContract]
	public class GameState
	{
		[DataMember]
		public int Round { get; set; }
		[DataMember]
		public GridSize GridSize { get; set; }
		[DataMember]
		public List<Player> Players { get; set; }
		[DataMember]
		public int Identifier { get; set; }
	}
}
