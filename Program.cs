using efproject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddDbContext<TasksContext>(p => p.UseInMemoryDatabase("TasksDB"));
builder.Services.AddDbContext<TasksContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("taskDBConnection")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbStatus", async ([FromServices] TasksContext dbContext) => {
    dbContext.Database.EnsureCreated();
    return Results.Ok("Database connected:  " + dbContext.Database.IsNpgsql());
});

app.Run();

