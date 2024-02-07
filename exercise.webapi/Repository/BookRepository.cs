using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository : Repository<Book>
    {
        DataContext _db;
        
        public BookRepository(DataContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<Book>> Get()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public override async Task<Book> GetById(object id)
        {
            IEnumerable<Book> books = await _db.Books.Include(b => b.Author).ToListAsync();
            return books.FirstOrDefault(b => b.Id == (int)id);
        }
    }
}
