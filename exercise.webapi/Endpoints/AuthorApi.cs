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
        authors.MapPost("/", AddAuthor);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetAuthors(IRepository<Author> repo)
    {
        var list = await repo.GetAll();
        return TypedResults.Ok(list);
    }

    private static async Task<IResult> AddAuthor(IRepository<Author> repo, PostAuthorModel author)
    {
        Author newEntity = new() { FirstName = author.FirstName, LastName = author.LastName, Email = author.Email };
        await repo.Add(newEntity);
        return TypedResults.Ok(newEntity);
    }
}