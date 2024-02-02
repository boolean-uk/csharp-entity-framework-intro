using exercise.webapi.DTO_s;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;


namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var libraryGroup = app.MapGroup("Books");
            libraryGroup.MapGet("/books", GetBooks);
            libraryGroup.MapGet("/books/{id}", GetBook);
            libraryGroup.MapPut("Book/{id}", UpdateBook);
            libraryGroup.MapDelete("/{id}", DeleteBook);
            libraryGroup.MapPost("/{id}", CreateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository, IPublisherRepository publisherRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var publishers = await publisherRepository.GetPublishers();
            List<BookDetailsDTO> result = new List<BookDetailsDTO>();

            foreach (Book item in books)
            {
                var pub = publishers.Where(x => x.Id == item.PublisherId);
                result.Add(new BookDetailsDTO()
                {
                    Id = item.Id,
                    Title = item.Title,
                    AuthorID = item.Author.Id,
                    AuthorFirstName = item.Author.FirstName,
                    AuthorLastName = item.Author.LastName,
                    AuthorEmail = item.Author.Email,
                    publisherName = publishers
                        .Where(x => x.Id == item.PublisherId).Select(x => x.Name).FirstOrDefault()
                });

            }

            return TypedResults.Ok(result);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBook(IBookRepository repository, int id)
        {
            var book = await repository.GetBookByID(id);
            var bookDto = new BookDetailsDTO()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorID = book.Author.Id,
                AuthorFirstName = book.Author.FirstName,
                AuthorLastName = book.Author.LastName,
                AuthorEmail = book.Author.Email
            };
            return TypedResults.Ok(bookDto);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateBook(IBookRepository repository, int id, int newId)
        {
            var book = await repository.GetBookByID(id);
            var bookDto = new BookDetailsDTO()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorID = newId,
                AuthorFirstName = book.Author.FirstName,
                AuthorLastName = book.Author.LastName,
                AuthorEmail = book.Author.Email

            };
            await repository.UpdateBook(id, newId);
            return TypedResults.Created($"{bookDto.Title}, {bookDto.AuthorFirstName} {bookDto.AuthorLastName}", bookDto);
        }

        public static async Task<IResult> DeleteBook(IBookRepository repository, int id)
        {
            return TypedResults.Ok(repository.DeleteBook(id));
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateBook(IBookRepository repository, IAuthorRepository authRepo, Book book)
        {
            var entities = await authRepo.GetAllAuthors();

            if(!entities.Any(a => a.Id == book.AuthorId))
            {
                return TypedResults.NotFound();
            }
            if(book.Title == string.Empty)
            {
                return Results.BadRequest();
            }

            var b =  repository.CreateBook(book);
            var bookDto = new PostBookDto()
            {
                Title = book.Title,
                AuthorFirstName = book.Author.FirstName,
                AuthorLastName = book.Author.LastName,
                AuthorEmail = book.Author.Email
            };

            return TypedResults.Ok(bookDto);
        }
    }
}
