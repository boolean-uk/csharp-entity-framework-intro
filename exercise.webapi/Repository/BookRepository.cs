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

        /*
         * Get the Author by ID to correctly get the updated author object.
         */
        public async Task<Author> GetAuthorById(int authorId)
        {
            var author = await _db.Authors.FindAsync(authorId);
            return author;
        }

        /*
         * implement the GET book and GET all books. When you return the books objects, use an appropriate DTO to return the book + author (but no nested books inside author). 
         * Make sure to include the authors when you load the data in the repository.
         */
        public async Task<IEnumerable<BookDTO>> GetAllBooks()
        {
            var books = await _db.Books.Include(b => b.Author).ToListAsync();
            return books.Select(book => new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new AuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            });

        }

        public async Task<BookDTO> GetBookById(int id)
        {
            var bookClass = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            var bookDTO = new BookDTO
            {
                Id = bookClass.Id,
                Title = bookClass.Title,
                AuthorId = bookClass.AuthorId,
                Author = new AuthorDTO
                {
                    Id = bookClass.Author.Id,
                    FirstName = bookClass.Author.FirstName,
                    LastName = bookClass.Author.LastName,
                    Email = bookClass.Author.Email
                }
            };
            return bookDTO;
        }


        /*
         * implement the UPDATE boook where you can change the author via id (you may skip updating other properties like title, etc); make sure to return the Book + Author once the update is done
         */
        public async Task<BookDTO> UpdateBook(int bookId, int authorId)
        {
            var bookToUpdate = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == bookId);
            bookToUpdate.AuthorId = authorId;

            await _db.SaveChangesAsync();
            // key changed, now try to fetch the book again with updated author.

            var newAuthor = await GetAuthorById(authorId);

            var authorDTO = new AuthorDTO
            {
                Id = newAuthor.Id,
                FirstName = newAuthor.FirstName,
                LastName = newAuthor.LastName,
                Email = newAuthor.Email
            };

            var bookUpdated = new BookDTO
            {
                Id = bookToUpdate.Id,
                Title = bookToUpdate.Title,
                AuthorId = bookToUpdate.AuthorId,
                Author = authorDTO
            };


            return bookUpdated;
        }


        /*
         * implement the DELETE book
         */
        public async Task<BookDTO> DeleteBook(int id)
        {
            var foundBook = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            if (foundBook == null)
            {
                return null;
            }
            _db.Books.Remove(foundBook);
            await _db.SaveChangesAsync();

            var deletedBookDTO = new BookDTO
            {
                Id = foundBook.Id,
                Title = foundBook.Title,
                AuthorId = foundBook.AuthorId,
                Author = new AuthorDTO
                {
                    Id = foundBook.Author.Id,
                    FirstName = foundBook.Author.FirstName,
                    LastName = foundBook.Author.LastName,
                    Email = foundBook.Author.Email
                }
            };
            return deletedBookDTO;
        }


        /*
         * implement the CREATE book - it should return NotFound when author id is not valid and BadRequest when book object not valid
         */
        public async Task<BookDTO> CreateBook(BookPost book)
        {
            int newId = _db.Books.Max(b => b.Id) + 1;
            var newAuthor = await GetAuthorById(book.AuthorId);


            Book newBook = new Book
            {
                Id = newId,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = newAuthor
            };

            _db.Books.Add(newBook);
            _db.SaveChanges();


            var bookDTO = new BookDTO
            {
                Id = newBook.Id,
                Title = newBook.Title,
                AuthorId = newBook.AuthorId,
                Author = new AuthorDTO
                {
                    Id = newBook.Author.Id,
                    FirstName = newBook.Author.FirstName,
                    LastName = newBook.Author.LastName,
                    Email = newBook.Author.Email
                }
            };


            return bookDTO;
        }


    }
}
