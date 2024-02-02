using exercise.webapi.DTO_s;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("Authors");

            authorGroup.MapGet("/", GetAuthors);
            authorGroup.MapGet("/{id}", GetAuthor);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository authRepository, IPublisherRepository pubRepo, IBookRepository bookRepository)
        {
            var authors = await authRepository.GetAllAuthors(); 
            var books = await bookRepository.GetAllBooks(); 

            List< AuthorPublisherDTO> authorList = new List< AuthorPublisherDTO>();

            foreach (var entry in authors)
            {
                AuthorPublisherDTO author = new AuthorPublisherDTO()
                {
                    Id = entry.Id,
                    FirstName = entry.FirstName,
                    LastName = entry.LastName,
                    Books = books
                        .Where(book => book.AuthorId == entry.Id)
                        .Select(book => new BookPublisherDto()
                        {
                            Title = book.Title,
                            PublisherName = book.Publisher.Name
                        }).ToList()
                };
                authorList.Add(author);
            }

            return TypedResults.Ok(authorList);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, IPublisherRepository pubRepo, IBookRepository bookRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            var books = await bookRepository.GetAllBooks();


            var authorDTO = new AuthorPublisherDTO()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Books = books
                    .Where(x => x.AuthorId == author.Id)
                    .Select(book => new BookPublisherDto
                    {
                        Title = book.Title,
                        PublisherName = book.Publisher.Name
                    }).ToList()
                
            };

            return TypedResults.Ok(authorDTO);
        }



    }
}
