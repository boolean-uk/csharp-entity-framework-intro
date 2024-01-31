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
    }
}
