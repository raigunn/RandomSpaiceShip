using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.Requests
{
	[DataContract]
	public class GameState
	{
		[DataMember]
		public int Round { get; set; }
		[DataMember]
		public int[] GridSize { get; set; }
		[DataMember]
		public List<int[]> Players { get; set; }
	}
}
