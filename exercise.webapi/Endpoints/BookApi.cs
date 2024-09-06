using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Authentication;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("book");
            app.MapGet("/", GetBooks);
            app.MapGet("/{id}", GetBookById);
            app.MapPut("/{id}", UpdateBook);
            app.MapDelete("/{id}", DeleteById);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            GetBooksResponse response = new GetBooksResponse();

            var results = await bookRepository.GetAllBooks();

            foreach (var b in results) 
            {
                DTOBook book = new DTOBook();
                book.Title = b.Title;
                book.ID = b.Id;

                DTOAuthor author = new DTOAuthor();
                author.Name = b.Author.FirstName + " " + b.Author.LastName;
                author.Email = b.Author.Email;

                book.Author = author;

                response.Books.Add(book);
            }
            return TypedResults.Ok(response);
        }

        private static async Task<IResult> GetBookById(IBookRepository bookRepository ,int id)
        {
            Book result = await bookRepository.GetBookById(id);

            DTOBook book = new DTOBook();
            book.Title = result.Title;
            book.ID = result.Id;

            DTOAuthor author = new DTOAuthor();
            author.Name = result.Author.FirstName + " " + result.Author.LastName;
            author.Email = result.Author.Email;

            book.Author = author;

            return TypedResults.Ok(book);
        }

        private static async Task<IResult> UpdateBook(IAuthorRepository authorRepository, IBookRepository bookRepository, int id, BookPutModel model)
        {
            var editing = await bookRepository.GetBookById(id);

            DTOBook editedBook = new DTOBook();
            editedBook.Title = editing.Title;
            editedBook.ID = editing.Id;

            DTOAuthor dtoAuthor = new DTOAuthor();

            var exists = await authorRepository.GetAuthorByName(model.FirstName, model.LastName);

            if (exists != null) 
            {
                editing.AuthorId = exists.Id;

                dtoAuthor.Name = exists.FirstName + " " + exists.LastName;
                dtoAuthor.Email = exists.Email;
                editedBook.Author = dtoAuthor;
                await bookRepository.UpdateById(id, editing);
                return TypedResults.Ok(editedBook);
            }
            else
            {
                Author author = new Author();
                author.FirstName = model.FirstName;
                author.LastName = model.LastName;
                author.Email = model.Email;

                editing.Author = author;
                await bookRepository.UpdateById(id, editing);

                dtoAuthor.Name = editing.Author.FirstName + " " + editing.Author.LastName;
                dtoAuthor.Email = editing.Author.Email;

                editedBook.Author = dtoAuthor;
                return TypedResults.Ok(editedBook);
            }
        }

        private static async Task<IResult> DeleteById(IBookRepository bookRepository, int id)
        {
            var deleted = await bookRepository.DeleteById(id);

            DTOBook deletedBook = new DTOBook();
            deletedBook.Title = deleted.Title;
            deletedBook.ID = deleted.Id;

            DTOAuthor author = new DTOAuthor();
            author.Name = deleted.Author.FirstName + " " + deleted.Author.LastName;
            author.Email = deleted.Author.Email;

            deletedBook.Author = author;

            return TypedResults.Ok(deletedBook);
        }
    }
}
