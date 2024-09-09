using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var author = app.MapGroup("Author");
            author.MapGet("/", GetAuthors);
            author.MapGet("/{id}", GetOne);
            
            

        }
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAll();
            List<AuthorDTO> results = new List<AuthorDTO>();
            foreach (var author in authors)
            {
                AuthorDTO authordto = new AuthorDTO();
                authordto.FirstName = author.FirstName;
                authordto.LastName = author.LastName;
                foreach (Book b in author.Books)
                {
                    authordto.Books.Add(b.Title);
                }
                results.Add(authordto);
            }

            return TypedResults.Ok(results);
        }
        private static async Task <IResult> GetOne(IAuthorRepository itsrepo, int id)
        {

        }

    }
}
