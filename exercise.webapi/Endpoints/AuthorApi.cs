using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var author = app.MapGroup("author");

            author.MapGet("/", GetAllAuthors);
            author.MapGet("/{id}", GetAuthorById);
        }

        public static async Task<IResult> GetAllAuthors(IRepository<Author> authorRepository)
        {

            var payload = from a in authorRepository.GetAllEntities().Result
                          select new AuthorPayload()
                          {
                              Id = a.Id,
                              FirstName = a.FirstName,
                              LastName = a.LastName,
                              Email = a.Email,
                              Books = from b in a.Books
                                      select new TestBookPayload()
                                      {
                                          Id = b.Id,
                                          Title = b.Title,
                                          AuthorId = a.Id,
                                          FirstName = a.FirstName,
                                          LastName = a.LastName,
                                          Email = a.Email
                                      }
                          };

            return TypedResults.Ok(payload);
        }

        private static async Task<IResult> GetAuthorById(IRepository<Author> authorRepository, int id)
        {

            var author = await authorRepository.GetEntityById(id);

            var payload =  new AuthorPayload()
                          {
                              Id = author.Id,
                              FirstName = author.FirstName,
                              LastName = author.LastName,
                              Email = author.Email,
                              Books = from b in author.Books
                                      select new TestBookPayload()
                                      {
                                          Id = b.Id,
                                          Title = b.Title
                                      }
                          };

            return TypedResults.Ok(payload);
        }
    }
}
