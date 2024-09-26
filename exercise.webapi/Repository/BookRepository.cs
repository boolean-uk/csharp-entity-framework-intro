using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;
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

        public async Task<Author> CreateBook(int authorId, BookCreatePayload book)
        {
            var author = _db.Authors.FirstOrDefault(b => b.Id == authorId);
            var publisher = _db.Publishers.FirstOrDefault(p => p.Id == book.PublisherId);
            Book b = new Book() {Title = book.Title, BookAuthors = author.BookAuthors, PublisherId = book.PublisherId};
            await _db.Books.AddAsync(b);
            await _db.BookAuthors.AddAsync(new BookAuthor() {BookId = b.Id, AuthorId = author.Id});
            await _db.SaveChangesAsync();
            return author;
        }

        public async Task<Book> DeleteBook(int Id)
        {
            var book = await GetBook(Id);
            if(book == null)
                return null;

            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return book;
        }
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books
                .Include(book => book.BookAuthors)
                .ThenInclude(authorBook => authorBook.Author)
                .Include(publisher => publisher.Publisher)
                .ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            var book = await _db.Books
            .Include(book => book.BookAuthors)
            .Include(book => book.BookAuthors.Select(authorBook => authorBook.Author))
            .Include(book => book.Publisher)
            .Where(book => book.Id == id)
            .FirstOrDefaultAsync();
            return book;
        }
        
        public async Task<Book> UpdateBook(int Id, BookUpdateDTO payload)
        {
            if(Id <= 0)
                return null;
            Book book = await GetBook(Id);

            if(payload.Title != "") {
                book.Title = payload.Title;
            }

            if(isAuthor(payload.AuthorId)) {
                _db.BookAuthors.Add(new BookAuthor {BookId = book.Id, AuthorId = payload.AuthorId});
            }
            await _db.SaveChangesAsync();
            return book;
        }

        private bool isAuthor(int authorId) {
            bool authorExists = _db.Authors.Any(author => author.Id == authorId);
            return authorExists;
        }
    }
}
