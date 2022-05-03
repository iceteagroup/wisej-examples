using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Wisej.Core;

namespace Integration4
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public IConfiguration Configuration { get; }

		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(new WebApplicationOptions
			{
				Args = args,
				WebRootPath = "./"
			});

			var app = builder.Build();
			app.UseWisej();
			app.UseFileServer();
			app.Run();
		}
	}
}
