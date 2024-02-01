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

            app.MapGet("/publisher/{id}", GetPublisherById);
            app.MapGet("/publisher/all", GetPublishers);




        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            List<BookAuthorDTO> newBooks = new List<BookAuthorDTO>();
            foreach (var bo in books)
            {
                newBooks.Add(new BookAuthorDTO(){AuthorId = 
                    bo.AuthorId, Title = bo.Title, PublisherId = bo.PublisherId,
                    AuthorObj = new AuthorDTO()
                        {Email = bo.Author.Email, FirstName = bo.Author.FirstName, LastName = bo.Author.LastName}}
                );
            }

            return TypedResults.Ok(newBooks);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var books = await bookRepository.GetBookById(id);
            BookAuthorDTO newBook = new BookAuthorDTO()
            {
                AuthorId = books.AuthorId, PublisherId = books.PublisherId, Title = books.Title,
                AuthorObj = new AuthorDTO(){Email = books.Author.Email, FirstName = books.Author.FirstName, LastName = books.Author.LastName}
            };
            return TypedResults.Ok(newBook);
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



        private static async Task<IResult> GetPublisherById(IBookRepository bookRepository, int id)
        {
            var pub = await bookRepository.GetPublisherById(id);

            PublisherDTO PubDTO = new PublisherDTO();
            PubDTO.Id = pub.Id;
            PubDTO.Name = pub.Name;

            foreach (var pubBook in pub.PublishedBooks)
            {
                PubDTO.PublishedBooks.Add(new BookAuthorDTO()
                {
                    AuthorId = pubBook.AuthorId, PublisherId = pubBook.PublisherId, Title = pubBook.Title,
                    AuthorObj = new AuthorDTO() { Email = pubBook.Author.Email, FirstName = pubBook.Author.FirstName, LastName = pubBook.Author.LastName }
                });

            }

            return TypedResults.Ok(PubDTO);
        }

        private static async Task<IResult> GetPublishers(IBookRepository bookRepository)
        {
            //var author = await bookRepository.GetAuthorById(id);


            //return TypedResults.Ok(authorDTO);
            throw new NotImplementedException();
        }

    }
}
