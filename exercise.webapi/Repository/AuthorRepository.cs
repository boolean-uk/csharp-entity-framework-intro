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

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _db.Authors.Include(a => a.Books).ToListAsync();
        }

        public async Task<Author> GetAuthorByName(string FirstName, string LastName)
        {
            return await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(x => x.FirstName == FirstName && x.LastName == LastName);
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await _db.Authors.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
