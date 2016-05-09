using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Services.Logic;

namespace GameServicesTests
{
	[TestFixture]
	public class DirectionsTests
	{
		[Test]
		public void Test_TopLeftCorner()
		{
			List<int> available = Directions.Available(8, 8, 0, 0);
			Assert.Contains(1, available);
			Assert.Contains(2, available);
			Assert.AreEqual(2, available.Count);
		}

		[Test]
		public void Test_TopRightCorner()
		{
			List<int> available = Directions.Available(8, 8, 7, 0);
			Assert.Contains(3, available);
			Assert.Contains(2, available);
			Assert.AreEqual(2, available.Count);
		}

		[Test]
		public void Test_BottomLeftCorner()
		{
			List<int> available = Directions.Available(8, 8, 0, 7);
			Assert.Contains(1, available);
			Assert.Contains(0, available);
			Assert.AreEqual(2, available.Count);
		}

		[Test]
		public void Test_BottomRightCorner()
		{
			List<int> available = Directions.Available(8, 8, 7, 7);
			Assert.Contains(0, available);
			Assert.Contains(3, available);
			Assert.AreEqual(2, available.Count);
		}
	}
}
