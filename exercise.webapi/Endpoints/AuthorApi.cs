using exercise.webapi.Dto;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints;

public static class AuthorApi
{
    public static void ConfigureAuthorsApi(this WebApplication app)
    {
        app.MapGet("/authors", GetAuthors);
        app.MapGet("/authors/{id}", GetAuthor);
    }

    [ProducesResponseType(typeof(IEnumerable<AuthorResponse>), StatusCodes.Status200OK)]
    private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
    {
        var authors = await authorRepository.GetAllAuthors();
        var response = authors.Select(a => new AuthorResponse(a));
        
        return TypedResults.Ok(response);
    }

    [ProducesResponseType(typeof(AuthorResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
    {
        var author = await authorRepository.GetAuthorById(id);
        if (author == null)
        {
            return TypedResults.NotFound();
        }
        
        return TypedResults.Ok(new AuthorResponse(author));
    }
}