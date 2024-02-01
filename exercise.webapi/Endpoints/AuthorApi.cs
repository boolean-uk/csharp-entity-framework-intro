using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAll);
            app.MapGet("/authors/{id}", Get);
        }

        private static async Task<IResult> GetAll(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.Get();

            if (authors == null)
                return Results.NotFound();

            IEnumerable<OutputAuthor> outputAuthors = Services.DtoManager.Convert(authors);
            return TypedResults.Ok(outputAuthors);
        }

        private static async Task<IResult> Get(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.Get(id);

            if (author == null)
                return Results.NotFound();

            OutputAuthor outputAuthor = Services.DtoManager.Convert(author);
            return TypedResults.Ok(outputAuthor);
        }
    }
}
