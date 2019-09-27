using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesAPI.Services;

namespace MoviesAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "Server=localhost;Database=MoviesDB;User Id=sa;Password=Passw0rd!;";

            services
                 .AddDbContext<MoviesDbContext>(o =>
                   o.UseSqlServer(connectionString));

            services.AddMvc();
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MoviesDbContext moviesDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                var options = new WebpackDevMiddlewareOptions()
                {
                    HotModuleReplacement = true
                };
                app.UseWebpackDevMiddleware(options);
            }
            app.UseStaticFiles();
            moviesDbContext.CreateSeedData();
            app.UseMvc();
        }
    }
}
