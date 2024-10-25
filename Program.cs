using Microsoft.EntityFrameworkCore;
using Minimal.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
