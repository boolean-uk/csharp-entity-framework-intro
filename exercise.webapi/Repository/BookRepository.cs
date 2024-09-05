using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository(DataContext db) : IRepository<Book>
    {
        public async Task<IEnumerable<Book>> GetAll()
        {
            return await db.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .ToListAsync();
        }

        public async Task<Book> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> Add(Book entity)
        {
            db.Books.Add(entity);
            await db.SaveChangesAsync();
            return entity;
        }
    }
}
