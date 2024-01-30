using exercise.webapi.DTO;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {

        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("/author");
            authorGroup.MapGet("/", GetAllAuthors);
            authorGroup.MapGet("/{id}", GetAuthorById);
        } 



        private static async Task<IResult> GetAllAuthors(IAuthorRepository authorRepository)
        {
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(await authorRepository.GetAllAuthors()));
        } 

        private static async Task<IResult> GetAuthorById(int id, IAuthorRepository authorRepository)
        {
            throw new NotImplementedException();
        }
    }
}
