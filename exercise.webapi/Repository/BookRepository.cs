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

        public async Task<Book> GetBook(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);

        }

        public async Task<Book> UpdateBook(int id, UpdateBookAuthorDTO updateDTO)
        {
            var book = await _db.Books.FindAsync(id);
            if (book == null)
            {
                throw new Exception("Book not found");
            }

            var authorExists = await _db.Authors.AnyAsync(a => a.Id == updateDTO.AuthorId);
            if (!authorExists)
            {
                throw new Exception("Author not found");
            }

            book.AuthorId = updateDTO.AuthorId;

            _db.Books.Update(book);
            await _db.SaveChangesAsync();

            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
