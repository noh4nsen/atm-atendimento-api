using Atm.Atendimento.Dados.Repositories;
using Atm.Atendimento.Domain;
using Atm.Atendimento.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Atm.Atendimento.Dados.Extensions
{
    internal static class ServiceCollectionExtensions
    {
        internal static void SetupRepositories(this IServiceCollection services)
        {

        }

        internal static void SetupDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DbContext>(options =>
                options.EnableSensitiveDataLogging()
                       .UseNpgsql(connectionString, b => b.MigrationsAssembly(typeof(DbContext).Assembly.FullName))
            );
        }
    }
}
