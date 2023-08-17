using Data;
using Data.IRepository;
using Data.Unit;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace Ecommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                //pattern: "{area=User}/{controller=Auth}/{action=Login}/{id?}");
                //pattern: "{area=Admin}/{controller=MainPage}/{action=Index}/{id?}");   
                pattern: "{area=User}/{controller=MainPage}/{action=Index}/{id?}") ;
                


            app.MapRazorPages();

            app.Run();
        }
    }
}