using MVCApp2.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
namespace MVCApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSession();
            
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages(options=> options.Conventions.AuthorizePage("/login"));

            builder.Services.AddAuthentication(CookieAuthenticationDefaults
                .AuthenticationScheme)
                .AddCookie(options => options.LoginPath = "/Userlogin"
                );

            builder.Services.AddDbContext<StudentsContext>();
            var app = builder.Build();
            app.UseSession();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Products}/{action=HomePage}/{id?}");

            app.Run();
        }
    }
}
