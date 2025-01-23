using exercise.webapi.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");

            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            try
            {
                var authors = await authorRepository.GetAllAuthors();

                var atrs = authors.Select(author =>
                {
                    return new AuthorGet(
                    author.Id,
                    author.FirstName,
                    author.LastName,
                    author.Email,
                    author.Books.Select(b => new BookInternal(
                        b.Id,
                        b.Title
                        )
                    ));
                });

                return TypedResults.Ok(atrs);
            }
            catch(Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            try
            {
                var author = await authorRepository.GetAuthor(id);

                if (author == null)
                    return TypedResults.Problem(null);

                AuthorGet atr = new AuthorGet(
                    author.Id,
                    author.FirstName,
                    author.LastName,
                    author.Email,
                    author.Books.Select(b => new BookInternal(
                        b.Id,
                        b.Title
                    ))
                );

                return TypedResults.Ok(atr);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
