using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/books", GetBooks);
            books.MapGet("/{id}", GetABook);
            books.MapPost("/", CreateBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            List<BookResponseDTO> results = new List<BookResponseDTO>();
            var books = await bookRepository.GetAllBooks();

            foreach(var book in books)
            {
                var bookDTO = new BookResponseDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    PublisherId = book.PublisherId,
                    Publisher = new PublisherDTO
                    {
                        Name = book.Publisher.Name
                    },
                    Authors = book.Bookauthors.Select(ba => new AuthorDTO
                    {
                        FirstName = ba.Author.FirstName, 
                        LastName = ba.Author.LastName,
                        Email = ba.Author.Email
                    }).ToList()
                };
                results.Add(bookDTO);
            }
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetABook(IBookRepository bookRepository, int id)
        {
            var results = await bookRepository.GetABook(id);
            if (results == null)
            {
                TypedResults.NotFound("Id not found");
            }

            var bookDTO = new BookResponseDTO
            {
                Id = results.Id,
                Title = results.Title,
                PublisherId = results.PublisherId,
                Publisher = new PublisherDTO
                {
                    Name = results.Publisher.Name
                }
                
            };
            foreach(var author in results.Bookauthors)
            {
                AuthorDTO entity = new AuthorDTO
                {
                    FirstName = author.Author.FirstName,
                    LastName = author.Author.LastName,
                    Email = author.Author.Email
                };
                bookDTO.Authors.Add(entity);
            }
            return TypedResults.Ok(bookDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> UpdateBook(IBookRepository bookrepo, int id, BookPut model)
        {
            var results = await bookrepo.UpdateBook(id, model);
            if (results == null)
            {
                TypedResults.NotFound();
            }

            var bookDTO = new BookResponseDTO
            {
                Id = results.Id,
                Title = results.Title,
                PublisherId = results.PublisherId,
                Publisher = new PublisherDTO
                {
                    Name = results.Publisher.Name
                },
                Authors = results.Bookauthors.Select(ba => new AuthorDTO
                {
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName,
                    Email = ba.Author.Email
                }).ToList()
            };
            return TypedResults.Ok(bookDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IBookRepository bookrepo, int id)
        {
            var results = await bookrepo.DeleteBook(id);
            if (results == null)
            {
                TypedResults.NotFound("Id not found");
            }

            var bookDTO = new BookResponseDTO
            {
                Id = results.Id,
                Title = results.Title,
                PublisherId = results.PublisherId,
                Publisher = new PublisherDTO
                {
                    Name = results.Publisher.Name
                },
                Authors = results.Bookauthors.Select(ba => new AuthorDTO
                {
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName,
                    Email = ba.Author.Email
                }).ToList()
            };
            return TypedResults.Ok(bookDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateBook(IBookRepository bookrepo, BookPost model)
        {
            var results = await bookrepo.CreateBook(model);
            if (results == null)
            {
                TypedResults.NotFound("Invalid data");
            }

            var bookDTO = new BookResponseDTO
            {
                Id = results.Id,
                Title = results.Title,
                PublisherId = results.PublisherId,
                Publisher = new PublisherDTO
                {
                    Name = results.Publisher.Name
                },
                Authors = results.Bookauthors.Select(ba => new AuthorDTO
                {
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName,
                    Email = ba.Author.Email
                }).ToList()
            };
            return TypedResults.Ok(bookDTO);
        }
    }
}
