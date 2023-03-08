using System;
using System.Management.Instrumentation;
using Wisej.Web;

namespace Wisej.WebAuthnDemo
{
	internal static class Program
	{
		static Program()
		{
			Application.Services.AddService<UserStorageService>();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.MainPage = new Page1();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}