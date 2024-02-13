using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Models.DTO_fromClient;
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
            app.MapGet("/books/{id}", GetABook);
            app.MapPut("/books/{book}/{author}", UpdateBook);
            app.MapDelete("/books/{id}", Delete);
            app.MapPost("/books", Create);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetABook(IBookRepository bookRepository, int id)
        {
            var Book = await bookRepository.GetABook(id);            
            return TypedResults.Ok(Book);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int book, int author)
        {
            var Book = await bookRepository.UpdateBook(book, author);
            return TypedResults.Ok(Book);
        }

        private static async Task<IResult> Delete(IBookRepository bookRepository, int id)
        {
            var Book = await bookRepository.Delete(id);
            return TypedResults.Ok(Book);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> Create(IBookRepository bookRepository, Book_client_DTO book)
        {
            if (book.Title == string.Empty) { return  TypedResults.BadRequest("Error: Book title is empty");}
            Response<Book> response = await bookRepository.Create(book);            
            if (response.Status == System.Net.HttpStatusCode.NotFound)
            {
                return TypedResults.NotFound($"Author with id: {book.AuthorId} was not found");
            }

            if (response.Status == System.Net.HttpStatusCode.Created) 
            {
                return TypedResults.Created("Book was successfully created",response.item);
            }
            return TypedResults.BadRequest();
        }
    }
}
