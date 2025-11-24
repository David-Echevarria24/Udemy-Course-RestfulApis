using Microsoft.EntityFrameworkCore;
using TMApi.Data;
using TMApi.Interface;
using TMApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApiDbContext>(option => option.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TaskManagementDB;Integrated Security=True;"));

builder.Services.AddScoped<ITaskRepository, TaskRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
