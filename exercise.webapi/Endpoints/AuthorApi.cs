using exercise.webapi.Models.DTOs;
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
        var returnList = new List<AuthorWithBooksAndPublisherDTO>();
        foreach (var author in authors)
        {
            returnList.Add(AuthorWithBooksAndPublisherDTO.AuthorToDTO(author));
        }
        return TypedResults.Ok(returnList);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
    {
        var author = await authorRepository.GetAuthorById(id);

        if (author == null)
        {
            return TypedResults.NotFound($"Id: {id} not found!");
        }

        return TypedResults.Ok(AuthorWithBooksAndPublisherDTO.AuthorToDTO(author));
    }
}
