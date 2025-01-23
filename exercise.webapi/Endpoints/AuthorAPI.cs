using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");

            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            List<AuthorDTO> authorsDTO = new List<AuthorDTO>();
            var authors = await authorRepository.GetAllAuthors();
            foreach (var author in authors)
            {
                authorsDTO.Add(new AuthorDTO
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                    Books = author.Books.Select(b => b.Title),
                });
            }
            return TypedResults.Ok(authorsDTO);
        }

        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            AuthorDTO authorDTO = new AuthorDTO();
            var author = authorRepository.GetAuthor(id);
            authorDTO.Id = author.Result.Id;
            authorDTO.FirstName = author.Result.FirstName;
            authorDTO.LastName = author.Result.LastName;
            authorDTO.Email = author.Result.Email;
            authorDTO.Books = author.Result.Books.Select(b => b.Title);
            return TypedResults.Ok(authorDTO);
        }
    }
}
