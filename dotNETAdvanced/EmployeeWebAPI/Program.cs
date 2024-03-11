
using AutoMapper;
using EmployeeWebAPI.Models;

namespace EmployeeWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //to configure XML response format
            builder.Services.AddControllers().AddXmlSerializerFormatters();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //configure automapper

            MapperConfiguration config = new MapperConfiguration(c =>
                                         c.AddProfile(new CustomerProfile()));

            IMapper mapper = config.CreateMapper();
            //add mappper
            builder.Services.AddSingleton(mapper);


            //configure the dependency injection to inject the DataAccess class
            builder.Services.AddScoped<IEmpDataAceess, EmployeeDataAccess>();
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
