using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;

using AirBook.Options;

namespace AirBook
{
    public class Startup
    {
        public IConfigurationRoot Configuration;
        public Startup(IHostingEnvironment env){
            //Init Configuration
            //The builder can AddJsonFile AddCommandLine AddInMemoryCollection and so on
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(env.ContentRootPath);
            builder.AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

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
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePages();
            }

            app.UseStaticFiles();

            //TODO: Use JWT as Identity

            app.UseMvc(routes =>
            {
                //Note: This ROUTE requires every request contains a version as a parameter 
                routes.MapRoute("default", "{version?}/{controller=Home}/{action=Index}/{id?}");
            });

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services.AddMvc();
            services.AddOptions();
            services.Configure<TestOptions>(testOptions => 
            {
                testOptions.Option1 = Configuration["Versions:CurrentVersion"];
            });
            //In tutorial, we can just Use
            //services.Configure<MyOptions>(Configuration);
            //But failed when I use like this
        }
    }
}
