using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPost("/books/create", createBook);
            app.MapDelete("/books/delete/{id}", deleteBook);
            app.MapPut("/books/author/{id}/{authorId}", updateBook);
            app.MapDelete("/books/delete/author/{bookId}", removeAuthor);
            app.MapPut("/books/assign/{id}/{authorId}", assignAuthor);



        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository, IEnumerable<BookDTO> list)
        {
            var books = await bookRepository.GetAllBooks();
            var bookDtos = books.Select(b => new BookDTO
            {
                bookId = b.Id,
                title = b.Title,
                authorId = b.Author.Id,
                AuthorName = b.Author.FirstName + " " + b.Author.LastName

            }).ToList();
            return TypedResults.Ok(bookDtos);
        }
        private static async Task<IResult> GetBook(IBookRepository bookRepository,int id)
        {
            var book = await bookRepository.GetBook(id);
            BookDTO bookDTO = new BookDTO() { bookId = book.Id,
                title = book.Title,
                authorId = book.AuthorId,
                AuthorName = book.Author.FirstName + " " + book.Author.LastName
            };
            return TypedResults.Ok(bookDTO);
        }
            
        private static async Task<IResult> deleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            BookDTO bookDTO = new BookDTO()
            {
                bookId = book.Id,
                title = book.Title,
                authorId = book.AuthorId,
                AuthorName = book.Author.FirstName + " " + book.Author.LastName
            };
            bookRepository.DeleteBook(id);

            return TypedResults.Ok(book);
        }

        private static async Task<IResult> createBook(IBookRepository bookRepository, BookDTO bookDTO)
        {
            var Author = bookRepository.GetAuthor(bookDTO.authorId);
            if (Author == null)
            {
                return TypedResults.NotFound();
            }

            var createdBook = await bookRepository.createBook(bookDTO);
            if (createdBook==null)
            {
                return TypedResults.BadRequest();
            } 

            return TypedResults.Ok(bookDTO);
        }

        private static async Task<IResult> updateBook(IBookRepository bookRepository, int id, int authorId)
        {
            var book = await bookRepository.UpdateBook(id, authorId);

            BookDTO updatedDTO = new BookDTO()
            {
                bookId = book.Id,
                title = book.Title,
                authorId = book.AuthorId,
                AuthorName = book.Author.FirstName + " " + book.Author.LastName
            };
            return TypedResults.Ok(updatedDTO);   
        }

        private static async Task<IResult> removeAuthor(IBookRepository bookRepository, int bookId)
        {
            var book = await bookRepository.RemoveAuthor(bookId);
            if (book == null)
            {
                return TypedResults.BadRequest();
            }
            BookDTO removedAuthorBook = new BookDTO()
            {
                bookId = book.Id,
                title = book.Title,
                authorId = -1,
                AuthorName = null
            };
            return TypedResults.Ok(removedAuthorBook);
        }

        private static async Task<IResult> assignAuthor(IBookRepository bookRepository, int bookId, int authorId)
        {
            var book = await bookRepository.AssignAuthor(bookId,authorId);
            if (book == null)
            {
                return TypedResults.BadRequest();
            }
            BookDTO assignedAuthorBook = new BookDTO()
            {
                bookId = book.Id,
                title = book.Title,
                authorId = book.AuthorId,
                AuthorName = book.Author.FirstName + " " + book.Author.LastName
            };

            return TypedResults.Ok(assignedAuthorBook);
        }
    }
}
