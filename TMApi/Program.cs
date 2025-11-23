using Microsoft.EntityFrameworkCore;
using TMApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApiDbContext>(option => option.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TaskManagementDB;Integrated Security=True;"));




var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
