namespace Gshahine.DotNetCore
{
  using System.IO;
  using Microsoft.AspNetCore.Hosting;

  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
                .UseApplicationInsights()
          .UseKestrel()
          .UseContentRoot(Directory.GetCurrentDirectory())
          .UseIISIntegration()
          .UseStartup<Startup>()
          .Build();

      host.Run();
    }
  }
}
