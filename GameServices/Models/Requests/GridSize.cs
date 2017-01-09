using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Models.Requests
{
	[DataContract]
	public class GridSize
	{
		[DataMember]
		public int Cols { get; set; }
		[DataMember]
		public int Rows { get; set; }
		public GridSize(int cols, int rows)
		{
			Cols = cols;
			Rows = rows;
		}
	}
}
