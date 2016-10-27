using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace AirBook
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, IHostingEnvironment env)
        {
            //TODO: Logging
            loggerFactory.AddConsole(LogLevel.Warning, true);

            //TODO: Error Handler
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            //TODO: Use JWT as Identity

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{version?}/{controller=Home}/{action=Index}/{id?}");
            });

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services.AddMvc();
        }
    }
}
