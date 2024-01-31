using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;

        public BookRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetBookById(int bookID)
        {
            IEnumerable<Book> allBooks = await GetAllBooks();

            Book? book = allBooks.FirstOrDefault(b => b.Id == bookID);

            return book;
        }

        public async Task<Book> UpdateBookByID(int bookID, string firstname, string lastname)
        {
            IEnumerable<Book> allBooks = await GetAllBooks();

            Book? book = allBooks.FirstOrDefault(b => b.Id == bookID);

            if (book != null)
            {
                book.Author.FirstName = firstname;
                book.Author.LastName = lastname;
                _db.SaveChanges();
                return book;
            }
            return book;
        }

        public async Task<Book> DeleteBookByID(int bookID)
        {
            List<Book> allBooks = await _db.Books.Include(b => b.Author).ToListAsync();

            Book? book = allBooks.FirstOrDefault(b => b.Id == bookID);

            if (book != null)
            {
                allBooks.Remove(book);
                _db.Books.Remove(book);
                _db.SaveChanges();
                return book;
            }
            return book;
        }

        public async Task<Book> CreateNewBook(string title, int authorID)
        {
            Book book = new Book();
            book.Title = title;
            book.AuthorId = authorID;
            _db.Books.Add(book);
            _db.SaveChanges();
            return book;
        }
    }
}