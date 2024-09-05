using exercise.webapi.Data;
using exercise.webapi.DTO;
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

        private BookGetModel CreateBookModel(Book book)
        {
            return new BookGetModel
            {
                Title = book.Title,
                Author = new BookAuthorModel
                {
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                },
                Publisher = book.Publisher.Name
            };
        }

        public async Task<BookGetModel> DeleteBook(int id)
        {
            var result = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
            _db.Books.Remove(result);
            await _db.SaveChangesAsync();
            return CreateBookModel(result);
        }

        public async Task<IEnumerable<BookGetModel>> GetAllBooks()
        {
            var result =  await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
            var books = new List<BookGetModel>();
            foreach (var book in result)
            {
                books.Add(CreateBookModel(book));
            }
            return books;
        }

        public async Task<BookGetModel> GetBook(int id)
        {
            var result = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
            return CreateBookModel(result);
        }

        public async Task<BookGetModel> UpdateBook(int id, BookUpdateModel model)
        {
            var result = await _db.Books.FindAsync(id);
            result.AuthorId = model.AuthorId;
            await _db.SaveChangesAsync();
            await _db.Entry(result).Reference(b => b.Author).LoadAsync();
            await _db.Entry(result).Reference(b => b.Publisher).LoadAsync();
            return CreateBookModel(result);
        }

        public async Task<BookGetModel> CreateBook(BookCreateModel model)
        {
            if (model.Title.Equals("") || model.Title.Equals("string")) throw new ArgumentException();

            var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == model.AuthorId);
            if (author == null) throw new KeyNotFoundException();

            var book = new Book() { Title = model.Title, AuthorId = author.Id, Author = author, Publisher = await _db.Publishers.FirstOrDefaultAsync() };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();

            return CreateBookModel(book);
        }
    }
}
