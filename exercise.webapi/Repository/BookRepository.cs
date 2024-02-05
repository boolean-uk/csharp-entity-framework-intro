using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
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


        public async Task<GetBookDTO?> GetBookById(int id)
        {
            return await _db.Books.Where(x => x.Id == id).Select(y => new GetBookDTO()
            {
                Id = y.Id,
                Title = y.Title,
                AuthorInfo = y.BookAuthors.Join(_db.Authors, bookauthor => bookauthor.AuthorId, author => author.Id, (bookauthor, author) => new AuthorInfoDTO()
                {
                    AuthorId = author.Id,
                    AuthorEmail = author.Email,
                    AuthorFirstName = author.FirstName,
                    AuthorLastName = author.LastName,
                }).ToList(),
                PublisherId = y.Publisher.Id,
                PublisherName = y.Publisher.Name,
            }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<GetBookDTO>> GetAllBooks()
        {
            return await _db.Books.Select(x => new GetBookDTO()
            {
                Id = x.Id,
                Title = x.Title,
                AuthorInfo = x.BookAuthors.Join(_db.Authors, bookauthor => bookauthor.AuthorId, author => author.Id, (bookauthor, author) => new AuthorInfoDTO()
                {
                    AuthorId = author.Id,
                    AuthorEmail = author.Email,
                    AuthorFirstName = author.FirstName,
                    AuthorLastName = author.LastName,
                }).ToList(),
                PublisherId = x.Publisher.Id,
                PublisherName = x.Publisher.Name,
            }).ToListAsync();

        }

        public async Task<GetBookDTO?> ChangeAuthorById(UpdateBookAuthorDTO updateDTO)
        {
            Author? newAuthor = await _db.Authors.Where(x => x.Id == updateDTO.NewAuthorId).FirstOrDefaultAsync();
            if (newAuthor == null)
            {
                return null;
            }
            Book? dbBook = await _db.Books.Where(x => x.Id == updateDTO.BookId).Include(x => x.Publisher).FirstOrDefaultAsync();
            if (dbBook == null) { return null; }
            BookAuthor bookAuthor = new() { AuthorId = newAuthor.Id, BookId = dbBook.Id };
            dbBook.BookAuthors.Add(bookAuthor);
            await _db.SaveChangesAsync();
            return new GetBookDTO()
            {
                Id = dbBook.Id,
                Title = dbBook.Title,
                AuthorInfo = dbBook.BookAuthors.Join(_db.Authors, bookauthor => bookauthor.AuthorId, author => author.Id, (bookauthor, author) => new AuthorInfoDTO()
                {
                    AuthorId = author.Id,
                    AuthorEmail = author.Email,
                    AuthorFirstName = author.FirstName,
                    AuthorLastName = author.LastName,
                }).ToList(),
                PublisherId = dbBook.Publisher.Id,
                PublisherName = dbBook.Publisher.Name,
            };
        }

        public async Task<int> DeleteBookById(int id)
        {
            Book? dbBook = await _db.Books.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (dbBook == null) { return -1; }
            _db.Books.Remove(dbBook);
            await _db.SaveChangesAsync();
            return 0;
        }

        public async Task<int> CreateBook(CreateBookDTO createDTO)
        {
            if (createDTO.Title.Length == 0) { return -1; }
            List<Author> dbAuthor = await _db.Authors.Where(x => createDTO.AuthorIds.Contains(x.Id)).ToListAsync();
            if (dbAuthor.Count == 0) { return -2; }
            Publisher? dbPublisher = await _db.Publishers.Where(x => x.Id == createDTO.PublisherId).FirstOrDefaultAsync();
            if (dbPublisher == null) { return -3; }
            Book book = new Book();
            _db.Books.Add(book);
            book.PublisherId = createDTO.PublisherId;
            book.Publisher = dbPublisher;
            book.Title = createDTO.Title;
            book.BookAuthors = dbAuthor.Select(x => new BookAuthor() { AuthorId = x.Id, BookId = book.Id }).ToList();
            await _db.SaveChangesAsync();
            return 0;
        }
    }
}
