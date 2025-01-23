using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", Get);
            app.MapPost("/books", Create);
            app.MapPut("/books/{id}", Put);
            app.MapDelete("/books/{id}", Delete);
            
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            List<BookDTO> bookDTOList = books.Select(book => new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new MinimalAuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            }).ToList();
            return TypedResults.Ok(bookDTOList);
        }

        
        private static async Task<IResult> Get(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.Get(id);
            if (book == null) { return TypedResults.NotFound("Book Not Found"); }
            var bookDTO = new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new MinimalAuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            };
            return TypedResults.Ok(bookDTO);
        }

        private static async Task<IResult> Create(IBookRepository bookRepository, IAuthorRepository authorRepository, PostBook book)
        {
            if(String.IsNullOrEmpty(book.Title))
            { 
                return TypedResults.BadRequest(); 
            }
            Author authorFound = await authorRepository.Get(book.AuthorId);
            if(authorFound == null) { return TypedResults.NotFound(); }

            Book newBook = new Book
            {
                Title = book.Title,
                AuthorId = book.AuthorId,

            };
            bookRepository.Create(newBook);
            return TypedResults.Ok(new BookDTO
            {
                Id = newBook.Id,
                Title = newBook.Title,
                AuthorId = newBook.AuthorId,
                Author = new MinimalAuthorDTO
                {
                    Id = authorFound.Id,
                    FirstName = authorFound.FirstName,
                    LastName = authorFound.LastName,
                    Email = authorFound.Email
                }
            });
            

        }

        private static async Task<IResult> Put(IBookRepository bookRepository, IAuthorRepository authorRepository, int id, PutBook book)
        {
            Author foundAuthor = null;
            Book bookToBeUpdated = null;
            if(book.AuthorId.HasValue) { 
            foundAuthor = await authorRepository.Get(book.AuthorId.Value);
            }
            if (String.IsNullOrEmpty(book.Title) && !book.AuthorId.HasValue) 
            {
                return TypedResults.BadRequest("Empty payload");
            }
            if(foundAuthor == null && book.AuthorId.HasValue) { return TypedResults.NotFound("Author not found"); };
            bookToBeUpdated = bookRepository.Get(id).Result;
            if (bookToBeUpdated == null)
            {
                return TypedResults.NotFound("Book not found");
            }
            bookToBeUpdated.Title = !string.IsNullOrEmpty(book.Title) ? book.Title : bookToBeUpdated.Title;
            if (foundAuthor != null)
            {
                bookToBeUpdated.AuthorId = (int)book.AuthorId;
                bookToBeUpdated.Author = foundAuthor;
            }
            bookRepository.Update(bookToBeUpdated);
            return TypedResults.Ok(new BookDTO
            {
                Id = bookToBeUpdated.Id,
                Title = bookToBeUpdated.Title,
                AuthorId = bookToBeUpdated.AuthorId,
                Author = new MinimalAuthorDTO
                {
                    Id = bookToBeUpdated.Author.Id,
                    FirstName = bookToBeUpdated.Author.FirstName,
                    LastName = bookToBeUpdated.Author.LastName,
                    Email = bookToBeUpdated.Author.Email
                }
            });  

        }

        private static async Task<IResult> Delete(IBookRepository bookRepository, IAuthorRepository authorRepository, int id)
        {
            Book book = bookRepository.Get(id).Result;
            bool isDeleted = await bookRepository.Delete(book);
            return TypedResults.Ok(new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new MinimalAuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            });
        }
    }
}
