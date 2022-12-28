using FriendXY.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Configurantions for manager SQL conexion
builder.Services.AddDbContext<DBBirthdayContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBBirthdayContext")));

var app = builder.Build();

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
    pattern: "{controller=Friends}/{action=Home}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller= Friends}/{action= Details}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller= Friends}/{action= Delete}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller= Friends}/{action= Create}/{id?}");



app.Run();
