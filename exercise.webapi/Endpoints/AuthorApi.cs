using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.Services;
using System.Collections.Generic;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {

            var authorGroup = app.MapGroup("author");
            authorGroup.MapGet("", GetAllAuthorBooks);
            authorGroup.MapGet("{id}", GetAuthorBooks);
        }

        private static async Task<IResult> GetAllAuthorBooks(IAuthorRepository authorRepository)
        {
            var booksByAuthors = await authorRepository.GetAllAuthorBooks();
            Service service = new Service();

            List<AuthorDTO> authorDTO = new();
            foreach (var b in booksByAuthors)
                authorDTO.Add(service.CreateAuthorDTO(b.Item1, b.Item2, b.Item1.Id));

            return TypedResults.Ok(authorDTO);
        }

        private static async Task<IResult> GetAuthorBooks(IAuthorRepository authorRepository, int authorId)
        {
            var booksByAuthor = authorRepository.GetAuthorBooks(authorId);
            return TypedResults.Ok(booksByAuthor);
        }
    }
}
