using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace DemoWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<BookContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("BookContext") ?? throw new InvalidOperationException("Connection string 'BookContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            IWebHostEnvironment _env = app.Services.GetRequiredService<IWebHostEnvironment>();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}