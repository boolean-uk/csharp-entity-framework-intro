using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Author>> GetAllAuthor()
        {
            return await _db.Authors.ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetBook(int id)
        {
            List<Book> books = await _db.Books.Include(b => b.Author).ToListAsync();
            Book book = books.FirstOrDefault(x => x.Id == id)!;
            if (book != null) return book;
            return null;
        }

        public async Task<Author>GetAuthor(int id)
        {
            List<Author> authors = await _db.Authors.ToListAsync();
            Author author = authors.FirstOrDefault(x => x.Id == id)!;
            if (author != null) return author;
            return null;
        }

        public async Task<Book> UpdateBook(int id,int author_id)
        {
            Book book = await GetBook(id);
            
            Author author = await GetAuthor(author_id);
            

            if (book != null && author != null)
            {
                book.Author.Books.Remove(book);
                author.Books.Add(book);
                book.Author = author;
                book.AuthorId = author.Id;
                _db.Books.Update(book);
                _db.SaveChanges();
                return book;
            }

            
            return null;
        }

        public async Task<Book>DeleteBook(int id)
        {
            Book book = await GetBook(id);
            Book temp = book;
            Author author = await GetAuthor(book.AuthorId);
            if (book != null)
            {
                _db.Books.Remove(book);
                author.Books.Remove(book);
                _db.SaveChanges();
                return temp;
            }
            return null;
        }

        public async Task<Book> CreateBook(string title, int author_id)
        {
            Author author = await GetAuthor(author_id);
            if (author != null)
            {
                Book book = new Book() { Title = title, AuthorId = author_id, Author = author };
                _db.Books.Add(book);
                author.Books.Add(book);
                _db.SaveChanges();
                return book;
            }
            return null;
        }

        
    }
}
