using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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
         * implement the GET book and GET all books. When you return the books objects, use an appropriate DTO to return the book + author (but no nested books inside author). 
         * Make sure to include the authors when you load the data in the repository.
         */
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)   
                .FirstAsync(b => b.Id == id);
        }


        /*
         * implement the UPDATE boook where you can change the author via id (you may skip updating other properties like title, etc); make sure to return the Book + Author once the update is done
         */
        public async Task<Book> UpdateBook(int bookId, BookPut model)
        {
            var book = await _db.Books
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .FirstOrDefaultAsync(b => b.Id == bookId);

            if (book != null)
            {
                // Update PublisherId if provided
                if (model.PublisherId > 0)
                {
                    var publisher = await _db.Publishers.FindAsync(model.PublisherId);
                    if (publisher != null)
                    {
                        book.PublisherId = model.PublisherId;
                        book.Publisher = publisher;
                    }
                }

                // Update Authors if provided
                if (model.AuthorIds != null && model.AuthorIds.Any())
                {
                    // Remove existing book authors
                    _db.BookAuthors.RemoveRange(book.BookAuthors);

                    // Add new book authors
                    foreach (var authorId in model.AuthorIds)
                    {
                        var author = await _db.Authors.FindAsync(authorId);

                        if (author != null)
                        {
                            var bookAuthor = new BookAuthor
                            {
                                Book = book,
                                Author = author
                            };

                            _db.BookAuthors.Add(bookAuthor);
                        }
                    }
                }

                await _db.SaveChangesAsync();
            }

            return book;
        }


        /*
         * implement the DELETE book
         */
        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books
                .Include(b => b.Publisher)
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book != null)
            {
                _db.Books.Remove(book);
                await _db.SaveChangesAsync();
            }

            return book;
        }

        /*
         * implement the CREATE book - it should return NotFound when author id is not valid and BadRequest when book object not valid
         */
        public async Task<Book> CreateBook(BookPost model)
        {
            var publisher = await _db.Publishers.FindAsync(model.PublisherId);
            var authors = await _db.Authors.ToListAsync();

            if (publisher == null || string.IsNullOrWhiteSpace(model.Title) || model.Title == "string")
            {
                return null; // Return null to indicate a failure in creating the book
            }

            var newBook = new Book
            {
                Title = model.Title,
                PublisherId = model.PublisherId,
                Publisher = publisher
            };

            foreach (var authorId in model.AuthorIds)
            {
                var author = await _db.Authors.FindAsync(authorId);

                if (author == null)
                {
                    return null; // Return null to indicate a failure in creating the book
                }

                var bookAuthor = new BookAuthor
                {
                    Book = newBook,
                    Author = author
                };

                _db.BookAuthors.Add(bookAuthor);
            }

            await _db.SaveChangesAsync();

            // Reload the book to get the updated relationships
            await _db.Entry(newBook).Collection(b => b.BookAuthors).LoadAsync(); // Use Collection instead of Reference

            return newBook;
        }

        public async Task<bool> AreAuthorsValid(List<int> authorIds)
        {
            var existingAuthors = await _db.Authors
                .Where(a => authorIds.Contains(a.Id))
                .Select(a => a.Id)
                .ToListAsync();

            return existingAuthors.Count == authorIds.Count;
        }


    }
}

