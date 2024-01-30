using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.Payload;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository.BookRepo
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;

        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();

        }

        public async Task<Book?> UpdateBookByIDAsync(int bookID, int authorID)
        {
            Book book = GetByIdAsync(bookID).Result;
            if (book == null) { return null; }

            Author author = _db.Authors.FirstOrDefaultAsync(a => a.Id == authorID).Result;
            if (author == null) { return null; }

            // Update Author
            book.Author.Books.Remove(book);
            author.Books.Add(book);

            //Update Book
            book.AuthorId = authorID;
            book.Author = author;
            await _db.SaveChangesAsync();

            return book;
        }

        public async Task<bool> DeleteABook(int bookID)
        {
            Book book = GetByIdAsync(bookID).Result;
            if (book == null) { return false; }

            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<Book> CreateABook(BookPayload payload)
        {
            if (string.IsNullOrWhiteSpace(payload.Title))
            {
                return null;
            }

            var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == payload.AuthorId);
            if (author == null)
            {
                throw new Exception("Author not found");
            }


            var result = _db.Books.Add(new Book { Title = payload.Title, AuthorId = payload.AuthorId }).Entity;

            await _db.SaveChangesAsync();

            return result;

        }
    }
}
