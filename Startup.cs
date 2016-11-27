using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;


namespace webapp
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {

        }

        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
           app.UseMvc(routes =>
           {
               routes.MapRoute("default",
                   template: "{controller=Home}/{action=Index}/{id?}");
           });
        }
    }
}
