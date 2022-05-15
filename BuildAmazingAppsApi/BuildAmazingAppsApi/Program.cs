using BuildAmazingAppsApi.DataModels;
using BuildAmazingAppsApi.Repositories;
using Microsoft.EntityFrameworkCore;
 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationManager configuration = builder.Configuration;
// IWebHostEnvironment environment = builder.Environment;


builder.Services.AddControllers();
builder.Services.AddDbContext<StudentAdminContext>(options => options.UseSqlServer(configuration.GetConnectionString("StudentAdminPortalDb")));

builder.Services.AddScoped<IStudentRepository, SqlStudentRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
