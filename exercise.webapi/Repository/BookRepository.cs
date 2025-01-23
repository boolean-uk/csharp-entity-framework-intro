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

        public async Task<Book> CreateBook(string title, int authorid)
        {
            Book book = new Book(); 
            book.Title = title;

            Author author = await _db.Authors.FirstOrDefaultAsync(b => b.Id == authorid);

            if (author == null)
            {
                return null;
            }
            author.Books.Add(book);
          
            book.Author = author;

            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();   

            return book;

            
            
        }

        public async Task<bool> DeleteBook(int id)
        {
            Book book =await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                return false;
            }
           _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetBook(int id)
        {
            return await _db.Books
                   .Include(b => b.Author) // Inkluderer relasjonen til forfatter
                   .FirstOrDefaultAsync(b => b.Id == id); // Henter boka basert på ID

        }

        public async Task<Book> UpdateBook(int id,string firstname,string lastname)
        {
            Book book = await _db.Books.Include(b=> b.Author).FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                return null;
            }
            book.Author.FirstName = firstname;
            book.Author.LastName = lastname;   
            await _db.SaveChangesAsync();
            

            return book;

        }

    }
}
