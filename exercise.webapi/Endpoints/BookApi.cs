using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/book{id}", GetBookById);
            app.MapPut("/updateBook{id}", UpdateBook);
            app.MapDelete("/DeleteBook{id}", DeleteBook);
            app.MapPost("/CreateBook{id}", CreateBook);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();

           var bookDtos = new List<GetBookDto>();
            
            foreach (var book in books)
            {
                //  BookDto2 bookDto2 = new BookDto2()
                GetBookDto bookDto = new GetBookDto()
                {

                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Publisher = new PublisherForBookDto()
                    {
                        Id = book.Publisher.Id,
                        Name = book.Publisher.Name
                    }
                };
                bookDtos.Add(bookDto);

            }

            return TypedResults.Ok(bookDtos);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBookById(int id, IBookRepository bookRepository)
        {
           

            var book = await bookRepository.GetBookById(id);

            var bookDto = new GetBookDto() 
            { 
               Id = book.Id,
               Title = book.Title,
               Author = book.Author,
               Publisher = new PublisherForBookDto() { Id = book.Publisher.Id, Name = book.Publisher.Name}
            };

            return TypedResults.Ok(bookDto);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateBook(int id, int authorId, IBookRepository bookRepository)
        {
            var book = await bookRepository.UpdateBook(id, authorId);

            var bookDto = new UpdateBookDto()
            {
                Author = book.Author
            };

            return TypedResults.Ok(bookDto);
        }
        
        private static async Task<IResult> DeleteBook(int id, IBookRepository bookRepository)
        {
            
            return TypedResults.Ok(bookRepository.DeleteBook(id));

            
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateBook(int id, string title, IBookRepository bookRepository)
        {
            var book = bookRepository.CreateBook(id, title);

            var bookDto = new CreateBookDto() { AuthorId = id, Title = title };

            return TypedResults.Ok(bookDto);
        }
    }
}
