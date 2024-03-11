
using AutoMapper;
using EmployeeWebAPI.Models;

namespace BookApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            MapperConfiguration config = new MapperConfiguration(c =>
                                         c.AddProfile(new CustomerProfile()));

            IMapper mapper = config.CreateMapper();
            //add mappper
            builder.Services.AddSingleton(mapper);
            builder.Services.AddScoped<IBookDataAccess, BookDataAccess>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
