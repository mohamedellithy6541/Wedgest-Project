
using Microsoft.EntityFrameworkCore;
using Wedgest.Data;
using Wedgest.DTOS;
using Wedgest.Repositories;
using Wedgest.TicketRepo;

namespace Wedgest
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
            #region Resgister My services
            builder.Services.AddScoped<ApplicationContext>();
            builder.Services.AddDbContext<ApplicationContext>(options =>
            options.UseMySql(
              builder.Configuration.GetConnectionString("Conf"),
                  new MySqlServerVersion(new Version(8, 0, 2))));
            builder.Services.AddScoped(typeof(IGenaricRepository<>), typeof(GenaricRepository<>));
            builder.Services.AddScoped<ITicketRepositry, TiketRepository>();
            builder.Services.AddAutoMapper(typeof(MapTickets));
            #endregion

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
