using exercise.webapi.Data;
using exercise.webapi.Models.BaseModels;
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

        public async Task<Book> Get(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<Book> Update(Book book)
        {
            _db.Books.Attach(book);
            _db.Entry(book).State = EntityState.Modified;
            _db.SaveChangesAsync();
            return book;
        }


    }
}
