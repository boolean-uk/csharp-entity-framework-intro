using exercise.webapi.AlternativeModels;
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

        public async Task<Payload<Book>> CreateBook(PostBook postBook)
        {
            Payload<Book> payload = new Payload<Book>();
            if (_db.Authors.Count(x => x.Id == postBook.AuthorId) == 0)
            {
                payload.status = Status.NotFound;
                return payload;
            }
            if (!postBook.Title.Any())
            {
                payload.status = Status.BadRequest;
                return payload;
            }
            Book book = new Book() { Title = postBook.Title, AuthorId = postBook.AuthorId };
            _db.Books.Add(book);
            _db.SaveChanges();

            int id = _db.Books.Max(x => x.Id);
            payload.data = await 
                _db.Books.Include(b => b.Author).Include(b => b.Publisher).
                FirstOrDefaultAsync(x => x.Id == id);

            return payload;
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = await 
                _db.Books.Include(b => b.Author).Include(b => b.Publisher).
                FirstOrDefaultAsync(x => x.Id == id);
            _db.Books.Remove(book);
            _db.SaveChanges();

            return book;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await 
                _db.Books.Include(b => b.Author).Include(b => b.Publisher).
                ToListAsync();

        }

        public async Task<Author> GetAuthor(int id)
        {
            return await 
                _db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).
                FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Author>> GetAuthors()
        {
            return await 
                _db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).
                ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            return await 
                _db.Books.Include(b => b.Author).Include(b => b.Publisher).
                FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Publisher>> GetPublishers()
        {
            return await 
                _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).
                ToListAsync();
        }

        public async Task<Book> UpdateBook(int id, int authorId)
        {
            var book = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);
            book.AuthorId = authorId;
            await _db.SaveChangesAsync();

            return await 
                _db.Books.Include(b => b.Author).Include(b => b.Publisher).
                FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
 