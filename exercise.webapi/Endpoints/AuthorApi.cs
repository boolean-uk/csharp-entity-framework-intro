
using exercise.webapi.DTO;
using exercise.webapi.DTOS;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");

            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthorById);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            GetAllAuthorsResponse response = new GetAllAuthorsResponse();
            var authors = await authorRepository.GetAllAuthors();

            foreach (Author author in authors)
            {
                DTOAuthorWithBooks dtoAuthor = new DTOAuthorWithBooks()
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email
                };

                foreach (Book book in author.Books)
                {
                    DTOPublisherWithoutBook dtoPublisher = new DTOPublisherWithoutBook() 
                    {
                        Id = book.Publisher.Id,
                        Name = book.Publisher.Name,
                        Email = book.Publisher.Email
                    };

                    DTOBookWithoutAuthorWithPublisher dtoBook = new DTOBookWithoutAuthorWithPublisher()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Publisher = dtoPublisher
                    };

                    dtoAuthor.Books.Add(dtoBook);
                }

                response.Authors.Add(dtoAuthor);
            }

            return TypedResults.Ok(response.Authors);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository, int id)
        {
            try
            {
                var author = await authorRepository.GetAuthorById(id);

                DTOAuthorWithBooks dtoAuthor = new DTOAuthorWithBooks()
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email
                };

                foreach (Book book in author.Books)
                {
                    DTOPublisherWithoutBook dtoPublisher = new DTOPublisherWithoutBook() 
                    {
                        Id = book.Publisher.Id,
                        Name = book.Publisher.Name,
                        Email = book.Publisher.Email
                    };

                    DTOBookWithoutAuthorWithPublisher dtoBook = new DTOBookWithoutAuthorWithPublisher()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Publisher = dtoPublisher
                    };

                    dtoAuthor.Books.Add(dtoBook);
                }

                return TypedResults.Ok(dtoAuthor);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
