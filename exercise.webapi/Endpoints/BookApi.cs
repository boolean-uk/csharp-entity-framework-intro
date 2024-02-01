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
            app.MapGet("/books/{id}", GetBook);
            app.MapPut("/books/update/{id}", UpdateBook);
            app.MapDelete("/book/delete/{id}", DeleteBook);
            app.MapPost("/book/create", CreateBook);


            app.MapGet("/author", GetAuthors);
            app.MapGet("/author/{id}", GetAuthor);


        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var books = await bookRepository.GetBookById(id);
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int newAuthorId)
        {
            var books = await bookRepository.UpdateBookById(id, newAuthorId);
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var books = await bookRepository.DeleteBookById(id);
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookDTO bookdto)
        {
            Book book = new Book() { AuthorId = bookdto.AuthorId, Title = bookdto.Title };
            var books = await bookRepository.CreateBook(book);
            return TypedResults.Ok(books);
        }




        private static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var authors = await bookRepository.GetAllAuthors();
            List<AuthorDTO> authorsDTO = new List<AuthorDTO>();
            foreach (var aut in authors)
            {
                List<BookDTO> booksDTO = new List<BookDTO>();
                foreach (var book in aut.Books)
                {
                    booksDTO.Add(new BookDTO(){AuthorId = book.AuthorId, Title = book.Title});
                }
                authorsDTO.Add(new AuthorDTO(){book = booksDTO, Email = aut.Email, FirstName = aut.FirstName, LastName = aut.LastName});
            }
            return TypedResults.Ok(authorsDTO);
        }

        private static async Task<IResult> GetAuthor(IBookRepository bookRepository, int id)
        {
            var author = await bookRepository.GetAuthorById(id);
            AuthorDTO authorDTO = new AuthorDTO(){Email = author.Email, FirstName = author.FirstName, LastName = author.LastName};

            List<BookDTO> bookDTO = new List<BookDTO>();
            foreach (var book in author.Books)
            {
                bookDTO.Add(new BookDTO(){AuthorId = book.AuthorId, Title = book.Title});
            }
            authorDTO.book = bookDTO;


            return TypedResults.Ok(authorDTO);
        }

    }
}
