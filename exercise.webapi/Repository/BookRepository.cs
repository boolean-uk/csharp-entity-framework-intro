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
            Book b = new Book() {Title = book.Title, Authors = author.Books, PublisherId = book.PublisherId, Publisher = publisher};
            await _db.Books.AddAsync(b);
            await _db.SaveChangesAsync();
            return author;
        }

        public async Task<Book> DeleteBook(int Id)
        {
            var book = await GetBook(Id);
            if(book == null)
                return null;

            _db.Books.Remove(book);
            return book;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books
                .Include(book => book.Authors)
                .ThenInclude(authorBook => authorBook.Author)
                .Include(publisher => publisher.Publisher)
                .ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            try
            {
                Book book = await _db.Books.FindAsync(id);
                if (book == null)
                {
                    return null;
                }
                return book;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<ICollection<BookAuthor>> UpdateBook(int Id, BookUpdateDTO payload)
        {
            if(Id <= 0)
                return null;
            Book book = await _db.Books.FirstOrDefaultAsync(b => b.Id == Id);

            if(payload.Title != "") {
                book.Title = payload.Title;
            }

            if(isAuthor(payload.AuthorId)) {
                _db.BookAuthors.Add(new BookAuthor {BookId = book.Id, AuthorId = payload.AuthorId});
            }
            await _db.SaveChangesAsync();
            return book.Authors;
        }

        private bool isAuthor(int authorId) {
            bool authorExists = _db.Authors.Any(author => author.Id == authorId);
            return authorExists;
        }
    }
}
