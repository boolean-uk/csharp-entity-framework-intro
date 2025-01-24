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

        public async Task<List<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();

        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(book => book.Id == id);
        }
        

        public async Task<Book> CreateBook(Book entity)
        {
            await _db.Books.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        
        
        
        }

        public async Task<Book> UpdateBookAuthor(int bookId, int authorId)
        
        {

            var book = await _db.Books.FirstOrDefaultAsync( b => b.Id == bookId);
            var author = await _db.Authors.FirstOrDefaultAsync( a => a.Id == authorId);
            book.AuthorId = authorId;
            book.Author = author;

            if (book != null || author != null)
            {
                _db.Books.Update(book);
                await _db.SaveChangesAsync();

                return book;
            }

            else return null;

        }

        public async Task<Book> DeleteBook(int id)
        {
            Book book = GetBookById(id).Result; 
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return book;
        }



    }
}
