using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Net;

namespace exercise.webapi.Repository
{
    public class Repository: IRepository
    {
        DataContext _db;
               
        public Repository(DataContext db)
        {
            _db = db;
            _db.SaveChanges();
        }

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _db.Publishers.Include(p => p.Books).ToListAsync();

        }


        public async Task<Publisher> GetPublisherById(int id)
        {
            return await _db.Publishers.Include(p => p.Books).FirstAsync(a => a.Id == id);

        }
        public async Task<IEnumerable<BookAuthor>> GetAllBookAuthors()
        {

            return await _db.BookAuthors.Include(x => x.Author).ToListAsync();
        }
        public async Task<IEnumerable<BookAuthor>> GetAllAuthorBooks()
        {

            return await _db.BookAuthors.Include(x => x.Book).ThenInclude(y=>y.Publisher).ToListAsync();
        }

        public async Task<IEnumerable<BookAuthor>> GetBookAuthorsByBookId(int bookId)
        {
            return await _db.BookAuthors.Include(x => x.Author).Where(x => x.BookId == bookId).ToListAsync();
        }

        public async Task<IEnumerable<BookAuthor>> GetAuthorBooksByAuthorId(int authorId)
        {
            return await _db.BookAuthors.Include(x => x.Book).ThenInclude(y => y.Publisher).Where(x => x.AuthorId == authorId).ToListAsync();
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).ToListAsync();

        }


        public async Task<Author> GetAuthorById(int id)
        {
            return await  _db.Authors.Include(b => b.Books).ThenInclude(b => b.Publisher).FirstAsync(a => a.Id == id);

        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            
            IEnumerable<Book> books = await _db.Books.Include(b => b.Publisher).ToListAsync();

            return books;
       
        }

        public async Task<Book> GetBookById(int bookId)
        {
  
            Book book = await _db.Books.Include(b => b.Publisher).FirstAsync(b => b.Id == bookId);

            return  book;

        }

        public async Task<Book> Add(PostBook model)
        {
            int bookId = _db.Books.Max(book => book.Id) + 1;
            _db.Books.Add(new Book() {Id = bookId, Title = model.Title, PublisherId = model.PublisherId });
            foreach(int id in model.AuthorIds)
            {
                _db.BookAuthors.Add(new BookAuthor() { AuthorId = id, BookId = bookId });
            }
            
            _db.SaveChanges();
            
            return await _db.Books.Include(b => b.Publisher).FirstAsync(b => b.Title == model.Title); ;
        }

        public async Task<Book> Update(int bookId, int authorId)
        {
            BookAuthor item = await _db.BookAuthors.FirstAsync(b => b.BookId.Equals(bookId));
            item.AuthorId = authorId;
            _db.SaveChanges();

            return await _db.Books.Include(b => b.Publisher).FirstAsync(b => b.Id == bookId);
        }

        public async Task<IEnumerable<Book>> Delete(int id)
        {
            BookAuthor item = await _db.BookAuthors.FirstAsync(i => i.BookId == id);
            _db.BookAuthors.Remove(item);
            Book book = await _db.Books.FirstAsync(b => b.Id.Equals(id));
            _db.Books.Remove(book);
            _db.SaveChanges();
            return await _db.Books.Include(b => b.Publisher).ToListAsync();
        }
    }
}
