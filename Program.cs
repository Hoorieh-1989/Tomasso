using inlämning1Tomasso.Data;
using inlämning1Tomasso.Data.Keys;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using System.Text;

var builder = WebApplication.CreateBuilder(args);

// 1) EF Core
builder.Services.AddDbContext<TomassoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// 2) JWT
builder.Services.AddSingleton<JwtTokenGenerator>();
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKeyBytes = Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]);

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opts =>
    {
        opts.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes)
        };
    });

// 3) Controllers
builder.Services.AddControllers();

// 4) Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Tomasos Pizzeria API",
        Version = "v1",
        Description = "Web API för Tomasos beställningssystem.",
    });
}); var app = builder.Build();

// 5) Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tomasos Pizzeria API v1");
        c.RoutePrefix = string.Empty; // Visar Swagger UI direkt på root URL (localhost:5000/)
    });
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();