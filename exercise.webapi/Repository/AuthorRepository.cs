using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : Repository<Author>
    {
        private readonly DataContext _db;

        public AuthorRepository(DataContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<Author>> Get()
        {
            return await _db.Authors
                            .Include(a => a.BookAuthorPairs)
                                .ThenInclude(ba => ba.Book)
                            .ToListAsync();
        }

        public override async Task<Author> GetById(object id)
        {
            var author = await _db.Authors
                          .Include(a => a.BookAuthorPairs)
                              .ThenInclude(ba => ba.Book)
                          .FirstOrDefaultAsync(a => a.Id == (int)id);

            if (author == null)
            {
                throw new KeyNotFoundException($"An author with the ID {id} was not found.");
            }

            return author;
        }
    }
}
