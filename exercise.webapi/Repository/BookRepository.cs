using exercise.webapi.Data;
using exercise.webapi.DTO;
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

        public async Task<Book> AddBook(NewBookDTO newBook)
        {
            if (newBook.AuthorId == null || newBook.Title == null)
            {
                throw new BadHttpRequestException($"Invalid format.");
            }
            else
            {
                // Calling for author, if no author => no valid author id => throw exception.
                Author author = await _db.Authors.FirstOrDefaultAsync(b => b.Id == newBook.AuthorId) ?? throw new ArgumentException($"No author id match.");
                Book book = new Book()
                {
                    Title = newBook.Title,
                    AuthorId = newBook.AuthorId,
                    Author = author
                };
                await _db.Books.AddAsync(book);
                await _db.SaveChangesAsync();

                return book;
            }
        }

        public async Task<Book> DeleteBook(int? id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
            if (book == null) { throw new Exception($"No..THIS WILL BE ERROR NOT FOUND.. not 400"); }
            else
            {
                await _db.Books.AddAsync(book);
                await _db.SaveChangesAsync();
            }
            return book;
        }

        public async Task<Book> GetABook(int? id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);

            return book;
        }


        /// <summary>
        /// THIS IS a method to get all books --> and also include the author. 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> UpdateBook(int? id, UpdateAuthorDTO newAuthor)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
            if (book == null) { return null; }
            else
            {
                book.Author.FirstName = newAuthor.FirstName;
                book.Author.LastName = newAuthor.LastName;
                book.Author.Email = newAuthor.Email;
                _db.SaveChanges();
                return book;
            }

        }
    }
}
