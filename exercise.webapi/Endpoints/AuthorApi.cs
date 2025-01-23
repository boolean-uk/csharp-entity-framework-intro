using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }


        #region Get authors
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            //Payload<List<Book>> payload = new Payload<List<Book>>();


            var results = await authorRepository.GetAllAuthors();
            var resultsDTO = results.Select(a => new AuthorListDTO
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                BookList = a.Books.Select(b => new BookListDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                }).ToList()
            });

            return TypedResults.Ok(resultsDTO);
        }

        public static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null)
            {
                return Results.NotFound();
            }
            var authorDTO = new AuthorListDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                BookList = author.Books.Select(b => new BookListDTO
                {
                    Id = b.Id,
                    Title = b.Title,

                }).ToList()
            };
            return Results.Ok(authorDTO);

        }
        #endregion

    }
}
