using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.GenericDto;
using exercise.webapi.Repository;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("Author");

            authorGroup.MapGet("/", GetAuthors);
            authorGroup.MapGet("/{id}", GetAAuthor);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();

            List<AuthorBooksDto> authorsDto = new List<AuthorBooksDto>();

            foreach (var author in authors)
            {
                AuthorBooksDto auhtorDto = new AuthorBooksDto()
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                    Books = new List<BookNoAuthorDto>()
                    
                };
                foreach (var book in author.Books)
                {
                    var bookDto = new BookNoAuthorDto()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        AuthorId = author.Id,
                    };
                    auhtorDto.Books.Add(bookDto);
                }
                authorsDto.Add(auhtorDto);
            }

            Payload<List<AuthorBooksDto>> payload = new Payload<List<AuthorBooksDto>>();
            payload.data = authorsDto;
            return TypedResults.Ok(payload);
        }

        private static async Task<IResult> GetAAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAAuthor(id);

            if (author == null)
            {
                return TypedResults.BadRequest();
            }

            AuthorBooksDto auhtorDto = new AuthorBooksDto()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = new List<BookNoAuthorDto>()
            };
            foreach (var book in author.Books)
            {
                var bookDto = new BookNoAuthorDto()
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = author.Id,
                };
                auhtorDto.Books.Add(bookDto);
            }

            Payload<AuthorBooksDto> payload = new Payload<AuthorBooksDto>();
            payload.data = auhtorDto;
            return TypedResults.Ok(payload);
        }
    }
}
