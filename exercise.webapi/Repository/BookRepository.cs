using exercise.webapi.Data;
using exercise.webapi.DTO;
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

        public async Task<IEnumerable<BookGetDTO>> GetAllBooks()
        {
            return await _db.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Select(b => new BookGetDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = new AuthorGetDTO
                    {
                        Id = b.Author.Id,
                        FirstName = b.Author.FirstName,
                        LastName = b.Author.LastName,
                        Email = b.Author.Email
                    },
                    Publisher = new PublisherGetDTO
                    {
                        Id = b.Publisher.Id,
                        Name = b.Publisher.Name
                    }
                })
                .ToListAsync();

        }

        public async Task<BookGetDTO> GetBookById(int id)
        {
            return await _db.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Where(b => b.Id == id)
                .Select(b => new BookGetDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = new AuthorGetDTO
                    {
                        Id = b.Author.Id,
                        FirstName = b.Author.FirstName,
                        LastName = b.Author.LastName,
                        Email = b.Author.Email
                    },
                    Publisher = new PublisherGetDTO
                    {
                        Id = b.Publisher.Id,
                        Name = b.Publisher.Name
                    }
                })
                .FirstOrDefaultAsync();
        }

        public async Task<Book?> GetBookByIdAsModel(int id)
        {
            return await _db.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> AddBook(Book book)
        {
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> UpdateBook(int id, Book book)
        {
            var existingBook = await _db.Books.FindAsync(id);

            existingBook.AuthorId = book.AuthorId;
            existingBook.AuthorId = book.PublisherId;

            await _db.SaveChangesAsync();
            return existingBook;
        }


        public async Task<bool> DeleteBook(int id)
        {
            var book = await _db.Books.FindAsync(id);
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return true;
        }


    }
}
