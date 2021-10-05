using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.TodoItem;

namespace Infrastructure
{
    public static class Startup
    {
        public static void ConfigureInfrastruture(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<MyProjectNameDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Sql"));
            });
            services.AddScoped<MyProjectNameDbContext>();
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

        }
    }
}
