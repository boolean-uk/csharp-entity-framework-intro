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
            books.MapPost("/", AddBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IRepository<Book> repo)
        {
            var list = await repo.GetAll();
            return TypedResults.Ok(list);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddBook(IRepository<Book> bookRepo,
            IRepository<Author> authorRepo, IRepository<Publisher> publisherRepo,
            PostBookModel model)
        {
            var author = await authorRepo.GetByName(model.AuthorName);
            var publisher = await publisherRepo.GetByName(model.PublisherName);
            if (author == null || publisher == null)
            {
                return TypedResults.NotFound("Author or Publisher not found");
            }
            
            Book newEntity = new()
            {
                Title = model.Title,
                AuthorId = author.Id,
                PublisherId = publisher.Id,
                Author = author,
                Publisher = publisher
            };
            await bookRepo.Add(newEntity);
            return TypedResults.Ok(newEntity);
        }
    }
}
