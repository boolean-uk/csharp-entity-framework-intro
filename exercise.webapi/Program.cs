using exercise.webapi.Data;
using exercise.webapi.Endpoints;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository<Author>, AuthorRepository>();
builder.Services.AddScoped<IRepository<Book>, BookRepository>();
// builder.Services.AddScoped<IRepository<Checkout>, CheckoutRepository>();
builder.Services.AddScoped<IRepository<Publisher>, PublisherRepository>();
// builder.Services.AddScoped<IRepository<Review>, ReviewRepository>();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

using (var dbContext = new DataContext(new DbContextOptions<DataContext>()))
{
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureAuthorsApi();
app.ConfigureBooksApi();
app.ConfigurePublishersApi();
app.Run();
