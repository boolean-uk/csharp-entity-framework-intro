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
            return await _db.Books.Include(b => b.Author).ToListAsync();
        }
        public async Task<Book?> GetBook(int id)
        {
            return await _db.Books.Include(t => t.Author).SingleOrDefaultAsync(t => t.Id == id);
        }
        public async Task<Book?> UpdateBook(int id, BookUpdatePayload updateData)
        {
            var book = await _db.Books.Include(t => t.Author).SingleOrDefaultAsync(t => t.Id == id);
            var author = await _db.Authors.SingleOrDefaultAsync(t => t.Id == updateData.authorId);
            if (book == null || author == null)
            {
                return null;
            }
            bool hasUpdate = false;
            if (updateData.authorId != null)
            {
                book.AuthorId = (int)updateData.authorId;
                book.Author = author;
                hasUpdate = true;
            }
            if (!hasUpdate) throw new Exception("No update data provided");
            _db.SaveChanges();
            return book;
        }
        public async Task<Book?> DeleteBook(int id)
        {
            var book = await _db.Books.Include(t => t.Author).SingleOrDefaultAsync(t => t.Id == id);
            if (book == null)
            {
                return null;
            }
            _db.Books.Remove(book);
            _db.SaveChanges();
            return book;
        }
        public async Task<Book?> CreateBook(BookPostPayload newBook)
        {
            //Create book to return
            Book book = new Book();
            //Get the author from payload author ID
            var author = await _db.Authors.SingleOrDefaultAsync(t => t.Id == newBook.authorId);
            //Populate the book with payload data
            book.Title = newBook.title;
            book.AuthorId = newBook.authorId;
            book.Author = author;
            //add book to database and save it + return
            _db.Books.Add(book);
            _db.SaveChanges();
            return book;
        }
    }
}
