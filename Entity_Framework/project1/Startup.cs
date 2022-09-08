using Microsoft.AspNetCore.Builder;
using project1.Data;
using Microsoft.EntityFrameworkCore;

/*namespace project1
{
    public class Startup
    {
         public void Configure(IApplicationBuilder app)
          {

          }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbContext,SchoolContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
           // services.AddScoped<DbContext, SchoolContext>();
            
            

            services.AddDatabaseDeveloperPageExceptionFilter();

           

           


            services.AddControllersWithViews();
        }
    }
}*/



namespace project1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<SchoolContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();

            services.AddControllersWithViews();
            services.AddDatabaseDeveloperPageExceptionFilter();
        }
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            });
        }

    }
}
