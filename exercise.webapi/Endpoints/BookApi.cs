using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/GetBooks", GetBooks);
            books.MapPost("/AddBook", AddABook);
            books.MapGet("/GetBook{id}", GetBook);
            books.MapPut("/UpdateBook{bookId}", UpdateBook);
            books.MapDelete("/RemoveBook{id}", RemoveBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository repository)
        {
            var results = await repository.GetAllBooks();
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBook(IBookRepository repository, int id)
        {
            var results = await repository.GetBook(id);
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddABook(IBookRepository bookRepository, IAuthorRepository authorRepository, InputDTO data)
        {
            try
            {
                //Check if the input data was good
                foreach (var Id in data.AuthorIds)
                {
                    var response = authorRepository.GetAuthor(Id);
                    if (response.IsFaulted)
                    {
                        return TypedResults.BadRequest();
                    }
                }
                //Construct the book
                var book = new Book()
                {
                    Title = data.Title
                };

                foreach (var Id in data.AuthorIds)
                {
                    book.BookAuthors.Add(new BookAuthor() { BookId = book.Id, AuthorId = Id });
                }

                var results = await bookRepository.AddBook(book);

                if (results == null)
                {
                    return TypedResults.BadRequest();
                }
                else
                {
                    return TypedResults.Created($"http://localhost:5201/books/{results.Id}", results);
                }
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, int bookId, UpdateInputDTO data)
        {
            try
            {
                //Check if the input data was good
                foreach(var Id in data.newAuthors)
                {
                    var response = authorRepository.GetAuthor(Id);
                    if(response.IsFaulted)
                    {
                        return TypedResults.BadRequest();
                    }
                }
                //Get the book
                var book = await bookRepository.GetBook(bookId);
                if (book != null)
                {
                    //Update the book's authors
                    var results = await bookRepository.UpdateBook(bookId, data.newAuthors);
                    return TypedResults.Ok(results);
                }
                else
                {
                    return TypedResults.NotFound();
                }
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> RemoveBook(IBookRepository repository, int id)
        {
            try
            {
                //Check if the book exists
                var book = await repository.GetBook(id);
                if (book != null)
                {
                    //Delete the book from the database
                    var results = await repository.DeleteBook(id);
                    return TypedResults.Ok(results);
                }
                else
                {
                    return TypedResults.NotFound();
                }
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
