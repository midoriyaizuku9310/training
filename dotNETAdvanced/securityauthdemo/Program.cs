using Microsoft.AspNetCore.Authentication.Cookies;

namespace securityauthdemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           
            //specify the pages or folders to secure
            builder.Services.AddRazorPages(options=>options.Conventions.AuthorizePage("/home"));

            // Add services to the container.
            builder.Services
                .AddAuthentication(CookieAuthenticationDefaults
                .AuthenticationScheme)
                .AddCookie(options=>options.LoginPath="/login");

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
          

            app.MapRazorPages();

            app.Run();
        }
    }
}
