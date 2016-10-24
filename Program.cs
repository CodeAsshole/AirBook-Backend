using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace aspnetcoreapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()                                                   //Kestrel is like some ASP IIS
                .UseContentRoot(Directory.GetCurrentDirectory())                //Looks like some context
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
