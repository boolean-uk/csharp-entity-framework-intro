using exercise.webapi.Data;
using exercise.webapi.DtoModels.BookApiDtos;
using exercise.webapi.Models;
using exercise.webapi.ViewModels;
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
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();  
        }

        public async Task<Book> GetSingleBook(int id)
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> UpdateBook(int bookId, int authorId)
        {

            Book bookToBeUpdated = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == bookId);
            Author newAuthor = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId);
            
            if(bookToBeUpdated == null || newAuthor == null )
            {
                return null;
            }

            bookToBeUpdated.AuthorId = newAuthor.Id;
            bookToBeUpdated.Author = newAuthor;
            await _db.SaveChangesAsync();

            return bookToBeUpdated;
        }

        public async Task<Book> DeleteBook(int id)
        {
            Book bookToBeDeleted = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);

            if(bookToBeDeleted == null)
            {
                return null;
            }

            _db.Remove(bookToBeDeleted);
            await _db.SaveChangesAsync();
            return bookToBeDeleted;
        }

        public async Task<Book> CreateBook(BookPostModel newBook)
        {
            Author author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == newBook.AuthorId);
            Publisher publisher = await _db.Publishers.FirstOrDefaultAsync(p => p.Id == newBook.PublisherId);
            if(author == null || publisher == null)
            {
                return null;
            }

            Book bookToBeAdded = new Book();
            bookToBeAdded.AuthorId = newBook.AuthorId;
            bookToBeAdded.PublisherId = newBook.PublisherId;
            bookToBeAdded.Title = newBook.Title;
            bookToBeAdded.Author = author;
            bookToBeAdded.Publisher = publisher;

            author.Books.Add(bookToBeAdded);

            await _db.Books.AddAsync(bookToBeAdded);
            _db.SaveChangesAsync();
            return bookToBeAdded; 
        }
    }
}
