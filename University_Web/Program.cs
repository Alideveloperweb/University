using University_Common.Application;
using University_Configuration;
using University_Configuration.UnitOfWorkConfig;
using University_EfCore.AutoMapper;
using University_Web.ErrorHandlingSample;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddExceptionHandler<CustomExceptionHandler>();
#region Context

string ConnectionSqlServer = builder.Configuration.GetConnectionString("SqlServerConnection");
//string ConnectionSqlLite = builder.Configuration.GetConnectionString("SqliteConnection");

#endregion

#region AutoMapper 

builder.Services.AddAutoMapper(typeof(MappingProfile));

#endregion

#region Configuration

ConnectionConfig.ConfigureSqlServer(builder.Services, ConnectionSqlServer);
//ConnectionConfig.ConfigureSqlite(builder.Services, ConnectionSqlLite);
UnitOfWorkConfiguration.Configure(builder.Services);

#endregion

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStatusCodePages();
app.UseStatusCodePages(Text.Plain, "Status Code Page: {0}");
app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
