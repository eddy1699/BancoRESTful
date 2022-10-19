using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;
using Persistance.Repository;

namespace Persistance
{
    public static class ServiceExtensions
    {
        public static void AddPersistanceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
           services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                h => h.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            #region Repositories
            services.AddTransient(typeof(MyRepositoryAsync<>), typeof(MyRepositoryAsync<>));
            #endregion
        }

    }
}

    