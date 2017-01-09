using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Models.Requests
{
	[DataContract]
	public class Position
	{
		[DataMember]
		public int X { get; set; }
		[DataMember]
		public int Y { get; set; }

		public Position(int x, int y)
		{
			X = x;
			Y = y;
		}
	}
}
