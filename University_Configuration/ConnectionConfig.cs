
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using University_EfCore.Context;

namespace University_Configuration
{
    public static class ConnectionConfig
    {
        public static void Configure(this IServiceCollection services, string Connection)
        {
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(Connection);
            });

            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlLite(Connection);
            });
        }
    }
}
