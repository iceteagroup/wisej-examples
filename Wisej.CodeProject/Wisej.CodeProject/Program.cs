using System;
using System.Diagnostics;
using Wisej.Web;

namespace Wisej.CodeProject
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.Desktop = new MyDesktop();
		}
		
		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}

		internal static float CPU
		{
			get
			{
				// returns a random number for this sample.
				// returning the CPU Usage % requires elevated
				// permissions on the server side.
				lock (theCPUCounter)
				{
					return theCPUCounter.Next(50);
					// return theCPUCounter.NextValue();
				}
			}
		}
		private static Random theCPUCounter = new Random();
		// private static PerformanceCounter theCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
	}
}