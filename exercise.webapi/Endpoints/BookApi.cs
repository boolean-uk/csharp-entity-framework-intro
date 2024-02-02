using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            // Map endpoint to get all books
            app.MapGet("/books", GetBooks);

            // Map endpoint to get a single book by id
            app.MapGet("/books/{id}", GetBookById);

            // Map endpoint to create a new book
            app.MapPost("/books", CreateBook);

            // Map endpoint to update a book by id
            app.MapPut("/books/{id}", UpdateBook);

            // Map endpoint to delete a book by id
            app.MapDelete("/books/{id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            // Retrieve all books using the bookRepository
            var books = await bookRepository.GetAllBooks();
            // Return Ok with the list of books
            return TypedResults.Ok(books);
        }


        private static async Task<IResult> GetBookById(int id, IBookRepository bookRepository)
        {
            // Retrieve a single book by id using the bookRepository
            var book = await bookRepository.GetBook(id);

            // Return Ok if the book is found, NotFound otherwise
            return book != null ? TypedResults.Ok(book) : TypedResults.NotFound();
        }

        private static async Task<IResult> CreateBook([FromBody] Book newBook, IBookRepository bookRepository)
        {
            var createdBook = await bookRepository.CreateBook(newBook);
            if (createdBook != null)
            {
                BookDTO bookDTO = new BookDTO()
                {
                    Id = createdBook.Id,
                    Title = createdBook.Title,
                    AuthorId = createdBook.Author.Id,
                    Author = $"{createdBook.Author.FirstName} {createdBook.Author.LastName}",
                    PublisherId = createdBook.PublisherId,
                    Publisher = createdBook.Publisher.Name
                };
                return TypedResults.Ok(bookDTO);
            }

            return TypedResults.NotFound("Author does not exist");

        }

        private static async Task<IResult> UpdateBook(int id, [FromBody] Book updatedBook, IBookRepository bookRepository)
        {
            var updatedBookResult = await bookRepository.UpdateBook(id, updatedBook);

            // Return Ok if the book is updated successfully, NotFound otherwise
            return updatedBookResult != null ? TypedResults.Ok(updatedBookResult) : TypedResults.NotFound();
        }

        private static async Task<IResult> DeleteBook(int id, IBookRepository bookRepository)
        {
            var isDeleted = await bookRepository.DeleteBook(id);

            // Return NoContent if the book is deleted, NotFound otherwise
            return isDeleted ? TypedResults.NoContent() : TypedResults.NotFound();
        }


    }
}
