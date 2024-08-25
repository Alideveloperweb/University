using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using University_EfCore.Context;

namespace University_Configuration
{
    public static class ConnectionConfig
    {
        public static void ConfigureSqlServer(this IServiceCollection services, string Connection)
        {
            services.AddDbContext<SqlServerDbContext>(options =>
            {
                options.UseSqlServer(Connection);
            });

        }
        public static void ConfigureSqlite(this IServiceCollection services, string Connection)
        {
            services.AddDbContext<SqliteDbContext>(options =>
            {
                options.UseSqlite(Connection);
            });
        }
    }
}
