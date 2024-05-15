using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SimulationMicoHospital.Business.Services.Abstracts;
using SimulationMicoHospital.Business.Services.Concretes;
using SimulationMicoHospital.Core.Models;
using SimulationMicoHospital.Core.RepositoryAbstracts;
using SimulationMicoHospital.Data.DAL;
using SimulationMicoHospital.Data.RepositoryConcretes;

namespace SimulationMicoHospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("default"));
            });

            builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = true;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = true;
                opt.Password.RequireDigit = true;

                opt.User.RequireUniqueEmail = false;


            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


            builder.Services.AddScoped<ISliderRepository, SliderRepository>();
            builder.Services.AddScoped<ISliderService, SliderService>();

            var app = builder.Build();



            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
