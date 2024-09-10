using exercise.webapi.DTOs;
using exercise.webapi.Extensions;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAllAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }

        public static async Task<IResult> GetAllAuthors(IAuthorRepository authorRepository) 
        {
            var authors = await authorRepository.GetAll();
            List<AuthorDTO> authorsDTO = (from author in authors select author.MapToAuthorDTO()).ToList();
            return TypedResults.Ok(authorsDTO);
        }
        public static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id) 
        {
            var author = await authorRepository.GetA(id);
            return TypedResults.Ok(author.MapToAuthorDTO());
        }


    }
}
