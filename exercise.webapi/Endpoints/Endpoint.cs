using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.GenericDto;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class Endpoint
    {
        public static void ConfigureEndpoint(this WebApplication app)
        {
            var booksGroup = app.MapGroup("books");

            booksGroup.MapGet("/", GetBooks);
            booksGroup.MapGet("/{id}", GetBook);
            booksGroup.MapPut("/{id}", UpdateBook);
            booksGroup.MapDelete("/{id}", DeleteBook);
            booksGroup.MapPost("/", CreateBook);

            var authorsGroup = app.MapGroup("authors");

            authorsGroup.MapGet("/", GetAuthors);
            authorsGroup.MapGet("/{id}", GetAuthor);

            var publisherGroup = app.MapGroup("publishers");

            publisherGroup.MapGet("/", GetAllPublishers);
            publisherGroup.MapGet("/{id}", GetPublisher);
        }

        //Book API
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var entities = await bookRepository.GetAllBooks();

            List<BookDto> books = new List<BookDto>();

            foreach(var entity in entities)
            {
                var book = new BookDto()
                {
                    Title = entity.Title,
                    Author = new AuthorDto()
                    {
                        FirstName = entity.Author.FirstName,
                        LastName = entity.Author.LastName,
                        Email = entity.Author.Email
                    },
                    Publisher = new PublisherDto()
                    {
                        Name = entity.Publisher.Name,
                    }
                };
                books.Add(book);
            }

            Payload<List<BookDto>> result = new Payload<List<BookDto>>();
            result.data = books;


            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id) { 
            
            var entity = await bookRepository.GetBook(id);

            BookDto book = new BookDto()
            {
                Title = entity.Title,
                Author = new AuthorDto()
                {
                    FirstName = entity.Author.FirstName,
                    LastName = entity.Author.LastName,
                    Email = entity.Author.Email
                },
                Publisher = new PublisherDto()
                {
                    Name = entity.Publisher.Name,
                }
            };
            Payload<BookDto> result = new Payload<BookDto>();
            result.data = book;

            return TypedResults.Ok(result);

        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookAuthorPut model)
        {
            var entities = await bookRepository.GetAllBooks();
            if(!entities.Any(x => x.Id == id))
            {
                return TypedResults.NotFound("Book not found");
            }
            var entity = await bookRepository.GetBook(id);

            entity.AuthorId = model.AuthorId != null ? model.AuthorId : entity.AuthorId;

            BookDto Book = new BookDto()
            {
                Title = entity.Title,
                Author = new AuthorDto()
                {
                    FirstName = entity.Author.FirstName,
                    LastName = entity.Author.LastName,
                    Email = entity.Author.Email
                },
                Publisher = new PublisherDto()
                {
                    Name = entity.Publisher.Name,
                }
            };

            bookRepository.UpdateBookAuthor(id, entity);
            Payload<BookDto> result = new Payload<BookDto>();
            result.data = Book;

            return TypedResults.Created($"/{entity.Id}", result);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var entities = await bookRepository.GetAllBooks();
            if (!entities.Any(x => x.Id == id))
            {
                return TypedResults.NotFound("Book not found");
            }

            var entity = await bookRepository.GetBook(id);

            BookDto Book = new BookDto()
            {
                Title = entity.Title,
                Author = new AuthorDto()
                {
                    FirstName = entity.Author.FirstName,
                    LastName = entity.Author.LastName,
                    Email = entity.Author.Email
                },
                Publisher = new PublisherDto()
                {
                    Name = entity.Publisher.Name,
                }
            };

            Payload<BookDto> result = new Payload<BookDto>();
            result.data = Book;

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPost book)
        {

            var authorEntries = await bookRepository.GetAllAuthors();
            var publisherEntries = await bookRepository.GetAllPublishers();
            if (!authorEntries.Any(a => a.Id == book.AuthorId))
            {
                return TypedResults.NotFound("Author not found");
            }
           

            var bookEntries = await bookRepository.GetAllBooks();
            if (authorEntries.Any(a => a.Id == book.Id))
            {
                return TypedResults.BadRequest("Book already exists");
            }

            Book entity = new Book();

            entity.Id = book.Id;
            entity.Title = book.Title;
            entity.Author = authorEntries.FirstOrDefault(a => a.Id == book.AuthorId);
            entity.Publisher = publisherEntries.FirstOrDefault(p => p.Id == book.PublisherId);

            BookDto bookDto = new BookDto()
            {
                Title = book.Title,
                Author = new AuthorDto()
                {
                    FirstName = entity.Author.FirstName,
                    LastName = entity.Author.LastName,
                    Email = entity.Author.Email
                },
                Publisher = new PublisherDto()
                {
                    Name = entity.Publisher.Name,
                }
            };
            Payload<BookDto> result= new Payload<BookDto>();
            result.data = bookDto;

            await bookRepository.CreateBook(entity);
            return TypedResults.Ok(result);
        }

        //Author API
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var entities = await bookRepository.GetAllAuthors();


            List<AuthorDto> authors = new List<AuthorDto>();

            foreach(var entity in entities)
            {
                var author = new AuthorDto()
                {
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Email = entity.Email,
                    Books = entity.Books.Select(x => new BookDto() { Title = x.Title }).ToList(),
                };
                authors.Add(author);
            }

            Payload<List<AuthorDto>> result = new Payload<List<AuthorDto>>();
            result.data = authors;

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthor(IBookRepository bookRepository, int id)
        {
            var entity = await bookRepository.GetAuthor(id);

            AuthorDto author = new AuthorDto()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                Books = entity.Books.Select(x => new BookDto() { Title = x.Title}).ToList(),
            };

            Payload<AuthorDto> result = new Payload<AuthorDto>();
            result.data = author;

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllPublishers(IBookRepository bookRepository)
        {
            var entities = await bookRepository.GetAllPublishers();

            List<PublisherDto> publishers = new List<PublisherDto>();

            foreach(var entity in entities)
            {
                var publisher = new PublisherDto()
                {
                    Name = entity.Name,
                    Books = entity.Books.Select(x => new BookDto() { Title = x.Title }).ToList(),
                };
                publishers.Add(publisher);
            }

            Payload<List<PublisherDto>> result = new Payload<List<PublisherDto>>();
            result.data = publishers;

            return TypedResults.Ok(result);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublisher(IBookRepository bookRepository, int id)
        {
            var entity = await bookRepository.GetPublisher(id);

            PublisherDto publisher = new PublisherDto()
            {
                Name = entity.Name,
                Books = entity.Books.Select(x => new BookDto() { Title = x.Title }).ToList(),
            };

            Payload<PublisherDto> result = new Payload<PublisherDto>();
            result.data = publisher;

            return TypedResults.Ok(result);
        }


    }
}
