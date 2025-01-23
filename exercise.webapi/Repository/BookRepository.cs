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
        
        public async Task<Book> AddBook(Book book)
        {
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books
                .Include(b => b.Author)
                .ToListAsync();

        }
        
        public async Task<Book?> GetBookById(int id)
        {
            return await _db.Books.Select(b => new Book
            {
                Id = b.Id,
                Title = b.Title,
                Author = new Author
                {
                    Id = b.Author.Id,
                    FirstName = b.Author.FirstName,
                    LastName = b.Author.LastName,
                    Email = b.Author.Email
                }
            }).FirstOrDefaultAsync(b => b.Id == id);
        }

        public void DeleteBook(Book book)
        {
            _db.Books.Remove(book);
            _db.SaveChanges();
        }

        public async Task<Book> UpdateBook(Book book)
        {
            //_db.Books.Update(book);
            _db.Attach(book).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return book;
        }
    }
}
