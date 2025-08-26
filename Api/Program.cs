using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using MinimalApi;

IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
      .ConfigureWebHostDefaults(webBuilder =>
      {
          webBuilder.UseStartup<Startup>();
      });
}

CreateHostBuilder(args).Build().Run();