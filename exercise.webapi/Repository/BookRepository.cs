using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;

        public BookRepository(DataContext db)
        {
            _db = db;
        }


        public async Task<IEnumerable<GetBookDto>> GetAllBooks()
        {
            IEnumerable<GetBookDto> books = await _db.Books.Include(b => b.Author).Select(b => new GetBookDto()
                {
                    AuthorDto = b.Author,
                    Id = b.Id,
                    Title = b.Title
                }).ToListAsync();
            return books;

        }

        public async Task<GetBookDto> GetBook(int id)
        {
            Book book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id)
               ?? throw new ArgumentException($"No book with this id: {id}");
            GetBookDto dto = new()
            {
                AuthorDto = book.Author,
                Id = book.Id,
                Title = book.Title
            };
            return dto;
        }

        public async Task<GetBookDto> UpdateAuthor(int id, int authorId)
        {
            Book book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);

            Author author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId);
               
            book.Author = author;
            book.AuthorId = author.Id;
            await _db.SaveChangesAsync();
            var dto = new GetBookDto()
            {
                AuthorDto = book.Author,
                Id = book.Id,
                Title = book.Title
            };
            return dto;
        }


        public async Task<GetBookDto> DeleteBook(int id)
        {
            Book book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id)
            ?? throw new ArgumentException($"No book with this id: {id}");
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            var dto = new GetBookDto()
            {
                AuthorDto = book.Author,
                Id = book.Id,
                Title = book.Title
            };
            return dto;
        }

        public async Task<CreateBookDto> CreateBook(CreateBookDto book)
        {
            if (book.Title == null || book.AuthorId == null)
            {
                throw new BadHttpRequestException("Not a valid format!");
            }
            Author author = await _db.Authors
                .FirstOrDefaultAsync(a => a.Id == book.AuthorId)
                ?? throw new ArgumentException($"No author with this id: {book.AuthorId}");
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