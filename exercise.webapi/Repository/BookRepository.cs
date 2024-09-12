using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;
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


        public async Task<IEnumerable<BookDto>> GetAllBooks()
        {
            var books = await _db.Books.Include(b => b.Author).ToListAsync();
            return books.Select(b => new BookDto
            {
                Id = b.Id,
                Title = b.Title,
                Author = new AuthorDto
                {
                    Id = b.Author.Id,
                    FirstName = b.Author.FirstName,
                    LastName = b.Author.LastName,
                    Email = b.Author.Email
                }
            });
        }


        public async Task<BookDto> GetBook(int id)
        {
            var book = await _db.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                return null;

            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Author = new AuthorDto
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            };
        }


        public async Task<BookDto> DeleteBook(int id)
        {
            var bookToDelete = await _db.Books.FindAsync(id);
            if (bookToDelete == null)
            {
                return null;
            }

            _db.Books.Remove(bookToDelete);
            await _db.SaveChangesAsync();

            var deletedBookDto = new BookDto
            {
                Id = bookToDelete.Id,
                Title = bookToDelete.Title,
                Author = new AuthorDto
                {
                    Id = bookToDelete.Author.Id, 
                    FirstName = bookToDelete.Author.FirstName,
                    LastName = bookToDelete.Author.LastName, 
                    Email = bookToDelete.Author.Email 
                }
            };

            return deletedBookDto;
        }



        public async Task<BookDto> UpdateBook(int id, int newAuthorId)
        {
            // Find the book with the specified ID
            var existingBook = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            if (existingBook == null)
            {
                // If the book doesn't exist, return null indicating failure
                return null;
            }

            // Find the new author with the specified ID
            var newAuthor = await _db.Authors.FindAsync(newAuthorId);
            if (newAuthor == null)
            {
                // If the new author doesn't exist, return null indicating failure
                return null;
            }

            // Update the book's author
            existingBook.AuthorId = newAuthorId;

            // Save changes to the database
            await _db.SaveChangesAsync();

            // Return the updated book DTO with the new author details
            return new BookDto
            {
                Id = existingBook.Id,
                Title = existingBook.Title,
                Author = new AuthorDto
                {
                    Id = newAuthor.Id,
                    FirstName = newAuthor.FirstName,
                    LastName = newAuthor.LastName,
                    Email = newAuthor.Email
                    // You can include other author properties if needed
                }
            };
        }





        public async Task<BookDto> AddBook(BookDto bookDto)
        {
            // Check if the author with the specified ID exists
            var author = await _db.Authors.FindAsync(bookDto.Author.Id);
            if (author == null)
            {
                return null;
            }

            // Create a new Book entity and assign its properties
            var book = new Book
            {
                Title = bookDto.Title,
                AuthorId = author.Id
            };

            // Add the book to the DbSet and save changes
            _db.Books.Add(book);
            await _db.SaveChangesAsync();

            // Populate the BookDto with the newly created book's ID
            bookDto.Id = book.Id;

            // Return the original BookDto with the updated ID
            return bookDto;
        }


        public async Task<IEnumerable<AuthorDto>> GetAllAuthors()
        {
            var authors = await _db.Authors.Include(a => a.Books).ToListAsync();
            return authors.Select(a => new AuthorDto
            {
                Id = a.Id,
                FirstName= a.FirstName,
                Books = a.Books.Select(b => new BookDto
                {
                    Id = b.Id,
                    Title = b.Title
                })
            });
        }

        public async Task<AuthorDto> GetAuthor(int id)
        {
            var author = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id);
            if (author == null)
                return null;

            return new AuthorDto
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(b => new BookDto
                {
                    Id = b.Id,
                    Title = b.Title
                    // Map other book properties as needed
                })
            };
        }
    }

}

