using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors{id}", GetOneAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            GetAllResponse<DTOAuthor> authorResponse = new GetAllResponse<DTOAuthor>();
            var authors = await authorRepository.GetAllAuthors();

            foreach (Author author in authors)
            {
                DTOAuthor dtoauthor = new DTOAuthor() { ID = author.Id, Name = $"{author.FirstName} {author.LastName}", Email = author.Email };
                foreach (Book book in author.Books)
                {
                    DTOPublisherWithoutBooks dtopublisher = new DTOPublisherWithoutBooks() { ID = book.Publisher.Id, Name = book.Publisher.Name };
                    DTOBookWithoutAuthor dtobook = new DTOBookWithoutAuthor() { ID = book.Id, Title = book.Title, Publisher = dtopublisher };
                    dtoauthor.books.Add(dtobook);
                }

                authorResponse.response.Add(dtoauthor);
            }

            return TypedResults.Ok(authorResponse);
        }

        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetOneAuthor(int id, IAuthorRepository authorRepository)
        {
            var author = await authorRepository.GetOneAuthor(id);

            if (author == null)
            {
                return TypedResults.NotFound(new Message());
            }

            DTOAuthor dtoauthor = new DTOAuthor() { ID = author.Id, Name = $"{author.FirstName} {author.LastName}", Email = author.Email };
            foreach (Book book in author.Books)
            {
                DTOPublisherWithoutBooks dtopublisher = new DTOPublisherWithoutBooks() { ID = book.Publisher.Id, Name = book.Publisher.Name };
                DTOBookWithoutAuthor dtobook = new DTOBookWithoutAuthor() { ID = book.Id, Title = book.Title, Publisher = dtopublisher };
                dtoauthor.books.Add(dtobook);
            }

            return TypedResults.Ok(dtoauthor);
        }

    }
}