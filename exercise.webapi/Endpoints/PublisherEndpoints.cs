using exercise.webapi.DTO;
using exercise.webapi.Exceptions;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherEndpoints
    {
        public static string Path { get; private set; } = "publishers";

        public static void ConfigurePublisherEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            group.MapGet("/", GetPublishers);
            group.MapGet("/{id}", GetPublisher);
        }
        public static async Task<IResult> GetPublishers(IRepository<Publisher> repository)
        {
            try
            {
                IEnumerable<Publisher> publishers = await repository.GetAll();
                return TypedResults.Ok(publishers.Select(publisher => new PublisherView(
                   publisher.Id,
                   publisher.Name,
                   publisher.Books.Select(book => new BookInternalAuthor(
                       book.Id,
                       book.Title,
                       book.Authors.Select(author => new AuthorInternal(
                           author.Id,
                           author.FirstName,
                           author.LastName,
                           author.Email
                       ))
                   ))
                )));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        public static async Task<IResult> GetPublisher(IRepository<Publisher> repository, int id)
        {
            try
            {
                Publisher publisher = await repository.Get(id);
                return TypedResults.Ok(new PublisherView(
                   publisher.Id,
                   publisher.Name,
                   publisher.Books.Select(book => new BookInternalAuthor(
                       book.Id,
                       book.Title,
                       book.Authors.Select(author => new AuthorInternal(
                           author.Id,
                           author.FirstName,
                           author.LastName,
                           author.Email
                       ))
                   ))
                ));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
