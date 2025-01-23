using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorAPI(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", Get);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            List<AuthorDTO> authorsDTOList = authors.Select(authors => new AuthorDTO
            {
                Id = authors.Id,
                FirstName = authors.FirstName,
                LastName = authors.LastName,
                Email = authors.Email,
                Books = authors.Books.Select(books => new MinimalBookDTO
                {
                    Id = books.Id,
                    Title = books.Title,
                }).ToList()
            }).ToList();
            return TypedResults.Ok(authorsDTOList);
        }

        private static async Task<IResult> Get(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.Get(id);
            if (author == null) { return TypedResults.NotFound("Author Not Found"); }
            var AuthorDTO = new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(book => new MinimalBookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                }).ToList()
            };
            return TypedResults.Ok(AuthorDTO);
        }
    }
}
