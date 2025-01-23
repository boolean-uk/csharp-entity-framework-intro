using exercise.webapi.Data;
using exercise.webapi.DTOs;
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

        public async Task<BookDTO> CreateBook(CreateBookDTO bookDto)
        {
            var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == bookDto.AuthorId);
            if (author == null)
                throw new KeyNotFoundException("Author not found");

            if (string.IsNullOrEmpty(bookDto.Title))
                throw new ArgumentException("Book title is required");

            var book = new Book
            {
                Title = bookDto.Title,
                AuthorId = bookDto.AuthorId,
                Author = author
            };

            _db.Books.Add(book);
            await _db.SaveChangesAsync();

            return new BookDTO(book);
        }



        public async Task<IEnumerable<BookDTO>> GetAllBooks()
        {
            var books = await _db.Books.Include(b => b.Author).ToListAsync();

            if (books == null || !books.Any())
                throw new KeyNotFoundException("No books found.");

            return books.Select(book => new BookDTO(book));
        }

        public async Task<BookDTO> GetBookById(int id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                throw new KeyNotFoundException("Book not found");

            return new BookDTO(book);
        }

        public async Task<BookDTO> UpdateBookAuthorById(int bookId, int authorId)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == bookId)
                ?? throw new KeyNotFoundException("Book not found");

            var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId)
                ?? throw new KeyNotFoundException("Author not found");

            book.Author = author;
            book.AuthorId = author.Id;

            await _db.SaveChangesAsync();

            return new BookDTO(book);
        }

        public async Task DeleteBookById(int id)
        {
            var book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id)
                ?? throw new KeyNotFoundException("Book not found");

            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
        }
    }
}
