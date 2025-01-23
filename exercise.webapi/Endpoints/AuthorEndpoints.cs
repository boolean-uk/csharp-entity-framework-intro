using exercise.webapi.DTO;
using exercise.webapi.Exceptions;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorEndpoints
    {
        public static string Path { get; private set; } = "authors";

        public static void ConfigureAuthorsEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            group.MapPost("/", CreateAuthor);
            group.MapGet("/", GetAuthors);
            group.MapGet("/{id}", GetAuthor);
            group.MapPut("/{id}", UpdateAuthor);
            group.MapDelete("/{id}", DeleteAuthor);
        }
        public static async Task<IResult> CreateAuthor(IRepository<Author> repository, AuthorPost entity)
        {
            try
            {
                Author author = await repository.Add(new Author
                {
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Email = entity.Email,
                });
                return TypedResults.Ok(new AuthorView(
                    author.Id,
                    author.FirstName,
                    author.LastName,
                    author.Email,
                    author.Books.Select(b => new BookInternalPublisher(
                        b.Id,
                        b.Title,
                        new PublisherInternal(
                            b.Publisher.Id,
                            b.Publisher.Name
                        )
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
        public static async Task<IResult> GetAuthors(IRepository<Author> repository)
        {
            try
            {
                IEnumerable<Author> authors = await repository.GetAll();
                return TypedResults.Ok(authors.Select(a =>
                {
                    return new AuthorView(
                        a.Id,
                        a.FirstName,
                        a.LastName,
                        a.Email,
                        a.Books.Select(b => new BookInternalPublisher(
                            b.Id,
                            b.Title,
                            new PublisherInternal(
                                b.Publisher.Id,
                                b.Publisher.Name
                            )
                        )));
                }));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        public static async Task<IResult> GetAuthor(IRepository<Author> repository, int id)
        {
            try
            {
                Author author = await repository.Get(id);
                return TypedResults.Ok(new AuthorView(
                    author.Id,
                    author.FirstName,
                    author.LastName,
                    author.Email,
                    author.Books.Select(b => new BookInternalPublisher(
                        b.Id,
                        b.Title,
                        new PublisherInternal(
                            b.Publisher.Id,
                            b.Publisher.Name
                        )
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
        public static async Task<IResult> UpdateAuthor(IRepository<Author> bookRepository, IRepository<Author> authorRepository, int id, AuthorPut entity)
        {
            try
            {
                Author author = await bookRepository.Get(id);
                if (entity.FirstName != null) author.FirstName = entity.FirstName;
                if (entity.LastName != null) author.LastName = entity.LastName;
                if (entity.Email != null) author.Email = entity.Email;

                author = await bookRepository.Update(author);
                return TypedResults.Ok(new AuthorView(
                    author.Id,
                    author.FirstName,
                    author.LastName,
                    author.Email,
                    author.Books.Select(b => new BookInternalPublisher(
                        b.Id,
                        b.Title,
                        new PublisherInternal(
                            b.Publisher.Id,
                            b.Publisher.Name
                        )
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
        public static async Task<IResult> DeleteAuthor(IRepository<Author> repository, int id)
        {
            try
            {
                Author author = await repository.Delete(id);
                return TypedResults.Ok(new { Message = $"Deleted Author with FirstName = {author.FirstName}" });
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
