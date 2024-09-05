using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;
namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors/GetAllAuthors", GetAllAuthors);
            app.MapGet("/authors/getAnAuthor{id}", GetAuthor);
        }


        private static async Task<IResult> GetAllAuthors(IAuthorRepository AuthorRepository)
        {
            var authors = await AuthorRepository.GetAllAuthors();
            return TypedResults.Ok(authors);
        }

        private static async Task<IResult> GetAuthor(IAuthorRepository AuthorRepository, int id)
        {
            var author = await AuthorRepository.GetAuthor(id);
            return TypedResults.Ok(author);
        }
    }
}
