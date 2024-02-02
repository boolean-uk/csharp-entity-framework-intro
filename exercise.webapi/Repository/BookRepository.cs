using exercise.webapi.Data;
using exercise.webapi.DTO_s;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<Book> Add(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return book;
        }
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books
                .Include(b => b.Author)
                .ToListAsync();

        }
        public async Task<Book> GetBookByID(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstAsync(b => b.Id == id);
        }

        public async Task<Book> UpdateBook(int Id, int newId)
        {
            var book = await _db.Books.Include(b => b.Author).FirstAsync(b => b.Id == Id);
            book.AuthorId = newId;
            _db.SaveChanges();
            return book;
        }

        public async Task<Book> DeleteBook(int Id)
        {
           var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == Id);
            _db.Books.Remove(book);
            _db.SaveChanges();

            return book;
        }
       
        public async Task<Book> CreateBook(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
            return book;
        }
    }
}
