using exercise.webapi.Data;
using exercise.webapi.DTO;
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

        public async Task<Book> AddBook(Book book)
        {

           await _db.Books.AddAsync(book);
           await _db.SaveChangesAsync();
           return book;
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = _db.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);

            _db.Books.Remove(book);
            _db.SaveChangesAsync();

            return book;


        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }
        public async Task<Book?> GetBook(int id)
        {
            return _db.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);
        }

          
        public async Task<Book> UpdateBookById(int id, int targetid)
        {
            var entity = _db.Books.FirstOrDefault(a => a.Id == id);
            entity.AuthorId = targetid;
            _db.Attach(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;

        }
    }
}



    


