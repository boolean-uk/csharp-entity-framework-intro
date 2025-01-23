using exercise.webapi.Data;
using exercise.webapi.Endpoints;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddOpenApi();

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddDbContext<DataContext>(options =>
{
    var connectionString = configuration.GetConnectionString("DefaultConnectionString");
    options.UseNpgsql(connectionString);

    options.ConfigureWarnings(warnings =>
        warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
});


builder.Services.AddScoped<IRepository<Book>, BookRepository>();
builder.Services.AddScoped<IRepository<Author>, AuthorRepository>();
builder.Services.AddScoped<IRepository<Publisher>, PublisherRepository>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
    app.MapSwagger();
}

app.UseHttpsRedirection();
app.ConfigureBooksEndpoints();
app.ConfigureAuthorsEndpoints();
app.ConfigurePublisherEndpoints();
app.Run();
