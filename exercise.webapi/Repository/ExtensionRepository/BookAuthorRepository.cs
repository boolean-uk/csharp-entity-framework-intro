using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository.ExtensionRepository
{
    public class BookAuthorRepository : Repository<BookAuthor>
    {
        private readonly DataContext _db;
        public DbSet<BookAuthor> _table;

        public BookAuthorRepository(DataContext db) : base(db)
        {
            _db = db;
            _table = _db.Set<BookAuthor>();
        }

        public override async Task<BookAuthor> Delete(BookAuthor entity)
        {

            entity = await _table.FindAsync(entity.BookId, entity.AuthorId);
            if (entity != null)
            {
                _table.Remove(entity);
                await _db.SaveChangesAsync();
            }
            return entity;
        }
    }
}
