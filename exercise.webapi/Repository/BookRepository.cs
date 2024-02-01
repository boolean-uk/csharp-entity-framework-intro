using exercise.webapi.Data;
using exercise.webapi.Models;
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

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetBookById(int id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
            return book != null ? book : null;
        }

        public async Task<Book> UpdateBookById(int id, int newAuthorId)
        {
            var book = await GetBookById(id);
            book.AuthorId = newAuthorId;
            book.Author = await GetAuthorById(newAuthorId);

            _db.SaveChangesAsync();

            return book;
        }

        public async Task<Book> DeleteBookById(int id)
        {
            var book = await GetBookById(id);
            if (book != null)
            {
                _db.Books.Remove(book);
                _db.SaveChangesAsync();
                return book;
            }

            return null;
        }

        public async Task<Book> CreateBook(Book book)
        {
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }


        public async Task<IEnumerable<Author>> GetAllAuthors()
        { 
            return await _db.Authors.Include(b => b.Books).ToListAsync();
        }

        public async Task<Author> GetAuthorById(int id)
        {
            var aut = await _db.Authors.Include(b => b.Books).FirstOrDefaultAsync(a => a.Id == id);
            var books = await _db.Books.Where(x => x.AuthorId == aut.Id).ToListAsync();

            aut.Books = books;

            return aut;
        }


        public async Task<Publisher> GetPublisherById(int id)
        {
            return await _db.Publisher.Include(pb=>pb.PublishedBooks).ThenInclude(b=>b.Author).FirstOrDefaultAsync(p => p.Id == id);

        }

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _db.Publisher.ToListAsync();
        }
    }
}
