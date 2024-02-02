using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthor);

            app.MapGet("/authors/{id}", GetAuthorById);

        }

        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository)
        {
            var authors = from author in await authorRepository.GetAllAuthors()
                select new AuthorDTO()
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                    Books = author.Books.Select(book => new BookDTO()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        AuthorId = book.AuthorId,
                        Author = $"{book.Author.FirstName} {book.Author.LastName}",
                        PublisherId = book.PublisherId,
                        Publisher = book.Publisher.Name
                    })
                };

            return TypedResults.Ok(authors);
        }


        private static async Task<IResult> GetAuthorById(int id, IAuthorRepository authorRepository)
        {
            var author = await authorRepository.GetAuthor(id);

            var AuthorDTO = new AuthorDTO()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(book => new BookDTO()
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Author = $"{book.Author.FirstName} {book.Author.LastName}",
                    PublisherId = book.PublisherId,
                    Publisher = book.Publisher.Name
                })
            };

            return author != null ? TypedResults.Ok(AuthorDTO) : TypedResults.NotFound();
        }

    }
}
