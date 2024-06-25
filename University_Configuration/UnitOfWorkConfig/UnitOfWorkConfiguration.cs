using Microsoft.Extensions.DependencyInjection;
using University_Common.Domain;
using University_EfCore.Repository.UnitOfWork;

namespace University_Configuration.UnitOfWorkConfig
{
    public static class UnitOfWorkConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
