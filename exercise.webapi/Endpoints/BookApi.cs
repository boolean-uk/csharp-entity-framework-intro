using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var bookGroup = app.MapGroup("/books");
            bookGroup.MapGet("", GetBooks);
            bookGroup.MapGet("{id}", GetABook);
            bookGroup.MapPost("", AddBook);
            bookGroup.MapPut("{id}", UpdateBook);
            bookGroup.MapDelete("{id}", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            GetAllResponse<DTOBook> bookResponse = new GetAllResponse<DTOBook>();
            var books = await bookRepository.GetAllBooks();
            
            foreach (Book book in books)
            {
                bookResponse.response.Add(createDTOBook(book));
            }

            return TypedResults.Ok(bookResponse);
        }

        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async  Task<IResult> GetABook(int id, IBookRepository bookRepository)
        {
            var book = await bookRepository.GetABook(id);

            if (book == null)
            {
                return TypedResults.NotFound(new Message());
            }

            return TypedResults.Ok(createDTOBook(book));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddBook(IBookRepository bookRepository, IAuthorRepository authorRepository, BookPostModel bookModel)
        {
            try
            {
                if(! await bookRepository.CheckIfAuthor(bookModel.AuthorId))
                {
                    return TypedResults.NotFound(new Message() { Information = "Author does not exist in database" });
                }

                var book = await bookRepository.AddBook(new Book() { Title = bookModel.Title, AuthorId = bookModel.AuthorId, PublisherId = bookModel.PublisherId });
                book = await bookRepository.GetABook(book.Id);

                return TypedResults.Created("", createDTOBook(book));
            }
            catch (Exception ex) 
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateBook(int id, IBookRepository bookRepository, int authorId)
        {
            if (!  await bookRepository.CheckIfAuthor(authorId))
            {
                return TypedResults.NotFound(new Message() { Information = "Author does not exist in database" });
            }

            var toUpdate = await bookRepository.GetABook(id);

            if (toUpdate != null)
            {
                toUpdate.AuthorId = authorId;
                await bookRepository.UpdateBook(toUpdate);
                var updated = await bookRepository.GetABook(id);

                return TypedResults.Created("", createDTOBook(updated));
            }
            return TypedResults.NotFound(new Message());
        }

        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(int id, IBookRepository bookRepository)
        {
            var book = await bookRepository.DeleteBook(id);

            if (book != null)
            {
                return TypedResults.Ok(createDTOBook(book));
            }

            return TypedResults.NotFound(new Message());
        }

        private static DTOBook createDTOBook(Book book) 
        {
            DTOAuthorWithoutBooks dtoauthor = new DTOAuthorWithoutBooks() { ID = book.Author.Id, Name = $"{book.Author.FirstName} {book.Author.LastName}" };
            DTOPublisherWithoutBooks dtopublisher = new DTOPublisherWithoutBooks { ID = book.Publisher.Id, Name = book.Publisher.Name };
            return new DTOBook() { ID = book.Id, Title = book.Title, Author = dtoauthor, Publisher = dtopublisher };

        }
    }
}
