using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.Services;
using System.Runtime.InteropServices;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {

        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(AuthorService authorService)
        {
           var authors = await authorService.GetAuthors();
          return TypedResults.Ok(authors);
        }

       private static async Task<IResult> GetAuthor(AuthorService authorService, int id)
       {
            GetAuthorDTO author = null;

            try
            {
                author = await authorService.GetAuthor(id);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }

            return TypedResults.Ok(author);
        }
    }
}
