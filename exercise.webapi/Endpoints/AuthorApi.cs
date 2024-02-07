using exercise.webapi.Models;
using exercise.webapi.Models.ModelsAuthorAPI;
using exercise.webapi.Models.ModelsBookAPI;
using exercise.webapi.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var groupMembers = app.MapGroup("authors");
            groupMembers.MapGet("/", GetAuthors);
            groupMembers.MapGet("/{id}", GetAuthorById);
        }

        private static async Task<IResult> GetAuthors(IRepository<Author> authorRepository, IRepository<Book> bookRepository)
        {
            var authorDtos = new List<AuthorApiAuthorDto>();
            var authors = await authorRepository.Get();
            var books = await bookRepository.Get();

            foreach (var author in authors)
            {
                
                var pairs = author.BookAuthorPairs;
                var bookDtos = new List<AuthorApiBookDto>();

                foreach (var pair in pairs)
                {
                    var book = books.FirstOrDefault(b => b.Id == pair.BookId);
                    if (book != null)
                    {
                        var bookDto = new AuthorApiBookDto()
                        {
                            Id = book.Id,
                            Title = book.Title
                        };

                        bookDtos.Add(bookDto);
                    }
                }

                var authorDto = new AuthorApiAuthorDto()
                {
                    Id=author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                    Books = bookDtos
                };

                authorDtos.Add(authorDto);
            }
            return TypedResults.Ok(authorDtos);
        }

        private static async Task<IResult> GetAuthorById(IRepository<Author> authorRepository, IRepository<Book> bookRepository, int id)
        {
            var author = await authorRepository.GetById(id);
            var books = await bookRepository.Get();
            var pairs = author.BookAuthorPairs;
            var bookDtos = new List<AuthorApiBookDto>();

            foreach (var pair in pairs)
            {
                var book = books.FirstOrDefault(b => b.Id == pair.BookId);
                if (book != null)
                {
                    var bookDto = new AuthorApiBookDto()
                    {
                        Id = book.Id,
                        Title = book.Title
                    };

                    bookDtos.Add(bookDto);
                }
            }

            var authorDto = new AuthorApiAuthorDto()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = bookDtos
            };

            return TypedResults.Ok(authorDto);
        }
    }
}
