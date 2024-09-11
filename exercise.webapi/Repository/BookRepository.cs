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
            return (await db.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(b => b.Id == id))!;
        }

        public async Task<Book> GetByName(string title)
        {
            return (await db.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(b => b.Title.ToLower() == title.ToLower()))!;
        }
        
        public List<Book> GetByPublisherId(int id)
        {
            return db.Books.Where(b => b.PublisherId == id).ToList();
        }

        public Task<Book> GetByFullName(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> Add(Book entity)
        {
            db.Books.Add(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<Book> Remove(Book entity)
        {
            db.Books.Remove(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<Book> Update(Book entity)
        {
            var book = (await db.Books.FindAsync(entity.Id))!;
            book.Title = entity.Title;
            book.AuthorId = entity.Author.Id;
            book.PublisherId = entity.Publisher.Id;
            await db.SaveChangesAsync();
            return book;
        }
    }
}
