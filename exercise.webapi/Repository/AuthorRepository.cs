using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        private async Task<List<AuthorBookModel>> CreateBookList(ICollection<Book> books)
        {
            var booksGet = new List<AuthorBookModel>();
            foreach (var book in books)
            {
                await _db.Entry(book).Reference(b => b.Publisher).LoadAsync();
                booksGet.Add(new AuthorBookModel() { Title = book.Title, Publisher = book.Publisher.Name });
            }
            return booksGet;
        }

        private async Task<AuthorGetModel> CreateAuthorModel(Author author)
        {
            return new AuthorGetModel
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = await CreateBookList(author.Books)
            };
        }

        public async Task<IEnumerable<AuthorGetModel>> GetAllAuthors()
        {
            var result = await _db.Authors.Include(a => a.Books).ToListAsync();
            var authors = new List<AuthorGetModel>();
            foreach (var author in result)
            {
                authors.Add(await CreateAuthorModel(author));
            }
            return authors;
        }

        public async Task<AuthorGetModel> GetAuthor(int id)
        {
            var result = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(b => b.Id == id);
            return await CreateAuthorModel(result);
        }
    }
}
