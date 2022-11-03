using Microsoft.EntityFrameworkCore;
using Model.General;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

IConfiguration configuration = app.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<Settings>(options => configuration.GetSection("Settings").Bind(options));

var connection = configuration["ConexaoMySql:ConnectionString"];

builder.Services.AddDbContext<Context.AppContext>(opt => opt.UseSqlServer(connection));

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
