﻿using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        Task<Author> GetAuthorById(int id);
        Task<List<Author>> GetAuthors();
    }
}
