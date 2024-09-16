using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Hosting;

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
            return await _db.Books.Include(b => b.BookAuthors).ThenInclude(b => b.Author).ToListAsync();
        }

       
        public async Task<Book?> GetBook(int bookId)
        {
            return await _db.Books.Include(b => b.BookAuthors).ThenInclude(b => b.Author).FirstOrDefaultAsync(b => b.Id == bookId);
        }
        

        public async Task<Book?> DeleteBook(int bookId)
        {
            Book book = await GetBook(bookId);
            if (book != null)
            {
                _db.Books.Remove(book);
                await _db.SaveChangesAsync();
                return book;
            }

            return null;
        }

        public async Task<Book?> CreateBook(string Title)
        {
            if (Title == "") return null;
            Book book = new Book {Title = Title };
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }




        public async Task<Book?> UpdateBook(int BookId, string newTitle)//update author for a book?
        {
            Book book = await GetBook(BookId);
            if (book != null)
            {
                book.Title = newTitle ?? book.Title;
                await _db.SaveChangesAsync();

                return book;
            }
            
            return null;
        }

  

    }
}
