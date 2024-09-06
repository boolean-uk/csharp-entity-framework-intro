using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id:int}", GetBookById);
            books.MapGet("/{title}", GetBookByTitle);
            books.MapPost("/", AddBook);
            books.MapDelete("/{id:int}", RemoveBook);
            books.MapPut("/{id:int}", UpdateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IRepository<Book> repo)
        {
            var books = await repo.GetAll();
            var bookDTOs = books.Select(b => new BookDTO
            {
                Title = b.Title,
                AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                AuthorEmail = b.Author.Email,
                PublisherName = b.Publisher.Name
            }).ToList();
            return TypedResults.Ok(bookDTOs);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBookById(IRepository<Book> repo, int id)
        {
            var book = await repo.GetById(id);
            if (book == null) return TypedResults.NotFound($"Book with id {id} does not exist");
            var bookDTO = new BookDTO
            {
                Title = book.Title,
                AuthorName = book.Author.FirstName + " " + book.Author.LastName,
                AuthorEmail = book.Author.Email,
                PublisherName = book.Publisher.Name
            };
            return TypedResults.Ok(bookDTO);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBookByTitle(IRepository<Book> repo, string title)
        {
            var book = await repo.GetByName(title);
            if (book == null) return TypedResults.NotFound($"Book with title {title} does not exist");
            var bookDTO = new BookDTO
            {
                Title = book.Title,
                AuthorName = book.Author.FirstName + " " + book.Author.LastName,
                AuthorEmail = book.Author.Email,
                PublisherName = book.Publisher.Name
            };
            return TypedResults.Ok(bookDTO);
        }
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddBook(IRepository<Book> bookRepo,
            IRepository<Author> authorRepo, IRepository<Publisher> publisherRepo,
            PostBookModel model)
        {
            var author = await authorRepo.GetById(model.AuthorId);
            if (author == null) return TypedResults.NotFound($"Author with id {model.AuthorId} not found");
            var publisher = await publisherRepo.GetById(model.PublisherId);
            if (publisher == null) return TypedResults.NotFound($"Publisher with id {model.PublisherId} not found");
            
            Book newEntity = new()
            {
                Title = model.Title,
                AuthorId = author.Id,
                PublisherId = publisher.Id,
                Author = author,
                Publisher = publisher
            };
            await bookRepo.Add(newEntity);
            return TypedResults.Created($"/{newEntity.Id}", newEntity);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> RemoveBook(IRepository<Book> bookRepo,
            IRepository<Author> authorRepo, IRepository<Publisher> publisherRepo, int id)
        {
            var book = await bookRepo.GetById(id);
            
            if (book == null) return TypedResults.NotFound($"Book with id {id} does not exist");
            var response = await bookRepo.Remove(book);
            return TypedResults.Ok(response);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook(IRepository<Book> bookRepo,
            IRepository<Author> authorRepo, IRepository<Publisher> publisherRepo,
            int id, PostBookModel model)
        {
            var book = await bookRepo.GetById(id);
            if (book == null) return TypedResults.NotFound($"Book with id {id} does not exist");
            var author = await authorRepo.GetById(model.AuthorId);
            if (author == null) return TypedResults.NotFound($"Author with id {model.AuthorId} not found");
            var publisher = await publisherRepo.GetById(model.PublisherId);
            if (publisher == null) return TypedResults.NotFound($"Publisher with id {model.PublisherId} not found");
            
            book.Title = model.Title;
            book.AuthorId = model.AuthorId;
            book.Author = author;
            book.PublisherId = model.PublisherId;
            book.Publisher = publisher;
            
            var response = await bookRepo.Update(book);
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
