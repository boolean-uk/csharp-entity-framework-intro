﻿using exercise.webapi.Data;
using exercise.webapi.Endpoints;
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

        public async Task<List<Author>> GetAll()
        {
            
            return await _db.Authors.Include(a => a.Books).ToListAsync();
        }

        

            }
}
