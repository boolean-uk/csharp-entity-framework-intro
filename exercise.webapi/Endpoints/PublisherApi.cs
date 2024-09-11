using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints;

public static class PublisherApi
{
    public static void ConfigurePublishersApi(this WebApplication app)
    {
        var publishers = app.MapGroup("publisher");
        publishers.MapGet("/", GetPublishers);
        publishers.MapGet("/{id}", GetPublisherById);
        publishers.MapPost("/", AddPublisher);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetPublishers(IRepository<Publisher> repo, IRepository<Book> bookRepo)
    {
        var list = await repo.GetAll();
        var listDto = list.Select(p => new PublisherDTO()
        {
            Name = p.Name,
            Books = bookRepo.GetByPublisherId(p.Id)
        });
        return TypedResults.Ok(listDto);
    }
    
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetPublisherById(IRepository<Publisher> repo, IRepository<Book> bookRepo, int id)
    {
        var p = await repo.GetById(id);
        var response = new PublisherDTO()
        {
            Name = p.Name,
            Books = bookRepo.GetByPublisherId(p.Id)
        };
        return TypedResults.Ok(response);
    }

    private static async Task<IResult> AddPublisher(IRepository<Publisher> repo, PostPublisherModel publisher)
    {
        Publisher newEntity = new() { Name = publisher.Name };
        await repo.Add(newEntity);
        return TypedResults.Ok(newEntity);
    }
}