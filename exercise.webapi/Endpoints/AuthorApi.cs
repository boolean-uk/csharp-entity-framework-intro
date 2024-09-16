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
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = GetAuthorDTO.FromRepository(await authorRepository.GetAllAuthors());
            return TypedResults.Ok(authors);
        }
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            //Load author
            var author = await authorRepository.GetAuthor(id);
            //Check if author exists otherwise return notFound
            if (author == null)
            {
                return TypedResults.NotFound($"No author found with id: {id}!");
            }
            //Insert author into DTO and return ok for found
            var result = new GetAuthorDTO(author);
            return TypedResults.Ok(result);
        }
    }
}
