using System;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Payload;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints;

public static class AuthorApi
{

    public static void ConfigureAuthorApi(this WebApplication app)
    {
        var author = app.MapGroup("/author");

        author.MapGet("/{id}", GetAuthor);
        author.MapGet("/", GetAuthors);


    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
    {
        Payload<AuthorDTO> payload = await authorRepository.GetAuthor(id);

        if (!payload.GoodResponse)
        {
            return TypedResults.NotFound(payload.Message);
        }

        return TypedResults.Ok(payload.Data);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
    {
        Payload<IEnumerable<AuthorDTO>> payload = await authorRepository.GetAuthors();

        return TypedResults.Ok(payload.Data);
    }
}
