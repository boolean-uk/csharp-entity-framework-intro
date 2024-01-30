using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();

        }

        public async Task<Book?> GetBookbyId(int id)
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(x => x.Id == id);
       //     return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> UpdateBook(int id, int authorId)
        {
            Book? book = await _db.Books.Include(b => b.Author).Include(b=> b.Publisher).FirstOrDefaultAsync(x => x.Id == id);
            if (book is null) return null;
            Author? author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == authorId);
            if (author is null) throw new Exception();
            book.AuthorId = authorId;
            book.Author = author;
            _db.SaveChanges();
            return book;
        }

        public async Task<bool> DeleteBook(int id)
        {
            Book? book = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);
            if (book is null) return false;
            _db.Books.Remove(book);
            book.Author.Books.Remove(book);
            _db.SaveChanges();
            return true;
        }

        public async Task<Book> CreateBook(BookPostPayload data)
        {
            Book book = new Book();
            book.Title = data.title;
            book.AuthorId = data.authorId;
            Author? author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == data.authorId);
            if (author is null) throw new Exception();
            book.Author = author;
            await _db.AddAsync(book);
            _db.SaveChanges();
            return book;
        }
    }
}
