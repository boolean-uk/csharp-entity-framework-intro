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
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapPost("/", PostBook);
            books.MapGet("/{id}",GetOne);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", Deletebook);
        }
       

        private static async Task<IResult> Deletebook(IBookRepository bookrepo, int id)
        {
            await bookrepo.Delete(id);
            return TypedResults.Ok(id);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookrepo, int id, Book book)
        {
            var updateBook = await bookrepo.Update(book, id);
            return TypedResults.Ok(updateBook);
        }

        private static async Task<IResult> GetOne(IBookRepository bookrepo, int id)
        {
            var oneBook = await bookrepo.GetProdById(id);
            return TypedResults.Ok(oneBook);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        private static async Task<IResult> PostBook(IBookRepository bookrepo, Book entity)
        {
            if (entity.AuthorId == null) {
                return TypedResults.NotFound("Author ID not valid");
            }
            if (entity == null) {
                return TypedResults.BadRequest("Book is not valid");
            }
            return  TypedResults.Ok(bookrepo.Add(entity));
        }
        [ProducesResponseType(StatusCodes.Status200OK)]

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            List<BookDTO> results = new List<BookDTO>();
            foreach (var book in books) {
                BookDTO bookDTO = new BookDTO();
                bookDTO.Id = book.Id;
                bookDTO.Title = book.Title;
                bookDTO.Author = book.Author.FirstName+" "+ book.Author.LastName;
                results.Add(bookDTO);
            }

            return TypedResults.Ok(results);
        }
    }
}
