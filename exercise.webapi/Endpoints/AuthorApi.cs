using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints;

public static class AuthorApi
{
    public static void ConfigureAuthorsApi(this WebApplication app)
    {
        var group = app.MapGroup("authors");

        group.MapGet("/", GetAuthors);
        group.MapGet("/{id}", GetAuthor);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
    {
        var authors = await authorRepository.GetAllAuthors();
        return TypedResults.Ok(authors);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
    {
        var author = await authorRepository.GetAuthorById(id);

        if (author == null)
        {
            return TypedResults.NotFound($"Id: {id} not found!");
        }

        return TypedResults.Ok(author);
    }
}
