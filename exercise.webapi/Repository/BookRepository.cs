using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using exercise.webapi.Models.DTOs;

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

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> UpdateBooksAuthor(int id, int newAuthor)
        {
            var book = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
            var authorToUpdate = await _db.Authors.FindAsync(newAuthor);
            book.Author = authorToUpdate;
            await _db.SaveChangesAsync();

            return book;
        }

        public async Task<Book> DeleteBook (int id)
        {
            var book = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return book;
        }

        public async Task<Book> CreateBook(CreateBookDto newBook)
        {
            var existingAuthor = await _db.Authors.FindAsync(newBook.AuthorId);
            var bookToAdd = new Book
            {
                Title = newBook.Title,
                AuthorId = newBook.AuthorId,
                Author = existingAuthor
            };
            _db.Books.Add(bookToAdd);
            await _db.SaveChangesAsync();

            return bookToAdd;
        }

        // -------------------- Author ----------------------

        public async Task<IEnumerable<AuthorDto>> GetAllAuthors()
        {
            var authors = await _db.Authors.Include(a => a.Books).ToListAsync();
            var authorDtos = authors.Select(author => new AuthorDto
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(book => new BookDto
                {
                    Id = book.Id,
                    Title = book.Title
                }).ToList()
            });

            return authorDtos;
        }

        public int GetAmountOfAuthors()
        {
            return _db.Authors.Max(x => x.Id); 
        }

        public async Task<IEnumerable<BookDto>> GetBooksByAuthorId(int authorId)
        {
            var author = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == authorId);
            var books = author.Books.Select(b => new BookDto { Id = b.Id, Title = b.Title }).ToList();

            return books;
        }

        // ------------------------ Publisher ------------------------

        public async Task<IEnumerable<PublisherDto>> GetAllPublishers()
        {
            var publishers = await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).ToListAsync();

            var publisherDtos = publishers.Select(publisher => new PublisherDto
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Books = publisher.Books.Select(book => new BookDto
                {
                    Id = book.Id,
                    Title = book.Title,
                }).ToList()
            });

            return publisherDtos;
        }

        public async Task<IEnumerable<BookDto>> GetBooksByPublisherId(int publisherId)
        {
            var publisher = await _db.Publishers.Include(p => p.Books).FirstOrDefaultAsync(p => p.Id == publisherId);
            var books = publisher.Books.Select(b => new BookDto { Id = b.Id, Title = b.Title }).ToList();
            return books;
        }
    }
}
