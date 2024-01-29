using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books" , GetBooks);
            app.MapGet("/books/{id}" , GetBookById);
            app.MapPut("/books/{id}" , UpdateBook);
            app.MapDelete("/books/{id}" , DeleteBook);
            app.MapPost("/books" , CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var bookResponseDTOs = books.Select(book => MapToBookResponseDTO(book)).ToList();
            return TypedResults.Ok(bookResponseDTOs);
        }

        private static async Task<IResult> GetBookById([FromServices] IBookRepository bookRepository , [FromServices] IAuthorRepository authorRepository , int id)
        {
            var book = await bookRepository.GetBookById(id);
            if(book == null)
                return Results.NotFound();

            var author = await authorRepository.GetAuthorById(book.AuthorId);
            book.Author = author; // Attach author information to the book

            var bookResponseDTO = MapToBookResponseDTO(book);
            return TypedResults.Ok(bookResponseDTO);
        }

        private static async Task<IResult> UpdateBook([FromServices] IBookRepository bookRepository , int id , [FromBody] BookUpdateDTO bookUpdateDTO)
        {
            var book = await bookRepository.GetBookById(id);
            if(book == null)
                return Results.NotFound();

            // Update author if provided
            if(bookUpdateDTO.AuthorId.HasValue)
            {
                var author = await bookRepository.GetAuthorById(bookUpdateDTO.AuthorId.Value);
                if(author == null)
                    return Results.NotFound();

                book.AuthorId = author.Id;
            }

            await bookRepository.SaveChanges();

            var updatedBookResponseDTO = MapToBookResponseDTO(book);
            return TypedResults.Ok(updatedBookResponseDTO);
        }

        private static async Task<IResult> DeleteBook([FromServices] IBookRepository bookRepository , int id)
        {
            var book = await bookRepository.GetBookById(id);
            if(book == null)
                return Results.NotFound();

            await bookRepository.DeleteBook(book);
            return Results.Ok();
        }

        private static async Task<IResult> CreateBook([FromServices] IBookRepository bookRepository , [FromBody] BookCreateDTO bookCreateDTO)
        {
            var author = await bookRepository.GetAuthorById(bookCreateDTO.AuthorId);

            if(author == null)
                return Results.NotFound();

            var newBook = new Book
            {
                Title = bookCreateDTO.Title ,
                AuthorId = author.Id
            };

            await bookRepository.AddBook(newBook);

            var createdBookResponseDTO = MapToBookResponseDTO(newBook);
            return Results.Created("/books/{id}" , createdBookResponseDTO);
        }




        private static BookResponseDTO MapToBookResponseDTO(Book book)
        {
            return new BookResponseDTO
            {
                Id = book.Id ,
                Title = book.Title ,
                Author = MapToAuthorResponseDTO(book.Author)
            };
        }

        private static AuthorResponseDTO MapToAuthorResponseDTO(Author author)
        {
            if(author == null)
            {
                return new AuthorResponseDTO();
            }

            return new AuthorResponseDTO
            {
                Id = author.Id ,
                FirstName = author.FirstName ,
                LastName = author.LastName ,
                Email = author.Email ,
            };
        }
    }
}
