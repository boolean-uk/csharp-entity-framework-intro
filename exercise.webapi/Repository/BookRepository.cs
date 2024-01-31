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


        /* The previous code
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }
        */
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            // Retrieve all books including their authors
            return await _db.Books.Include(b => b.Author).ToListAsync();

            // Map each book to a BookDTO
            //return books.Select(book => new BookDTO(book));
        }

        public async Task<Book> GetBook(int bookId)
        {
            // Retrieve a single book including its author based on the bookId
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == bookId);

            // If the book is found, map it to a BookDTO, otherwise return null
            //return book != null ? new BookDTO(book) : null;
        }
        public async Task<Book> CreateBook(Book newBook)
        {
            // Map the BookDTO to a Book entity
            var bookEntity = new Book
            {
                Id = newBook.Id,
                Title = newBook.Title,
            };

            // Check if the specified author exists in the database
            var author = await _db.Authors.FindAsync(newBook.Author.Id);
            if (author == null)
            {
                // If the author doesn't exist, return null (you may consider handling this differently based on your requirements)
                return null;
            }

            // Associate the book with the author
            bookEntity.Author = author;

            // Add the new book to the database
            _db.Books.Add(bookEntity);
            await _db.SaveChangesAsync();

            // Map the newly created book to a BookDTO and return it
            return bookEntity;
        }

        public async Task<Book> UpdateBook(int bookId, Book updatedBook)
        {
        var existingBook = await _db.Books.FindAsync(bookId);

        if (existingBook != null)
        {
            // Update the properties of the existing book
            existingBook.Title = updatedBook.Title;

        // Check if the specified author exists in the database
        var author = await _db.Authors.FindAsync(updatedBook.Author.Id);
        if (author != null)
        {
            existingBook.Author = author;
        }
        else
        {
            // Handle the case where the specified author doesn't exist
            // You may choose to return null or throw an exception based on your requirements
            return null;
        }

        // Save the changes to the database
        await _db.SaveChangesAsync();

        // Map the updated book to a BookDTO and return it
        return existingBook;
        }

            return null; // Return null if the book with the specified ID is not found
        }


        public async Task<bool> DeleteBook(int bookId)
        {
            var book = await _db.Books.FindAsync(bookId);

            if (book != null)
            {
                _db.Books.Remove(book);
                await _db.SaveChangesAsync();
                return true; // Return true if deletion is successful
            }

            return false; // Return false if the book is not found
        }
    }
}
