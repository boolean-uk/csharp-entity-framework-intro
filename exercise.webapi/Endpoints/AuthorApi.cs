using exercise.webapi.Models;
using exercise.webapi.Repository;
using System.Runtime.CompilerServices;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors/", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthorById);
        }

        private static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository, int id)
        {
            var result = await authorRepository.GetAuthorById(id);
            List<SimpleBookDTO> books = new List<SimpleBookDTO>();
            foreach (var book in result.Books)
            {
                books.Add(new SimpleBookDTO
                {
                    Title = book.Title,
                });
            }
            var dto = new AuthorAndBooksDTO
            {
                FirstName = result.FirstName,
                LastName = result.LastName,
                Email = result.Email,
                Books = books
            };
            return TypedResults.Ok(dto);

        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var result = await authorRepository.GetAuthors();
            List<AuthorAndBooksDTO> authors = new List<AuthorAndBooksDTO>();

            foreach (var author in result)
            {
                List<SimpleBookDTO> books = new List<SimpleBookDTO>();
                foreach(var book in author.Books)
                {
                    books.Add(new SimpleBookDTO
                    {
                        Title = book.Title,
                    });
                }
                authors.Add(
                new AuthorAndBooksDTO
                {
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                    Books = books
                }
                );
            }
            return TypedResults.Ok(authors);
        }
    }
}
