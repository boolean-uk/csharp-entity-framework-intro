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

        public async Task<Book> GetById(int id)
        {
            return await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
             
        }

        public async Task<Book> UpdateById(int id, Book entity)
        {
            _db.Attach(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }
        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);

            if (book != null)
            {
                _db.Books.Remove(book); 
            }

            return book;
        }

        public async Task<Book> CreateABook(Book book)
        {
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return book;
        }

      
    }
}
