using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SurveyAppMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using SurveyAppMVC.Services;
using SurveyAppMVC.Infrastructure.Data;
using SurveyAppMVC.Infrastructure.Repository;
using SurveyAppMVCMVC.Infrastructure.Data;
using SurveyAppMVC.Injections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("db");
if (connectionString != null)
{
    builder.Services.AddInjections(connectionString);
}

builder.Services.AddCors(build=>
{
    build.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<SurveyDbContext>();
//context.Database.EnsureCreated();
DbSeeding.SeedDatabase(context);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
