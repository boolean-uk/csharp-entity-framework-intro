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

        //does not neet to be async
        public async Task<BookDTO> CreateBook(string Title, int AuthorId)
        {
            Author Author = _db.Authors.FirstOrDefault(x=>x.Id == AuthorId);
            Book book = null;  
            await _db.Books.AddAsync( book = new Book() { Title = Title, AuthorId = AuthorId, Author = Author});
            await _db.SaveChangesAsync();
            return book.MapToDTO();
            
        }

        public BookDTO DeleteBook(int Id)
        {
            var book = _db.Books.FirstOrDefault(x => x.Id == Id);
            _db.Books.Remove(book);
            _db.SaveChanges();
            return book.MapToDTO();
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooks()
        {
            var books = await _db.Books.Include(b => b.Author).Include(p => p.Publisher).ToListAsync();
            return books.MapListToDTO();
        }

        public async Task<BookDTO> GetBook(int Id)
        {
            Book book = _db.Books.Include(b => b.Author).Include(p => p.Publisher).FirstOrDefault(x => x.Id == Id);
            return book.MapToDTO();
        }

        public async Task<BookDTO> UpdateBook(int Id, string Title, int AuthorId)
        {
            var book = await _db.Books.Include(b => b.Author).Include(p => p.Publisher).FirstOrDefaultAsync(b => b.Id == Id);
            if (book != null)
            {
                var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == AuthorId);
                if (author != null)
                {
                    book.Title = Title;
                    book.Author = author;
                    await _db.SaveChangesAsync();
                    return book.MapToDTO();
                }
            }
            return null;
        }
    }
}
