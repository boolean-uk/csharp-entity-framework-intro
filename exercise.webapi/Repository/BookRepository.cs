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
            return await _db.Books.Where(x => x.Id == id).Select(x => new GetBookDTO()
            {
                Id = x.Id,
                Title = x.Title,
                AuthorId = x.AuthorId,
                AuthorEmail = x.Author.Email,
                AuthorFirstName = x.Author.FirstName,
                AuthorLastName = x.Author.LastName,
            }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<GetBookDTO>> GetAllBooks()
        {
            return await _db.Books.Select(x => new GetBookDTO()
            {
                Id = x.Id,
                Title = x.Title,
                AuthorId = x.AuthorId,
                AuthorEmail = x.Author.Email,
                AuthorFirstName = x.Author.FirstName,
                AuthorLastName = x.Author.LastName,
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
            dbBook.Author = newAuthor;
            await _db.SaveChangesAsync();
            return new GetBookDTO()
            {
                Id = dbBook.Id,
                Title = dbBook.Title,
                AuthorId = newAuthor.Id,
                AuthorFirstName = newAuthor.FirstName,
                AuthorLastName = newAuthor.LastName,
                AuthorEmail = newAuthor.Email
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
            Author? dbAuthor = _db.Authors.Where(x => x.Id == createDTO.AuthorId).FirstOrDefault();
            if (dbAuthor == null) { return -2; }
            Book book = new Book() { Author = dbAuthor, AuthorId = dbAuthor.Id, Title = createDTO.Title };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return 0;
        }
    }
}
