using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return _db.Authors;
        }

        public async Task<AuthorDto> GetAuthorDetail(int id)
        {
            AuthorDto author = new();
            Author getAuthor = await _db.Authors.FirstOrDefaultAsync(x => x.Id == id);
            author.Id = getAuthor.Id;
            author.FirstName = getAuthor.FirstName;
            author.LastName = getAuthor.LastName;
            author.Email = getAuthor.Email;
            //author.Books.Concat(await _db.Books.Where(x => x.AuthorId == author.Id).ToListAsync());
            foreach (Book book in await _db.Books.Where(x => x.AuthorId.Contains(author.Id)).ToListAsync())
            {
                BookDto bookDto = new();
                bookDto.Id = book.Id;
                bookDto.Title = book.Title;
                bookDto.Publisher = await _db.Publishers.FirstOrDefaultAsync(b => b.Id == book.PublisherId);
                author.Books.Add(bookDto);
            }
            return author;
        }
    }
}
