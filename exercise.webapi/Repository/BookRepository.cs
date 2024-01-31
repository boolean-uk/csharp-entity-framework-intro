using exercise.webapi.Data;
using exercise.webapi.DTOs;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<GetBookDTO>> GetAllBooks()
        {
            IEnumerable <GetBookDTO> books = await _db.Books
                .Include(b => b.Author)
                .Select(b => new GetBookDTO()
                {
                    Author = b.Author,
                    Id = b.Id,
                    Title = b.Title
                }).ToListAsync();
            return books;
        }

        public async Task<GetBookDTO> GetBookById(int id)
        {
            Book book = await _db.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.Id == id)
                ?? throw new ArgumentException($"No book with id: {id}");
            GetBookDTO dto = new()
            {
                Author = book.Author,
                Id = book.Id,
                Title = book.Title
            };
            return dto;
        }

        public async Task<GetBookDTO> UpdateBookAuthor(int bookId, int authorId)
        {
            Book book = await _db.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.Id == bookId)
                ?? throw new ArgumentException($"No book with id: {bookId}");
            Author author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId)
                ?? throw new ArgumentException($"No author with id: {authorId}");
            book.Author = author;
            book.AuthorId = author.Id;
            await _db.SaveChangesAsync();
            var dto = new GetBookDTO()
            {
                Author = book.Author,
                Id = book.Id,
                Title = book.Title
            };
            return dto;
        }

        public async Task<GetBookDTO> DeleteBookById(int bookId)
        {
            Book book = await _db.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.Id == bookId)
                ?? throw new ArgumentException($"No book with id: {bookId}");
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            var dto = new GetBookDTO()
            {
                Author = book.Author,
                Id = book.Id,
                Title = book.Title
            };
            return dto;
        }

        public async Task<CreateBookDTO> CreateBook(CreateBookDTO book)
        {
            if (book.Title == null || book.AuthorId == null)
            {
                throw new BadHttpRequestException("Not a valid format!");
            }
            Author author = await _db.Authors
                .FirstOrDefaultAsync(a => a.Id == book.AuthorId)
                ?? throw new ArgumentException($"No author with id: {book.AuthorId}");
            Book newBook = new()
            {
                Author = author,
                Title = book.Title
            };
            await _db.Books.AddAsync(newBook);
            return book;
        }
    }
}
