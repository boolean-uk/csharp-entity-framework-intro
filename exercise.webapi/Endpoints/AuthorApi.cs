using exercise.webapi.DTO;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/{id}", GetAuthor);
            authors.MapGet("/", GetAuthors);
        }


        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository,IPublisherRepository publisherRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null)
            {
                return Results.NotFound();
            }
            foreach (var book in author.Books)
            {
                book.Publisher = await publisherRepository.GetPublisher(book.PublisherId);
            }

            return TypedResults.Ok(new AuthorResponseDto(author));
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAuthors();
            var authorDtos = authors.Select(author => new AuthorResponseDto(author));
            return TypedResults.Ok(authorDtos);
        }
    }
}
