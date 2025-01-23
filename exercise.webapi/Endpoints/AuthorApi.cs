
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Routing.Constraints;
using static System.Reflection.Metadata.BlobBuilder;
namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigueAuthorEnpoints(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var authors = new Payload<List<AuthorDTO>>()
            {
                Data = new List<AuthorDTO>()
            };

            var results = await bookRepository.GetAllAuthor();
            var books = await bookRepository.GetAllBooks();
            foreach (Author author in results)
            {
                AuthorDTO authorDTO = new AuthorDTO();
                
                authorDTO.FirstName = author.FirstName;
                authorDTO.LastName = author.LastName;
                authorDTO.Email = author.Email;
                authorDTO.Id = author.Id;
                authorDTO.books = new List<BookDTONoAuthor>();


                var authorBooks = books.Where(b => b.AuthorId == author.Id).ToList();
                
                foreach(Book book in authorBooks)
                {
                    BookDTONoAuthor dto = new BookDTONoAuthor();
                    PublisherNoBooks publisherDTO = new PublisherNoBooks();
                    publisherDTO.Id = book.Publisher.Id;
                    publisherDTO.FirstName = book.Publisher.FirstName;
                    publisherDTO.LastName = book.Publisher.LastName;
                    dto.title = book.Title;
                    
                    dto.id = book.Id;
                    dto.publisher = publisherDTO;
                    
                    
                    authorDTO.books.Add(dto);
                }

                authors.Data.Add(authorDTO);
            }
            return TypedResults.Ok(authors);
        }
        private static async Task<IResult>GetAuthor(IBookRepository bookRepository, int id)
        {
            var payload = new Payload<AuthorDTO>();

            Author author = await bookRepository.GetAuthor(id);
            var books = await bookRepository.GetAllBooks();
            AuthorDTO authorDTO = new AuthorDTO();
            authorDTO.Email = author.Email;
            authorDTO.FirstName = author.FirstName;
            authorDTO.LastName = author.LastName;
            authorDTO.Id = author.Id;
            authorDTO.books = new List<BookDTONoAuthor>();
            var authorBooks = books.Where(x => x.AuthorId == author.Id).ToList();
            foreach(Book book in authorBooks)
            {
                PublisherNoBooks publisherDTO = new PublisherNoBooks();
                publisherDTO.FirstName = book.Publisher.FirstName;
                publisherDTO.Id = book.Publisher.Id;
                publisherDTO.LastName = book.Publisher.LastName;
                BookDTONoAuthor dto = new BookDTONoAuthor();
                dto.title = book.Title;
                dto.id = book.Id;
                dto.publisher = publisherDTO;
                authorDTO.books.Add(dto);
            }

            payload.Data = authorDTO;

            return TypedResults.Ok(payload);

        }
    }
}
