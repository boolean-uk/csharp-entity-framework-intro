using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors/");
            authors.MapGet("/", GetAllAuthors);
            authors.MapGet("/{id}", GetAuthorById);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllAuthors(IAuthorRepository authorRepo)
        {
            var authors = from author in await authorRepo.GetAllAuthors()
                          select new AuthorDTO()
                          {
                              Id = author.Id,
                              FirstName = author.FirstName,
                              LastName = author.LastName,
                              Email = author.Email,
                              Books = author.Books.Select(x => new BookDTO()
                              {
                                  Id=x.Id,
                                  Title = x.Title,
                                  authorId = x.AuthorId,
                                  AuthorName = $"{author.FirstName} {author.LastName}"
                              })

                          };

            return TypedResults.Ok(authors);
        }

        private static async Task<IResult> GetAuthorById(IAuthorRepository authorRepo, int id)
        {
            var author = await authorRepo.GetAuthor(id);
            var authorDTO = new AuthorDTO()
            {
                Id = author.Id,
                FirstName= author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(x => new BookDTO()
                {
                    Id = x.Id,
                    Title = x.Title,
                    authorId = x.AuthorId,
                    AuthorName = $"{author.FirstName} {author.LastName}"
                })
            };
            return TypedResults.Ok(authorDTO);
        }
    }
}
