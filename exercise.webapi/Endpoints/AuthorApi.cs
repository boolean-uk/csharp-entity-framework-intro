using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints;

public static class AuthorApi
{
    public static void ConfigureAuthorsApi(this WebApplication app)
    {
        var authors = app.MapGroup("authors");
        authors.MapGet("/", GetAuthors);
        authors.MapGet("/{id:int}", GetAuthorById);
        authors.MapGet("/{firstname}/{lastname}", GetAuthorByFullName);
        authors.MapPost("/", AddAuthor);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetAuthors(IRepository<Author> repo)
    {
        var authors = await repo.GetAll();
        var authorDTOs = authors.Select(a => new AuthorDTO
        {
            Name = a.FirstName + " " + a.LastName,
            Email = a.Email,
        }).ToList();
        return TypedResults.Ok(authorDTOs);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetAuthorById(IRepository<Author> repo, int id)
    {
        var author = await repo.GetById(id);
        if (author == null) return TypedResults.NotFound($"Author with id {id} does not exist");
        var authorDTO = new AuthorDTO
        {
            Name = author.FirstName + " " + author.LastName,
            Email = author.Email,
        };
        return TypedResults.Ok(authorDTO);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetAuthorByFullName(IRepository<Author> repo, string firstName, string lastName)
    {
        var author = await repo.GetByFullName(firstName, lastName);
        if (author == null) return TypedResults.NotFound($"Author with name {firstName} {lastName} does not exist");
        var authorDTO = new AuthorDTO
        {
            Name = author.FirstName + " " + author.LastName,
            Email = author.Email,
        };
        return TypedResults.Ok(authorDTO);
    }

    private static async Task<IResult> AddAuthor(IRepository<Author> repo, PostAuthorModel author)
    {
        Author newEntity = new() { FirstName = author.FirstName, LastName = author.LastName, Email = author.Email };
        await repo.Add(newEntity);
        return TypedResults.Ok(newEntity);
    }
}