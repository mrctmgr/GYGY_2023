using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MovieFlix.Core.Contracts.Repository;
using MovieFlix.Core.Contracts.Service;
using MovieFlix.Core.Entities;
using MovieFlix.Infrastructure.Data;
using MovieFlix.Infrastructure.Repository;
using MovieFlix.Infrastructure.Service;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var connectionString = builder.Configuration.GetConnectionString("db");
        builder.Services.AddDbContext<MovieFlixDbContext>(options =>
            options.UseSqlServer(connectionString));

        builder.Services.AddControllersWithViews();

        builder.Services.AddSqlServer<MovieFlixDbContext>(builder.Configuration.GetConnectionString("db"));



        builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
        builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
        builder.Services.AddScoped<IMovieCastRepositoryAsync, MovieCastRepositoryAsync>();
        builder.Services.AddScoped<IAccountRepositoryAsync, AccountRepositoryAsync>();


        builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();
        builder.Services.AddScoped<IMovieCastServiceAsync, MovieCastServiceAsync>();
        builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
        builder.Services.AddScoped<IAccountServiceAsync, AccountServiceAsync>();


        builder.Services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<MovieFlixDbContext>()
            .AddDefaultTokenProviders();


        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.SaveToken = true;

            options.RequireHttpsMetadata = false;
            

            try
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JWT:ValidAudience"],
                    ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
                };
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("ArgumentNullException: " + ex.Message);
                // Hata işleme kodlarını buraya ekleyebilirsiniz
            }

        });

        
        builder.Services.AddDbContext<MovieFlixDbContext>(options =>
            options.UseSqlServer(connectionString));

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            //app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Movies}/{action=Index}/{id?}");


        app.Run();
    }
}