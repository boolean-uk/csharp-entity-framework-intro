using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

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
            return await _db.Books.Include(book => book.Author).ToListAsync();

        }

        public async Task<Book?> GetBook(int id)
        {
            return await _db.Books.Include(book => book.Author).FirstOrDefaultAsync(book => book.Id == id);
        }

        public async Task<Book?> UpdateBook(int bookId, int authorId)
        {
            var book = await GetBook(bookId);
            if (book == null)
            {
                return null;
            }
            var author = await _db.Authors.Include(author => author.Books).FirstOrDefaultAsync(author => author.Id == authorId);
            if (author == null)
            {
                return null;
            }
            book.Author = author;
            book.AuthorId = author.Id;
            author.Books.Add(book);
            return book;
        }

        public async Task<Book?> DeleteBook(int id)
        {
            var book = await GetBook(id);
            if (book == null)
            {
                return null;
            }
            var author = await _db.Authors.Include(author => author.Books).FirstOrDefaultAsync(author => author.Id == book.AuthorId);
            author.Books.Remove(book);
            _db.Books.Remove(book);
            _db.SaveChanges();
            return book;
        }

        public async Task<Book?> AddBook(BookPost book)
        {
            var author = await _db.Authors.Include(author => author.Books).FirstOrDefaultAsync(author => author.Id == book.AuthorId);
            if (author == null)
            {
                return null;
            }
            Book newBook = new Book { Title = book.Title, AuthorId = book.AuthorId, Author = author };
            author.Books.Add(newBook);
            _db.Books.Add(newBook);
            _db.SaveChanges();
            return newBook;
        }
    }
}
