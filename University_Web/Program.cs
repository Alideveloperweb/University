

using University_Configuration;
using University_Configuration.UnitOfWorkConfig;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


#region Context

string Connection = builder.Configuration.GetConnectionString("UniversityContext");

#endregion

#region Configuration
ConnectionConfig.Configure(builder.Services, Connection);
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
