using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Net;

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
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
        }
        public async Task<Book?> GetBook(int id)
        {
            return await _db.Books.Include(t => t.Author).Include(b => b.Publisher).SingleOrDefaultAsync(t => t.Id == id);
        }
        public async Task<Book?> UpdateBook(int id, int newAuthorId)
        {
            //Load book to update
            var book = await GetBook(id);
            //Load author from provided newAuthorId
            var author = await _db.Authors.SingleOrDefaultAsync(t => t.Id == newAuthorId);
            //Check book && author exist, otherwise return null
            if (book == null || author == null)
            {
                return null;
            }
            bool hasUpdate = false;
            if (newAuthorId != null)
            {
                book.AuthorId = newAuthorId;
                book.Author = author;
                hasUpdate = true;
            }
            if (!hasUpdate)
            {
                return null;
            }
            _db.SaveChanges();
            return book;
        }
        public async Task<Book?> DeleteBook(int id)
        {
            //Load book to delete
            var book = await GetBook(id);
            if (book == null)
            {
                return null;
            }
            _db.Books.Remove(book);
            _db.SaveChanges();
            return book;
        }
        public async Task<Book?> CreateBook(string newTitle, int newAuthorId)
        {
            //Create book to return
            Book book = new Book();
            //Get the author from payload author ID
            var author = await _db.Authors.SingleOrDefaultAsync(t => t.Id == newAuthorId);
            //Populate the book with payload data
            book.Title = newTitle;
            book.AuthorId = newAuthorId;
            book.Author = author;
            //add book to database and save it + return
            _db.Books.Add(book);
            _db.SaveChanges();
            return book;
        }
    }
}
