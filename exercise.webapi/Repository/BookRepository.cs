using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;

        public BookRepository(DataContext db)
        {
            _db = db;
        }

        /*
         * implement the GET book and GET all books. When you return the books objects, use an appropriate DTO to return the book + author (but no nested books inside author). 
         * Make sure to include the authors when you load the data in the repository.
         */
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)   
                .FirstAsync(b => b.Id == id);
        }


        /*
         * implement the UPDATE boook where you can change the author via id (you may skip updating other properties like title, etc); make sure to return the Book + Author once the update is done
         */
        public async Task<Book> UpdateBook(int bookId, int authorId)
        {
            var book = await _db.Books
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .FirstOrDefaultAsync(b => b.Id == bookId);

            var author = await _db.Authors.FindAsync(authorId);

            if (book != null && author != null)
            {
                var bookAuthor = new BookAuthor
                {
                    Book = book,
                    Author = author
                };

                _db.BookAuthors.Add(bookAuthor);
                await _db.SaveChangesAsync();
            }

            return book;
        }

        /*
         * implement the DELETE book
         */
        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book != null)
            {
                _db.Books.Remove(book);
                await _db.SaveChangesAsync();
            }

            return book;
        }

        /*
         * implement the CREATE book - it should return NotFound when author id is not valid and BadRequest when book object not valid
         */
        public async Task<Book> CreateBook(BookPost model)
        {
            var publisher = await _db.Publishers.FindAsync(model.PublisherId);
            var author = await _db.Authors.FindAsync(model.AuthorId);

            if (author == null || publisher == null || string.IsNullOrWhiteSpace(model.Title) || model.Title == "string")
            {
                return null; // Return null to indicate a failure in creating the book
            }

            var newBook = new Book
            {
                Title = model.Title,
                PublisherId = model.PublisherId,
                Publisher = publisher
            };

            var bookAuthor = new BookAuthor
            {
                Book = newBook,
                Author = author
            };

            _db.BookAuthors.Add(bookAuthor);
            await _db.SaveChangesAsync();

            // Reload the book to get the updated relationships
            await _db.Entry(newBook).Reference(b => b.BookAuthors).LoadAsync();

            return newBook;
        }

    }
}

