using exercise.webapi.Data;
using exercise.webapi.Models;
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

        public async Task<Book> CreateBook(int id, string title)
        {
            Author author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == id)
          ?? throw new ArgumentException($"No author with id: {id}");


            var book = new Book();
            book.AuthorId = id;
            book.Title = title;
            book.Id = GetAllBooks().Result.Count() + 1;
            book.Author = author;
            _db.Add(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books.Include(a => a.Author).SingleOrDefaultAsync(b => b.Id == id)
                ?? throw new ArgumentException($"No book with id: {id}");

            _db.Remove(book);
            await _db.SaveChangesAsync();

            return book;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).Include(a => a.Publisher).ToListAsync();
            

        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.Include(a => a.Author).Include(b => b.Publisher).SingleOrDefaultAsync(b => b.Id == id)
                ?? throw new ArgumentException($"No book with id: {id}");
        }

        public async Task<Book> UpdateBook(int id, int newAuthorId)
        {
            var book = await _db.Books.Include(a => a.Author).SingleOrDefaultAsync(a => a.Id == id);

            Author author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == newAuthorId)

            ?? throw new ArgumentException($"No author with id: {newAuthorId}");

            book.Author = author;

            await _db.SaveChangesAsync();

            return book;
        }
    }
}
