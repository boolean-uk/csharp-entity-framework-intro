using exercise.webapi.Data;
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

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetBookById(int id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
            return book != null ? book : null;
        }

        public async Task<Book> UpdateBookById(int id, int newAuthorId)
        {
            var book = await GetBookById(id);
            book.AuthorId = newAuthorId;
            book.Author = await GetAuthorById(newAuthorId);

            _db.SaveChangesAsync();

            return book;
        }

        public async Task<Book> DeleteBookById(int id)
        {
            var book = await GetBookById(id);
            if (book != null)
            {
                _db.Books.Remove(book);
                _db.SaveChangesAsync();
                return book;
            }

            return null;
        }

        public async Task<Book> CreateBook(BookDTO bookdto)
        {
            Book book = new Book();
            book.Title = bookdto.Title;
            book.AuthorId = bookdto.AuthorId;
            book.Author = await GetAuthorById(book.AuthorId);
            if (book.Author == default(Author))
            {
                return null;
            }

            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }


        public async Task<IEnumerable<Author>> GetAllAuthors()
        { 
            var authors = await _db.Authors.ToListAsync();

            foreach (var aut in authors)
            {
                var books = _db.Books.Where(x => x.AuthorId == aut.Id);
                foreach (var bo in books)
                {
                    aut.Books.Add(new BookDTO() { Title = bo.Title, AuthorId = bo.AuthorId });
                }
            }

            return authors;
        }

        public async Task<Author> GetAuthorById(int id)
        {
            var aut = await _db.Authors.FirstOrDefaultAsync(a => a.Id == id);
            var books = _db.Books.Where(x => x.AuthorId == aut.Id);
            foreach (var temp in books)
            {
                aut.Books.Add(new BookDTO()
                {
                    Title = temp.Title, AuthorId = temp.AuthorId
                });
            }

            return aut;
        }
    }
}
