using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class Repository: IRepository
    {
        DataContext _db;
        
        public Repository(DataContext db)
        {
            _db = db;
        }

        //public async Task<Book> AddBook(Book book)
        //{
        //    await _db.Books.AddAsync(book);
        //    await _db.SaveChangesAsync();
        //    return book;
        //}


        public async Task<List<Book>> GetAllBooks()
        {
            return await _db.Books.Include(s => s.Author).ToListAsync();
        }
        public async Task<Book> GetBook(int id)
        {
            return await _db.Books.Include(a => a.Author).FirstAsync( b => b.Id == id);
        }

        public async Task<Book> CreateAsync(Book model)
        {
            await _db.Books.AddAsync(model);
            await _db.SaveChangesAsync();
            return model;
        }
        public async Task<Book> DeleteAsync(int id)
        {
            var skillModel = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);
            if (skillModel == null)
            {
                return null;
            }

            _db.Books.Remove(skillModel);
            await _db.SaveChangesAsync();
            return skillModel;
        }


        public async Task<Book> UpdateBook(Book book)
        {
            _db.Books.Update(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<List<Author>> GetAllAuthor()
        {
            return await _db.Authors.Include(s => s.Books).ToListAsync();
        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.Include(a => a.Books).FirstAsync(b => b.Id == id);
        }
    }
}
