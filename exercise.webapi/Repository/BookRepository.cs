using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<ResponseBookDTO> AddBook(BookPost data)
        {
            
            Book book = new Book()
            {
                Title = data.title,
            };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();

            foreach (var authorId in data.authorId)
            {
                var author = await _db.Authors.FindAsync(authorId);
                if (author == null)
                {
                    throw new Exception("Author ID not found!");
                }
                book.BookAuthors.Add(new BookAuthor
                {
                    BookId = book.Id,
                    AuthorId = authorId
                });
            }
            await _db.SaveChangesAsync();
            ResponseBookDTO response = PutBook(book);
            
            return response;
        }

        public async Task<bool> CheckBookDataId(BookPost data)
        {
            var authorIds = data.authorId;
            var existingAuthorIds = await _db.Authors
                .Where(a => authorIds.Contains(a.Id))
                .Select(a => a.Id)
                .ToListAsync();

            return existingAuthorIds.Count == authorIds.Count;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var book = await _db.Books
              .Include(b => b.BookAuthors)
              .ThenInclude(ba => ba.Author)
              .SingleOrDefaultAsync(b => b.Id == id);

            if (book != null)
            {

                _db.Books.Remove(book);

                // Save changes to the database
                await _db.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<ResponseBookDTO>> GetAllBooks()
        {
            // Include BookAuthors and then Authors via ThenInclude to load related entities
            var books = await _db.Books
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .ToListAsync();

            List<ResponseBookDTO> result = new List<ResponseBookDTO>();

            // Convert each book entity to ResponseBookDTO
            foreach (var book in books)
            {
                result.Add(PutBook(book)); // PutBook handles multiple authors now
            }

            return result;
        }

        public async Task<ResponseBookDTO> GetBook(int id)
        {
            // Include BookAuthors and related Authors
            var book = await _db.Books
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .SingleOrDefaultAsync(b => b.Id == id);

            // Check if the book is found
            if (book == null)
            {
                return null; // or handle the case where the book is not found as needed
            }

            // Convert the book entity to ResponseBookDTO
            ResponseBookDTO response = PutBook(book);

            return response;
        }

        public async Task<ResponseBookDTO> UpdateBook(int id, BookUpdate data)
        {
            // Include BookAuthors and related Authors for the book
            var book = await _db.Books
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .SingleOrDefaultAsync(b => b.Id == id);

            if (book != null)
            {
                // Update the book's properties and associated authors
                UpdateValues(book, data);

                // Convert the updated book entity to ResponseBookDTO
                ResponseBookDTO result = PutBook(book);

                // Save changes to the database
                await _db.SaveChangesAsync();

                return result;
            }

            return null;
        }

        private ResponseBookDTO PutBook(Book? book)
        {
            if (book == null)
            {
                throw new Exception("Something went wrong, book was null!");
            }

            // Create the result DTO
            ResponseBookDTO result = new ResponseBookDTO
            {
                Id = book.Id,
                Title = book.Title,
                Authors = new List<AuthorDTO>() // Initialize the Authors list
            };

            // Loop through all BookAuthors to populate the Authors list in the DTO
            foreach (var bookAuthor in book.BookAuthors)
            {
                var author = bookAuthor.Author; // Get the author from the BookAuthor junction
                result.Authors.Add(new AuthorDTO
                {
                    Id = author.Id,
                    Email = author.Email,
                    FirstName = author.FirstName,
                    LastName = author.LastName
                });
            }

            return result;
        }

        private async void UpdateValues(Book book, BookUpdate data)
        {
            book.BookAuthors.Clear();

            // Add new authors to the BookAuthors collection
            foreach (var authorId in data.AuthorIds)
            {
                var author = await _db.Authors.SingleOrDefaultAsync(a => a.Id == authorId);
                if (author == null)
                {
                    throw new Exception($"Author with ID {authorId} not found.");
                }

                // Add new BookAuthor entry for each author
                book.BookAuthors.Add(new BookAuthor
                {
                    BookId = book.Id,
                    AuthorId = author.Id,
                    Book = book,
                    Author = author
                });
            }
        }
    }

}
