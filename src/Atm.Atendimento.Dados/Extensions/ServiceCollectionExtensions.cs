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
            services.AddScoped(typeof(IRepository<Orcamento>), typeof(Repository<Orcamento>));
            services.AddScoped(typeof(IRepository<Peca>), typeof(Repository<Peca>));
            services.AddScoped(typeof(IRepository<CustoServico>), typeof(Repository<CustoServico>));
            services.AddScoped(typeof(IRepository<Servico>), typeof(Repository<Servico>));
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
