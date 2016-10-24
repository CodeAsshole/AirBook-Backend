using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //TODO: Logging

            //TODO: Error Handler

            app.UseStaticFiles();

            //TODO: Use JWT as Identity

            app.UseMvc();

        }

        public void ConfigureServices(IServiceCollection services)
        {
          services.AddMvc();
        }
    }
}
