﻿using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<Author> GetAuthor(int id);
        public Task<IEnumerable<Author>> GetAuthors();
    }
}
