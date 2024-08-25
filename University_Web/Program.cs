

using University_Configuration;
using University_Configuration.UnitOfWorkConfig;
using University_EfCore.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


#region Context

string ConnectionSqlServer = builder.Configuration.GetConnectionString("SqlServerConnection");
string ConnectionSqlLite = builder.Configuration.GetConnectionString("SqliteConnection");

#endregion

#region AutoMapper 

builder.Services.AddAutoMapper(typeof(MappingProfile));

#endregion

#region Configuration

ConnectionConfig.ConfigureSqlServer(builder.Services, ConnectionSqlServer);
ConnectionConfig.ConfigureSqlite(builder.Services, ConnectionSqlLite);
UnitOfWorkConfiguration.Configure(builder.Services);

#endregion

var app = builder.Build();



app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
