using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Book> CreateBook(string Title,int AuthorId,Author Author)
        {
            Book b = new Book();
            b.Author     = Author;
            b.Title      = Title;
            b.AuthorId   = AuthorId;
            b.Author     = Author;

            await _db.Books.AddAsync(b);
            await _db.SaveChangesAsync();

            return b;
        }

        public async Task<Book> DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            var books = await _db.Books.Include(b => b.Author).ToListAsync();

            return books;
        }

        public async Task<Book> GetBook(int id)
        {
            return await _db.Books.Include(b => b.Author).Where(b => b.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Book> UpdateBook(int id, Author Author)
        {
            Book b = await GetBook(id);
            b.Author = Author;
            await _db.SaveChangesAsync();
            return b;
        }
    }
}
