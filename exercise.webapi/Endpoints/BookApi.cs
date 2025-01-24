using System.Reflection;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/books", GetAllBooks);
            books.MapGet("/books{id}", GetBookById);
            books.MapPost("/books/{id}", CreateBook);
            books.MapDelete("/books{id}", DeleteBook);
            books.MapPut("/books{id}", UpdateBookAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> GetAllBooks(IBookRepository repository)
        {

            try
            {
                var books = await repository.GetAllBooks();
                var bookDto = books.Select(b => new BookDTO
                {
                    Title = b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                    AuthorEmail = b.Author.Email,
                    PublisherName = b.Publisher.Name}).ToList();


                return TypedResults.Ok(bookDto);
            }

            catch (Exception ex)
            {

                return TypedResults.BadRequest(ex.Message);

            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBookById(IBookRepository repository, int id)
        {
            var book = await repository.GetBookById(id);
            if (book == null)
            {

                return TypedResults.NotFound("Book not found");

            }

            var bookDto = new BookDTO
            { 
                Title = book.Title,
                AuthorEmail = book.Author.Email,
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",    
                PublisherName = book.Publisher.Name
              
                
            
            };

            return TypedResults.Ok(bookDto);

        }



        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, IPublisherRepository publisherRepository, BookPost model)
        {
            var author = await authorRepository.GetAuthorById(model.AuthorId);
            var publisher = await publisherRepository.GetPublisherById(model.PublisherId);
            if (author == null || publisher == null)
            {
                return TypedResults.NotFound("Author or Publisher not found");
            }

            if (model.Title == null)
            {
                return TypedResults.BadRequest("Book object not valid");
            
            }

            Book book = new Book()
            {
                Title = model.Title,
                AuthorId = author.Id,
                PublisherId = publisher.Id,
                Author = author,
                Publisher = publisher
            };

            // Save the book to the repository
            await bookRepository.CreateBook(book);

            var bookDto = new BookDTO
            {
                Title = book.Title,
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                AuthorEmail = book.Author.Email,
                PublisherName = book.Publisher.Name
            };

            return TypedResults.Created($"/neondb/books/{book.Id}", bookDto);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(IBookRepository repository, int id)
        {
            var book = await repository.GetBookById(id);

            if (book == null)
            {
                return TypedResults.NotFound("Book not found");
            }
            
            await repository.DeleteBook(book.Id);

            return TypedResults.Ok(book);


        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBookAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, IPublisherRepository publisherRepository, int id, BookPost model)
        {
            var book = await bookRepository.GetBookById(id);
            var author = await authorRepository.GetAuthorById(model.AuthorId);
            var publisher = await publisherRepository.GetPublisherById(model.PublisherId);


            if (book == null) 
                return TypedResults.NotFound($"Book with the id: {id} does not exist");
            
            if (author == null) 
                return TypedResults.NotFound($"Author with the id: {model.AuthorId} not found");
            
            if (publisher == null) 
                return TypedResults.NotFound($"Publisher with id {model.PublisherId} not found");

            book.Title = model.Title;
            book.AuthorId = model.AuthorId;
            book.Author = author;
            book.PublisherId = model.PublisherId;
            book.Publisher = publisher;

            var response = await bookRepository.UpdateBookAuthor(book.Id, book.AuthorId);
            var bookDTO = new BookDTO
            {
                Title = response.Title,
                AuthorName = response.Author.FirstName + " " + response.Author.LastName,
                AuthorEmail = response.Author.Email,
                PublisherName = response.Publisher.Name
            };
            return TypedResults.Ok(bookDTO);
        }

    }

}