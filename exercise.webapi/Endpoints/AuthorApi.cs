using static exercise.webapi.Repository.IAuthorRepository;
using exercise.webapi.DTOs;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
        }

        public static async Task<IResult> GetAuthors(IAuthorRepository authorsRepository)
        {
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(await authorsRepository.GetAuthorsAsync()));
        }
   
    }
}



  

