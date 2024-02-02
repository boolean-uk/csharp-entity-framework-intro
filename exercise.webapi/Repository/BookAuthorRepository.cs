using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace exercise.webapi.Repository
{
    public class BookAuthorRepository : IBookAuthorRepository
    {
        DataContext _db;

        public BookAuthorRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<Book> CreateRelation(int bookId, int authorId)
        {
            BookAuthor bookAuthor = new BookAuthor()
            {
                AuthorId = authorId,
                BookId = bookId
            };
            _db.BookAuthors.Add(bookAuthor);
            _db.SaveChanges();

            return await _db.Books.Include(b => b.Authors).ThenInclude(ba => ba.Author).Include(b => b.Publisher).
                FirstOrDefaultAsync(x => x.Id == bookId);
        }

        public async Task<Book> DeleteRelation(BookAuthor relation)
        {
            Book book = await _db.Books.Include(b => b.Authors).ThenInclude(ba => ba.Author).Include(b => b.Publisher).
                FirstOrDefaultAsync(x => x.Id == relation.BookId);

            _db.BookAuthors.Remove(relation);
            await _db.SaveChangesAsync();

            return book;
        }

        public async Task<BookAuthor> GetRelation(int authorId, int bookId)
        {
            return await _db.BookAuthors.FirstOrDefaultAsync(x => x.BookId == bookId & x.AuthorId == authorId);
        }
    }
}
