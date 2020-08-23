using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection {
    public class ConfigureRepository {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection) {
            serviceCollection.AddScoped (typeof (IRepository<>), typeof (BaseRepository<>));
            serviceCollection.AddDbContext<MyContext> (
                opt => opt.UseSqlServer ("Data Source=DESKTOP-D9VV8QN;Initial Catalog=dbAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
        }
    }
}
