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
                AuthorInfo = y.Authors.Select(z => new AuthorInfoDTO()
                {
                    AuthorId = z.Id,
                    AuthorEmail = z.Email,
                    AuthorFirstName = z.FirstName,
                    AuthorLastName = z.LastName,
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
                AuthorInfo = x.Authors.Select(y => new AuthorInfoDTO()
                {
                    AuthorId = y.Id,
                    AuthorEmail = y.Email,
                    AuthorFirstName = y.FirstName,
                    AuthorLastName = y.LastName,
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
            Book? dbBook = await _db.Books.Where(x => x.Id == updateDTO.BookId).FirstOrDefaultAsync();
            if (dbBook == null) { return null; }
            dbBook.Authors.Add(newAuthor);
            await _db.SaveChangesAsync();
            return new GetBookDTO()
            {
                Id = dbBook.Id,
                Title = dbBook.Title,
                AuthorInfo = dbBook.Authors.Select(y => new AuthorInfoDTO()
                {
                    AuthorId = y.Id,
                    AuthorEmail = y.Email,
                    AuthorFirstName = y.FirstName,
                    AuthorLastName = y.LastName,
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
            Book book = new Book()
            {
                Authors = dbAuthor,
                PublisherId = createDTO.PublisherId,
                Publisher = dbPublisher,
                Title = createDTO.Title,
            };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return 0;
        }
    }
}
