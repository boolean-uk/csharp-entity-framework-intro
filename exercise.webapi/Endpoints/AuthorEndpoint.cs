using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;

namespace exercise.webapi.Endpoints
{
    public static class AuthorEndpoint
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/author", GetAll);
            app.MapGet("/author/{id}", GetAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IAuthorRepository repository) 
        {
            List<Author_DTO_2> authors = await repository.getAll();
            return TypedResults.Ok(authors);
        }

        public static async Task<IResult> GetAuthor(IAuthorRepository repository, int id)
        {
            Author_DTO_2 authors = await repository.getAuthor(id);
            return TypedResults.Ok(authors);
        }
    }
}
