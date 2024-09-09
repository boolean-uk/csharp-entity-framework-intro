using exercise.webapi.DTO;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorsApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{firstname}", GetAnAuthor);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {

            var author = await authorRepository.GetAllAuthors();

            return TypedResults.Ok(ConvertToDTOList.ConvertAuthorDOTList(author));
        }

        private static async Task<IResult> GetAnAuthor(IAuthorRepository authorRepository, string firstname, string lastname)
        {
            var author = await authorRepository.GetAnAuthor(firstname, lastname);
            return TypedResults.Ok(ConvertToDTOList.ConvertAuthorDOT(author));
        }
    }


}
