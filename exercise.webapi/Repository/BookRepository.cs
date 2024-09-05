using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.ViewModels;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Book> AddBook(Book entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();

            /*
            //Output
            OutputDTO output = new OutputDTO(entity);
            return output;
            */
            return entity;
        }

        public async Task<Book> DeleteBook(int id)
        {
            var entity = await _db.Books.FindAsync(id);
            //OutputDTO? output = null;
            if (entity != null)
            {
                ////Remove the book from the previous author
                //BookDTO? book = entity.Author.Books.FirstOrDefault(b => b.Id == entity.Id);
                //if (book != null)
                //{
                //    entity.Author.Books.Remove(book);
                //}
                //Remove the book
                _db.Books.Remove(entity);
                await _db.SaveChangesAsync();
                //output = new OutputDTO(entity);
            }
            return entity;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            var entity = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            return entity;
        }

        public async Task<Book> UpdateBook(int id, Book entity)
        {
            _db.Attach(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            /*
            //Output
            OutputDTO output = new OutputDTO(entity);
            return output;
            */
            return entity;
        }
    }
}
