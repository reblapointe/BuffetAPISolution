using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BuffetAPI.Data;
using Serilog;

namespace BuffetAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<BuffetAPIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("BuffetAPIContext") ?? throw new InvalidOperationException("Connection string 'BuffetAPIContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            /*...*/
            builder.Services.AddSwaggerGen();
            builder.Host.UseSerilog((context, config) =>
            {
                config.WriteTo.Console().ReadFrom.Configuration(context.Configuration)
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentName()
                .Enrich.WithProperty("ApplicationName", context.HostingEnvironment.ApplicationName);
            });

            var app = builder.Build();
            /*...*/
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
