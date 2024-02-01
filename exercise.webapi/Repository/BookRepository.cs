using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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


        public async Task<IEnumerable<BookDTO>> GetAllBooks()
        {
            var books = from book in _db.Books
                        select new BookDTO()
                        {
                            Id = book.Id,
                            Title = book.Title,
                            AuthorName = $"{book.Author.FirstName} {book.Author.LastName}"
                        };
            return await books.ToListAsync();

        }

        public async Task<BookDTO> GetBookById(int id)
        {
            var book = await _db.Books.Include(b => b.Author).Select(b => new BookDTO()
            { 
                Id = b.Id,
                Title = b.Title,
                AuthorName = $"{b.Author.FirstName} {b.Author.LastName}"
            }).SingleOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                
            }
            return book;
        }

        public async Task<Book> UpdateBook(int id, int authorId)
        {
            Book bookToChange = _db.Books.FirstOrDefault(b => b.Id == id);
            Author authorToAdd = _db.Authors.FirstOrDefault(a => a.Id == authorId);

            bookToChange.Author = authorToAdd;
            bookToChange.AuthorId = authorId;
            _db.SaveChanges();

            return bookToChange;
            
        }
        public async  Task<BookDTO> DeleteBook(int id)
        {
            var bookToDelete = _db.Books.FirstOrDefault(a => a.Id == id);

            var bookDTO = await GetBookById(id);
            _db.Books.Remove(bookToDelete);
            _db.SaveChanges();

            return bookDTO;
        }

        public async Task<Book> CreateBook(BookDTO postBookDTO)
        {
            throw new NotImplementedException();
        }
    }
}
