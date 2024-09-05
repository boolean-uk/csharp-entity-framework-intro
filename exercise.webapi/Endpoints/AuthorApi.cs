using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var group = app.MapGroup("authors");
            group.MapGet("/", GetAuthors);
            group.MapGet("/{id}", GetAuthor);
          //  group.MapDelete("/Author:{authorId},{bookId}", EditAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IRepository Repository)
        {
            var authors = await Repository.GetAllAuthors();
            IEnumerable<BookAuthor> authorBooks = await Repository.GetAllAuthorBooks();
            IEnumerable<BookAuthor> bookAuthors = await Repository.GetAllBookAuthors();

            var DTAuthors = new List<DTAuthor>();
            foreach (var author in authors)
            {
                int numOfBooks = authorBooks.Count(ab => ab.AuthorId == author.Id);
                List<SimpleBook> books = new List<SimpleBook>();
                foreach (var authorbook in authorBooks)
                {
                 if (authorbook.AuthorId == author.Id)
                    {
                        string authornames = "";
                        foreach (var item in bookAuthors)
                        {
                            if (item.BookId == authorbook.BookId)
                            {
                                authornames += $"{item.Author.FirstName} {item.Author.LastName}, ";
                            }
                        }

                        SimpleBook book = new SimpleBook()
                        {
                            Id = authorbook.BookId,
                            Title = authorbook.Book.Title,
                            AuthorName = authornames,
                            PublisherName = $"{authorbook.Book.Publisher.Firstname} {authorbook.Book.Publisher.Lastname}"
                        };
                        books.Add(book);
                    }


                }
                DTAuthors.Add(new DTAuthor()
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                    BookCount = numOfBooks,
                    Books = books
                });
            };


            return TypedResults.Ok(DTAuthors);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthor(IRepository Repository, int id)
        {
            Author author = await Repository.GetAuthorById(id);
            IEnumerable<BookAuthor> authorBooks = await Repository.GetAuthorBooksByAuthorId(id);
            IEnumerable<BookAuthor> bookAuthors = await Repository.GetAllBookAuthors();

            List<SimpleBook> books = new List<SimpleBook>();
            foreach (var authorBook in authorBooks)
            {
                string authornames = "";
                foreach (var bookAuthor in bookAuthors)
                {
                    if (bookAuthor.BookId == authorBook.BookId)
                    {
                        authornames += $"{bookAuthor.Author.FirstName} {bookAuthor.Author.LastName}, ";
                    }
                }
                books.Add(new SimpleBook() { 
                    Id = authorBook.BookId, 
                    Title = authorBook.Book.Title,
                    AuthorName = authornames,
                    PublisherName = $"{authorBook.Book.Publisher.Firstname} {authorBook.Book.Publisher.Lastname}"
                });

            }
            if (author != null) {
                DTAuthor dtauthor = new DTAuthor()
                
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                    BookCount = authorBooks.Count(),
                    Books = books,

                };

                return TypedResults.Ok(dtauthor);
            }
            

            return TypedResults.NotFound("Not Found");   
        }

     


    }

    
};
