using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {

        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var books = app.MapGroup("authors");
            books.MapGet("/", GetAllAuthors);
            books.MapGet("/{id}", GetAuthor);
        }

        public static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            return TypedResults.Ok(author);

        }

        public static async Task<IResult> GetAllAuthors(IAuthorRepository authorRepository)
        {

            var authors = await authorRepository.GetAllAuthors();
            return TypedResults.Ok(authors);


        }



    }
}
    