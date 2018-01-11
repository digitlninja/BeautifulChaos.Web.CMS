using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Web
{
  // ORDER MATTERS
  public class Startup
  {
    // Represents root of configuration file (previously in web.config) -> represents all config needed to run app
    public IConfigurationRoot Configuration { get; }

    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        .AddJsonFile($"ConfigSettings.json")
        .AddEnvironmentVariables();
      Configuration = builder.Build();

      /*  if(env.IsDevelopment())
            builder.AddUserSecrets<ConfigSettings>();
        var x = 0;*/
    }


    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services) // DI Container for services
    {
      services.AddMvc();
    }

    /* 
     * Allows us to configure  the pipeline - AspNet.Core Assumes you're using no frameworks unless they are explicitly defined. 
     * Use this method to tell asp core what frameworks you would like to use for this app 
     * ------------------------------------------------------------------------------------
     * -- IApplicationBuilder = allows us to add services to the pipeline for this app.
     * -- IHostingProvider = stores information about the hosting envrionment the app is running in.
     * -- ILoggerFactory = allows us to add and configure logging provider.
     */
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      loggerFactory.AddConsole(Configuration.GetSection("Logging"));

      // Allows serving static files (CSS, JS etc)
      app.UseStaticFiles();

      // This will serve up wwwroot
      app.UseFileServer();

      app.UseStatusCodePages();

      // Add Identity to the pipeline (auth etc), before MVC.
      app.UseAuthentication();

      // define default routes
      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}"
        );

        routes.MapRoute(
          name: "login",
          template: "{controller=Account}/{action=Login}/{id?}"
        );
      });

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("Home/Error");
      }
    }
  }
}
