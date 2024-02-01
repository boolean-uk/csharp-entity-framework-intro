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
         * Get the Author by ID to correctly get the updated author object. It may be kinda redundant now
         */
        public async Task<Author> GetAuthorById(int authorId)
        {
            var author = await _db.Authors.FindAsync(authorId);
            return author;
        }

        /*
         * implement the GET book and GET all books. When you return the books objects, use an appropriate DTO to return the book + author (but no nested books inside author). 
         * Make sure to include the authors when you load the data in the repository.
         */
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).OrderBy(b => b.Id).ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstAsync(b => b.Id == id); ;
        }


        /*
         * implement the UPDATE boook where you can change the author via id (you may skip updating other properties like title, etc); make sure to return the Book + Author once the update is done
         */
        public async Task<Book> UpdateBook(int bookId, int authorId)
        {
            var book = await _db.Books.Include(b => b.Author).FirstAsync(b => b.Id == bookId);
            var author = await _db.Authors.FindAsync(authorId);

            if (book != null || author != null)
            {
                book.AuthorId = authorId;
                book.Author = author;
                await _db.SaveChangesAsync();
            }

            return book;
        }

        /*
         * implement the DELETE book
         */
        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstAsync(b => b.Id == id);
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
        public async Task<Book> CreateBook(BookPost book)
        {
            var author = await _db.Authors.FindAsync(book.AuthorId);

            var newBook = new Book
            {
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = author
            };

            // Check if the author exists and book title is not null or default string
            if (author != null && !string.IsNullOrWhiteSpace(book.Title) && book.Title != "string")
            {

                _db.Books.Add(newBook);
                await _db.SaveChangesAsync();

                // Reload the book
                await _db.Entry(newBook).Reference(b => b.Author).LoadAsync();

            }

            return newBook; 
        }

    }
}

