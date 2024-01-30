using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;
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

        public async Task<Author> AddAuthor(string firstName, string lastName, ICollection<BookAuthor>? books)
        {
            var author = new Author
            {
                FirstName = firstName,
                LastName = lastName,
                Books = books
            };

            await _db.Authors.AddAsync(author);
            await _db.SaveChangesAsync();

            return author;
        }

        public async Task<Author> DeleteAuthor(int authorId)
        {
            var author = await _db.Authors.FindAsync(authorId);
            
            if (author != null)
            {
                _db.Authors.Remove(author);
                await _db.SaveChangesAsync();
            }

            return author;
        }

        public async Task<ICollection<Author>> GetAllAuthors()
        {
            return await _db.Authors
            .Include(a => a.Books)
            .ThenInclude(ba => ba.Book)
            .ThenInclude(b => b.Publisher)
            .ToListAsync();
        }

        public async Task<Author> GetAuthor(int id)
        {
            return await _db.Authors.FindAsync(id);
        }

        public async Task<Author> UpdateAuthor(int authorId, AuthorUpdatePayload payload)
        {
            var author = await _db.Authors.FindAsync(authorId);

            if (author != null)
            {
                author.FirstName = payload.FirstName;
                author.LastName = payload.LastName;

                if(payload.Books != null) {
                    foreach (BookAuthor book in payload.Books)
                    {
                        if(_db.Books.FindAsync(book) != null) {
                            author.Books.Add(book);
                        }
                    }
                }
                await _db.SaveChangesAsync();
            }
            return author;
        }

        Task<ICollection<Author>> IAuthorRepository.UpdateAuthor(int authorId, AuthorUpdatePayload payload)
        {
            throw new NotImplementedException();
        }
    }
}
