using exercise.webapi.Data;
using exercise.webapi.DTO;
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

        public async Task<Book> createBook(BookDTO book)
        {

            Author bookAuthor = _db.Authors.FirstOrDefault(x => x.Id==book.authorId);

            if (bookAuthor == null)
            {
                return null;
            }
            Book booktoCreate = new Book()
            {
                AuthorId = book.authorId,
                
                Title = book.title,
                Id = book.bookId
            };
            _db.Books.Add(booktoCreate);
            _db.SaveChanges();
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == book.bookId);
        }

        public Task DeleteBook(int id)
        {
            var book = _db.Books.Include(b => b.Author).FirstOrDefault(x => x.Id == id);
            _db.Books.Remove(book);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetBook(int id)
        {
            return  _db.Books.Include(b => b.Author).FirstOrDefault(x=> x.Id==id);
        }

        public async Task<Author> GetAuthor(int id)
        {
            return _db.Authors.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Book> UpdateBook(int id, int newAuthorId)
        {
            var book =  _db.Books.Include(b => b.Author).FirstOrDefault(x => x.Id == id);
            var AuthortoChangeTo = _db.Authors.FirstOrDefault(x=> x.Id == newAuthorId);
            book.Author = AuthortoChangeTo;
            _db.Entry(book).State = EntityState.Modified;
            _db.SaveChanges();
            return await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
        }


        public async Task<Book> RemoveAuthor(int bookId)
        {
            var book = _db.Books.Include(b => b.Author).FirstOrDefault(x => x.Id == bookId);
            if (book.Author == null)
            {
                return null;
            }
            book.Author = null;
            return await _db.Books.FirstOrDefaultAsync(b => b.Id == bookId);




        }
        public async Task<Book> AssignAuthor(int bookId, int authorId)
        {
            var book = _db.Books.Include(b => b.Author).FirstOrDefault(x => x.Id == bookId);
            if (book.Author != null)
            {
                return null;
            }
            var AuthorToAssign = _db.Authors.FirstOrDefault(x => x.Id == authorId);
            book.Author = AuthorToAssign;
            _db.Entry(book).State |= EntityState.Modified;
            _db.SaveChanges();
            return await _db.Books.FirstOrDefaultAsync(b => b.Id == bookId);




        }
    }
}
