
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;


namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/author", GetAuthor);
            


        }

        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null)
            {
                return TypedResults.NotFound(new { Message = $"authors with {id} is not found." });

            }
            var authorDto = new AuthorDTO
            {
                Id = author.Id,
                Name = $"{author.FirstName} {author.LastName}",
                BookTitles = author.Books.Select(b => b.Title).ToList()

            };
            return TypedResults.Ok(authorDto);
            
        }
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            if (authors == null) {

                return TypedResults.NotFound(new { Message = $"authors list is empty." });
            }

            var authorDtos = authors.Select(a => new AuthorDTO
            {
                Id = a.Id,
                Name = $"{a.FirstName} {a.LastName}",
                BookTitles = a.Books.Select(b => b.Title).ToList()
            }).ToList();

            return TypedResults.Ok(authorDtos);

        }
    }
}
