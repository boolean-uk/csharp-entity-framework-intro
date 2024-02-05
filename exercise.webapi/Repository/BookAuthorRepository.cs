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

        public async Task<int> AddAuthorToBook(int bookId, int authorId)
        {
            Book? dbBook = _db.Books.Where(x => x.Id == bookId).FirstOrDefault();
            if (dbBook == null) { return -1; }
            Author? dbAuthor = _db.Authors.Where(x => x.Id == authorId).FirstOrDefault();
            if (dbAuthor == null) { return -2; }
            BookAuthor ba = new() { AuthorId = authorId, BookId = bookId };
            _db.BookAuthors.Add(ba);
            await _db.SaveChangesAsync();
            return 0;
        }

        public async Task<int> RemoveAuthorFromBookById(int bookId, int authorId)
        {
            BookAuthor? ba = _db.BookAuthors.Where(x => x.BookId == bookId && x.AuthorId == authorId).FirstOrDefault();
            if (ba == null) { return -1; }
            _db.BookAuthors.Remove(ba);
            await _db.SaveChangesAsync();
            return 0;
        }
    }
}
