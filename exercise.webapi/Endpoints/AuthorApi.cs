using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("/authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository repository)
        {
            var authors = await repository.GetAllAuthors();
            List<AuthorDTO> result = authors.Select(a => new AuthorDTO
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                Books = a.Books.Select(b => new BookDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                }).ToList()
            }).ToList();
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> GetAuthor(IAuthorRepository repository, int id)
        {
            var author = await repository.GetAuthor(id);
            if (author == null) return TypedResults.NotFound("Not Found");
            AuthorDTO result = new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(b => new BookDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                }).ToList()
            };
            return TypedResults.Ok(result);
        }
    }
}
