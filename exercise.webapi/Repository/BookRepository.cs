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

        public async Task<Book> GetById(int id)
        {
        
            var result = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
            return result;
            
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> UpdateById(int id, int authorId)
        {
            Book target = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);

            target.AuthorId = authorId;
            target.Author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == authorId);

            _db.Attach(target).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return target;
        }

        public async Task<string> DeleteById(int id)
        {
            if (await ContainsBook(id))
            {
                var target = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);
                _db.Books.Remove(target);
                await _db.SaveChangesAsync();

                return "The Selected Book Has been removed";
            }
            return "The Selected book Has not been removed";
        }

        public async Task<Book> Create(Book book)
        {
            await _db.AddAsync(book);
            await _db.SaveChangesAsync();

            return book;
        }

        public async Task<bool> ContainsAuthor(int id)
        {
            if (_db.Authors.Select(x => x.Id).ToList().Contains(id))
                return true;

            return false;
        }
        public async Task<bool> ContainsBook(int id)
        {
            if (_db.Books.Select(x => x.Id).ToList().Contains(id))
                return true;

            return false;
        }
    }
}
