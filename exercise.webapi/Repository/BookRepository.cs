using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DataContext _db;

        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
        }

        public async Task<Book>? GetBook(int id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            return book;
        }

        public async Task<IEnumerable<Book>> DeleteBook(int id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return await _db.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<Book>? CreateBook(string title)
        {
            List<Book> books = await _db.Books.ToListAsync();
            int nrProducts = await _db.Books.CountAsync();

            for (int i = 0; i < nrProducts; i++)
            {
                if (books[i].Title == title)
                    return null;
            }

            int id = books.Last().Id;
            id++;

            var newBook = new Book() { Id = id, Title = title };
            await _db.AddAsync(newBook);
            await _db.SaveChangesAsync();
            return newBook;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}