using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using workshop.wwwapi.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var group = app.MapGroup("books");
            group.MapGet("/", GetBooks);
            group.MapGet("/{id}", GetABook);
            group.MapPost("/", CreateBook);
            group.MapPut("/{id}", UpdateBook);
            group.MapDelete("/{id}", DeleteBook);
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IRepository Repository)
        {
            IEnumerable<Book> books = await Repository.GetAllBooks();
            IEnumerable<BookAuthor> bookAuthors = await Repository.GetAllBookAuthors();
            var DTObooks = new List<DTBook>();
 
            foreach (var book in books)
            {
                List<string> authors = new List<string>();
                foreach (var item in bookAuthors)
                {
                    if (item.BookId == book.Id)
                    {
                        authors.Add($"{item.Author.FirstName} {item.Author.LastName}");
                    }
                }
                DTObooks.Add(new DTBook() { Id = book.Id, Title = book.Title, PublisherId = book.PublisherId, PublisherName = $"{book.Publisher.Firstname} {book.Publisher.Lastname}", Authors = authors });
                
            }
            

             return TypedResults.Ok(DTObooks);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetABook(IRepository Repository, int id)
        {
            var book = await Repository.GetBookById(id);
            var bookAuthors = await Repository.GetBookAuthorsByBookId(id);
            var DTbook = new DTBook();
            if (book != null) { 
                List<string> authors = new List<string>();
                foreach (var item in bookAuthors)
                {
                    authors.Add( $"{item.Author.FirstName} {item.Author.LastName}");
   
                }
            DTbook = new DTBook() {                  
                               Id = book.Id,
                               Title = book.Title,
                                Authors = authors,
                                PublisherId = book.PublisherId,
                                PublisherName = $"{book.Publisher.Firstname} {book.Publisher.Lastname}"

            };
            }


            return TypedResults.Ok(DTbook);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        private static async Task<IResult> CreateBook(IRepository Repository, PostBook model)
        {
            if (model == null
                || model.PublisherId == 0
                || model.AuthorIds.Length < 1
                || model.AuthorIds.Contains(0)
                )        
                
                {

                return TypedResults.BadRequest("Input not valid");
            }
            else
            {
                var book = await Repository.Add(model);
                var bookAuthors = await Repository.GetBookAuthorsByBookId(book.Id);

                string authors = "";
                foreach (var item in bookAuthors)
                {
                    authors += ($"{item.Author.FirstName} {item.Author.LastName}, ");

                }

                SimpleBook dto = new SimpleBook()
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorName = authors,
                    PublisherName = $"{book.Publisher.Firstname} {book.Publisher.Lastname}"

                };

                return  bookAuthors == null ? TypedResults.NotFound("The Author does not exist") : TypedResults.Created($"/{dto.Id}", dto);
            }
        }
           

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateBook(IRepository Repository, int bookId, int newAuthorId)
        {
            var book = await Repository.Update(bookId, newAuthorId);
            var bookAuthors = await Repository.GetBookAuthorsByBookId(bookId);


            List<string> authors = new List<string>();
            foreach (var item in bookAuthors)
            {
                authors.Add($"{item.Author.FirstName} {item.Author.LastName}");

            }
            var DTbook = new DTBook();
            if (book != null)
            {
                DTbook = new DTBook()
                {
                    Id = book.Id,
                    Title = book.Title,
                     Authors = authors,
                    PublisherId = book.PublisherId,
                    PublisherName = $"{book.Publisher.Firstname} {book.Publisher.Lastname}"

                };
            }

            return TypedResults.Created($"/{DTbook.Id}", DTbook);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(IRepository Repository, int bookId)
        {
            await Repository.Delete(bookId);

           return TypedResults.Ok("Book deleted");

        }




       


    }
    public static class StringExtensions
    {
        public static bool IsNumeric(this string text) => double.TryParse(text, out _);

    }

};
