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
        public async Task<AuthorDTO> GetAuthorById(int authorId)
        {
            var author = await _db.Authors.FindAsync(authorId);

            if (author == null)
            {
                return null;
            }

            var authorDTO = new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email
            };

            return authorDTO;
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

            var bookUpdated = new BookDTO
            {
                Id = bookToUpdate.Id,
                Title = bookToUpdate.Title,
                AuthorId = bookToUpdate.AuthorId,
                Author = newAuthor
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
                Author = await GetAuthorById(foundBook.Author.Id)
            };  
            return deletedBookDTO;
        }


        /*
         * implement the CREATE book - it should return NotFound when author id is not valid and BadRequest when book object not valid
         */
        public async Task<BookDTO> CreateBook(BookDTO bookDTO)
        {
            throw new NotImplementedException();
        }


    }
}
