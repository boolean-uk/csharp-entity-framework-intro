using exercise.webapi.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/author", GetAllAuthors);
            app.MapGet("/author{id}", Get);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllAuthors(IAuthorRepository authorRepository)
        {
            var result = await authorRepository.GetAllAuthors();
            var resultsDTO = result.Select(a => new AuthorListDTO
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                Books = a.Books.Select(b => new BookListDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                }).ToList()
            });
            return TypedResults.Ok(resultsDTO);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> Get(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.Get(id);
            if (author == null)
            {
                return TypedResults.NotFound("No Author with the given id");
            }
            var authorDTO = new AuthorListDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(b => new BookListDTO
                {
                    Id = b.Id,
                    Title = b.Title,

                }).ToList()
            };
            return TypedResults.Ok(authorDTO);

        }
    }
}
