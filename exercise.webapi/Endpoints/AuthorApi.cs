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

        private static async Task<IResult> GetAuthors(IRepository<Author> authorRepository)
        {
            var authorDtos = new List<AuthorApiAuthorDto>();
            var authors = await authorRepository.Get();

            foreach (var author in authors)
            {
                
                var bookDtos = new List<AuthorApiBookDto>();
                var books = author.Books;
                
                foreach (var book in books)
                {
                    var bookDto = new AuthorApiBookDto()
                    {
                        Id = book.Id,
                        Title = book.Title,
                    };

                    bookDtos.Add(bookDto);
                }

                var authorDto = new AuthorApiAuthorDto()
                {
                    Id=author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                    BookDtos = bookDtos
                };

                authorDtos.Add(authorDto);
            }
            return TypedResults.Ok(authorDtos);

        }

        private static async Task<IResult> GetAuthorById(IRepository<Author> authorRepository, int id)
        {
            var author = await authorRepository.GetById(id);
            var books = author.Books;
            var bookDtos = new List<AuthorApiBookDto>();

            foreach (var book in books)
            {
                var bookDto = new AuthorApiBookDto()
                {
                    Id = book.Id,
                    Title = book.Title,
                };

                bookDtos.Add(bookDto);
            }

            var authorDto = new AuthorApiAuthorDto()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                BookDtos = bookDtos
            };

            return TypedResults.Ok(authorDto);
        }
    }
}
