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
            return await _db.Books.Include(b => b.Author).ToListAsync();  
        }

        public async Task<Book> GetSingleBook(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> UpdateBook(int bookId, int authorId)
        {

            Book bookToBeUpdated = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == bookId);
            Author newAuthor = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId);
            
            if(bookToBeUpdated == null || newAuthor == null )
            {
                return null;
            }

            bookToBeUpdated.AuthorId = newAuthor.Id;
            bookToBeUpdated.Author = newAuthor;
            await _db.SaveChangesAsync();

            return bookToBeUpdated;
        }

        public async Task<Book> DeleteBook(int id)
        {
            Book bookToBeDeleted = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);

            if(bookToBeDeleted == null)
            {
                return null;
            }

            _db.Remove(bookToBeDeleted);
            await _db.SaveChangesAsync();
            return bookToBeDeleted;
        }
    }
}
