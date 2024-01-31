using exercise.webapi.DTO;
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
            var authors = await authorRepository.GetAllAuthors();

            List<AuthorDTO> results = new List<AuthorDTO>();

            foreach (var author in authors)
            {
                var AuthorDTO = new AuthorDTO()
                { 
                    Id = author.Id,
                    FirstName = author.FirstName, LastName = author.LastName, Email = author.Email
                };
                results.Add(AuthorDTO);
            }

            return TypedResults.Ok(results);
        }


        private static async Task<IResult> GetAuthorById(int id, IAuthorRepository authorRepository)
        {
            var book = await authorRepository.GetAuthor(id);

            return book != null ? TypedResults.Ok(book) : TypedResults.NotFound();
        }

    }
}
