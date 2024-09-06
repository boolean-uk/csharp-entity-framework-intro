﻿using exercise.webapi.Data;
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

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await  _db.Authors.Include(a => a.Books).ThenInclude(books => books.Publisher).ToListAsync();
        }

        public async Task<Author> GetSingleAuthor(int id)
        {
            return await _db.Authors.Include(a => a.Books).ThenInclude(books => books.Publisher).FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
