using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository: IRepository<Book>
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async void SaveRepository()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetAllEntities()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetEntityById(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<bool> DeleteEntity(Book book)
        {
            try
            {
                _db.Books.Remove(book);
                return true;
            }catch (Exception ex) {return false;}
        }
    }
}
