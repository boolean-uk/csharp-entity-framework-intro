using exercise.webapi.Data;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public class BookAuthorRepository : IBookAuthorRepository
    {
        DataContext _db;
        public BookAuthorRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<BookAuthor> AddBookAuthor(BookAuthor bookAuthor)
        {
            await _db.BookAuthors.AddAsync(bookAuthor);
            await _db.SaveChangesAsync();
            return bookAuthor;
        }

        public async Task<bool> DeleteBookAuthor(int id)
        {
            var bookAuthor = await _db.BookAuthors.FindAsync(id);
            if (bookAuthor == null)
            {
                return false;
            }
            _db.BookAuthors.Remove(bookAuthor);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
