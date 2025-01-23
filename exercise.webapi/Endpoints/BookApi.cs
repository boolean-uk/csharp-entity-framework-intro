using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("books/{id}", GetSingleBook);
            app.MapPost("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPost("/books", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = new Payload<List<BookDTO>>()
            {
                Data = new List<BookDTO>()
            };

            var results = await bookRepository.GetAllBooks();
            foreach (Book book in results)
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.title = book.Title;
                bookDTO.id = book.Id;
                bookDTO.author_id = book.AuthorId;
                AuthorDTO authorDTO = new AuthorDTO();
                authorDTO.firstname = book.Author.FirstName;
                authorDTO.lastname = book.Author.LastName;
                authorDTO.email = book.Author.Email;
                authorDTO.id = book.Author.Id;
                bookDTO.author = authorDTO;
                books.Data.Add(bookDTO);


            }
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetSingleBook(IBookRepository bookRepository, int id)
        {
            var book = new Payload<BookDTO>();

            Book result = await bookRepository.GetBook(id);

            BookDTO bookDTO = new BookDTO();
            AuthorDTO authorDTO = new AuthorDTO();
            bookDTO.title = result.Title;
            bookDTO.id = result.Id;
            bookDTO.author_id = result.AuthorId;
            authorDTO.firstname = result.Author.FirstName;
            authorDTO.lastname = result.Author.LastName;
            authorDTO.email = result.Author.Email;
            authorDTO.id = result.Author.Id;
            bookDTO.author = authorDTO;
            book.Data = bookDTO;
            return TypedResults.Ok(book);

        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int author_id)
        {
            var booker = new Payload<BookDTO>();
            Book book = await bookRepository.UpdateBook(id, author_id);

            BookDTO bookDTO = new BookDTO();
            AuthorDTO authorDTO = new AuthorDTO();
            bookDTO.title = book.Title;
            bookDTO.id = book.Id;
            bookDTO.author_id = book.AuthorId;
            authorDTO.firstname = book.Author.FirstName;
            authorDTO.lastname = book.Author.LastName;
            authorDTO.email = book.Author.Email;
            authorDTO.id = book.Author.Id;
            bookDTO.author = authorDTO;
            booker.Data = bookDTO;
            return TypedResults.Ok(booker);


        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            Book bookToDelete = await bookRepository.GetBook(id);

            BookDTO bookDTO = new BookDTO();

            bookDTO.id = bookToDelete.Id;
            bookDTO.title = bookToDelete.Title;
            bookDTO.author_id = bookToDelete.AuthorId;
            AuthorDTO authorDTO = new AuthorDTO();
            authorDTO.firstname = bookToDelete.Author.FirstName;
            authorDTO.lastname = bookToDelete.Author.LastName;
            authorDTO.id = bookToDelete.Author.Id;
            authorDTO.email = bookToDelete.Author.Email;


            bookDTO.author = authorDTO;
            
            await bookRepository.DeleteBook(id);

            return TypedResults.Ok(bookDTO);
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, int author_id)
        {
            Book book = await bookRepository.CreateBook("Axel's Bedtime Stories", author_id);
            Payload<BookDTO>payload = new Payload<BookDTO>();
            BookDTO bookDTO = new BookDTO();

            bookDTO.id = book.Id;
            bookDTO.title = book.Title;
            bookDTO.author_id = book.AuthorId;
            AuthorDTO authorDTO = new AuthorDTO();
            authorDTO.firstname = book.Author.FirstName;
            authorDTO.lastname = book.Author.LastName;
            authorDTO.id = book.Author.Id;
            authorDTO.email = book.Author.Email;


            bookDTO.author = authorDTO;
            payload.Data = bookDTO;
            return TypedResults.Ok(payload);

        }

        
    }
}