using exercise.webapi.Models;
using exercise.webapi.Repository;
using System.Runtime.CompilerServices;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors/", GetAuthors);
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
