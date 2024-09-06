using exercise.webapi.Data;
using exercise.webapi.DTO;
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

        public async Task<IEnumerable<BookDTO>> GetAllBooks()
        {
            var books = from b in _db.Books
                        select new BookDTO()
                        {
                            Id = b.Id,
                            Title = b.Title,
                            AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                            AuthorId = b.AuthorId,
                        };

            return books;
        }
        public async Task<BookDTO> GetBook(int id)
        {
            var book = await _db.Books.Include(b => b.Author).Select(b => new BookDTO()
            {

                Id = b.Id,
                Title = b.Title,
                AuthorName = b.Author.FirstName + " " + b.Author.LastName
            }).SingleOrDefaultAsync(b => b.Id == id);

            return book;
        }

        //Should change this to updating to new ID, instead of changing name due to changing every instance of that id's name
        public async Task<BookDTO> UpdateBook(BookDTO newBook, int id)
        {
            Book book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            book.Author.FirstName = newBook.AuthorName.Split(' ')[0];
            book.Author.LastName = newBook.AuthorName.Split(' ')[1];
            _db.Attach(book).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return newBook;
        }

        public async Task<Book> DeleteBook(int id)
        {
            Book book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);

            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return book;
        }

        public async Task<BookDTO> CreateBook(BookDTO newBook)
        {
            try
            {
                Author author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == newBook.AuthorId);
                Book book = new Book()
                {
                    Title = newBook.Title,
                    AuthorId = newBook.AuthorId,
                };
                _db.Books.AddAsync(book);
                await _db.SaveChangesAsync();
                BookDTO dto = await GetBook(book.Id);
                return dto;

            }
            catch (Exception ex)
            {
                return null;
            }


        }

    }
}
