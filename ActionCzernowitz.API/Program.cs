using ActionCzernowitz.API;
using ActionCzernowitz.API.Interfaces;
using ActionCzernowitz.API.Services;
using ActionCzernowitz.BLL.Interfaces.IServices;
using ActionCzernowitz.BLL.Mapping;
using ActionCzernowitz.BLL.Services;
using ActionCzernowitz.DAL;
using ActionCzernowitz.DAL.EF;
using ActionCzernowitz.DAL.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

// Add services to the container.
var services = builder.Services;

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "MusicPlayer API",
        Description = "ASP.NET Core Web API"
    });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the bearer scheme"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });

    c.OperationFilter<AuthOperationFilter>();
});
services.AddAutoMapper(typeof(UserMapperProfile).Assembly);
services.AddCors();

#region Services

services.AddScoped<IUserService, UserService>();
services.AddScoped<IAuthService, AuthService>();
services.AddScoped<IJwtTokenService, JwtTokenService>();

#endregion Services

#region JWT Authentication

services
    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(cfg =>
    {
        cfg.RequireHttpsMetadata = false;
        cfg.SaveToken = true;
        cfg.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = config["JWTConfiguration:JwtIssuer"],

            ValidateAudience = true,
            ValidAudience = config["JWTConfiguration:JwtAudience"],

            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWTConfiguration:JwtKey"])),

            ValidateLifetime = false,

            ClockSkew = TimeSpan.Zero,
        };
    });

services.AddTransient<IJwtTokenService, JwtTokenService>();

#endregion JWT Authentication

services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

services.AddIdentity<User, IdentityRole<Guid>>(action =>
{
    action.Password = new PasswordOptions
    {
        RequireDigit = false,
        RequireUppercase = false,
        RequireNonAlphanumeric = false,
        RequireLowercase = false,
        RequiredLength = 1,
    };
}).AddEntityFrameworkStores<ApplicationContext>();

var app = builder.Build();

// adding default data to DB.

using var scope = app.Services.CreateScope();
await DataInitializer.Initialize(scope.ServiceProvider.GetRequiredService<UserManager<User>>());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder => builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
