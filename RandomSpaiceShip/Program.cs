using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using GameServices;

namespace RandomSpaiceShip
{
	class Program
	{
		static void Main(string[] args)
		{
			RestGameServices gameServices = new RestGameServices();
			WebServiceHost serviceHost = new WebServiceHost(gameServices, new Uri("http://localhost:8000/RandomSpaiceShip"));
			serviceHost.Open();
			Console.ReadKey();
			serviceHost.Close();
		}
	}
}
