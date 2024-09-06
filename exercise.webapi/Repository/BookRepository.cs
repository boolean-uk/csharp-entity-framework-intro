using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.DTO;
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

        public async Task<IEnumerable<DTOBook>> GetAllBooks()
        {
            List<DTOBook> dTOBooks = new List<DTOBook>();
            List<Book> books = await _db.Books.Include(b => b.Author).ToListAsync();
            foreach (Book book in books)
            {
                DTOBook dtobook = new DTOBook();
                dtobook.authorName = $"{book.Author.FirstName} {book.Author.LastName}";
                dtobook.AuthorID = book.AuthorId;
                dtobook.Title = book.Title;
                dtobook.Id = book.Id;
                dTOBooks.Add(dtobook);
            }
            return dTOBooks;

        }
        public async Task<DTOBook> GetBook(int id)
        {
            var dtobook = await _db.Books.Include(b => b.Author).Select(b => new DTOBook()
            {
                authorName = $"{b.Author.FirstName} {b.Author.LastName}",
                AuthorID = b.AuthorId,
                Title = b.Title,
                Id = b.Id
            }).SingleOrDefaultAsync(b => b.Id == id);

            return dtobook;
        }

        public async Task<DTOBook> UpdateBook(DTOBook book, int AuthorID)
        {
            Book oldbook = await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == book.Id);
            oldbook.AuthorId = AuthorID;
            _db.Attach(oldbook).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            DTOBook newbook = await GetBook(book.Id);
            return newbook;

        }

        public async Task<DTOBook> DeleteBook(int bookid)
        {
            DTOBook book = await GetBook(bookid);
            Book deletedbook = await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == bookid);
            _db.Books.Remove(deletedbook);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<DTOBook> AddBook(DTOBook book)
        {
            try
            {
                //Author author = await _db.Authors.Include(a=> a.Id).FirstOrDefaultAsync(a => a.Id == book.AuthorID);
                Book addedBook = new Book()
                {
                    //Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorID
                };
                var id = _db.Books.Add(addedBook);
                await _db.SaveChangesAsync();
                DTOBook bookDTO = await GetBook(addedBook.Id);
                return bookDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
