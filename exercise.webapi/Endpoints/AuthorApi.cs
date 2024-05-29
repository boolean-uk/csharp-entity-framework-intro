using System.Runtime.CompilerServices;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void CofigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAllAuthors);
            app.MapGet("/authors/{authorId}", GetAuthor);
        }

        public static async Task<IResult> GetAllAuthors(IAuthorsRepository authorsRepository)
        {
            var authors = await authorsRepository.GetAllAuthorsAsync();
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(await authorsRepository.GetAllAuthorsAsync()));
        }

        private static async Task<IResult> GetAuthor(IAuthorsRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new AuthorResponseDTO(author));
        }
    }
}
