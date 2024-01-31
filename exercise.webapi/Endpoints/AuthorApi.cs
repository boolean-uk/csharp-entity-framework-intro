using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var group_author = app.MapGroup("author");

            group_author.MapGet("/books", GetAuthors);
            group_author.MapGet("/{id}", GetAuthor);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]

        public static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var authors = await bookRepository.GetAllAuthors();
            return TypedResults.Ok(authors);

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthor([FromServices] IBookRepository bookRepository, int id)
        {
            var author = await bookRepository.GetAuthor(id);
            if (author == null)
            {
                return Results.NotFound();
            }
            

            return TypedResults.Ok(author);
        }

        
    }
}
