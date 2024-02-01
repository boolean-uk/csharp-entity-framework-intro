using exercise.webapi.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var group = app.MapGroup("authors");
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors{id}", GetAuthorById);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository repository)
        {
            var authors = from author in await repository.GetAllAuthors()
                          select new AuthorDto()
                          {
                              Id = author.Id,
                              FirstName = author.FirstName,
                              LastName = author.LastName,
                              Email = author.Email,
                              Books = author.Books.Select(x => new BookDto()
                              {
                                  Id = x.Id,
                                  Title = x.Title,
                                  AuthorId = x.AuthorId,
                                  AuthorName = $"{author.FirstName} {author.LastName}",
                              })
                          };
            return TypedResults.Ok(authors);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthorById(IAuthorRepository repository, int id)
        {
            var author = await repository.GetById(id);

            if (author == null)
            {
                return TypedResults.NotFound();
            }

            var authorBooks = repository.GetById(id);
            var authorDto = new AuthorDto()
            {   
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(b =>  new BookDto()
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorId = b.AuthorId,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                })
            };
            return TypedResults.Ok(authorDto);
        }
    }
}
