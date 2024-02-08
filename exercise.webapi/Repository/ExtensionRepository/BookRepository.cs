using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exercise.webapi.Repository.ExtensionRepository
{
    public class BookRepository : Repository<Book>
    {
        private readonly DataContext _db;

        public BookRepository(DataContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<Book>> Get()
        {
            return await _db.Books
                            .Include(b => b.BookAuthorPairs) // First include the join table
                                .ThenInclude(ba => ba.Author) // Then include the author
                            .ToListAsync();
        }

        public override async Task<Book> GetById(object id)
        {
            var book = await _db.Books
                            .Include(b => b.BookAuthorPairs) // Include the join table
                                .ThenInclude(ba => ba.Author) // Then include the author
                            .FirstOrDefaultAsync(b => b.Id == (int)id);

            if (book == null)
            {
                throw new KeyNotFoundException($"A book with the ID {id} was not found.");
            }

            return book;
        }
    }
}
