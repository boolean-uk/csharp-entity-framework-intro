﻿using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<Author>> GetAuthors();

        public Task<Author> GetAuthor(int id);

    }
}
