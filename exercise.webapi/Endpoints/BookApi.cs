using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books{id}", GetABook);
            app.MapPost("/books{id}", AddBook);
            app.MapPut("/book{id}", UpdateBook);
            app.MapDelete("/books{id}", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            GetBookResponse bookResponse = new GetBookResponse();
            var books = await bookRepository.GetAllBooks();
            
            foreach (Book book in books)
            {
                DTOAuthorWithoutBooks dtoauthor = new DTOAuthorWithoutBooks() { ID = book.Author.Id, Name = $"{book.Author.FirstName} {book.Author.LastName}"};
                DTOBook dtobook = new DTOBook() { ID = book.Id, Title = book.Title, Author = dtoauthor };
                bookResponse.Books.Add(dtobook);
            }

            return TypedResults.Ok(bookResponse);
        }

        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async  Task<IResult> GetABook(int id, IBookRepository bookRepository)
        {
            var book = await bookRepository.GetABook(id);

            if (book == null)
            {
                return TypedResults.NotFound(new Message());
            }
            DTOAuthorWithoutBooks dtoauthor = new DTOAuthorWithoutBooks() { ID = book.Author.Id, Name = $"{book.Author.FirstName} {book.Author.LastName}"};
            DTOBook dtobook = new DTOBook() { ID = book.Id, Title = book.Title, Author = dtoauthor };
            return TypedResults.Ok(dtobook);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddBook(IBookRepository bookRepository, BookPostModel bookModel)
        {
            try
            {
                var book = await bookRepository.AddBook(new Book() { Title = bookModel.Title, AuthorId = bookModel.AuthorId });
                book = await bookRepository.GetABook(book.Id);

                DTOAuthorWithoutBooks dtoauthor = new DTOAuthorWithoutBooks() { ID = book.Author.Id, Name = $"{book.Author.FirstName} {book.Author.LastName}" };
                DTOBook dtobook = new DTOBook() { ID = book.Id, Title = book.Title, Author = dtoauthor };

                return TypedResults.Created("", book);
            }
            catch (Exception ex) 
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateBook(int id, IBookRepository bookRepository, int authorId)
        {
            var toUpdate = await bookRepository.GetABook(id);
            if (toUpdate != null)
            {
                toUpdate.AuthorId = authorId;
                await bookRepository.UpdateBook(toUpdate);
                var updated = await bookRepository.GetABook(id);
                DTOAuthorWithoutBooks dtoauthor = new DTOAuthorWithoutBooks() { ID = updated.Author.Id, Name = $"{updated.Author.FirstName} {updated.Author.LastName}" };
                DTOBook dtobook = new DTOBook() { ID = updated.Id, Title = updated.Title, Author = dtoauthor };

                return TypedResults.Created("", dtobook);
            }
            return TypedResults.NotFound(new Message());
        }

        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(int id, IBookRepository bookRepository)
        {
            var book = await bookRepository.DeleteBook(id);

            if (book != null)
            {
                DTOAuthorWithoutBooks dtoauthor = new DTOAuthorWithoutBooks() { ID = book.Author.Id, Name = $"{book.Author.FirstName} {book.Author.LastName}" };
                DTOBook dtobook = new DTOBook() { ID = book.Id, Title = book.Title, Author = dtoauthor };
                return TypedResults.Ok(dtobook);
            }

            return TypedResults.NotFound(new Message());
        }
    }
}
