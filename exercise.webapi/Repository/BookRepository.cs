using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Net;

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
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetABook(string title)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Title.Equals(title));
        }

        public async Task<Book> AddBook(string title, string authorFirstName, string authorLastName)
        {
            var author = _db.Authors.FirstOrDefault(a => a.FirstName.Equals(authorFirstName) && a.LastName.Equals(authorLastName));
            int bookID = _db.Books.Max(x=>x.Id) +1;
            int authorID = _db.Authors.Max(x => x.Id) + 1;

            if (author is not null)
            {
                Book book = new Book { Title = title, Author = author, AuthorId = author.Id, Id = bookID };
                author.Books.Add(book);
                _db.Books.Add(book);
                await _db.SaveChangesAsync();
                return book;
            }
            else
            {
                author = new Author { Books = new List<Book>(), FirstName = authorFirstName, LastName = authorLastName, Id = authorID, Email = $"{authorFirstName}.{authorLastName}"};
                Book book = new Book { Title = title, Author = author, AuthorId = author.Id, Id = bookID };
                author.Books.Add(book);
                _db.Authors.Add(author);
                _db.Books.Add(book);
                await _db.SaveChangesAsync();
                return book;
            }
        }
        
        public async Task<Book> DeleteBook(string title)
        {

            Book book = _db.Books.Include(b => b.Author).FirstOrDefault(b => b.Title.Equals(title));
            Author a = book.Author;
            a.Books.Remove(book);
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> UppdateBook(string title, string newTitle)
        {
            if (_db.Books.Include(b => b.Author).FirstOrDefault(b => b.Title.Equals(title)) is not null) {
                _db.Books.Include(b => b.Author).FirstOrDefault(b => b.Title.Equals(title)).Title = newTitle;
                await _db.SaveChangesAsync();
            }
            return _db.Books.Include(b => b.Author).FirstOrDefault(b => b.Title.Equals(newTitle));
        }
    }
}
