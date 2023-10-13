using ProjectRoots.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddCors(options => 
{
    options.AddDefaultPolicy(builder => 
        builder.WithOrigins("http://localhost:8080")
            .AllowAnyMethod()
            .AllowAnyHeader());
});

// Swagger setup.
builder.Services.AddSwaggerGen();

// Register your DbContext with the Dependency Injection system.

builder.Services.AddDbContext<ProjectRootsDb>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Swagger setup.
app.UseSwagger();
app.UseSwaggerUI();

// Error handling and development specific settings.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseCors();
app.UseHttpsRedirection();

// If you have authentication, it should be set up here. Example:
// app.UseAuthentication();

app.UseAuthorization();
app.MapControllers();
app.Run();