using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;

        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public DataContext GetDatabase() { return _db; }

        public async Task<Tuple<Book, Author>> CreateBook(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();

            Tuple<Book, Author> result = new Tuple<Book, Author>(book, _db.Authors.FirstOrDefault(x => x.Id == book.AuthorId));
            return result;
        }

        public async Task<Book> DeleteBook(int id)
        {
            Book bookRef = _db.Books.FirstOrDefault(b => b.Id == id);
            if (bookRef == null || bookRef == default(Book))
                return bookRef;

            _db.Books.Remove(bookRef);
            _db.SaveChanges();

            return bookRef;
        }

        public async Task<Tuple<IEnumerable<Book>, IEnumerable<Author>>> GetAllBooks()
        {
            IEnumerable<Author> authors = _db.Authors.Where( a => default(Book) != 
                    _db.Books.FirstOrDefault(b => b.AuthorId == a.Id) 
                    );

            Tuple<IEnumerable<Book>, IEnumerable<Author>> result =
                new Tuple<IEnumerable<Book>, IEnumerable<Author>>( _db.Books, authors );

            return result;
        }

        public async Task<Tuple<Book, Author>> GetBook(int id)
        {
            Book book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            Tuple<Book, Author> result = new Tuple<Book, Author>(
                book,
                _db.Authors.FirstOrDefault(a => a.Id == book.AuthorId)
                );
            return result;
        }

        public async Task<Tuple<Book, Author>> UpdateBook( int bookID, int newAuthorID)
        {
            Book bookRef = _db.Books.FirstOrDefault( b => b.Id == bookID);
            if (bookRef == null || bookRef == default(Book))
                return null;

            Author authorRef = _db.Authors.FirstOrDefault(x => x.Id == newAuthorID); ;
            if (authorRef == default(Author))
                return null;

            // Update Book
            bookRef.AuthorId = authorRef.Id;
            
            Tuple<Book, Author> result = new Tuple<Book, Author>(bookRef, authorRef);
            return result;
        }
    }
}
