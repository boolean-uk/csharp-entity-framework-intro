using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

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
            var books = from book in _db.Books
                        select new BookDto()
                        {
                            Id = book.Id,
                            Title = book.Title,
                            AuthorId = book.AuthorId,
                            AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                            PublisherId = book.Publisher.Id,
                            PublisherName = book.Publisher.PublisherName
                        };
            return await books.ToListAsync();
        }

        public async Task<BookDto> GetById(int id)
        {
            var book = await _db.Books.Include(b => b.Author).Select(b => new BookDto()
            {
                Id = b.Id,
                Title = b.Title,
                AuthorId = b.AuthorId,
                AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                PublisherId = b.Publisher.Id,
                PublisherName = b.Publisher.PublisherName
            }).SingleOrDefaultAsync(b => b.Id == id);

            return book;
        }

        public async Task<Book> Update(int id, int authorId)
        {
            Book updatingBook = _db.Books.FirstOrDefault(b => b.Id == id);
            Author newAuthor = _db.Authors.FirstOrDefault(a => a.Id == authorId);

            updatingBook.Author = newAuthor;
            updatingBook.AuthorId = authorId;
            _db.SaveChanges();

            return updatingBook;
        }

        public async Task<BookDto> Delete(int id)
        {
            var deleting = _db.Books.FirstOrDefault(b => b.Id == id);

            var bookDto = await GetById(id);
            _db.Books.Remove(deleting);
            _db.SaveChanges();

            return bookDto;
        }

        public async Task<Book> Create(BookPost book, int authorId)
        {
            var author = _db.Authors.FirstOrDefault(a => a.Id == authorId);
            var lastInList = _db.Books.LastOrDefault().Id;
            Book createBook = new Book()
            {
                Id = lastInList + 1,
                Title = book.Title,
                AuthorId = authorId,
                Author = author
            };

            _db.Books.Add(createBook);
            _db.SaveChanges();
            return createBook;
        }

    }
}
