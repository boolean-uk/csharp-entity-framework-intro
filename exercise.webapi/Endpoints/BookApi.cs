using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.GenericDto;
using exercise.webapi.Repository;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var bookGroup = app.MapGroup("book");

            bookGroup.MapGet("/", GetBooks);
            bookGroup.MapGet("/{id}", GetABook);
            bookGroup.MapPut("/{id}", UpdateBook);
            bookGroup.MapDelete("/{id}", DeleteBook);
            bookGroup.MapPost("/{id}", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();

            List<BookDto> booksDto = new List<BookDto>();

            foreach (var book in books)
            {
                var bookdto = new BookDto()
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Author = new AuthorPlainDto()
                    {
                        Id = book.Author.Id,
                        FirstName = book.Author.FirstName,
                        LastName = book.Author.LastName,
                        Email = book.Author.Email

                    },
                    Publisher = new PublisherPlainDto()
                    {
                        Id=book.Publisher.Id,
                        Name = book.Publisher.Name,
                    }
                };
                booksDto.Add(bookdto);
            }

            Payload<List<BookDto>> payload = new Payload<List<BookDto>>();
            payload.data = booksDto;
            return TypedResults.Ok(payload);
        }

        private static async Task<IResult> GetABook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetABook(id);

            if (book == null)
            {
                return TypedResults.BadRequest();
            }

            BookDto bookdto = new BookDto()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new AuthorPlainDto()
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email

                },
                Publisher = new PublisherPlainDto()
                {
                    Id = book.Publisher.Id,
                    Name = book.Publisher.Name,
                }
            };

            Payload<BookDto> payload = new Payload<BookDto>();
            payload.data = bookdto;
            return TypedResults.Ok(payload);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookDto input)
        {
            var test = bookRepository.UpdateBook(id, input);
            if (test == null)
            {
                return Results.NotFound($"Book not found.");
            }
            return TypedResults.Created($"{input.Title}", input);
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var test = bookRepository.GetABook(id);
            return test == null ? Results.NotFound($"Book not found.") : TypedResults.Ok(bookRepository.DeleteBook(id));
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookDto input)
        {
            Book newBook = new Book()
            {
                Title = input.Title,
                AuthorId = input.AuthorId
            };
            var test = await bookRepository.CreateBook(newBook);
            return test == null ? Results.BadRequest("Book with provided name already exists.") : TypedResults.Created($"{test.Title}", test);
        }
    }
}
