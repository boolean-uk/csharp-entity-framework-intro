using ef.intro.wwwapi.Models;
using ef.intro.wwwapi.Repository;

namespace ef.intro.wwwapi.EndPoint
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapPost("/authors", AddAuthor);
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthor);
            app.MapPut("/authors/{id}", UpdateAuthor);
            app.MapDelete("/authors/{id}", DeleteAuthor);
        }

        private static async Task<IResult> GetAuthors(ILibraryRepository service)
        {
            try
            {
                return await Task.Run(() => 
                {
                    return Results.Ok(service.GetAllAuthors());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetAuthor(int id, ILibraryRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var person = service.GetAuthor(id);
                    if (person == null) return Results.NotFound();
                    return Results.Ok(person);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> AddAuthor(Author author, ILibraryRepository service)
        {
            try
            {
                if (service.AddAuthor(author)) return Results.Ok(author);
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateAuthor(Author author, ILibraryRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (service.UpdateAuthor(author)) return Results.Ok(author);
                    return Results.NotFound();
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteAuthor(int id, ILibraryRepository service)
        {
            try
            {
                if (service.DeleteAuthor(id)) return Results.Ok();
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}